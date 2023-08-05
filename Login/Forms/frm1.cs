using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Login.Checkup;

namespace Login
{
    public partial class Loginfrm : Form
    {
        private readonly Database db;
        public Loginfrm()
        {
            InitializeComponent();
            db = new Database();
        }
        private void Btn_login(object sender, EventArgs e)//Login Check
        {
            Start();
        }
        private async void Btn_reg_Click(object sender, EventArgs e)//Insert And Register
        {
            if (Check_Input(regbox_firstname.Text, regbox_lastname.Text, regbox_username.Text, regbox_mail.Text))
            {
                Print(Error.Null, null);
                return;
            }

            if (!Check_Password(regbox_pass1.Text, regbox_pass2.Text))
            {
                Print(Error.Pass, null);
                return;
            }

            if (!Check_Mail(regbox_mail.Text))
            {
                Print(Error.Format, null);
                return;
            }
            //Final:

            var Items = new List<string> { regbox_firstname.Text, regbox_lastname.Text, regbox_username.Text, regbox_mail.Text, regbox_pass1.Text, "read", datePicker.GetSelectedDateInPersianDateTime().ToShortDateString() };
            if (await db.InsertToDB(Items))
            {
                Print(Error.Ok, "");
                tabControl1.SelectTab(tab_login);
                datePicker.Text = regbox_firstname.Text = regbox_lastname.Text = regbox_mail.Text = regbox_pass1.Text = regbox_pass2.Text = regbox_username.Text = null;
            }
        }
        private async void Start()
        {
            if (Check_Input(txtbox_username.Text, txtbox_pass.Text))
            {
                Print(Error.Null, null);
                return;
            }
            await Waiting();
        }
        private async Task Waiting()
        {
            await Task.Run(async () =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    await Task.Delay(20);
                    progressBar1.Invoke(new Action(() =>
                    {
                        progressBar1.Value = i;
                    }));
                }
                progressBar1.Invoke(new Action(() =>
                {
                    db.Login(txtbox_username.Text, txtbox_pass.Text);
                    progressBar1.Value = 0;
                    txtbox_username.Text = txtbox_pass.Text = null;
                }));
            });
        }
        public void CharCheck(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void DatePicker_OnOpenDropDown(object sender, EventArgs e) => Print(Error.Other, ":توجه\r\nتاریخ تولد انتخاب شده باید افراد متولدین بیشتر از 15 سال باشند\r\nدر غیر اینصورت در پایگاه داه خالی ثبت خواهد شد ");
        private void Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectTab(tab_sign);
        }
    }
}