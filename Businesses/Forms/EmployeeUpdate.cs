using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Businesses.Forms
{
    public partial class EmployeeUpdate : Form
    {
        public employees Employee { get; set; }

        public EmployeeUpdate(employees employee)
        {
            InitializeComponent();
            using (var entity = new BusinessesEntities())
            {
                JobIdCB.DataSource = entity.jobs.Select(x => x.job_id).ToList();
                DepartmentIdCB.DataSource = entity.departments.Select(x => x.department_id).ToList();
            }

            Employee = employee;
            FirstNameTB.Text = Employee.first_name;
            LastNameTB.Text = Employee.last_name;
            EmailTB.Text = Employee.email;
            PhoneTB.Text = Employee.phone_number;
            HireDateTB.Text = Employee.hire_date.Date.ToString();
            JobIdCB.SelectedItem = Employee.job_id;
            SalaryTB.Text = Employee.salary.ToString();
            DepartmentIdCB.SelectedItem = Employee.department_id;
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

        private void UpdateBTN_Click(object sender, EventArgs e)
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

                Employee.first_name = FirstNameTB.Text.Trim();
                Employee.last_name = LastNameTB.Text.Trim();
                Employee.email = EmailTB.Text.Trim();
                Employee.phone_number = PhoneTB.Text.Trim();
                Employee.hire_date = date;
                Employee.job_id = (int)JobIdCB.SelectedItem;
                Employee.salary = Convert.ToDecimal(SalaryTB.Text.Trim());
                Employee.department_id = (int)DepartmentIdCB.SelectedItem;
            }
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}