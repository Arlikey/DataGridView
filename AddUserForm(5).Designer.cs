namespace DataGridView
{
    partial class AddUserForm_5_
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
            components = new System.ComponentModel.Container();
            nameTextBox = new TextBox();
            ageNumericUpDown = new NumericUpDown();
            addButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            emailTextBox = new TextBox();
            label6 = new Label();
            countryTextBox = new TextBox();
            cityTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameTextBox.Location = new Point(112, 71);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(124, 23);
            nameTextBox.TabIndex = 0;
            nameTextBox.Validating += Validating;
            // 
            // ageNumericUpDown
            // 
            ageNumericUpDown.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ageNumericUpDown.Location = new Point(112, 116);
            ageNumericUpDown.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            ageNumericUpDown.Name = "ageNumericUpDown";
            ageNumericUpDown.Size = new Size(48, 23);
            ageNumericUpDown.TabIndex = 2;
            ageNumericUpDown.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // addButton
            // 
            addButton.Cursor = Cursors.Hand;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addButton.Location = new Point(95, 273);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 40);
            addButton.TabIndex = 4;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(63, 72);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 5;
            label1.Text = "Имя :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(41, 116);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 5;
            label2.Text = "Возраст :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(85, 20);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 5;
            label3.Text = "Пользователь";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(51, 155);
            label4.Name = "label4";
            label4.Size = new Size(55, 17);
            label4.TabIndex = 5;
            label4.Text = "E-mail :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(46, 196);
            label5.Name = "label5";
            label5.Size = new Size(60, 17);
            label5.TabIndex = 5;
            label5.Text = "Страна :";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(112, 154);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(124, 23);
            emailTextBox.TabIndex = 6;
            emailTextBox.Validating += emailTextBox_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(46, 234);
            label6.Name = "label6";
            label6.Size = new Size(54, 17);
            label6.TabIndex = 5;
            label6.Text = "Город :";
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(112, 195);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(124, 23);
            countryTextBox.TabIndex = 6;
            countryTextBox.Validating += Validating;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(112, 233);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(124, 23);
            cityTextBox.TabIndex = 6;
            cityTextBox.Validating += Validating;
            // 
            // AddUserForm_5_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 325);
            Controls.Add(cityTextBox);
            Controls.Add(countryTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(addButton);
            Controls.Add(ageNumericUpDown);
            Controls.Add(nameTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddUserForm_5_";
            Text = "AddEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private NumericUpDown ageNumericUpDown;
        private Button addButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ErrorProvider errorProvider1;
        private TextBox emailTextBox;
        private TextBox cityTextBox;
        private TextBox countryTextBox;
        private Label label6;
    }
}