namespace Lab01
{
    partial class Form1
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
            this.btnTruyen = new System.Windows.Forms.Button();
            this.txtDuLieu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTruyen
            // 
            this.btnTruyen.Location = new System.Drawing.Point(179, 166);
            this.btnTruyen.Name = "btnTruyen";
            this.btnTruyen.Size = new System.Drawing.Size(181, 50);
            this.btnTruyen.TabIndex = 0;
            this.btnTruyen.Text = "Gửi dữ liệu sang form 2";
            this.btnTruyen.UseVisualStyleBackColor = true;
            this.btnTruyen.Click += new System.EventHandler(this.btnTruyen_Click);
            // 
            // txtDuLieu
            // 
            this.txtDuLieu.CausesValidation = false;
            this.txtDuLieu.Location = new System.Drawing.Point(120, 62);
            this.txtDuLieu.Name = "txtDuLieu";
            this.txtDuLieu.Size = new System.Drawing.Size(221, 22);
            this.txtDuLieu.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 244);
            this.Controls.Add(this.txtDuLieu);
            this.Controls.Add(this.btnTruyen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTruyen;
        private System.Windows.Forms.TextBox txtDuLieu;
    }
}

