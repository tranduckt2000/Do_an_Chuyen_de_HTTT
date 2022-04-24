using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChungKhoan
{
    public partial class FormGiaoDich : DevExpress.XtraEditors.XtraForm
    {
        public FormGiaoDich()
        {
            InitializeComponent();
        }
        private void reset()
        {
            txtMaCoPhieu.Text = "";
            txtSoLuong.Value = 0;
            txtGiaDat.Value = 0;
            this.lenhDatTableAdapter.Fill(this.chungKhoanDataSet.LenhDat);
        }
        private bool kiemTraDuLieuDauVao()
        {
            if (txtMaCoPhieu.Text == "")
            {

                MessageBox.Show("Hãy nhập mã cổ phiểu", "Thông báo", MessageBoxButtons.OK);
                txtMaCoPhieu.Focus();
                return false;
            }

            if (txtSoLuong.Value < 0)
            {
                MessageBox.Show("Số lượng tối thiểu là 1 ", "Thông báo", MessageBoxButtons.OK);
                txtSoLuong.Focus();
                return false;
            }

            if (txtGiaDat.Value < 0)
            {
                MessageBox.Show("Giá đặt tối thiểu là 1", "Thông báo", MessageBoxButtons.OK);
                txtGiaDat.Focus();
                return false;
            }

            return true;
        }

        private void lenhDatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lenhDatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chungKhoanDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chungKhoanDataSet.LenhDat' table. You can move, or remove it, as needed.
            this.lenhDatTableAdapter.Fill(this.chungKhoanDataSet.LenhDat);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
            {
                return;
            }

            string maCoPhieu = txtMaCoPhieu.Text.Trim();
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string loaiGiaoDich = (string)cbLoaiGiaoDich.Text;
            Console.WriteLine("loai GD"+ loaiGiaoDich);

            int soLuong = (int)txtSoLuong.Value;
            float giaDat = (float)txtGiaDat.Value;

            try
            {
                Program.KetNoi();
                string query = "EXEC sp_KhopLenhLienTuc '" + maCoPhieu + "', '" + today + "', '" + loaiGiaoDich + "', " + soLuong + ", " + giaDat;
                Program.myReader = Program.ExecSqlDataReader(query);
                if (Program.myReader == null)
                {
                    return;
                }
                Program.myReader.Read();
                Program.myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            reset();
        }

        private void cbLoaiGiaoDich_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
