using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Businesses.Forms
{
    public partial class LocationUpdate : Form
    {
        public new locations Location { get; set; }

        public LocationUpdate(locations location)
        {
            InitializeComponent();
            using (var entity = new BusinessesEntities())
            {
                CountriesCB.DataSource = entity.countries.Select(x => x.country_id).ToList();
            }

            Location = location;
            StreetAdressTB.Text = Location.street_address;
            PostalCodeTB.Text = Location.postal_code;
            CityTB.Text = Location.city;
            StateProvinceTB.Text = Location.state_province;
            CountriesCB.SelectedItem = Location.country_id;
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CityTB.Text) || CountriesCB.SelectedItem == null)
            {
                MessageBox.Show("Not all fields are filled");
                return;
            }

            using (var entity = new BusinessesEntities())
            {
                Location.street_address = StreetAdressTB.Text.Trim();
                Location.postal_code = PostalCodeTB.Text.Trim();
                Location.city = CityTB.Text.Trim();
                Location.state_province = StateProvinceTB.Text.Trim();
                Location.country_id = (string)CountriesCB.SelectedItem;
            }
            Close();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}