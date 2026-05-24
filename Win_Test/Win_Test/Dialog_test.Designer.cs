namespace Win_Test
{
    partial class Dialog_test
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
            this.Txt_memo = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Btn_font = new System.Windows.Forms.Button();
            this.Btn_color = new System.Windows.Forms.Button();
            this.Btn_save = new System.Windows.Forms.Button();
            this.Btn_open = new System.Windows.Forms.Button();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_memo
            // 
            this.Txt_memo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Txt_memo.Location = new System.Drawing.Point(0, 0);
            this.Txt_memo.Multiline = true;
            this.Txt_memo.Name = "Txt_memo";
            this.Txt_memo.Size = new System.Drawing.Size(465, 450);
            this.Txt_memo.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Btn_font
            // 
            this.Btn_font.Font = new System.Drawing.Font("굴림", 12F);
            this.Btn_font.Location = new System.Drawing.Point(526, 83);
            this.Btn_font.Name = "Btn_font";
            this.Btn_font.Size = new System.Drawing.Size(219, 51);
            this.Btn_font.TabIndex = 1;
            this.Btn_font.Text = "글꼴";
            this.Btn_font.UseVisualStyleBackColor = true;
            this.Btn_font.Click += new System.EventHandler(this.Btn_font_Click);
            // 
            // Btn_color
            // 
            this.Btn_color.Font = new System.Drawing.Font("굴림", 12F);
            this.Btn_color.Location = new System.Drawing.Point(526, 140);
            this.Btn_color.Name = "Btn_color";
            this.Btn_color.Size = new System.Drawing.Size(219, 51);
            this.Btn_color.TabIndex = 2;
            this.Btn_color.Text = "색상";
            this.Btn_color.UseVisualStyleBackColor = true;
            this.Btn_color.Click += new System.EventHandler(this.Btn_color_Click);
            // 
            // Btn_save
            // 
            this.Btn_save.Font = new System.Drawing.Font("굴림", 12F);
            this.Btn_save.Location = new System.Drawing.Point(526, 197);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(219, 51);
            this.Btn_save.TabIndex = 3;
            this.Btn_save.Text = "저장";
            this.Btn_save.UseVisualStyleBackColor = true;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // Btn_open
            // 
            this.Btn_open.Font = new System.Drawing.Font("굴림", 12F);
            this.Btn_open.Location = new System.Drawing.Point(526, 254);
            this.Btn_open.Name = "Btn_open";
            this.Btn_open.Size = new System.Drawing.Size(219, 51);
            this.Btn_open.TabIndex = 4;
            this.Btn_open.Text = "불러오기";
            this.Btn_open.UseVisualStyleBackColor = true;
            this.Btn_open.Click += new System.EventHandler(this.Btn_open_Click);
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.Font = new System.Drawing.Font("굴림", 12F);
            this.Btn_cancel.Location = new System.Drawing.Point(526, 311);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(219, 51);
            this.Btn_cancel.TabIndex = 5;
            this.Btn_cancel.Text = "종료";
            this.Btn_cancel.UseVisualStyleBackColor = true;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // Dialog_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.Btn_open);
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.Btn_color);
            this.Controls.Add(this.Btn_font);
            this.Controls.Add(this.Txt_memo);
            this.Name = "Dialog_test";
            this.Text = "Dialog_test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_memo;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Btn_font;
        private System.Windows.Forms.Button Btn_color;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.Button Btn_open;
        private System.Windows.Forms.Button Btn_cancel;
    }
}