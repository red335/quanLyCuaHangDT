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
    public delegate void Sorting(string str);
    public partial class Form_Sorting : Form
    {
        private Sorting sorting;
        private Size panel_size;
        Panel[] panels;
        string[] list_thuocTinh;
        ComboBox[] comboBoxes;
      
        public Form_Sorting(string str, Sorting sorting)
        {
            InitializeComponent();
            this.sorting = sorting;
            panel_size = new Size(FlList.Width - 10, 30);
            XuLyChuoi(str);
            comboBoxes = new ComboBox[list_thuocTinh.Length];
            panels = new Panel[list_thuocTinh.Length];
            UI();
        }
        
        private void XuLyChuoi(string str)
        {
            string[] str_1 = str.Split(',');
            list_thuocTinh = new string[str_1.Length];

            for (int i = 0; i < str_1.Length; i++)
                list_thuocTinh[i] = str_1[i].Split(':')[0];


        }
        private void UI()
        {
            for (int i = 0; i < list_thuocTinh.Length; i++)
            {
                panels[i] = new Panel();
                panels[i] = createPanel(i);
                FlList.Controls.Add(panels[i]);
            }
        }

        private Panel createPanel(int i)
        {

            Panel panel = new Panel();
            panel.SuspendLayout();
            panel.Margin = new Padding(0, 0, 0, 0);
            panel.Location = new Point(0, 0);
            panel.Size = panel_size;

            panel.Controls.Add(createLabel(list_thuocTinh[i]));

            ComboBox comboBox = createCombobox();
            panel.Controls.Add(comboBox);
            panel.ResumeLayout(false);
            panel.PerformLayout();
            panel.Name = "pn" + list_thuocTinh[i];
            panel.BorderStyle = BorderStyle.None;
            comboBoxes[i] = comboBox;

            return panel;
        }

        private Label createLabel(string tit)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(5, 9);
            label.Name = tit;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Size = new System.Drawing.Size(43, 13);
            label.TabIndex = 0;
            label.Text = tit;

            return label;
        }
        private ComboBox createCombobox()
        {
            ComboBox comboBox = new ComboBox();
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "none", "Tăng", "Giảm" });
            comboBox.Location = new System.Drawing.Point(97, 6);
            comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            comboBox.Name = "comboBox1";
            comboBox.Size = new System.Drawing.Size(82, 21);
            comboBox.TabIndex = 1;
            comboBox.SelectedIndex = 0;
            return comboBox;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            string kq = "";
            for (int i = 0; i < comboBoxes.Length; i++)
            {
                int a = comboBoxes[i].SelectedIndex;
                if (a == 2)
                    kq += "-1";
                else
                    kq += a.ToString();

                if (i < comboBoxes.Length - 1)
                    kq += ",";
            }
            sorting(kq);

            this.Close();
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
