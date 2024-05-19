using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataGridView
{
    public partial class AddEmployeeForm : Form
    {
        public event Action<Employee> AddEmployee;
        public AddEmployeeForm()
        {
            InitializeComponent();
            addButton.Enabled = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                Name = nameTextBox.Text,
                Age = (int)ageNumericUpDown.Value,
                Position = positionTextBox.Text,
                Salary = salaryNumericUpDown.Value
            };
            AddEmployee?.Invoke(employee);
            Close();
        }

        private void Validating(object sender, CancelEventArgs e)
        {
            foreach (var textBox in Controls.OfType<System.Windows.Forms.TextBox>())
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    addButton.Enabled = false;
                    break;
                }
                else
                {
                    addButton.Enabled = true;
                }
            }
        }
    }
}
