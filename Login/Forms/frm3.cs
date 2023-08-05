using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Login.Checkup;

namespace Login
{
    public partial class Frm3 : Form
    {
        readonly Loginfrm f1;
        readonly Database db;
        string mdfy;
        List<string> Items;

        public Frm3()
        {
            InitializeComponent();
            db = new Database();
            f1 = new Loginfrm();
        }
        private async void Btn_reg_Click(object sender, EventArgs e)
        {
            if (Check_Input(regbox_firstname.Text, regbox_lastname.Text, regbox_username.Text, regbox_mail.Text))
            {
                Print(Error.Null, null);
                return;
            }
            if (!Check_Mail(regbox_mail.Text))
            {
                Print(Error.Format, null);
                return;
            }
            mdfy = (radio_write.Checked) ? "write" : "read";

            //Final:

            if (Idbox.Text is "0") //insert
            {
                Items = new List<string> { regbox_firstname.Text, regbox_lastname.Text, regbox_username.Text, regbox_mail.Text, regbox_username.Text, mdfy, datePicker.GetSelectedDateInPersianDateTime().ToShortDateString() };
                if (await db.InsertToDB(Items))
                {
                    Print(Error.Ok, null);
                    Print(Error.Other, "توجه رمزعبور کاربر اضافه شده همان نام کاربری ثبت شده است");
                }
            }
            else  //update:
            {
                Items = new List<string> { regbox_firstname.Text, regbox_lastname.Text, regbox_username.Text, regbox_mail.Text, mdfy, datePicker.GetSelectedDateInPersianDateTime().ToShortDateString() };
                int id = Convert.ToInt32(Idbox.Text.ToString());
                if (db.UpdateTBL(id, Items))
                {
                    Print(Error.Ok, null);
                }
            }
            this.Close();
        }
        private void Frm3_FormClosed(object sender, FormClosedEventArgs e)
        {
            regbox_firstname.Select();
            regbox_firstname.Text = regbox_lastname.Text = regbox_username.Text = regbox_mail.Text = null;
            radio_read.Checked = regbox_username.Enabled = true;
            datePicker.SelectedDateInDateTime = DateTime.Now;
        }
        private void CharCheck(object sender, KeyPressEventArgs e) => f1.CharCheck(sender, e);
    }
}