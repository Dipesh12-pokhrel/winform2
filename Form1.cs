namespace WinForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            /* if (uname.Text == "dipesh")
             {
                 if (pass.Text == "@16rt")
                 {
                     label4.Text = "SuccessFul login!";
                 }
                 else
                 {
                     label5.Text = "Invalid password!";
                 }
             }
             else
             {
                 label5.Text = "Invalid Username!";
             }*/
            string username = uname.Text.Trim();
            string password = pass.Text.Trim();
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                if (username == "admin" && password == "admin")
                {
                    MessageBox.Show("SuccessFully login!");
                    this.Hide();
                    new Dashboard().Show();
                }
                else
                {
                    MessageBox.Show("Invalid credential!");
                }
            }
            else
            {
                MessageBox.Show("Please enter credentials!");
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           if(checkBox1.Checked)
           {
                    pass.PasswordChar = '\0';
           }
           else
            {
                pass.PasswordChar = '*';
            }
      
        }
    }
}
