using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Businesses.Forms
{
    public partial class CountryInsert : Form
    {
        public CountryInsert()
        {
            InitializeComponent();
            using (var entity = new BusinessesEntities())
            {
                RegionsCB.DataSource = entity.regions.Select(x => x.region_id).ToList();
            }
        }

        private void InsertBTN_Click(object sender, EventArgs e)
        {
            if (RegionsCB.SelectedItem == null || string.IsNullOrWhiteSpace(CountryNameTB.Text))
            {
                MessageBox.Show("Not all fields are filled");
                return;
            }

            using (var entity = new BusinessesEntities())
            {
                var new_country = new countries
                {
                    country_id = new string(CountryNameTB.Text.Trim().ToUpper().Take(2).ToArray()),
                    country_name = CountryNameTB.Text.Trim(),
                    region_id = (int)RegionsCB.SelectedItem
                };

                entity.countries.Add(new_country);
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