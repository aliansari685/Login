using Login.Model;

namespace Login
{
    partial class Frm3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm3));
            this.label8 = new System.Windows.Forms.Label();
            this.regbox_mail = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.regbox_lastname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.regbox_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.regbox_firstname = new System.Windows.Forms.TextBox();
            this.btn_reg = new System.Windows.Forms.Button();
            this.radio_read = new System.Windows.Forms.RadioButton();
            this.radio_write = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Idbox = new System.Windows.Forms.TextBox();
            this.datePicker = new BehComponents.DateTimePickerX();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(276, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 31;
            this.label8.Text = "E-Mail:";
            // 
            // regbox_mail
            // 
            this.regbox_mail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.regbox_mail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Mail", true));
            this.regbox_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbox_mail.Location = new System.Drawing.Point(356, 67);
            this.regbox_mail.Name = "regbox_mail";
            this.regbox_mail.Size = new System.Drawing.Size(143, 24);
            this.regbox_mail.TabIndex = 2;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Login.Model.User);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "LastName:";
            // 
            // regbox_lastname
            // 
            this.regbox_lastname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Lastname", true));
            this.regbox_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbox_lastname.Location = new System.Drawing.Point(101, 64);
            this.regbox_lastname.Name = "regbox_lastname";
            this.regbox_lastname.Size = new System.Drawing.Size(143, 24);
            this.regbox_lastname.TabIndex = 1;
            this.regbox_lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharCheck);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Username:";
            // 
            // regbox_username
            // 
            this.regbox_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.regbox_username.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Username", true));
            this.regbox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbox_username.Location = new System.Drawing.Point(101, 106);
            this.regbox_username.Name = "regbox_username";
            this.regbox_username.Size = new System.Drawing.Size(143, 24);
            this.regbox_username.TabIndex = 3;
            this.regbox_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharCheck);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "FirstName:";
            // 
            // regbox_firstname
            // 
            this.regbox_firstname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Firstname", true));
            this.regbox_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbox_firstname.Location = new System.Drawing.Point(356, 24);
            this.regbox_firstname.Name = "regbox_firstname";
            this.regbox_firstname.Size = new System.Drawing.Size(143, 24);
            this.regbox_firstname.TabIndex = 0;
            this.regbox_firstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharCheck);
            // 
            // btn_reg
            // 
            this.btn_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reg.Location = new System.Drawing.Point(36, 149);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(224, 51);
            this.btn_reg.TabIndex = 6;
            this.btn_reg.Text = "Accept";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.Btn_reg_Click);
            // 
            // radio_read
            // 
            this.radio_read.AutoSize = true;
            this.radio_read.Checked = true;
            this.radio_read.Location = new System.Drawing.Point(130, 18);
            this.radio_read.Name = "radio_read";
            this.radio_read.Size = new System.Drawing.Size(57, 17);
            this.radio_read.TabIndex = 33;
            this.radio_read.TabStop = true;
            this.radio_read.Text = "خواندن";
            this.radio_read.UseVisualStyleBackColor = true;
            // 
            // radio_write
            // 
            this.radio_write.AutoSize = true;
            this.radio_write.Location = new System.Drawing.Point(88, 41);
            this.radio_write.Name = "radio_write";
            this.radio_write.Size = new System.Drawing.Size(99, 17);
            this.radio_write.TabIndex = 35;
            this.radio_write.TabStop = true;
            this.radio_write.Text = "خواندن و نوشتن";
            this.radio_write.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radio_read);
            this.groupBox1.Controls.Add(this.radio_write);
            this.groupBox1.Location = new System.Drawing.Point(293, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(203, 70);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "سطح دسترسی :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Write";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Read";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "ID:";
            // 
            // Idbox
            // 
            this.Idbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "ID", true));
            this.Idbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idbox.Location = new System.Drawing.Point(101, 20);
            this.Idbox.Name = "Idbox";
            this.Idbox.ReadOnly = true;
            this.Idbox.Size = new System.Drawing.Size(143, 24);
            this.Idbox.TabIndex = 39;
            // 
            // datePicker
            // 
            this.datePicker.AnchorSize = new System.Drawing.Size(177, 26);
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
            this.datePicker.ClearButtonWidth = 18;
            this.datePicker.ClearDateTimeWhenDownDeleteKey = true;
            this.datePicker.CustomFormat = "";
            this.datePicker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateInStringPersian", this.userBindingSource, "Birth", true));
            this.datePicker.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.datePicker.DropDownClosedWhenClickOnDays = true;
            this.datePicker.DropDownClosedWhenSelectedDateChanged = false;
            this.datePicker.Format = BehComponents.DateTimePickerX.FormatDate.Long;
            this.datePicker.Format4Binding = "yyyy/MM/dd";
            this.datePicker.Location = new System.Drawing.Point(322, 104);
            this.datePicker.Name = "datePicker";
            this.datePicker.RightToLeftLayout = true;
            this.datePicker.ShowClearButton = true;
            this.datePicker.Size = new System.Drawing.Size(177, 26);
            this.datePicker.TabIndex = 4;
            this.datePicker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.datePicker.TextWhenClearButtonClicked = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(250, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 41;
            this.label9.Text = "Birthday:";
            // 
            // Frm3
            // 
            this.AcceptButton = this.btn_reg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 222);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.Idbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.regbox_mail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.regbox_lastname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.regbox_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.regbox_firstname);
            this.Controls.Add(this.btn_reg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Frm3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm3_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox regbox_mail;
        public System.Windows.Forms.TextBox regbox_lastname;
        public System.Windows.Forms.TextBox regbox_username;
        public System.Windows.Forms.TextBox regbox_firstname;
        public System.Windows.Forms.RadioButton radio_write;
        public System.Windows.Forms.RadioButton radio_read;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Idbox;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.BindingSource userBindingSource;
        internal BehComponents.DateTimePickerX datePicker;
    }
}