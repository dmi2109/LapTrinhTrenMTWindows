namespace BaiTap03
{
    partial class frmBaiTapHoTen
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
            this.btnHo = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoTen = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.lblHoLot = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHo
            // 
            this.btnHo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHo.Location = new System.Drawing.Point(55, 151);
            this.btnHo.Name = "btnHo";
            this.btnHo.Size = new System.Drawing.Size(85, 39);
            this.btnHo.TabIndex = 0;
            this.btnHo.Text = "Họ Lót";
            this.btnHo.UseVisualStyleBackColor = false;
            this.btnHo.Click += new System.EventHandler(this.btnHo_Click);
            // 
            // btnTen
            // 
            this.btnTen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTen.Location = new System.Drawing.Point(206, 151);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(82, 39);
            this.btnTen.TabIndex = 1;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = false;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoTen
            // 
            this.btnHoTen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHoTen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHoTen.Location = new System.Drawing.Point(355, 151);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(90, 39);
            this.btnHoTen.TabIndex = 2;
            this.btnHoTen.Text = "Họ và Tên";
            this.btnHoTen.UseVisualStyleBackColor = false;
            this.btnHoTen.Click += new System.EventHandler(this.btnHoTen_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKetThuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKetThuc.Location = new System.Drawing.Point(170, 213);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(151, 39);
            this.btnKetThuc.TabIndex = 3;
            this.btnKetThuc.Text = "Thoát Chương Trình";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // lblHoLot
            // 
            this.lblHoLot.AutoSize = true;
            this.lblHoLot.Location = new System.Drawing.Point(52, 78);
            this.lblHoLot.Name = "lblHoLot";
            this.lblHoLot.Size = new System.Drawing.Size(42, 16);
            this.lblHoLot.TabIndex = 4;
            this.lblHoLot.Text = "Họ lót";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(52, 111);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(31, 16);
            this.lblTen.TabIndex = 5;
            this.lblTen.Text = "Tên";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(122, 72);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(314, 22);
            this.txtHo.TabIndex = 6;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(122, 105);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(314, 22);
            this.txtTen.TabIndex = 7;
            // 
            // lblHoTen
            // 
            this.lblHoTen.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblHoTen.Location = new System.Drawing.Point(0, 1);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(488, 54);
            this.lblHoTen.TabIndex = 8;
            // 
            // frmBaiTapHoTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(490, 270);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblHoLot);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnHoTen);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHo);
            this.Name = "frmBaiTapHoTen";
            this.Text = "Bài Tập Họ Tên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHo;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoTen;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Label lblHoLot;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblHoTen;
    }
}

