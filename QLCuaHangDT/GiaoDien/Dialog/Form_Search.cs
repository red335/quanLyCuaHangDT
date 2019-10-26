using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDT.GiaoDien.Dialog
{
    public delegate void getReusultSearching(string id);
    public partial class Form_Search : Form
    {
        private getReusultSearching getReusultSearching; 
        public Form_Search(getReusultSearching getReusultSearching)
        {
            InitializeComponent();
            this.getReusultSearching = getReusultSearching;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getReusultSearching(textBox1.Text);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
