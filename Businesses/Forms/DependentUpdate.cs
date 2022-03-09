using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Businesses.Forms
{
    public partial class DependentUpdate : Form
    {
        public dependents Dependent { get; set; }

        public DependentUpdate(dependents dependent)
        {
            InitializeComponent();
            using (var entity = new BusinessesEntities())
            {
                EmployeeCB.DataSource = entity.employees.Select(x => x.employee_id).ToList();
            }

            Dependent = dependent;
            FirstNameTB.Text = Dependent.first_name;
            LastNameTB.Text = Dependent.last_name;
            RelationshipTB.Text = Dependent.relationship;
            EmployeeCB.SelectedItem = Dependent.employee_id;
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
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
                Dependent.first_name = FirstNameTB.Text.Trim();
                Dependent.last_name = LastNameTB.Text.Trim();
                Dependent.relationship = RelationshipTB.Text.Trim();
                Dependent.employee_id = (int)EmployeeCB.SelectedItem;
            }
            Close();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}