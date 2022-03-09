using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Businesses.Forms
{
    public partial class DependentInsert : Form
    {
        public DependentInsert()
        {
            InitializeComponent();
            using (var entity = new BusinessesEntities())
            {
                EmployeeCB.DataSource = entity.employees.Select(x => x.employee_id).ToList();
            }
        }

        private void InsertBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstNameTB.Text)
                || string.IsNullOrWhiteSpace(LastNameTB.Text)
                || string.IsNullOrWhiteSpace(RelationshipTB.Text)
                || EmployeeCB.SelectedItem == null)
            {
                MessageBox.Show("Not all fields are filled");
                return;
            }

            using (var entity = new BusinessesEntities())
            {
                var new_Dependent = new dependents
                {
                    first_name = FirstNameTB.Text.Trim(),
                    last_name = LastNameTB.Text.Trim(),
                    relationship = RelationshipTB.Text.Trim(),
                    employee_id = (int)EmployeeCB.SelectedItem,
                };

                entity.dependents.Add(new_Dependent);
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