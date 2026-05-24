namespace Win_Test
{
    partial class Log
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_NO = new System.Windows.Forms.Button();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.Lbl_Pass = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(339, 16);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 31);
            this.Btn_OK.TabIndex = 0;
            this.Btn_OK.Text = "확인";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_NO
            // 
            this.Btn_NO.Location = new System.Drawing.Point(339, 53);
            this.Btn_NO.Name = "Btn_NO";
            this.Btn_NO.Size = new System.Drawing.Size(75, 31);
            this.Btn_NO.TabIndex = 1;
            this.Btn_NO.Text = "취소";
            this.Btn_NO.UseVisualStyleBackColor = true;
            this.Btn_NO.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lbl_ID.Location = new System.Drawing.Point(93, 21);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(41, 19);
            this.Lbl_ID.TabIndex = 2;
            this.Lbl_ID.Text = "ID : ";
            this.Lbl_ID.Click += new System.EventHandler(this.Lbl_ID_Click);
            // 
            // Lbl_Pass
            // 
            this.Lbl_Pass.AutoSize = true;
            this.Lbl_Pass.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lbl_Pass.Location = new System.Drawing.Point(12, 58);
            this.Lbl_Pass.Name = "Lbl_Pass";
            this.Lbl_Pass.Size = new System.Drawing.Size(122, 19);
            this.Lbl_Pass.TabIndex = 3;
            this.Lbl_Pass.Text = "PASSWORD : ";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(140, 19);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(181, 21);
            this.txt_ID.TabIndex = 4;
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(140, 56);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(181, 21);
            this.txt_Pass.TabIndex = 5;
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 99);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.Lbl_Pass);
            this.Controls.Add(this.Lbl_ID);
            this.Controls.Add(this.Btn_NO);
            this.Controls.Add(this.Btn_OK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Log";
            this.Text = "Log on";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Log_FormClosing);
            this.Load += new System.EventHandler(this.Log_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_NO;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.Label Lbl_Pass;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Pass;
    }
}

