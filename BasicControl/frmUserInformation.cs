using BasicControl.Entities;
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
    public partial class frmUserInformation : Form
    {
        Student student;
        public frmUserInformation(string idStudent = "3")
        {
            InitializeComponent();
            student = Student.Get(idStudent);
            if (student == null)
            {
                MessageBox.Show($"Không tìm thấy student có mã là {idStudent}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //Cách 1
                txtHoTen.Text = $"{student.LastName} {student.FirstName}";
                //Cách 2
                txtHoTen.Text = student.FullName;
                txtNoiSinh.Text = student.POB;
                txtQueQuan.Text = student.HomeTown;
                dtpNgaySinh.Value = student.DOB;

                if (student.Gender == EGender.Nam)
                    rdbNam.Checked = true;
                else if (student.Gender == EGender.Nu) 
                    rdbNu.Checked = true;
                else 
                    rdbKhac.Checked = true;
            }
        }
    }
}
