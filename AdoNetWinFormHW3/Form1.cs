using AdoNetWinFormHW3.Services;
using AdoNetWinformsApp.Services;

namespace AdoNetWinFormHW3
{
    public partial class Form1 : Form
    {
        private Dictionary<int, Action> LoadTabMethods;
        private CountryService _countryService;
        public Form1()
        {
            _countryService = new CountryService();
            LoadTabMethods = new Dictionary<int, Action>
            {
                {0, () =>  LoadCountry()}
                
            };
            InitializeComponent();
        }
        private void MainTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTabMethods[MainTab.SelectedIndex]();
        }
        private async void LoadCountry()
        {
            TableCreatorService.ShowTable(
                CountryGrid,
                TableCreatorService.CreateCountryTable(await _countryService.GetCountry()));
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTabMethods[0]();
        }
    }
}