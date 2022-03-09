using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Businesses.Forms
{
    public partial class EmployeeInsert : Form
    {
        public EmployeeInsert()
        {
            InitializeComponent();
            using (var entity = new BusinessesEntities())
            {
                JobIdCB.DataSource = entity.jobs.Select(x => x.job_id).ToList();
                DepartmentIdCB.DataSource = entity.departments.Select(x => x.department_id).ToList();
            }
        }

        private void InsertBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LastNameTB.Text)
                || string.IsNullOrWhiteSpace(EmailTB.Text)
                || string.IsNullOrWhiteSpace(HireDateTB.Text)
                || JobIdCB.SelectedItem == null)
            {
                MessageBox.Show("Not all fields are filled");
                return;
            }

            using (var entity = new BusinessesEntities())
            {
                if (!DateTime.TryParse(HireDateTB.Text.Trim(), out var date))
                {
                    MessageBox.Show("Incorrect date format");
                    return;
                }

                var new_Employee = new employees()
                {
                    first_name = FirstNameTB.Text.Trim(),
                    last_name = LastNameTB.Text.Trim(),
                    email = EmailTB.Text.Trim(),
                    phone_number = PhoneTB.Text.Trim(),
                    hire_date = date,
                    job_id = (int)JobIdCB.SelectedItem,
                    salary = Convert.ToDecimal(SalaryTB.Text.Trim()),
                    department_id = (int)DepartmentIdCB.SelectedItem
                };

                entity.employees.Add(new_Employee);
                entity.SaveChanges();
            }
            Close();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JobIdCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (JobIdCB.SelectedItem == null)
            {
                return;
            }

            using (var entity = new BusinessesEntities())
            {
                int ind = (int)JobIdCB.SelectedItem;
                SalaryTB.Text = entity.jobs.Find(ind).min_salary.ToString();
            }
        }
    }
}