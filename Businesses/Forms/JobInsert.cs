using System;
using System.Windows.Forms;

namespace Businesses.Forms
{
    public partial class JobInsert : Form
    {
        public JobInsert()
        {
            InitializeComponent();
        }

        private void InsertBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(JobTitleTB.Text))
            {
                MessageBox.Show("Not all fields are filled");
                return;
            }

            using (var entity = new BusinessesEntities())
            {
                var new_Job = new jobs
                {
                    job_title = JobTitleTB.Text.Trim(),
                    min_salary = Convert.ToDecimal(MinSalaryTB.Text.Trim()),
                    max_salary = Convert.ToDecimal(MaxSalaryTB.Text.Trim())
                };

                entity.jobs.Add(new_Job);
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