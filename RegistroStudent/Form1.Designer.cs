namespace RegistroStudent
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtFather = new TextBox();
            txtMother = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtTuition = new TextBox();
            txtCareer = new TextBox();
            numericUpDown = new NumericUpDown();
            btnCreate = new Button();
            LblStu = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 27);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 27);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 1;
            label2.Text = "FHATER LAST NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 27);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 2;
            label3.Text = "MOTHER LAST NAME";
            // 
            // txtName
            // 
            txtName.Location = new Point(24, 66);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // txtFather
            // 
            txtFather.Location = new Point(221, 66);
            txtFather.Name = "txtFather";
            txtFather.Size = new Size(100, 23);
            txtFather.TabIndex = 4;
            // 
            // txtMother
            // 
            txtMother.Location = new Point(405, 66);
            txtMother.Name = "txtMother";
            txtMother.Size = new Size(100, 23);
            txtMother.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 144);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 6;
            label4.Text = "BIRTHDATE";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(34, 178);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(90, 23);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(286, 144);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 8;
            label5.Text = "TUITION";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(456, 144);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 9;
            label6.Text = "CAREER";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(611, 144);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 10;
            label7.Text = "AVERAGE";
            // 
            // txtTuition
            // 
            txtTuition.Location = new Point(262, 178);
            txtTuition.Name = "txtTuition";
            txtTuition.Size = new Size(100, 23);
            txtTuition.TabIndex = 11;
            // 
            // txtCareer
            // 
            txtCareer.Location = new Point(425, 178);
            txtCareer.Name = "txtCareer";
            txtCareer.Size = new Size(100, 23);
            txtCareer.TabIndex = 12;
            // 
            // numericUpDown
            // 
            numericUpDown.Location = new Point(594, 178);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(120, 23);
            numericUpDown.TabIndex = 13;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(628, 258);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(104, 49);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "CREATE STUDENT";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // LblStu
            // 
            LblStu.AutoSize = true;
            LblStu.Location = new Point(53, 292);
            LblStu.Name = "LblStu";
            LblStu.Size = new Size(16, 15);
            LblStu.TabIndex = 15;
            LblStu.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblStu);
            Controls.Add(btnCreate);
            Controls.Add(numericUpDown);
            Controls.Add(txtCareer);
            Controls.Add(txtTuition);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(txtMother);
            Controls.Add(txtFather);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtFather;
        private TextBox txtMother;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtTuition;
        private TextBox txtCareer;
        private NumericUpDown numericUpDown;
        private Button btnCreate;
        private Label LblStu;
    }
}
