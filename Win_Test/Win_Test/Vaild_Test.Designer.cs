namespace Win_Test
{
    partial class Vaild_Test
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
            this.label1 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_message = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_home = new System.Windows.Forms.TextBox();
            this.txt_cell = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(57, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "성명(&N) :";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.email.Location = new System.Drawing.Point(38, 107);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(107, 22);
            this.email.TabIndex = 2;
            this.email.Text = "이메일(&E) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(38, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "집전화(&T) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(36, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "휴대폰(&H) :";
            // 
            // lbl_message
            // 
            this.lbl_message.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_message.Font = new System.Drawing.Font("휴먼엑스포", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_message.Location = new System.Drawing.Point(1, 378);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(428, 86);
            this.lbl_message.TabIndex = 8;
            this.lbl_message.Text = "label5";
            this.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_message.Validated += new System.EventHandler(this.lbl_message_Validated);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(158, 77);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(225, 25);
            this.txt_name.TabIndex = 1;
            this.txt_name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_name_Validating);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(158, 108);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(225, 25);
            this.txt_email.TabIndex = 3;
            this.txt_email.Validating += new System.ComponentModel.CancelEventHandler(this.txt_email_Validating);
            // 
            // txt_home
            // 
            this.txt_home.Location = new System.Drawing.Point(158, 139);
            this.txt_home.Name = "txt_home";
            this.txt_home.Size = new System.Drawing.Size(225, 25);
            this.txt_home.TabIndex = 5;
            this.txt_home.Validating += new System.ComponentModel.CancelEventHandler(this.txt_home_Validating);
            // 
            // txt_cell
            // 
            this.txt_cell.Location = new System.Drawing.Point(158, 170);
            this.txt_cell.Name = "txt_cell";
            this.txt_cell.Size = new System.Drawing.Size(225, 25);
            this.txt_cell.TabIndex = 7;
            this.txt_cell.Validating += new System.ComponentModel.CancelEventHandler(this.txt_cell_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.Location = new System.Drawing.Point(220, 214);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(119, 62);
            this.Btn_cancel.TabIndex = 10;
            this.Btn_cancel.Text = "취소";
            this.Btn_cancel.UseVisualStyleBackColor = true;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // Vaild_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 464);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_cell);
            this.Controls.Add(this.txt_home);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label1);
            this.Name = "Vaild_Test";
            this.Text = "Vaild_Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_home;
        private System.Windows.Forms.TextBox txt_cell;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_cancel;
    }
}