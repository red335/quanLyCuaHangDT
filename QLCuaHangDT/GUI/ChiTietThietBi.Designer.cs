namespace QLCuaHangDT.GUI
{
    partial class ChiTietThietBi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myLabel1 = new QLCuaHangDT.GUI.MyLabel();
            this.SuspendLayout();
            // 
            // myLabel1
            // 
            this.myLabel1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.myLabel1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.myLabel1.Location = new System.Drawing.Point(0, 0);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(53, 56);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "myLabel1";
            this.myLabel1.UseVisualStyleBackColor = true;
            // 
            // ChiTietThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.myLabel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ChiTietThietBi";
            this.Size = new System.Drawing.Size(481, 56);
            this.ResumeLayout(false);

        }

        #endregion

        private MyLabel myLabel1;
    }
}
