namespace DataGridView
{
    partial class AddEmployeeForm
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
            nameTextBox = new TextBox();
            positionTextBox = new TextBox();
            ageNumericUpDown = new NumericUpDown();
            salaryNumericUpDown = new NumericUpDown();
            addButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salaryNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameTextBox.Location = new Point(125, 69);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 0;
            nameTextBox.Validating += Validating;
            // 
            // positionTextBox
            // 
            positionTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            positionTextBox.Location = new Point(125, 166);
            positionTextBox.Name = "positionTextBox";
            positionTextBox.Size = new Size(126, 23);
            positionTextBox.TabIndex = 1;
            positionTextBox.Validating += Validating;
            // 
            // ageNumericUpDown
            // 
            ageNumericUpDown.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ageNumericUpDown.Location = new Point(125, 114);
            ageNumericUpDown.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            ageNumericUpDown.Name = "ageNumericUpDown";
            ageNumericUpDown.Size = new Size(48, 23);
            ageNumericUpDown.TabIndex = 2;
            ageNumericUpDown.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // salaryNumericUpDown
            // 
            salaryNumericUpDown.DecimalPlaces = 2;
            salaryNumericUpDown.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            salaryNumericUpDown.Location = new Point(125, 207);
            salaryNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            salaryNumericUpDown.Name = "salaryNumericUpDown";
            salaryNumericUpDown.Size = new Size(83, 23);
            salaryNumericUpDown.TabIndex = 3;
            // 
            // addButton
            // 
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addButton.Location = new Point(96, 260);
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
            label1.Location = new Point(76, 70);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 5;
            label1.Text = "Имя :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(54, 114);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 5;
            label2.Text = "Возраст :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(102, 20);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 5;
            label3.Text = "Сотрудник";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(31, 167);
            label4.Name = "label4";
            label4.Size = new Size(88, 17);
            label4.TabIndex = 5;
            label4.Text = "Должность :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(45, 208);
            label5.Name = "label5";
            label5.Size = new Size(74, 17);
            label5.TabIndex = 5;
            label5.Text = "Зарплата :";
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 325);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(addButton);
            Controls.Add(salaryNumericUpDown);
            Controls.Add(ageNumericUpDown);
            Controls.Add(positionTextBox);
            Controls.Add(nameTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddEmployeeForm";
            Text = "AddEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)salaryNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private TextBox positionTextBox;
        private NumericUpDown ageNumericUpDown;
        private NumericUpDown salaryNumericUpDown;
        private Button addButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}