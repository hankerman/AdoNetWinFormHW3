using AdoNetWinFormHW3.Entities;
using AdoNetWinFormHW3.Forms;
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
                {0, () =>  LoadCountry()},
                {1, () => LoadCities()}
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

        private async void LoadCities()
        {
            TableCreatorService.ShowTable(
            CitiesGrid,
                TableCreatorService.CreateCityTable(await _countryService.GetCity()));

            var pairs = await _countryService.GetCountryPairsAsync();
            _countryService.PopulateCombobox(CountryCombobox, pairs);
        }

        private async void LoadCities(int countryId)
        {
            TableCreatorService.ShowTable(
                CitiesGrid,
                TableCreatorService.CreateCityTable(await _countryService.GetCity(countryId)));
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTabMethods[0]();
        }

        private async void btnAddCountry_Click(object sender, EventArgs e)
        {
            var pairs = await _countryService.GetCountryPairsAsync();
            var form = new AddOrEditCountry(pairs);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await _countryService.AddCountry(form.CountryName, form.Area, form.PartOfWorlds);
                LoadCountry();
            }
        }

        private async void btnDeleteCountry_Click(object sender, EventArgs e)
        {
            if (CountryGrid.SelectedRows.Count > 0)
            {
                var countryId = int.Parse(CountryGrid.SelectedRows[0].Cells[0].Value.ToString()!);
                try
                {
                    await _countryService.DeleteCountry(countryId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    LoadCountry();
                }
            }
            else
            {
                MessageBox.Show("Выберите страну для удаления.");
            }
        }

        private async void btnEditCountry_Click(object sender, EventArgs e)
        {
            if (CountryGrid.SelectedRows.Count > 0)
            {
                var countryId = int.Parse(CountryGrid.SelectedRows[0].Cells[0].Value.ToString()!);
                var country = await _countryService.GetCountryId(countryId);
                if (country == null)
                {
                    MessageBox.Show("Страна не найдена");
                    LoadCountry();
                    return;
                }
                else
                {
                    try
                    {
                        var pairs = await _countryService.GetCityPairsAsync();
                        var form = new AddOrEditCountry(pairs, country.Name, country.Area, country.PartOfWorld, country.CapitalId);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            await _countryService.EditCountry(country, form.CountryName, form.Area, form.PartOfWorlds, form.Capital);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        LoadCountry();
                    }
                }

            }
            else
            {
                MessageBox.Show("Выберите тип товара для изменения.");
            }
        }

        private async void btnAddCity_Click(object sender, EventArgs e)
        {
            var pairs = await _countryService.GetCountryPairsAsync();
            var form = new AddOrEditCity(pairs);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await _countryService.AddCity(form.CityName, form.Population, form.Country);
                LoadCities();
            }
        }

        private async void btnEditCity_Click(object sender, EventArgs e)
        {
            if (CitiesGrid.SelectedRows.Count > 0)
            {
                var cityId = int.Parse(CitiesGrid.SelectedRows[0].Cells[0].Value.ToString()!);
                var city = await _countryService.GetCityId(cityId);
                if (city == null)
                {
                    MessageBox.Show("Город не найден");
                    LoadCountry();
                    return;
                }
                else
                {
                    try
                    {
                        var pairs = await _countryService.GetCountryPairsAsync();
                        var form = new AddOrEditCity(pairs, city.Name, city.Population, city.CountryId);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            await _countryService.EditCity(city, form.CityName, form.Population, form.Country);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        LoadCities();
                    }
                }

            }
            else
            {
                MessageBox.Show("Выберите тип товара для изменения.");
            }
        }

        private void btnUpdateCitiesGrid_Click(object sender, EventArgs e)
        {

        }

        private void CountryCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCities((int)CountryCombobox.SelectedValue);
        }

        private async void btnCapital5K_Click(object sender, EventArgs e)
        {
            TableCreatorService.ShowTable(
                CountryGrid,
                TableCreatorService.CreateCountryTable(await _countryService.CapitalOver5K()));
        }

        private async void btnCountryName_Click(object sender, EventArgs e)
        {
            TableCreatorService.ShowTable(
                CountryGrid,
                TableCreatorService.CreateStringTable(await _countryService.CountryName()));
        }
    }
}