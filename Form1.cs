using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        private BindingList<Employee> employees = new BindingList<Employee>();
        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = employees;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.AddEmployee += AddEmployeeForm_AddEmployee;
            addEmployeeForm.ShowDialog();
        }

        private void AddEmployeeForm_AddEmployee(Employee obj)
        {
            employees.Add(obj);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 1) { 
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
            }
        }
    }

    public class Employee
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

    }
}
