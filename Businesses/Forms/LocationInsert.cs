using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Businesses.Forms
{
    public partial class LocationInsert : Form
    {
        public LocationInsert()
        {
            InitializeComponent();
            using (var entity = new BusinessesEntities())
            {
                CountriesCB.DataSource = entity.countries.Select(x => x.country_id).ToList();
            }
        }

        private void InsertBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CityTB.Text) || CountriesCB.SelectedItem == null)
            {
                MessageBox.Show("Not all fields are filled");
                return;
            }

            using (var entity = new BusinessesEntities())
            {
                var new_Location = new locations
                {
                    street_address = StreetAdressTB.Text.Trim(),
                    postal_code = PostalCodeTB.Text.Trim(),
                    city = CityTB.Text.Trim(),
                    state_province = StateProvinceTB.Text.Trim(),
                    country_id = CountriesCB.SelectedItem.ToString().Trim()
                };

                entity.locations.Add(new_Location);
                entity.SaveChanges();
            }

            Close();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}