using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class AdditionalTask5 : Form
    {
        private BindingList<User> users = new BindingList<User>();
        public AdditionalTask5()
        {
            InitializeComponent();

            usersDataGridView.DataSource = users;
            usersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddUserForm_5_ addUserForm = new AddUserForm_5_();
            addUserForm.AddUser += AddUserForm_AddUser;
            addUserForm.ShowDialog();
        }

        private void AddUserForm_AddUser(User obj)
        {
            users.Add(obj);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (usersDataGridView.Rows.Count > 1)
            {
                foreach (DataGridViewRow item in this.usersDataGridView.SelectedRows)
                {
                    usersDataGridView.Rows.RemoveAt(item.Index);
                }
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveUsersToFile();
        }

        private void SaveUsersToFile()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.DefaultExt = "json";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    SaveUsersAsJson(filePath);
                }
            }
        }

        private void SaveUsersAsJson(string filePath)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonString);
                MessageBox.Show("Users saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUsersFromFile()
        {
            using (OpenFileDialog loadFileDialog = new OpenFileDialog())
            {
                loadFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                loadFileDialog.DefaultExt = "json";
                loadFileDialog.AddExtension = true;

                if (loadFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = loadFileDialog.FileName;
                    ReadUsersFromJson(filePath);
                }
            }
        }

        private void ReadUsersFromJson(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                List<User> loadedUsers = JsonSerializer.Deserialize<List<User>>(jsonString);

                users.Clear();
                foreach (User user in loadedUsers)
                {
                    users.Add(user);
                }
                MessageBox.Show("Users loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            LoadUsersFromFile();
        }
    }
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

    }
}

