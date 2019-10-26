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
    public enum LOAI_LOC_DU_LIEU
    {  
        NONE,

        // LOC VOI KIEU DU LIEU INT, FLOAT, DATE
        LON_HON,
        NHO_HON,

        //LOC VOI KIEU DU LIEU STRING
        CHUA_DUNG,
        KHONG_CHUA,

        // LOC CHUNG
        BANG_NHAU,
        KHONG_BANG
    }

    
    public delegate void ResultFilter(int[] predicate, string[] values);

    public partial class Form_Fitler : Form
    {

        private ResultFilter resultFilter;    
        string data = "";
        List<string> values = new List<string>();
        List<string> title = new List<string>();
        List<ComboBox> comboBoxes = new List<ComboBox>();
        List<MaskedTextBox> textBoxes = new List<MaskedTextBox>();
        int[] kieuDLs = null;
        public Form_Fitler(string data, ResultFilter resultFilter)
        {
            this.data = data;
            this.resultFilter = resultFilter;
            tachDuLieu();
            kieuDLs = new int[values.Count];
            InitializeComponent();
            createUI();
        }
        private void tachDuLieu()
        {
            string[] tungPhan = data.Split(';');
            foreach (string str in tungPhan)
            {
                string[] s = str.Split(':');
                title.Add(s[0]);
                if (s[1] == "")
                    values.Add(" ");
                else
                    values.Add(s[1]);
            }
        }
        private void createUI()
        {
            for (int i = 0; i < values.Count; i++)
            {
                kieuDLs[i] = LoaiDuKieu(values[i]);

                Panel panel = createPanel();
                ComboBox comboBox = createComboBox(kieuDLs[i]);
                MaskedTextBox textBox = createTextBox(values[i], kieuDLs[i]);

                comboBoxes.Add(comboBox);
                textBoxes.Add(textBox);

                Label label = createLabel(title[i]);

                //   label.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(label);
                panel.Controls.Add(comboBox);
                panel.Controls.Add(textBox);

                FList.Controls.Add(panel);
            }

        }
        // 1.kieu bool, 2.kieu number, 3.kieu Date, 4.kieu string
        private int LoaiDuKieu(string dat)
        {

            int kieuDuLieu = 4;
            bool xacDinhRoi = false;
            int so1 = 0;
            DateTime dateTime = new DateTime();
            bool test = false;

            if ((xacDinhRoi = bool.TryParse(dat, out test)))
                kieuDuLieu = 1;

            else if (!xacDinhRoi && (xacDinhRoi = Int32.TryParse(dat, out so1)))
                kieuDuLieu = 2;
            else if (!xacDinhRoi && (xacDinhRoi = DateTime.TryParse(dat, out dateTime)))
                kieuDuLieu = 3;


            return kieuDuLieu;
        }

        private Panel createPanel()
        {
            Panel panel = new Panel();

            panel.Location = new System.Drawing.Point(3, 3);
            panel.Size = new System.Drawing.Size(272, 36);
            return panel;
        }

        private ComboBox createComboBox(int kieuDL)
        {
            ComboBox comboBox = new ComboBox();
           comboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboBox.FormattingEnabled = true;
            comboBox.Location = new System.Drawing.Point(88, 8);
            comboBox.Size = new System.Drawing.Size(106, 23);



            comboBox.Items.Add(LOAI_LOC_DU_LIEU.NONE.ToString());

            // kieu number, float , date
            if (kieuDL == 2 || kieuDL == 3)
            {
                comboBox.Items.Add(LOAI_LOC_DU_LIEU.LON_HON.ToString());
                comboBox.Items.Add(LOAI_LOC_DU_LIEU.NHO_HON.ToString());
            }
            // kieu string
            else if (kieuDL == 4)
            {
                comboBox.Items.Add(LOAI_LOC_DU_LIEU.CHUA_DUNG.ToString());
                comboBox.Items.Add(LOAI_LOC_DU_LIEU.KHONG_CHUA.ToString());

            }
            comboBox.Items.Add(LOAI_LOC_DU_LIEU.BANG_NHAU.ToString());
            comboBox.Items.Add(LOAI_LOC_DU_LIEU.KHONG_BANG.ToString());

            comboBox.SelectedIndex = 0;
            return comboBox;
        }
        private MaskedTextBox createTextBox(string da, int kDL)
        {
            MaskedTextBox textBox = new MaskedTextBox();

            // Chon Kieu Date
            if (kDL == 3)
            {
                textBox.Mask = "00/00/0000";
            }

            textBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox.Location = new System.Drawing.Point(200, 8);
            textBox.Size = new System.Drawing.Size(68, 23);

            return textBox;
        }

        private Label createLabel(string name)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(4, 9);

            label.Size = new System.Drawing.Size(41, 15);

            label.Text = name;
            return label;
        }

        private string getResult(ref int[] predicate, ref string[] values)
        {
            string result = "";
            for (int i = 0; i < textBoxes.Count; i++)
            {
                predicate[i] = comboBoxes[i].SelectedIndex;
                if (textBoxes[i].Text == "")
                {
                    values[i] = " ";
                    predicate[i] = 0;
                }
                else
                    values[i] = textBoxes[i].Text;
                result += predicate[i].ToString() + " - " + values[i] + " ; ";
            }
            return result;
        }
        private bool ketQua()
        {
            bool hopLe = true;
            for (int i = 0; i < textBoxes.Count && hopLe; i++)
            {
                if (comboBoxes[i].SelectedIndex == 0 || textBoxes[i].Text == "" || kieuDLs[i] == 4) continue;
                if (kieuDLs[i] != LoaiDuKieu(textBoxes[i].Text))
                    hopLe = false;
            }
            return hopLe;
        }
        private void OK_Click(object sender, EventArgs e)
        {
            if (ketQua())
            {
                int[] predicate = new int[textBoxes.Count];
                string[] values = new string[textBoxes.Count];
                string result = getResult(ref predicate, ref values);
                MessageBox.Show(result);
                resultFilter(predicate,values);
                this.Close();
            }
            else
            {
                MessageBox.Show("Loi Ve Kieu Du Lieu");
            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
