namespace Login
{
    partial class frm4
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
            this.label5 = new System.Windows.Forms.Label();
            this.regbox_pass2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.regbox_pass1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.regbox_oldpass = new System.Windows.Forms.TextBox();
            this.btn_reg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Repeat:";
            // 
            // regbox_pass2
            // 
            this.regbox_pass2.AcceptsTab = true;
            this.regbox_pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbox_pass2.Location = new System.Drawing.Point(131, 99);
            this.regbox_pass2.Name = "regbox_pass2";
            this.regbox_pass2.Size = new System.Drawing.Size(140, 24);
            this.regbox_pass2.TabIndex = 2;
            this.regbox_pass2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "New Password:";
            // 
            // regbox_pass1
            // 
            this.regbox_pass1.AcceptsTab = true;
            this.regbox_pass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbox_pass1.Location = new System.Drawing.Point(131, 57);
            this.regbox_pass1.Name = "regbox_pass1";
            this.regbox_pass1.Size = new System.Drawing.Size(140, 24);
            this.regbox_pass1.TabIndex = 1;
            this.regbox_pass1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Old Password:";
            // 
            // regbox_oldpass
            // 
            this.regbox_oldpass.AcceptsTab = true;
            this.regbox_oldpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbox_oldpass.Location = new System.Drawing.Point(131, 18);
            this.regbox_oldpass.Name = "regbox_oldpass";
            this.regbox_oldpass.Size = new System.Drawing.Size(140, 24);
            this.regbox_oldpass.TabIndex = 0;
            this.regbox_oldpass.UseSystemPasswordChar = true;
            // 
            // btn_reg
            // 
            this.btn_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reg.Location = new System.Drawing.Point(15, 139);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(256, 49);
            this.btn_reg.TabIndex = 3;
            this.btn_reg.Text = "Change";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.Btn_reg_Click);
            // 
            // frm4
            // 
            this.AcceptButton = this.btn_reg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 200);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regbox_oldpass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.regbox_pass2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.regbox_pass1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox regbox_pass2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regbox_pass1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox regbox_oldpass;
        private System.Windows.Forms.Button btn_reg;
    }
}