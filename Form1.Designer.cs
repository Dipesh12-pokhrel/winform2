namespace WinForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            uname = new TextBox();
            pass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            submit = new Label();
            label5 = new Label();
            invalid = new Label();
            label4 = new Label();
            success = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // uname
            // 
            uname.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            uname.BackColor = SystemColors.ScrollBar;
            uname.Location = new Point(315, 102);
            uname.Multiline = true;
            uname.Name = "uname";
            uname.Size = new Size(181, 27);
            uname.TabIndex = 0;
            uname.TextChanged += textBox1_TextChanged;
            // 
            // pass
            // 
            pass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pass.BackColor = SystemColors.ScrollBar;
            pass.Location = new Point(315, 151);
            pass.Multiline = true;
            pass.Name = "pass";
            pass.PasswordChar = '*';
            pass.Size = new Size(188, 27);
            pass.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 105);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 158);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // submit
            // 
            submit.AutoSize = true;
            submit.BackColor = SystemColors.ActiveCaption;
            submit.Location = new Point(365, 264);
            submit.Name = "submit";
            submit.Size = new Size(70, 20);
            submit.TabIndex = 4;
            submit.Text = "  Sign in  ";
            submit.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 264);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 8;
            // 
            // invalid
            // 
            invalid.AutoSize = true;
            invalid.Location = new Point(228, 264);
            invalid.Name = "invalid";
            invalid.Size = new Size(0, 20);
            invalid.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 245);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 7;
            // 
            // success
            // 
            success.AutoSize = true;
            success.Location = new Point(228, 244);
            success.Name = "success";
            success.Size = new Size(0, 20);
            success.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(335, 214);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(134, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Show password";
            checkBox1.TextImageRelation = TextImageRelation.TextAboveImage;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(invalid);
            Controls.Add(success);
            Controls.Add(submit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pass);
            Controls.Add(uname);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Login form";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox uname;
        private TextBox pass;
        private Label label1;
        private Label label2;
        private Label submit;
        private Label success;
        private Label invalid;
        private Label label4;
        private Label label5;
        private CheckBox checkBox1;
    }
}
