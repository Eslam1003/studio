using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studio
{
    public partial class Login : Form
    {
        DB con;
        public Login()
        {
            InitializeComponent();
            con = new DB();
        }

        private string UserName, Password,count;
        DataTable users ;

        public void ShowData()
        {
            string Query = $"SELECT * FROM users where user_name='{UserName}'AND password='{Password}'";
            users = con.GetData(Query);
            count = Convert.ToString(users.Rows.Count);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            UserName = Login_UserName.Text;
            Password = Login_UserName.Text;
            ShowData();
            if (count == "0")
            {
                MessageBox.Show("Not Valed User Name");
            }else if(count == "1")
            {
                 Main main = new Main();
                main.Show();
                this.Hide();
            }



        }

        private void UserNameText_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Login_Clear_Click(object sender, EventArgs e)
        {
            Login_UserName.Text = "";
            Login_Password.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
    }
}
