namespace Win_Test
{
    partial class main
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
            this.btn_child = new System.Windows.Forms.Button();
            this.btn_own = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_child
            // 
            this.btn_child.Location = new System.Drawing.Point(105, 32);
            this.btn_child.Name = "btn_child";
            this.btn_child.Size = new System.Drawing.Size(581, 127);
            this.btn_child.TabIndex = 0;
            this.btn_child.Text = "자식폼";
            this.btn_child.UseVisualStyleBackColor = true;
            this.btn_child.Click += new System.EventHandler(this.btn_child_Click);
            // 
            // btn_own
            // 
            this.btn_own.Location = new System.Drawing.Point(105, 165);
            this.btn_own.Name = "btn_own";
            this.btn_own.Size = new System.Drawing.Size(583, 120);
            this.btn_own.TabIndex = 1;
            this.btn_own.Text = "소유폼";
            this.btn_own.UseVisualStyleBackColor = true;
            this.btn_own.Click += new System.EventHandler(this.btn_own_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(105, 291);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(583, 120);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "종료";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_own);
            this.Controls.Add(this.btn_child);
            this.IsMdiContainer = true;
            this.Name = "main";
            this.Text = "main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_child;
        private System.Windows.Forms.Button btn_own;
        private System.Windows.Forms.Button btn_exit;
    }
}