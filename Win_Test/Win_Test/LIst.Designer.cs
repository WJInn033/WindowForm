namespace Win_Test
{
    partial class LIst
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
            this.List_Source = new System.Windows.Forms.ListBox();
            this.List_Dest = new System.Windows.Forms.ListBox();
            this.Btn_Move = new System.Windows.Forms.Button();
            this.Btn_Remove = new System.Windows.Forms.Button();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // List_Source
            // 
            this.List_Source.FormattingEnabled = true;
            this.List_Source.ItemHeight = 18;
            this.List_Source.Location = new System.Drawing.Point(12, 12);
            this.List_Source.Name = "List_Source";
            this.List_Source.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.List_Source.Size = new System.Drawing.Size(221, 490);
            this.List_Source.TabIndex = 0;
            // 
            // List_Dest
            // 
            this.List_Dest.FormattingEnabled = true;
            this.List_Dest.ItemHeight = 18;
            this.List_Dest.Location = new System.Drawing.Point(390, 12);
            this.List_Dest.Name = "List_Dest";
            this.List_Dest.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.List_Dest.Size = new System.Drawing.Size(221, 490);
            this.List_Dest.TabIndex = 1;
            // 
            // Btn_Move
            // 
            this.Btn_Move.Location = new System.Drawing.Point(255, 58);
            this.Btn_Move.Name = "Btn_Move";
            this.Btn_Move.Size = new System.Drawing.Size(115, 80);
            this.Btn_Move.TabIndex = 2;
            this.Btn_Move.Text = "▶▶▶▶";
            this.Btn_Move.UseVisualStyleBackColor = true;
            this.Btn_Move.Click += new System.EventHandler(this.Btn_Move_Click);
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.Location = new System.Drawing.Point(255, 201);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(115, 80);
            this.Btn_Remove.TabIndex = 3;
            this.Btn_Remove.Text = "◀◀◀◀";
            this.Btn_Remove.UseVisualStyleBackColor = true;
            this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // Btn_Search
            // 
            this.Btn_Search.Location = new System.Drawing.Point(255, 348);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(115, 80);
            this.Btn_Search.TabIndex = 4;
            this.Btn_Search.Text = "검색";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(55, 588);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(150, 86);
            this.Btn_Ok.TabIndex = 5;
            this.Btn_Ok.Text = "확인";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(431, 588);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(150, 86);
            this.Btn_Exit.TabIndex = 6;
            this.Btn_Exit.Text = "종료";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // LIst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 742);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Btn_Remove);
            this.Controls.Add(this.Btn_Move);
            this.Controls.Add(this.List_Dest);
            this.Controls.Add(this.List_Source);
            this.Name = "LIst";
            this.Text = "LIst";
            this.Load += new System.EventHandler(this.LIst_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox List_Source;
        private System.Windows.Forms.ListBox List_Dest;
        private System.Windows.Forms.Button Btn_Move;
        private System.Windows.Forms.Button Btn_Remove;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Button Btn_Exit;
    }
}