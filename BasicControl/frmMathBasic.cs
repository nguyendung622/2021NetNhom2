using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicControl
{
    public partial class frmMathBasic : Form
    {
        public frmMathBasic()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txtSoThuNhat.Text;
                Double nSoThuNhat = Convert.ToDouble(soThuNhat);

                var soThuHai = txtSoThuHai.Text;
                Double nSoThuHai = Double.Parse(soThuHai);
                var ketQua = nSoThuNhat + nSoThuHai;

                lblKetQua.Text = ketQua.ToString("N10");
            }
            catch(FormatException ex)
            {
                MessageBox.Show($"Lỗi định dạng. Vui lòng nhập số không nhập ký tự. Chi tiết lỗi: {ex.Message}");
            }
            catch(OverflowException ex)
            {
                MessageBox.Show($"Lỗi số quá lớn. Vui lòng nhập số nhỏ thôi nhé. Chi tiết lỗi: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi rồi bạn nhé. Chi tiết lỗi: {ex.Message}");
            }
        }
    }
}
