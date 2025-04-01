namespace WinForm2
{
    partial class Booking
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            Save = new Button();
            Cancel = new Button();
            fName = new TextBox();
            uM = new CheckBox();
            bC = new CheckBox();
            lName = new TextBox();
            dayCount = new NumericUpDown();
            add = new RichTextBox();
            Valid = new CheckBox();
            carType = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            age = new TextBox();
            fuelType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dayCount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 23);
            label1.Name = "label1";
            label1.Size = new Size(302, 35);
            label1.TabIndex = 0;
            label1.Text = "Car Booking Form";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 112);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 158);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 2;
            label3.Text = "Second Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 226);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(135, 333);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 4;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(131, 423);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 5;
            label6.Text = "Driving License";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(131, 376);
            label7.Name = "label7";
            label7.Size = new Size(117, 20);
            label7.TabIndex = 6;
            label7.Text = "Number of Days";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(131, 470);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 7;
            label8.Text = "Car Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(131, 512);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 8;
            label9.Text = "Fuel Type";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(131, 558);
            label10.Name = "label10";
            label10.Size = new Size(136, 20);
            label10.TabIndex = 9;
            label10.Text = "Unlimited Milleage";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(135, 604);
            label11.Name = "label11";
            label11.Size = new Size(125, 20);
            label11.TabIndex = 10;
            label11.Text = "Breakdown Cover";
            label11.Click += label11_Click;
            // 
            // Save
            // 
            Save.Location = new Point(146, 662);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 11;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += button1_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(446, 662);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(94, 29);
            Cancel.TabIndex = 12;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += button2_Click;
            // 
            // fName
            // 
            fName.Location = new Point(305, 98);
            fName.Multiline = true;
            fName.Name = "fName";
            fName.Size = new Size(289, 34);
            fName.TabIndex = 13;
            fName.TextChanged += textBox1_TextChanged_1;
            // 
            // uM
            // 
            uM.AutoSize = true;
            uM.Location = new Point(304, 558);
            uM.Name = "uM";
            uM.Size = new Size(54, 24);
            uM.TabIndex = 21;
            uM.Text = "opt";
            uM.UseVisualStyleBackColor = true;
            // 
            // bC
            // 
            bC.AutoSize = true;
            bC.Location = new Point(304, 603);
            bC.Name = "bC";
            bC.Size = new Size(54, 24);
            bC.TabIndex = 22;
            bC.Text = "opt";
            bC.UseVisualStyleBackColor = true;
            // 
            // lName
            // 
            lName.Location = new Point(304, 158);
            lName.Multiline = true;
            lName.Name = "lName";
            lName.Size = new Size(289, 34);
            lName.TabIndex = 23;
            lName.TextChanged += textBox9_TextChanged;
            // 
            // dayCount
            // 
            dayCount.Location = new Point(304, 374);
            dayCount.Maximum = new decimal(new int[] { 28, 0, 0, 0 });
            dayCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            dayCount.Name = "dayCount";
            dayCount.Size = new Size(114, 27);
            dayCount.TabIndex = 29;
            dayCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            dayCount.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // add
            // 
            add.Location = new Point(304, 213);
            add.Name = "add";
            add.Size = new Size(289, 105);
            add.TabIndex = 30;
            add.Text = "";
            // 
            // Valid
            // 
            Valid.AutoSize = true;
            Valid.Location = new Point(305, 419);
            Valid.Name = "Valid";
            Valid.Size = new Size(64, 24);
            Valid.TabIndex = 31;
            Valid.Text = "Valid";
            Valid.UseVisualStyleBackColor = true;
            Valid.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // carType
            // 
            carType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            carType.FormattingEnabled = true;
            carType.Items.AddRange(new object[] { "City Car", "Family Car", "Sports Car", "SUV" });
            carType.Location = new Point(305, 462);
            carType.Name = "carType";
            carType.Size = new Size(115, 28);
            carType.TabIndex = 32;
            carType.Text = "Choose a Car";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(623, 60);
            label12.Name = "label12";
            label12.Size = new Size(171, 20);
            label12.TabIndex = 35;
            label12.Text = "Welcome, to WeAreCars.";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(206, 112);
            label13.Name = "label13";
            label13.Size = new Size(15, 20);
            label13.TabIndex = 36;
            label13.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Red;
            label14.Location = new Point(233, 158);
            label14.Name = "label14";
            label14.Size = new Size(15, 20);
            label14.TabIndex = 37;
            label14.Text = "*";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Red;
            label15.Location = new Point(166, 328);
            label15.Name = "label15";
            label15.Size = new Size(15, 20);
            label15.TabIndex = 38;
            label15.Text = "*";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.Red;
            label16.Location = new Point(187, 226);
            label16.Name = "label16";
            label16.Size = new Size(15, 20);
            label16.TabIndex = 39;
            label16.Text = "*";
            label16.Click += label16_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Red;
            label17.Location = new Point(245, 374);
            label17.Name = "label17";
            label17.Size = new Size(15, 20);
            label17.TabIndex = 40;
            label17.Text = "*";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.Red;
            label18.Location = new Point(238, 420);
            label18.Name = "label18";
            label18.Size = new Size(15, 20);
            label18.TabIndex = 41;
            label18.Text = "*";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.Red;
            label19.Location = new Point(203, 470);
            label19.Name = "label19";
            label19.Size = new Size(15, 20);
            label19.TabIndex = 42;
            label19.Text = "*";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.Red;
            label20.Location = new Point(208, 509);
            label20.Name = "label20";
            label20.Size = new Size(15, 20);
            label20.TabIndex = 43;
            label20.Text = "*";
            // 
            // age
            // 
            age.Location = new Point(303, 336);
            age.Name = "age";
            age.Size = new Size(125, 27);
            age.TabIndex = 44;
            // 
            // fuelType
            // 
            fuelType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fuelType.FormattingEnabled = true;
            fuelType.Items.AddRange(new object[] { "Petrol", "Diesel", "Hybrid", "Full Electric" });
            fuelType.Location = new Point(305, 509);
            fuelType.Name = "fuelType";
            fuelType.Size = new Size(151, 28);
            fuelType.TabIndex = 33;
            fuelType.Text = "Choose Fuel Type";
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(803, 722);
            Controls.Add(age);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(fuelType);
            Controls.Add(carType);
            Controls.Add(Valid);
            Controls.Add(add);
            Controls.Add(dayCount);
            Controls.Add(lName);
            Controls.Add(bC);
            Controls.Add(uM);
            Controls.Add(fName);
            Controls.Add(Cancel);
            Controls.Add(Save);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Booking";
            Text = "Booking";
            ((System.ComponentModel.ISupportInitialize)dayCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button Save;
        private Button Cancel;
        private TextBox fName;
        private CheckBox uM;
        private CheckBox bC;
        private TextBox lName;
        private NumericUpDown dayCount;
        private RichTextBox add;
        private CheckBox Valid;
        private ComboBox carType;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private TextBox age;
        private ComboBox fuelType;
    }
}