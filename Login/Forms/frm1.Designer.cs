namespace Login
{
    partial class Loginfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginfrm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_login = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.tab_sign = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.datePicker = new BehComponents.DateTimePickerX();
            this.label8 = new System.Windows.Forms.Label();
            this.regbox_mail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.regbox_lastname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.regbox_username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.regbox_pass2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.regbox_pass1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.regbox_firstname = new System.Windows.Forms.TextBox();
            this.btn_reg = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1.SuspendLayout();
            this.tab_login.SuspendLayout();
            this.tab_sign.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab_login);
            this.tabControl1.Controls.Add(this.tab_sign);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(121, 20);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(557, 339);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tab_login
            // 
            this.tab_login.BackColor = System.Drawing.Color.White;
            this.tab_login.Controls.Add(this.linkLabel1);
            this.tab_login.Controls.Add(this.label2);
            this.tab_login.Controls.Add(this.txtbox_pass);
            this.tab_login.Controls.Add(this.label1);
            this.tab_login.Controls.Add(this.txtbox_username);
            this.tab_login.Controls.Add(this.btn);
            this.tab_login.Location = new System.Drawing.Point(4, 56);
            this.tab_login.Name = "tab_login";
            this.tab_login.Padding = new System.Windows.Forms.Padding(3);
            this.tab_login.Size = new System.Drawing.Size(549, 279);
            this.tab_login.TabIndex = 0;
            this.tab_login.Text = "Login";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(173, 203);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(227, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "اگر حساب کاربری ندارید برای ثبت نام کلیک کنید";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // txtbox_pass
            // 
            this.txtbox_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_pass.Location = new System.Drawing.Point(257, 84);
            this.txtbox_pass.Name = "txtbox_pass";
            this.txtbox_pass.Size = new System.Drawing.Size(142, 24);
            this.txtbox_pass.TabIndex = 1;
            this.txtbox_pass.UseSystemPasswordChar = true;
            this.txtbox_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // txtbox_username
            // 
            this.txtbox_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtbox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_username.Location = new System.Drawing.Point(259, 34);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(140, 24);
            this.txtbox_username.TabIndex = 0;
            this.txtbox_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharCheck);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(175, 133);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(224, 47);
            this.btn.TabIndex = 2;
            this.btn.Text = "Login";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.Btn_login);
            // 
            // tab_sign
            // 
            this.tab_sign.Controls.Add(this.label9);
            this.tab_sign.Controls.Add(this.datePicker);
            this.tab_sign.Controls.Add(this.label8);
            this.tab_sign.Controls.Add(this.regbox_mail);
            this.tab_sign.Controls.Add(this.label7);
            this.tab_sign.Controls.Add(this.regbox_lastname);
            this.tab_sign.Controls.Add(this.label6);
            this.tab_sign.Controls.Add(this.regbox_username);
            this.tab_sign.Controls.Add(this.label5);
            this.tab_sign.Controls.Add(this.regbox_pass2);
            this.tab_sign.Controls.Add(this.label3);
            this.tab_sign.Controls.Add(this.regbox_pass1);
            this.tab_sign.Controls.Add(this.label4);
            this.tab_sign.Controls.Add(this.regbox_firstname);
            this.tab_sign.Controls.Add(this.btn_reg);
            this.tab_sign.Location = new System.Drawing.Point(4, 56);
            this.tab_sign.Name = "tab_sign";
            this.tab_sign.Padding = new System.Windows.Forms.Padding(3);
            this.tab_sign.Size = new System.Drawing.Size(549, 279);
            this.tab_sign.TabIndex = 1;
            this.tab_sign.Text = "Sing Up";
            this.tab_sign.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Birthday:";
            // 
            // datePicker
            // 
            this.datePicker.AnchorSize = new System.Drawing.Size(397, 29);
            this.datePicker.AutoSize = true;
            this.datePicker.BackColor = System.Drawing.Color.White;
            this.datePicker.CalendarBoldedDayForeColor = System.Drawing.SystemColors.Highlight;
            this.datePicker.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.datePicker.CalendarDayRectTickness = 2F;
            this.datePicker.CalendarDaysBackColor = System.Drawing.Color.WhiteSmoke;
            this.datePicker.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.CalendarDaysForeColor = System.Drawing.Color.Black;
            this.datePicker.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.datePicker.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.datePicker.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.datePicker.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.datePicker.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.datePicker.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.datePicker.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.datePicker.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.datePicker.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.datePicker.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.datePicker.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.datePicker.CalendarShowToday = true;
            this.datePicker.CalendarShowTodayRect = true;
            this.datePicker.CalendarShowToolTips = true;
            this.datePicker.CalendarShowTrailing = true;
            this.datePicker.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.datePicker.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.datePicker.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.datePicker.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.datePicker.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.datePicker.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.datePicker.CalendarTitleBackColor = System.Drawing.Color.White;
            this.datePicker.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.datePicker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.datePicker.CalendarTodayBackColor = System.Drawing.SystemColors.ButtonFace;
            this.datePicker.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.datePicker.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.datePicker.CalendarTodayRectColor = System.Drawing.Color.Black;
            this.datePicker.CalendarTodayRectTickness = 2F;
            this.datePicker.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.datePicker.CalendarType = BehComponents.CalendarTypes.Persian;
            this.datePicker.CalendarWeekDaysBackColor = System.Drawing.Color.White;
            this.datePicker.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.datePicker.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.datePicker.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.datePicker.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.datePicker.ClearButtonBackColor = System.Drawing.Color.White;
            this.datePicker.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.datePicker.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("datePicker.ClearButtonImage")));
            this.datePicker.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.datePicker.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.datePicker.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.datePicker.ClearButtonText = "";
            this.datePicker.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.datePicker.ClearButtonToolTip = "";
            this.datePicker.ClearButtonWidth = 17;
            this.datePicker.ClearDateTimeWhenDownDeleteKey = true;
            this.datePicker.CustomFormat = "";
            this.datePicker.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.datePicker.DropDownClosedWhenClickOnDays = true;
            this.datePicker.DropDownClosedWhenSelectedDateChanged = false;
            this.datePicker.Format = BehComponents.DateTimePickerX.FormatDate.Long;
            this.datePicker.Format4Binding = "yyyy/MM/dd";
            this.datePicker.Location = new System.Drawing.Point(116, 150);
            this.datePicker.Name = "datePicker";
            this.datePicker.RightToLeftLayout = true;
            this.datePicker.ShowClearButton = true;
            this.datePicker.Size = new System.Drawing.Size(397, 29);
            this.datePicker.TabIndex = 19;
            this.datePicker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.datePicker.TextWhenClearButtonClicked = "";
            this.datePicker.OnOpenDropDown += new System.EventHandler(this.DatePicker_OnOpenDropDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(304, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "E-Mail:";
            // 
            // regbox_mail
            // 
            this.regbox_mail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.regbox_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbox_mail.Location = new System.Drawing.Point(373, 64);
            this.regbox_mail.Name = "regbox_mail";
            this.regbox_mail.Size = new System.Drawing.Size(140, 24);
            this.regbox_mail.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(290, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "LastName:";
            // 
            // regbox_lastname
            // 
            this.regbox_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbox_lastname.Location = new System.Drawing.Point(373, 18);
            this.regbox_lastname.Name = "regbox_lastname";
            this.regbox_lastname.Size = new System.Drawing.Size(140, 24);
            this.regbox_lastname.TabIndex = 1;
            this.regbox_lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharCheck);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Username:";
            // 
            // regbox_username
            // 
            this.regbox_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.regbox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbox_username.Location = new System.Drawing.Point(116, 64);
            this.regbox_username.Name = "regbox_username";
            this.regbox_username.Size = new System.Drawing.Size(140, 24);
            this.regbox_username.TabIndex = 2;
            this.regbox_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharCheck);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Repeat:";
            // 
            // regbox_pass2
            // 
            this.regbox_pass2.AcceptsTab = true;
            this.regbox_pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbox_pass2.Location = new System.Drawing.Point(373, 110);
            this.regbox_pass2.Name = "regbox_pass2";
            this.regbox_pass2.Size = new System.Drawing.Size(140, 24);
            this.regbox_pass2.TabIndex = 5;
            this.regbox_pass2.UseSystemPasswordChar = true;
            this.regbox_pass2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharCheck);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password:";
            // 
            // regbox_pass1
            // 
            this.regbox_pass1.AcceptsTab = true;
            this.regbox_pass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbox_pass1.Location = new System.Drawing.Point(116, 110);
            this.regbox_pass1.Name = "regbox_pass1";
            this.regbox_pass1.Size = new System.Drawing.Size(140, 24);
            this.regbox_pass1.TabIndex = 4;
            this.regbox_pass1.UseSystemPasswordChar = true;
            this.regbox_pass1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharCheck);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "FirstName:";
            // 
            // regbox_firstname
            // 
            this.regbox_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbox_firstname.Location = new System.Drawing.Point(116, 18);
            this.regbox_firstname.Name = "regbox_firstname";
            this.regbox_firstname.Size = new System.Drawing.Size(140, 24);
            this.regbox_firstname.TabIndex = 0;
            this.regbox_firstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharCheck);
            // 
            // btn_reg
            // 
            this.btn_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reg.Location = new System.Drawing.Point(166, 186);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(224, 49);
            this.btn_reg.TabIndex = 6;
            this.btn_reg.Text = "Register";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.Btn_reg_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 299);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(557, 40);
            this.progressBar1.TabIndex = 1;
            // 
            // Loginfrm
            // 
            this.AcceptButton = this.btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(557, 339);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Loginfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.tabControl1.ResumeLayout(false);
            this.tab_login.ResumeLayout(false);
            this.tab_login.PerformLayout();
            this.tab_sign.ResumeLayout(false);
            this.tab_sign.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_login;
        private System.Windows.Forms.TabPage tab_sign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_pass;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox regbox_pass2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regbox_pass1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox regbox_firstname;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox regbox_username;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox regbox_mail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox regbox_lastname;
        private System.Windows.Forms.ProgressBar progressBar1;
        private BehComponents.DateTimePickerX datePicker;
        private System.Windows.Forms.Label label9;
    }
}

