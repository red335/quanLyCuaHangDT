using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDT.GiaoDien.SanPham
{
    public delegate void getResultCauHinh(string cauhinh);
    public partial class CauHinh : Form
    {
        private DataTable tbThongTin = new DataTable();
        private getResultCauHinh getResultCauHinh;
        string result = "";
        public CauHinh(getResultCauHinh getResultCauHinh,string result )
        {
            InitializeComponent();
            this.result = result;
            this.getResultCauHinh = getResultCauHinh;
            tbThongTin.Columns.Add("Ten Thong Tin", Type.GetType("System.String"));
            tbThongTin.Columns.Add("Gia tri", Type.GetType("System.String"));


            duLieuCoSan();
            dataGridView1.DataSource = tbThongTin;

            dataGridView1.Font = new Font("Tahoma", 9F);
        }
        private void duLieuCoSan() {
            string[] listString = result.Split(';');
            foreach (string str in listString) {
                string[] dat = str.Split(':');
                tbThongTin.Rows.Add(dat);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbThongTin.Rows.Add(new string[] { "", "" });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                tbThongTin.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else {
                MessageBox.Show("Ban phai chon mot dong truoc khi xoa");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            result = "";
            for (int i = 0; i < tbThongTin.Rows.Count; i++)
            {
                DataRow dataRow = tbThongTin.Rows[i];
                if (new ThongTin(dataRow[0].ToString(), dataRow[1].ToString()).thongTinHopLe())
                {   
                    result += dataRow[0] + ":" + dataRow[1];
                    if (i != tbThongTin.Rows.Count - 1)
                        result += ";";
                }
            }
            getResultCauHinh(result);
            this.Close();
        }
    }
    
}
public class ThongTin {
    private string tenThongTin;
    private string soLieu;

    public ThongTin(string tenThongTin, string soLieu)
    {
        this.tenThongTin = tenThongTin;
        this.soLieu = soLieu;
    }

    public string TenThongTin { get => tenThongTin; set => tenThongTin = value; }
    public string SoLieu { get => soLieu; set => soLieu = value; }
    public bool thongTinHopLe() {
        tenThongTin = tenThongTin.Trim();
        soLieu = soLieu.Trim();
        return tenThongTin != "" && soLieu != "";
    }
}