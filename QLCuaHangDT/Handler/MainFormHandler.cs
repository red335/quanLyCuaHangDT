using System;
using System.Collections.Generic;
using QLCuaHangDT.GUI;
using QLCuaHangDT.DAO;
using QLCuaHangDT.Model;


namespace QLCuaHangDT.Handler
{
    
    class MainFormHandler
    {
        Form1 mainForm;
        NhanVienDAO nvDao = new NhanVienDAO();
        public MainFormHandler(Form1 form1)
        {
            mainForm = form1;
       
        }
        public void DocDS(int id) {
            List<NhanVien> ds = nvDao.layDanhSachNhanVien();
            mainForm.comboBox1.DataSource = ds;
            NhanVien nv = nvDao.layMotNhanVien(id);
            if (ds == null || nv == null) { System.Windows.Forms.MessageBox.Show("Test"); return; }
            mainForm.comboBox1.DisplayMember = "HoTen";
             mainForm.comboBox1.SelectedItem = nv;


        }

    }
}
