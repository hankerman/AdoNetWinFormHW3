using AdoNetWinFormHW3.Constans;
using AdoNetWinFormHW3.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AdoNetWinFormHW3.Forms
{
    public partial class AddOrEditCity : Form
    {
        private CountryService _countryService;
        public string CityName => txtNameCity.Text.Trim();
        public int Population => (int)numericPopulationCity.Value;
        public int Country => (int)CountryCombobox.SelectedValue;

        public AddOrEditCity(List<KeyValuePair<string, int>> CountryPair)
        {
            _countryService = new CountryService();
            InitializeComponent();
            _countryService.PopulateCombobox(CountryCombobox, CountryPair);
        }
        public AddOrEditCity(List<KeyValuePair<string, int>> CountryPair, string NameCity, int Population, int CountryId)
        {
            _countryService = new CountryService();
            InitializeComponent();
            _countryService.PopulateCombobox(CountryCombobox, CountryPair, CountryId);
            txtNameCity.Text = NameCity;
            numericPopulationCity.Value = Population;
        }

        private void txtNameCity_Validating(object sender, CancelEventArgs e)
        {
            if (txtNameCity.Text.Trim().Length > DatabaseDefaults.StringValueMaxLength)
            {
                errorName.SetError(txtNameCity, "Слишком длинное название города!");
                e.Cancel = true;
            }
            else if (string.IsNullOrEmpty(txtNameCity.Text))
            {
                errorName.SetError(txtNameCity, "Введите название города");
                e.Cancel = true;
            }
            else
            {
                errorName.SetError(txtNameCity, string.Empty);
                e.Cancel = false;
            }
        }

        private void numericPopulationCity_Validating(object sender, CancelEventArgs e)
        {
            if (numericPopulationCity.Value <= 0)
            {
                errorPopulation.SetError(numericPopulationCity, "Колличество жителей должно быть положительным");
                e.Cancel = true;
            }
            else
            {
                errorPopulation.SetError(numericPopulationCity, string.Empty);
                e.Cancel = false;
            }
        }

        private void CountryCombobox_Validating(object sender, CancelEventArgs e)
        {
            if ((int)CountryCombobox.SelectedValue == 0)
            {
                errorCountry.SetError(CountryCombobox, "Выберите страну");
                e.Cancel = true;
            }
            else
            {
                errorCountry.SetError(CountryCombobox, string.Empty);
                e.Cancel = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
