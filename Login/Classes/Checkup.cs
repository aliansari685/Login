using System;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    static class Checkup
    {
        //تعریف نوع داده شمارشی جهت نمایش پیام های دلخواه و مقدار دهی آن در خط بعدی
        public enum Error { Null, Tekrari, Ok, Cancel, DataBase, Pass, Format, Login, Other }
        public static void Print(Error Foul, string Message)
        {
            switch (Foul)
            {
                case Error.Null:
                    MessageBox.Show("مقادیر ورودی خالی است" + Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;

                case Error.Tekrari:
                    MessageBox.Show("مقدار نام کاربری تکرای است" + Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;

                case Error.Ok:
                    MessageBox.Show("عملیات با موفقیت انجام شد" + Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case Error.Cancel:
                    MessageBox.Show("عملیات متوقف و انجام نشد" + Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case Error.DataBase:
                    MessageBox.Show("مشکلی در پایگاه داده بوجود آمد" + Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case Error.Pass:
                    MessageBox.Show("رمز عبور از پنج حرف کمتر یا یکسان نیست" + Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;

                case Error.Format:
                    MessageBox.Show("فرمت مقادیر ورودی معتبر نیست" + Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;

                case Error.Login:
                    MessageBox.Show("نام کاربری  یا رمز عبور اشتباه است" + Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;

                case Error.Other:
                    MessageBox.Show(Message, "Other", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        public static async Task<string> Hash(string data, string key)
        {
            await Task.Delay(1000);
            using (HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(key)))
            {
                byte[] hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(data));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
        public static string Shamsi_Date()
        {
            PersianCalendar pr = new PersianCalendar();
            string datenow = string.Format("{0}/{1}/{2}-{3}",
                pr.GetYear(DateTime.Now),
                pr.GetMonth(DateTime.Now),
                pr.GetDayOfMonth(DateTime.Now),
                DateTime.Now.ToLongTimeString());
            return datenow;
        }

        #region Checking Functions
        //در این توابع چک کردن فرمت ورودی و خالی بودن آن ها بررسی میشود
        public static bool Check_Input(params string[] str) => str.Any(x => string.IsNullOrWhiteSpace(x));
        public static bool Check_Password(string str, string str1) => (str == str1) && (str.Length >= 5) && !(string.IsNullOrWhiteSpace(str));
        public static bool Check_Mail(string str)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,4})+)";
            return Regex.IsMatch(str, pattern);
        }
        public static bool IsPersianText(string text) => text.Any(c => c >= 0x0600 && c <= 0x06FF);
        #endregion
    }
}