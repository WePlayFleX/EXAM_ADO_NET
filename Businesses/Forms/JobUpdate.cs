using System;
using System.Windows.Forms;

namespace Businesses.Forms
{
    public partial class JobUpdate : Form
    {
        public jobs Job { get; set; }

        public JobUpdate(jobs job)
        {
            InitializeComponent();

            Job = job;
            JobTitleTB.Text = Job.job_title;
            MinSalaryTB.Text = Job.min_salary.ToString();
            MaxSalaryTB.Text = Job.max_salary.ToString();
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(JobTitleTB.Text))
            {
                MessageBox.Show("Not all fields are filled");
                return;
            }

            using (var entity = new BusinessesEntities())
            {
                Job.job_title = JobTitleTB.Text.Trim();
                Job.min_salary = Convert.ToDecimal(MinSalaryTB.Text.Trim());
                Job.max_salary = Convert.ToDecimal(MaxSalaryTB.Text.Trim());
            }
            Close();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}