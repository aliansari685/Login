using Login.Model;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using static Login.Checkup;

namespace Login
{
    public partial class Frm2 : Form
    {
        private Database db;
        readonly Frm3 _frm3;
        public Frm2()
        {
            InitializeComponent();
            CheckListItems();
            _frm3 = new Frm3();
            _frm3.FormClosed += GetData;
        }
        public void GetData(object sender, FormClosedEventArgs e)
        {
            db = new Database();
            dataGridView1.DataSource = db.Fill_Tabel();
            dataGridView1.Columns["ID"].Visible = false;
        }

        private void Btn_insert_Click(object sender, EventArgs e)
        {
            _frm3.userBindingSource.DataSource = new User();
            _frm3.ShowDialog();
        }
        private void Btn_edit_Click(object sender, EventArgs e)//Or DataGrid Double Click:
        {
            if (dataGridView1.SelectedRows.Count == 1 && btn_edit.Enabled)
            {
                using (var context = new LoginDBEntities())
                {
                    int _id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
                    var _user = context.Users.Find(_id);
                    _frm3.userBindingSource.DataSource = _user;
                    _frm3.radio_write.Checked = (_user.Modify == "write");
                    _frm3.regbox_username.Enabled = !(_user.Username == this.user.Text);
                    _frm3.ShowDialog();
                }
            }
        }
        private void Btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("اطمینان دارید برای حذف ؟", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow id in dataGridView1.SelectedRows)
                {
                    int _id = Convert.ToInt32(id.Cells[0].Value);
                    db.DeleteInDB(_id);
                }
                GetData(null, null);
                Print(Error.Ok, "\n تعداد : " + dataGridView1.SelectedRows.Count + "حذف شد");
            }
        }
        private void Btnpass_Click(object sender, EventArgs e)
        {
            using (frm4 f4 = new frm4())
            {
                f4.username = user.Text;
                f4.ShowDialog();
            }
            GetData(null, null);
        }

        public void Searchbox_TextChanged(object sender, EventArgs e)
        {
            if (Check_Input(searchbox.Text)) { GetData(null, null); }
        }

        private async void SearchBTN_Click(object sender, EventArgs e)
        {
            if (!Check_Input(searchbox.Text))
            {
                dataGridView1.DataSource = await db.Search_Query(searchbox.Text);
            }
            else
            {
                Print(Error.Null, null);
            }
        }
        private void CheckListItems() //Get Names By Class User
        {
            Type myClassType = typeof(User);
            PropertyInfo[] properties = myClassType.GetProperties();
            properties.Skip(1).ToList().ForEach(x => checkedListBox1.Items.Add(x.Name, true));
        }
        private void CheckedListBox1_SelectedValueChanged(object sender, EventArgs e)//DatagridView Col Visible Changed:
        {
            try
            {
                int selectedIndex = checkedListBox1.SelectedIndex;
                string columnName = checkedListBox1.Items[selectedIndex].ToString();
                bool isVisible = checkedListBox1.GetItemChecked(selectedIndex);
                dataGridView1.Columns[columnName].Visible = isVisible;
            }
            catch (Exception ex)
            {
                Print(Error.Cancel, ex.Message);
            }
        }
        private void Timer1_Tick(object sender, EventArgs e) => time.Text = Shamsi_Date();
    }
}