using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Businesses.Forms
{
    public partial class CountryUpdate : Form
    {
        public countries Country { get; set; }

        public CountryUpdate(countries country)
        {
            InitializeComponent();
            using (var entity = new BusinessesEntities())
            {
                RegionsCB.DataSource = entity.regions.Select(x => x.region_id).ToList();
            }

            Country = country;
            CountryNameTB.Text = Country.country_name;
            RegionsCB.SelectedItem = Country.region_id;
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CountryNameTB.Text) || RegionsCB.SelectedItem == null)
            {
                MessageBox.Show("Not all fields are filled");
                return;
            }

            using (var entity = new BusinessesEntities())
            {
                Country.region_id = (int)RegionsCB.SelectedItem;
                Country.country_name = CountryNameTB.Text.Trim();
            }
            Close();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}