namespace DataGridView
{
    partial class AdditionalTask5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usersDataGridView = new System.Windows.Forms.DataGridView();
            addButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            loadButton = new Button();
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // usersDataGridView
            // 
            usersDataGridView.BackgroundColor = SystemColors.Control;
            usersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDataGridView.Dock = DockStyle.Left;
            usersDataGridView.Location = new Point(0, 0);
            usersDataGridView.Name = "usersDataGridView";
            usersDataGridView.Size = new Size(628, 450);
            usersDataGridView.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addButton.Location = new Point(650, 97);
            addButton.Name = "addButton";
            addButton.Size = new Size(138, 62);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить пользователя";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteButton.Location = new Point(650, 205);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(138, 62);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Удалить пользователя";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackgroundImage = Properties.Resources.free_icon_save_2550221;
            saveButton.BackgroundImageLayout = ImageLayout.Stretch;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveButton.Location = new Point(650, 295);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(58, 53);
            saveButton.TabIndex = 2;
            saveButton.Text = "SAVE";
            saveButton.TextAlign = ContentAlignment.BottomCenter;
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // loadButton
            // 
            loadButton.BackgroundImage = Properties.Resources.free_icon_upload_1250734_removebg_preview;
            loadButton.BackgroundImageLayout = ImageLayout.Stretch;
            loadButton.FlatAppearance.BorderSize = 0;
            loadButton.FlatStyle = FlatStyle.Flat;
            loadButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loadButton.Location = new Point(735, 292);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(64, 56);
            loadButton.TabIndex = 2;
            loadButton.Text = "LOAD";
            loadButton.TextAlign = ContentAlignment.BottomCenter;
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // AdditionalTask5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loadButton);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(usersDataGridView);
            Name = "AdditionalTask5";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView usersDataGridView;
        private Button addButton;
        private Button deleteButton;
        private Button saveButton;
        private Button loadButton;
    }
}