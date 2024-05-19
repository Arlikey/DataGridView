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

namespace DataGridView
{
    public partial class AddUserForm_5_ : Form
    {
        public event Action<User> AddUser;
        public AddUserForm_5_()
        {
            InitializeComponent();
            addButton.Enabled = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = nameTextBox.Text,
                Age = (int)ageNumericUpDown.Value,
                Email = emailTextBox.Text,
                Country = countryTextBox.Text,
                City = cityTextBox.Text
            };
            AddUser?.Invoke(user);
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

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox emailTextBox = sender as TextBox;
            string email = emailTextBox.Text;

            if (!IsValidEmail(email))
            {
                e.Cancel = true;
                emailTextBox.Focus();
                errorProvider1.SetError(emailTextBox, "Неверный формат почты!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(emailTextBox, "");
            }
        }

        public bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
    }
}
