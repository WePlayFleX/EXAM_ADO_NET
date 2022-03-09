using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Businesses.Forms
{
    public partial class DepartmentInsert : Form
    {
        public DepartmentInsert()
        {
            InitializeComponent();
            using (var entity = new BusinessesEntities())
            {
                LocationsCB.DataSource = entity.locations.Select(x => x.location_id).ToList();
            }
        }

        private void InsertBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DepartmentNameTB.Text))
            {
                MessageBox.Show("Not all fields are filled");
                return;
            }

            using (var entity = new BusinessesEntities())
            {
                var new_Department = new departments
                {
                    department_name = DepartmentNameTB.Text.Trim(),
                    location_id = (int)LocationsCB.SelectedItem
                };

                entity.departments.Add(new_Department);
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