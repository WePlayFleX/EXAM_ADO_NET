using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Businesses.Forms
{
    public partial class DepartmentUpdate : Form
    {
        public departments Department { get; set; }

        public DepartmentUpdate(departments department)
        {
            InitializeComponent();
            using (var entity = new BusinessesEntities())
            {
                LocationsCB.DataSource = entity.locations.Select(x => x.location_id).ToList();
            }

            Department = department;
            DepartmentNameTB.Text = Department.department_name;
            LocationsCB.SelectedItem = Department.location_id;
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DepartmentNameTB.Text))
            {
                MessageBox.Show("Not all fields are filled");
                return;
            }

            using (var entity = new BusinessesEntities())
            {
                Department.department_name = DepartmentNameTB.Text.Trim();
                Department.location_id = (int)LocationsCB.SelectedItem;
            }
            Close();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}