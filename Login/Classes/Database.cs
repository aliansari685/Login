using Login.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using static Login.Checkup;

namespace Login
{
    sealed class Database : Operation
    {
        private string _info;
        internal string Information //send type user
        {
            get { return _info; }
            set
            {
                using (Frm2 f2 = new Frm2())
                {
                    _info = value;
                    switch (value)
                    {
                        case "read":
                            f2.btn_del.Enabled = f2.btn_edit.Enabled = f2.btn_insert.Enabled = false;
                            break;
                    }
                    f2.user.Text = _user.Username;
                    f2.Load += f2.Searchbox_TextChanged;
                    f2.ShowDialog();
                }
            }
        }
        public async void Login(string user, string pass) //Login Check..
        {
            using (context = new LoginDBEntities())
            {
                pass = await Hash(pass, pass);
                _user = context.Users.SingleOrDefault(x => x.Username == user && x.Password == pass);
                if (!(_user is null))
                {
                    Information = _user.Modify.ToLower();
                }
                else
                {
                    Print(Error.Login, null);
                }
            }
        }
        public bool Sum()
        {
            using (context = new LoginDBEntities())
            {
                int? num = context.Users.Sum(x => x.Row);
                int? num2 = context.Users.Count();
                num2 = num2 * (num2 + 1) / 2;
                return num2 == num;
            }
        }
        public BindingList<User> Fill_Tabel()
        {
            using (context = new LoginDBEntities())
            {
                context.Users.Load();
                return context.Users.Local.ToBindingList();
            }
        }
        public async Task<List<User>> Search_Query(string str)
        {
            str = str.Replace("ئ", "ی");
            await Task.Delay(500);
            using (context = new LoginDBEntities())
            {
                var query = IsPersianText(str) ? (from row in context.Users
                                                  where row.Firstname.Contains(str) || row.Lastname.Contains(str)
                                                  select row).ToList() :
                                              (from row in context.Users
                                               where row.Row.ToString().Contains(str) ||
                                               row.Firstname.Contains(str) ||
                                               row.Lastname.ToLower().Contains(str) ||
                                               row.Username.ToLower().Contains(str) ||
                                               row.Mail.ToLower().Contains(str) ||
                                               row.Modify.ToLower().Contains(str) ||
                                               row.RegisterDate.Contains(str) ||
                                               row.Birth.Contains(str)
                                               select row).ToList();
                Print(Error.Ok, "\n تعداد رکورد پیدا شده : " + query.Count);
                return query;
            }
        }
    }
}