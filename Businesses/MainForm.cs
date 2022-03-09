using Businesses.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Businesses
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        internal int GetId(DataGridView dataGridView)
        {
            var row = dataGridView.SelectedRows;
            return (int)row[0].Cells[0].Value;
        }

        #region RegionsMethods

        private void LoadRegBTN_Click(object sender, EventArgs e)
        {
            using (var entity = new BusinessesEntities())
            {
                RegDGV.DataSource = null;
                RegDGV.DataSource = entity.regions.ToList();
                RegDGV.Columns["region_id"].Visible = false;
                RegDGV.Columns["Countries"].Visible = false;
            }
        }

        private void InsertRegBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RegNameTB.Text))
            {
                MessageBox.Show("Field is empty");
                return;
            }

            using (var entity = new BusinessesEntities())
            {
                var new_Reg = new regions
                {
                    region_name = RegNameTB.Text.Trim()
                };

                entity.regions.Add(new_Reg);
                entity.SaveChanges();
            }
            LoadRegBTN_Click(sender, e);
            RegNameTB.Clear();
        }

        private void DeleteRegBTN_Click(object sender, EventArgs e)
        {
            if (RegDGV.SelectedRows.Count < 1)
            {
                return;
            }

            using (var entity = new BusinessesEntities())
            {
                var reg = entity.regions.Find(GetId(RegDGV));
                entity.regions.Remove(reg);
                entity.SaveChanges();
            }
            LoadRegBTN_Click(sender, e);
        }

        private void UpdateRegBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RegNameUpdateTB.Text))
            {
                MessageBox.Show("Field is empty");
                return;
            }

            using (var entity = new BusinessesEntities())
            {
                var reg = entity.regions.Find(GetId(RegDGV));
                reg.region_name = RegNameUpdateTB.Text.Trim();
                entity.SaveChanges();
            }
            LoadRegBTN_Click(sender, e);
        }

        private void RegDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (RegDGV.SelectedRows.Count < 1)
            {
                return;
            }

            var row = RegDGV.SelectedRows;

            RegNameUpdateTB.Text = row[0].Cells[1].Value.ToString();
        }

        #endregion RegionsMethods

        #region CountriesMethods

        private void LoadCouBTN_Click(object sender, EventArgs e)
        {
            using (var entity = new BusinessesEntities())
            {
                CouDGV.DataSource = null;
                CouDGV.DataSource = entity.countries.ToList();
                CouDGV.Columns["country_id"].Visible = false;
                CouDGV.Columns["locations"].Visible = false;
                CouDGV.Columns["regions"].Visible = false;
            }
        }

        private void InsertCouBtn_Click(object sender, EventArgs e)
        {
            var form = new CountryInsert();
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Successfully added");
                LoadCouBTN_Click(sender, e);
            }
        }

        private void DeleteCouBtn_Click(object sender, EventArgs e)
        {
            if (CouDGV.SelectedRows.Count < 1)
            {
                return;
            }

            using (var entity = new BusinessesEntities())
            {
                var row = CouDGV.SelectedRows;
                var id = (string)row[0].Cells[0].Value;

                var country = entity.countries.Find(id);
                entity.countries.Remove(country);
                entity.SaveChanges();
            }
            LoadCouBTN_Click(sender, e);
        }

        private void UpdateCouBtn_Click(object sender, EventArgs e)
        {
            var entity = new BusinessesEntities();
            var row = CouDGV.SelectedRows;
            var id = (string)row[0].Cells[0].Value;

            var country = entity.countries.Find(id);

            var form = new CountryUpdate(country);

            if (form.ShowDialog() == DialogResult.OK)
            {
                country = form.Country;
                entity.SaveChanges();

                MessageBox.Show("Successfully updated");
                LoadLocBTN_Click(sender, e);
            }
        }

        #endregion CountriesMethods

        #region LocationsMethods

        private void LoadLocBTN_Click(object sender, EventArgs e)
        {
            using (var entity = new BusinessesEntities())
            {
                LocDGV.DataSource = null;
                LocDGV.DataSource = entity.locations.ToList();
                LocDGV.Columns["location_id"].Visible = false;
                LocDGV.Columns["countries"].Visible = false;
                LocDGV.Columns["departments"].Visible = false;
            }
        }

        private void InsertLocBTN_Click(object sender, EventArgs e)
        {
            var form = new LocationInsert();
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Successfully added");
                LoadLocBTN_Click(sender, e);
            }
        }

        private void DeleteLocBTN_Click(object sender, EventArgs e)
        {
            if (LocDGV.SelectedRows.Count < 1)
            {
                return;
            }

            using (var entity = new BusinessesEntities())
            {
                var loc = entity.locations.Find(GetId(LocDGV));
                entity.locations.Remove(loc);
                entity.SaveChanges();
            }
            LoadLocBTN_Click(sender, e);
        }

        private void UpdateLocBtn_Click(object sender, EventArgs e)
        {
            var entity = new BusinessesEntities();
            locations location = entity.locations.Find(GetId(LocDGV));

            var form = new LocationUpdate(location);

            if (form.ShowDialog() == DialogResult.OK)
            {
                location = form.Location;
                entity.SaveChanges();

                MessageBox.Show("Successfully updated");
                LoadCouBTN_Click(sender, e);
            }
        }

        #endregion LocationsMethods

        #region DepartmentsMethods

        private void LoadDepBTN_Click(object sender, EventArgs e)
        {
            using (var entity = new BusinessesEntities())
            {
                DepDGV.DataSource = null;
                DepDGV.DataSource = entity.departments.ToList();
                DepDGV.Columns["department_id"].Visible = false;
                DepDGV.Columns["locations"].Visible = false;
                DepDGV.Columns["employees"].Visible = false;
            }
        }

        private void InsertDepBTN_Click(object sender, EventArgs e)
        {
            var form = new DepartmentInsert();
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Successfully added");
                LoadDepBTN_Click(sender, e);
            }
        }

        private void DeleteDepBTN_Click(object sender, EventArgs e)
        {
            if (DepDGV.SelectedRows.Count < 1)
            {
                return;
            }

            using (var entity = new BusinessesEntities())
            {
                var dep = entity.departments.Find(GetId(DepDGV));
                entity.departments.Remove(dep);
                entity.SaveChanges();
            }
            LoadDepBTN_Click(sender, e);
        }

        private void UpdateDepBtn_Click(object sender, EventArgs e)
        {
            var entity = new BusinessesEntities();
            var department = entity.departments.Find(GetId(DepDGV));

            var form = new DepartmentUpdate(department);

            if (form.ShowDialog() == DialogResult.OK)
            {
                department = form.Department;
                entity.SaveChanges();

                MessageBox.Show("Successfully updated");
                LoadDepBTN_Click(sender, e);
            }
        }

        #endregion DepartmentsMethods

        #region EmployeesMethods

        private void LoadEmpBTN_Click(object sender, EventArgs e)
        {
            using (var entity = new BusinessesEntities())
            {
                entity.Database.Log = Console.Write;

                EmpDGV.DataSource = null;
                EmpDGV.DataSource = entity.employees.ToList();
                EmpDGV.Columns["employee_id"].Visible = false;
                EmpDGV.Columns["departments"].Visible = false;
                EmpDGV.Columns["dependents"].Visible = false;
                EmpDGV.Columns["jobs"].Visible = false;
            }
        }

        private void InsertEmpBTN_Click(object sender, EventArgs e)
        {
            var form = new EmployeeInsert();
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Successfully added");
                LoadEmpBTN_Click(sender, e);
            }
        }

        private void DeleteEmpBTN_Click(object sender, EventArgs e)
        {
            if (EmpDGV.SelectedRows.Count < 1)
            {
                return;
            }

            using (var entity = new BusinessesEntities())
            {
                var emp = entity.employees.Find(GetId(EmpDGV));
                entity.employees.Remove(emp);
                entity.SaveChanges();
            }
            LoadEmpBTN_Click(sender, e);
        }

        private void UpdateEmpBTN_Click(object sender, EventArgs e)
        {
            var entity = new BusinessesEntities();
            var employee = entity.employees.Find(GetId(EmpDGV));

            var form = new EmployeeUpdate(employee);

            if (form.ShowDialog() == DialogResult.OK)
            {
                employee = form.Employee;
                entity.SaveChanges();

                MessageBox.Show("Successfully updated");
                LoadEmpBTN_Click(sender, e);
            }
        }

        #endregion EmployeesMethods

        #region JobsMethods

        private void LoadJobBTN_Click(object sender, EventArgs e)
        {
            using (var entity = new BusinessesEntities())
            {
                JobDGV.DataSource = null;
                JobDGV.DataSource = entity.jobs.ToList();
                JobDGV.Columns["employees"].Visible = false;
                JobDGV.Columns["job_id"].Visible = false;
            }
        }

        private void InsertJobBTN_Click(object sender, EventArgs e)
        {
            var form = new JobInsert();
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Successfully added");
                LoadJobBTN_Click(sender, e);
            }
        }

        private void DeleteJobBTN_Click(object sender, EventArgs e)
        {
            if (JobDGV.SelectedRows.Count < 1)
            {
                return;
            }

            using (var entity = new BusinessesEntities())
            {
                var job = entity.jobs.Find(GetId(JobDGV));
                entity.jobs.Remove(job);
                entity.SaveChanges();
            }
            LoadJobBTN_Click(sender, e);
        }

        private void UpdateJobBTN_Click(object sender, EventArgs e)
        {
            var entity = new BusinessesEntities();
            var job = entity.jobs.Find(GetId(JobDGV));

            var form = new JobUpdate(job);

            if (form.ShowDialog() == DialogResult.OK)
            {
                job = form.Job;
                entity.SaveChanges();

                MessageBox.Show("Successfully updated");
                LoadJobBTN_Click(sender, e);
            }
        }

        #endregion JobsMethods

        #region DependentsMethods

        private void LoadDepeBTN_Click(object sender, EventArgs e)
        {
            using (var entity = new BusinessesEntities())
            {
                DepeDGV.DataSource = null;
                DepeDGV.DataSource = entity.dependents.ToList();
                DepeDGV.Columns["dependent_id"].Visible = false;
                DepeDGV.Columns["employees"].Visible = false;
            }
        }

        private void InsertDepeBTN_Click(object sender, EventArgs e)
        {
            var form = new DependentInsert();
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Successfully added");
                LoadDepeBTN_Click(sender, e);
            }
        }

        private void DeleteDepeBTN_Click(object sender, EventArgs e)
        {
            if (DepeDGV.SelectedRows.Count < 1)
            {
                return;
            }

            using (var entity = new BusinessesEntities())
            {
                var dependent = entity.dependents.Find(GetId(DepeDGV));
                entity.dependents.Remove(dependent);
                entity.SaveChanges();
            }
            LoadDepeBTN_Click(sender, e);
        }

        private void UpdateDepeBTN_Click(object sender, EventArgs e)
        {
            var entity = new BusinessesEntities();
            var dependent = entity.dependents.Find(GetId(DepeDGV));

            var form = new DependentUpdate(dependent);

            if (form.ShowDialog() == DialogResult.OK)
            {
                dependent = form.Dependent;
                entity.SaveChanges();

                MessageBox.Show("Successfully updated");
                LoadDepeBTN_Click(sender, e);
            }
        }

        #endregion DependentsMethods

        #region AggregateFunctions

        private void MaxSalaryShowBTN_Click(object sender, EventArgs e)
        {
            using (var entity = new BusinessesEntities())
            {
                var max_salary = entity.employees.Select(x => x.salary).Max();

                FunctionsDGV.DataSource = null;
                FunctionsDGV.DataSource = entity.employees.Where(x => x.salary == max_salary).ToList();
                FunctionsDGV.Columns["departments"].Visible = false;
                FunctionsDGV.Columns["dependents"].Visible = false;
                FunctionsDGV.Columns["jobs"].Visible = false;
            }
        }

        private void MaxDepartmentsShowBTN_Click(object sender, EventArgs e)
        {
            using (var entity = new BusinessesEntities())
            {
                var max_count = entity.locations.Select(x => x.departments.Count).Max();

                FunctionsDGV.DataSource = null;
                FunctionsDGV.DataSource = entity.locations.Where(x => x.departments.Count == max_count).ToList();
                FunctionsDGV.Columns["countries"].Visible = false;
                FunctionsDGV.Columns["departments"].Visible = false;
            }
        }

        private void OrderBySalary_Click(object sender, EventArgs e)
        {
            using (var entity = new BusinessesEntities())
            {
                FunctionsDGV.DataSource = null;
                FunctionsDGV.DataSource = entity.employees.OrderByDescending(employees => employees.salary).ToList();
                FunctionsDGV.Columns["departments"].Visible = false;
                FunctionsDGV.Columns["dependents"].Visible = false;
                FunctionsDGV.Columns["jobs"].Visible = false;
            }
        }

        private void PopularJobShowBTN_Click(object sender, EventArgs e)
        {
            using (var entity = new BusinessesEntities())
            {
                var max_count = entity.jobs.Select(x => x.employees.Count).Max();

                FunctionsDGV.DataSource = null;
                FunctionsDGV.DataSource = entity.jobs.Where(x => x.employees.Count == max_count).ToList();
                FunctionsDGV.Columns["employees"].Visible = false;
            }
        }

        #endregion AggregateFunctions
    }
}