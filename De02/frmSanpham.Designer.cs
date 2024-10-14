namespace De02
{
    partial class frmSanpham
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
            this.dgvsv = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboloaisp = new System.Windows.Forms.ComboBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.lbloaisp = new System.Windows.Forms.Label();
            this.lbltensp = new System.Windows.Forms.Label();
            this.lblmsp = new System.Windows.Forms.Label();
            this.lblmasp = new System.Windows.Forms.Label();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.lblngaynhap = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.lbldmsp = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntk = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnkoluu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsv
            // 
            this.dgvsv.AllowUserToAddRows = false;
            this.dgvsv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.ngaynhap,
            this.loaisp});
            this.dgvsv.Location = new System.Drawing.Point(12, 136);
            this.dgvsv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvsv.Name = "dgvsv";
            this.dgvsv.RowHeadersWidth = 51;
            this.dgvsv.RowTemplate.Height = 24;
            this.dgvsv.Size = new System.Drawing.Size(696, 361);
            this.dgvsv.TabIndex = 17;
            this.dgvsv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsv_CellClick);
            // 
            // masp
            // 
            this.masp.HeaderText = "Mã Sp";
            this.masp.MinimumWidth = 6;
            this.masp.Name = "masp";
            // 
            // tensp
            // 
            this.tensp.HeaderText = "tên sản phẩm";
            this.tensp.MinimumWidth = 6;
            this.tensp.Name = "tensp";
            // 
            // ngaynhap
            // 
            this.ngaynhap.HeaderText = "ngày nhập";
            this.ngaynhap.MinimumWidth = 6;
            this.ngaynhap.Name = "ngaynhap";
            // 
            // loaisp
            // 
            this.loaisp.HeaderText = "loại sp";
            this.loaisp.MinimumWidth = 6;
            this.loaisp.Name = "loaisp";
            // 
            // cboloaisp
            // 
            this.cboloaisp.FormattingEnabled = true;
            this.cboloaisp.Location = new System.Drawing.Point(824, 339);
            this.cboloaisp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboloaisp.Name = "cboloaisp";
            this.cboloaisp.Size = new System.Drawing.Size(200, 24);
            this.cboloaisp.TabIndex = 23;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(824, 226);
            this.txttensp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(200, 22);
            this.txttensp.TabIndex = 22;
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(824, 166);
            this.txtmasp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(200, 22);
            this.txtmasp.TabIndex = 21;
            // 
            // lbloaisp
            // 
            this.lbloaisp.AutoSize = true;
            this.lbloaisp.Location = new System.Drawing.Point(768, 342);
            this.lbloaisp.Name = "lbloaisp";
            this.lbloaisp.Size = new System.Drawing.Size(51, 16);
            this.lbloaisp.TabIndex = 20;
            this.lbloaisp.Text = "Loại sp";
            // 
            // lbltensp
            // 
            this.lbltensp.AutoSize = true;
            this.lbltensp.Location = new System.Drawing.Point(775, 232);
            this.lbltensp.Name = "lbltensp";
            this.lbltensp.Size = new System.Drawing.Size(51, 16);
            this.lbltensp.TabIndex = 19;
            this.lbltensp.Text = "Tên Sp";
            // 
            // lblmsp
            // 
            this.lblmsp.AutoSize = true;
            this.lblmsp.Location = new System.Drawing.Point(775, 170);
            this.lblmsp.Name = "lblmsp";
            this.lblmsp.Size = new System.Drawing.Size(0, 16);
            this.lblmsp.TabIndex = 18;
            // 
            // lblmasp
            // 
            this.lblmasp.AutoSize = true;
            this.lblmasp.Location = new System.Drawing.Point(775, 172);
            this.lblmasp.Name = "lblmasp";
            this.lblmasp.Size = new System.Drawing.Size(44, 16);
            this.lblmasp.TabIndex = 24;
            this.lblmasp.Text = "Mã sp";
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Location = new System.Drawing.Point(824, 278);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(200, 22);
            this.dtNgayNhap.TabIndex = 26;
            // 
            // lblngaynhap
            // 
            this.lblngaynhap.AutoSize = true;
            this.lblngaynhap.Location = new System.Drawing.Point(746, 278);
            this.lblngaynhap.Name = "lblngaynhap";
            this.lblngaynhap.Size = new System.Drawing.Size(73, 16);
            this.lblngaynhap.TabIndex = 27;
            this.lblngaynhap.Text = "Ngày nhập";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(291, 523);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 28;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(404, 523);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 29;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(513, 523);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 30;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // lbldmsp
            // 
            this.lbldmsp.AutoSize = true;
            this.lbldmsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbldmsp.Location = new System.Drawing.Point(520, 36);
            this.lbldmsp.Name = "lbldmsp";
            this.lbldmsp.Size = new System.Drawing.Size(341, 32);
            this.lbldmsp.TabIndex = 31;
            this.lbldmsp.Text = "DANH MỤC SẢN PHẨM ";
            this.lbldmsp.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(893, 523);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 32;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(72, 96);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(200, 22);
            this.txttimkiem.TabIndex = 33;
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(279, 96);
            this.btntk.Margin = new System.Windows.Forms.Padding(4);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(100, 22);
            this.btntk.TabIndex = 34;
            this.btntk.Text = "Tìm ";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(633, 523);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 35;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // btnkoluu
            // 
            this.btnkoluu.Location = new System.Drawing.Point(746, 523);
            this.btnkoluu.Name = "btnkoluu";
            this.btnkoluu.Size = new System.Drawing.Size(115, 23);
            this.btnkoluu.TabIndex = 36;
            this.btnkoluu.Text = "không lưu";
            this.btnkoluu.UseVisualStyleBackColor = true;
            // 
            // frmSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 568);
            this.Controls.Add(this.btnkoluu);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.lbldmsp);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.lblngaynhap);
            this.Controls.Add(this.dtNgayNhap);
            this.Controls.Add(this.lblmasp);
            this.Controls.Add(this.cboloaisp);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.lbloaisp);
            this.Controls.Add(this.lbltensp);
            this.Controls.Add(this.lblmsp);
            this.Controls.Add(this.dgvsv);
            this.Name = "frmSanpham";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsv;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaisp;
        private System.Windows.Forms.ComboBox cboloaisp;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.Label lbloaisp;
        private System.Windows.Forms.Label lbltensp;
        private System.Windows.Forms.Label lblmsp;
        private System.Windows.Forms.Label lblmasp;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.Label lblngaynhap;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label lbldmsp;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnkoluu;
    }
}

