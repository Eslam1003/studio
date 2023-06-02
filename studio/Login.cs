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
            ShowData();
        }

            private void ShowData()
        {
            String Query = "SELECT * FROM users";
            list.DataSource = con.GetData(Query);
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
