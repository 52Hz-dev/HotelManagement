namespace Hotel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lb_ListDVTour = new System.Windows.Forms.Label();
            this.DGV_DVTour = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_ListDVThuong = new System.Windows.Forms.Label();
            this.DGV_DVThuong = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lb_MiniBar = new System.Windows.Forms.Label();
            this.DGV_MiniBar = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DVTour)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DVThuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_MiniBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 766);
            this.panel1.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 719);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(805, 47);
            this.panel7.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_ThanhToan);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(716, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(89, 47);
            this.panel8.TabIndex = 1;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.Location = new System.Drawing.Point(5, 11);
            this.btn_ThanhToan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(76, 28);
            this.btn_ThanhToan.TabIndex = 0;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DGV_MiniBar);
            this.panel6.Controls.Add(this.lb_MiniBar);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 498);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(805, 122);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lb_ListDVTour);
            this.panel5.Controls.Add(this.DGV_DVTour);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 377);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(805, 121);
            this.panel5.TabIndex = 3;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // lb_ListDVTour
            // 
            this.lb_ListDVTour.AutoSize = true;
            this.lb_ListDVTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ListDVTour.Location = new System.Drawing.Point(0, 0);
            this.lb_ListDVTour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ListDVTour.Name = "lb_ListDVTour";
            this.lb_ListDVTour.Size = new System.Drawing.Size(93, 13);
            this.lb_ListDVTour.TabIndex = 2;
            this.lb_ListDVTour.Text = "Dich vu Tour:  ";
            // 
            // DGV_DVTour
            // 
            this.DGV_DVTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DVTour.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_DVTour.Location = new System.Drawing.Point(0, 21);
            this.DGV_DVTour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGV_DVTour.Name = "DGV_DVTour";
            this.DGV_DVTour.RowHeadersWidth = 62;
            this.DGV_DVTour.RowTemplate.Height = 28;
            this.DGV_DVTour.Size = new System.Drawing.Size(805, 100);
            this.DGV_DVTour.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lb_ListDVThuong);
            this.panel4.Controls.Add(this.DGV_DVThuong);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 254);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(805, 123);
            this.panel4.TabIndex = 2;
            // 
            // lb_ListDVThuong
            // 
            this.lb_ListDVThuong.AutoSize = true;
            this.lb_ListDVThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ListDVThuong.Location = new System.Drawing.Point(0, 2);
            this.lb_ListDVThuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ListDVThuong.Name = "lb_ListDVThuong";
            this.lb_ListDVThuong.Size = new System.Drawing.Size(102, 13);
            this.lb_ListDVThuong.TabIndex = 2;
            this.lb_ListDVThuong.Text = "Dịch vụ thuong: ";
            // 
            // DGV_DVThuong
            // 
            this.DGV_DVThuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DVThuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_DVThuong.Location = new System.Drawing.Point(0, 23);
            this.DGV_DVThuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGV_DVThuong.Name = "DGV_DVThuong";
            this.DGV_DVThuong.RowHeadersWidth = 62;
            this.DGV_DVThuong.RowTemplate.Height = 28;
            this.DGV_DVThuong.Size = new System.Drawing.Size(805, 100);
            this.DGV_DVThuong.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 128);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(805, 126);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 128);
            this.panel2.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 620);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(805, 99);
            this.panel9.TabIndex = 6;
            // 
            // lb_MiniBar
            // 
            this.lb_MiniBar.AutoSize = true;
            this.lb_MiniBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MiniBar.Location = new System.Drawing.Point(0, 2);
            this.lb_MiniBar.Name = "lb_MiniBar";
            this.lb_MiniBar.Size = new System.Drawing.Size(61, 13);
            this.lb_MiniBar.TabIndex = 0;
            this.lb_MiniBar.Text = "Mini Bar: ";
            // 
            // DGV_MiniBar
            // 
            this.DGV_MiniBar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_MiniBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_MiniBar.Location = new System.Drawing.Point(0, 22);
            this.DGV_MiniBar.Name = "DGV_MiniBar";
            this.DGV_MiniBar.Size = new System.Drawing.Size(805, 100);
            this.DGV_MiniBar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 766);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DVTour)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DVThuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_MiniBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGV_DVThuong;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.DataGridView DGV_DVTour;
        private System.Windows.Forms.Label lb_ListDVTour;
        private System.Windows.Forms.Label lb_ListDVThuong;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lb_MiniBar;
        private System.Windows.Forms.DataGridView DGV_MiniBar;
    }
}

