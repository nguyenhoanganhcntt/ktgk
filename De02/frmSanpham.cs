using De02.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace De02
{
    public partial class frmSanpham : Form
    {
        SanphamDBContext dbsanpham = new SanphamDBContext();
        public frmSanpham()
        {
            InitializeComponent();
        }

        private void frmSanpham_Load(object sender, EventArgs e)
        {
            List<LoaiSP> listloaisp = dbsanpham.LoaiSP.ToList();
            List<Sanpham> listsanpham = dbsanpham.Sanpham.ToList();
            FillDataCBB(listloaisp);
            FillDataDGV(listsanpham);

        }
        private void FillDataCBB(List<LoaiSP> listloaisp)
        {
            cboloaisp.DataSource = listloaisp;
            cboloaisp.DisplayMember = "TenLoai";
            cboloaisp.ValueMember = "MaLoai";
        }
        private void FillDataDGV(List<Sanpham> listsanpham)
        {
            dgvsv.Rows.Clear();
            foreach (var sanpham in listsanpham)
            {
                int rownew = dgvsv.Rows.Add();
                dgvsv.Rows[rownew].Cells[0].Value = sanpham.MaSP;
                dgvsv.Rows[rownew].Cells[1].Value = sanpham.TenSP;
                dgvsv.Rows[rownew].Cells[2].Value = sanpham.Ngaynhap;
                dgvsv.Rows[rownew].Cells[3].Value = sanpham.LoaiSP.TenLoai;
                
            }

        }
        private void loadForm()
        {
            txtmasp.Clear(); txttensp.Clear();
        }
        private void loadDGV()
        {
            List<Sanpham> newliststudent = dbsanpham.Sanpham.ToList();
            FillDataDGV(newliststudent);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvsv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvsv.Rows[e.RowIndex];
               
                txtmasp.Text = row.Cells[0].Value.ToString(); 
                txttensp.Text = row.Cells[1].Value.ToString(); 
                if (row.Cells[2].Value != null)
                {
                    dtNgayNhap.Value = Convert.ToDateTime(row.Cells[2].Value); 
                }
                cboloaisp.Text = row.Cells[3].Value.ToString(); 
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtmasp.Text) || string.IsNullOrEmpty(txttensp.Text) || cboloaisp.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            var existingProduct = dbsanpham.Sanpham.SingleOrDefault(sp => sp.MaSP == txtmasp.Text);
            if (existingProduct != null)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại! Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         
            Sanpham newSanpham = new Sanpham()
            {
                MaSP = txtmasp.Text,
                TenSP = txttensp.Text,
                Ngaynhap = dtNgayNhap.Value,
                MaLoai = cboloaisp.SelectedValue.ToString()
            };

            
            dbsanpham.Sanpham.Add(newSanpham);
            try
            {
                dbsanpham.SaveChanges();
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDGV();
                loadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi thêm sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmasp.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var existingSanpham = dbsanpham.Sanpham.SingleOrDefault(sp => sp.MaSP == txtmasp.Text);

            if (existingSanpham == null)
            {
                MessageBox.Show("Sản phẩm không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            existingSanpham.TenSP = txttensp.Text;
            existingSanpham.Ngaynhap = dtNgayNhap.Value;
            existingSanpham.MaLoai = cboloaisp.SelectedValue.ToString();

            try
            {
                dbsanpham.SaveChanges(); 
                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadDGV(); 
                loadForm(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi cập nhật sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmasp.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var sanpham = dbsanpham.Sanpham.SingleOrDefault(sp => sp.MaSP == txtmasp.Text);
                if (sanpham != null)
                {
                   
                    dbsanpham.Sanpham.Remove(sanpham);
                    try
                    {
                        dbsanpham.SaveChanges();
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDGV();
                        loadForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi khi xóa sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sản phẩm không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
            else
                return;
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            string keyword = txttimkiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var filteredProducts = dbsanpham.Sanpham
                .Where(sp => sp.TenSP.Contains(keyword))
                .ToList();

            if (filteredProducts.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FillDataDGV(filteredProducts); 
            }
        }
    }
}
