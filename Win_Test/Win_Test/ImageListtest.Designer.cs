namespace Win_Test
{
    partial class ImageListtest
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_memo = new System.Windows.Forms.TextBox();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_undo = new System.Windows.Forms.Button();
            this.btn_cut = new System.Windows.Forms.Button();
            this.btn_paste = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txt_memo
            // 
            this.txt_memo.Location = new System.Drawing.Point(12, 12);
            this.txt_memo.Multiline = true;
            this.txt_memo.Name = "txt_memo";
            this.txt_memo.Size = new System.Drawing.Size(377, 426);
            this.txt_memo.TabIndex = 0;
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(472, 152);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(258, 39);
            this.btn_copy.TabIndex = 1;
            this.btn_copy.Text = "복사";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_undo
            // 
            this.btn_undo.Location = new System.Drawing.Point(472, 107);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(258, 39);
            this.btn_undo.TabIndex = 2;
            this.btn_undo.Text = "실행취소";
            this.btn_undo.UseVisualStyleBackColor = true;
            this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // btn_cut
            // 
            this.btn_cut.Location = new System.Drawing.Point(472, 197);
            this.btn_cut.Name = "btn_cut";
            this.btn_cut.Size = new System.Drawing.Size(258, 39);
            this.btn_cut.TabIndex = 3;
            this.btn_cut.Text = "자르기";
            this.btn_cut.UseVisualStyleBackColor = true;
            this.btn_cut.Click += new System.EventHandler(this.btn_cut_Click);
            // 
            // btn_paste
            // 
            this.btn_paste.Location = new System.Drawing.Point(472, 242);
            this.btn_paste.Name = "btn_paste";
            this.btn_paste.Size = new System.Drawing.Size(258, 39);
            this.btn_paste.TabIndex = 4;
            this.btn_paste.Text = "붙여넣기";
            this.btn_paste.UseVisualStyleBackColor = true;
            this.btn_paste.Click += new System.EventHandler(this.btn_paste_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(472, 287);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(258, 39);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "종료";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_message.Font = new System.Drawing.Font("굴림", 28F);
            this.lbl_message.Location = new System.Drawing.Point(0, 444);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(800, 74);
            this.lbl_message.TabIndex = 6;
            this.lbl_message.Text = "label1";
            this.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageListtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_paste);
            this.Controls.Add(this.btn_cut);
            this.Controls.Add(this.btn_undo);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.txt_memo);
            this.Name = "ImageListtest";
            this.Text = "ImageListtest";
            this.Load += new System.EventHandler(this.ImageListtest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txt_memo;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_undo;
        private System.Windows.Forms.Button btn_cut;
        private System.Windows.Forms.Button btn_paste;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_message;
    }
}