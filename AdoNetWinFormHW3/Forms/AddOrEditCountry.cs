using AdoNetWinFormHW3.Constans;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetWinFormHW3.Forms
{
    public partial class AddOrEditCountry : Form
    {
        public string CountryName => txtName.Text.Trim();
        public decimal Area => numericArea.Value;
        public PartOfWorld PartOfWorlds => (PartOfWorld)PartOfWorldCombobox.SelectedValue;
        public int Capital => (int)CapitalCombobox.SelectedValue;
        public AddOrEditCountry(List<KeyValuePair<string, int>> CapitalPair)
        {
            InitializeComponent();
            PopulateComboboxCapital(CapitalPair);
            PopulateComboboxPartOfWorld();

        }
        public AddOrEditCountry(List<KeyValuePair<string, int>> CapitalPair, string name, decimal area, PartOfWorld partOfWorld, int? capitalId)
        {
            InitializeComponent();
            labelCountry.Visible = true;
            CapitalCombobox.Visible = true;
            PopulateComboboxCapital(CapitalPair, CapitalIdIsInt(capitalId));
            PopulateComboboxPartOfWorld((int)partOfWorld);
            numericArea.Value = area;
            txtName.Text = name;
        }
        private void PopulateComboboxCapital(List<KeyValuePair<string, int>> keyValuePairs, int id = 0)
        {
            var pairs = new List<KeyValuePair<string, int>>();
            pairs.Add(new("Не выбран", 0));
            pairs.AddRange(keyValuePairs);

            CapitalCombobox.DisplayMember = "Key";
            CapitalCombobox.ValueMember = "Value";
            CapitalCombobox.DataSource = pairs;
            CapitalCombobox.SelectedItem = pairs.First(x => x.Value == id);
        }
        private void PopulateComboboxPartOfWorld(int id = 0)
        {
            var pairs = new List<KeyValuePair<string, int>>();
            pairs.Add(new("Не выбран", 0));
            var partOfWorld = Enum.GetValues<PartOfWorld>();
            pairs.AddRange(partOfWorld.Select(x => new KeyValuePair<string, int>(x.ToString(), (int)x)));

            PartOfWorldCombobox.DisplayMember = "Key";
            PartOfWorldCombobox.ValueMember = "Value";
            PartOfWorldCombobox.DataSource = pairs;
            PartOfWorldCombobox.SelectedItem = pairs.First(x => x.Value == id);
        }

        private int CapitalIdIsInt(int? Id)
        {
            if(Id == null)
            {
                return 0;
            }
            return (int)Id;
        }
        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text.Trim().Length > DatabaseDefaults.StringValueMaxLength)
            {
                errorName.SetError(txtName, "Слишком длинное название страны!");
                e.Cancel = true;
            }
            else if (string.IsNullOrEmpty(txtName.Text))
            {
                errorName.SetError(txtName, "Введите название страны");
                e.Cancel = true;
            }
            else
            {
                errorName.SetError(txtName, string.Empty);
                e.Cancel = false;
            }
        }

        private void numericArea_Validating(object sender, CancelEventArgs e)
        {
            if (numericArea.Value <= 0)
            {
                errorArea.SetError(numericArea, "Площадь должна быть положительной");
                e.Cancel = true;
            }
            else
            {
                errorArea.SetError(numericArea, string.Empty);
                e.Cancel = false;
            }
        }

        private void PartOfWorldCombobox_Validating(object sender, CancelEventArgs e)
        {
            if ((int)PartOfWorldCombobox.SelectedValue == 0)
            {
                errorPartOfWorld.SetError(PartOfWorldCombobox, "Выберите часть света!");
                e.Cancel = true;
            }
            else
            {
                errorPartOfWorld.SetError(PartOfWorldCombobox, string.Empty);
                e.Cancel = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
