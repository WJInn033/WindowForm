namespace Win_Test
{
    partial class Key_Form
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
            this.Lbl_Mag = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_memo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Mag
            // 
            this.Lbl_Mag.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Mag.Font = new System.Drawing.Font("굴림", 16F);
            this.Lbl_Mag.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Mag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Mag.Name = "Lbl_Mag";
            this.Lbl_Mag.Size = new System.Drawing.Size(1000, 91);
            this.Lbl_Mag.TabIndex = 0;
            this.Lbl_Mag.Text = "label1";
            this.Lbl_Mag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Mag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 407);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(508, 407);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_memo
            // 
            this.txt_memo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_memo.Location = new System.Drawing.Point(0, 91);
            this.txt_memo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_memo.Multiline = true;
            this.txt_memo.Name = "txt_memo";
            this.txt_memo.Size = new System.Drawing.Size(1000, 243);
            this.txt_memo.TabIndex = 3;
            this.txt_memo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_memo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_memo_KeyDown);
            this.txt_memo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_memo_KeyPress);
            // 
            // Key_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 540);
            this.Controls.Add(this.txt_memo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lbl_Mag);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Key_Form";
            this.Text = "Key_Form";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Form_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Mag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_memo;
    }
}