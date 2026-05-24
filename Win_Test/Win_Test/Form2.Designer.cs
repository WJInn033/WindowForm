namespace Win_Test
{
    partial class Form2
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
            this.Btn_modal = new System.Windows.Forms.Button();
            this.btn_modeless = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_modal
            // 
            this.Btn_modal.Location = new System.Drawing.Point(194, 44);
            this.Btn_modal.Name = "Btn_modal";
            this.Btn_modal.Size = new System.Drawing.Size(382, 135);
            this.Btn_modal.TabIndex = 0;
            this.Btn_modal.Text = "모달";
            this.Btn_modal.UseVisualStyleBackColor = true;
            this.Btn_modal.Click += new System.EventHandler(this.Btn_modal_Click);
            // 
            // btn_modeless
            // 
            this.btn_modeless.Location = new System.Drawing.Point(194, 201);
            this.btn_modeless.Name = "btn_modeless";
            this.btn_modeless.Size = new System.Drawing.Size(382, 155);
            this.btn_modeless.TabIndex = 1;
            this.btn_modeless.Text = "모드리스";
            this.btn_modeless.UseVisualStyleBackColor = true;
            this.btn_modeless.Click += new System.EventHandler(this.btn_modeless_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_modeless);
            this.Controls.Add(this.Btn_modal);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_modal;
        private System.Windows.Forms.Button btn_modeless;
    }
}