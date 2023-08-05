using System;
using System.Windows.Forms;
using static Login.Checkup;

namespace Login
{
    public partial class frm4 : Form
    {
        public string username;
        public frm4()
        {
            InitializeComponent();
        }
        private async void Btn_reg_Click(object sender, EventArgs e)
        {
            if (Check_Input(regbox_pass1.Text, regbox_pass2.Text, regbox_oldpass.Text))
            {
                Print(Error.Null, null);
                return;
            }

            if (!Check_Password(regbox_pass1.Text, regbox_pass2.Text))
            {
                Print(Error.Pass, null);
                return;
            }
            if (await new Database().Update_Pass(username, regbox_oldpass.Text, regbox_pass1.Text))
            {
                Print(Error.Ok, null);
            }
            regbox_oldpass.Text = regbox_pass1.Text = regbox_pass2.Text = null;
            this.Close();
        }
    }
}
