namespace QLCuaHangDT.GUI
{
    partial class FormDangNhap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Panel panel1;
            this.lbExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoggin = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbLoggin = new System.Windows.Forms.Label();
            this.lbWarning = new System.Windows.Forms.Label();
            this.pnBackgroundProcess = new System.Windows.Forms.Panel();
            this.pnProcess = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            this.pnBackgroundProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            panel1.Controls.Add(this.lbExit);
            panel1.Location = new System.Drawing.Point(-3, 1);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(611, 71);
            panel1.TabIndex = 0;
            // 
            // lbExit
            // 
            this.lbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbExit.AutoSize = true;
            this.lbExit.Font = new System.Drawing.Font(".VnAvantH", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.ForeColor = System.Drawing.Color.Red;
            this.lbExit.Location = new System.Drawing.Point(545, -4);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(66, 75);
            this.lbExit.TabIndex = 0;
            this.lbExit.Text = "X";
            this.lbExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbExit.Click += new System.EventHandler(this.lbExit_Clickr);
            this.lbExit.MouseLeave += new System.EventHandler(this.lbExit_MouseLeave);
            this.lbExit.MouseHover += new System.EventHandler(this.lbExit_MiuseHover);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.label1.Font = new System.Drawing.Font("UTM Alberta Heavy", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(197, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng Nhập";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Alexander", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(268, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "UserName";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Alexander", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(268, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLoggin
            // 
            this.txtLoggin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLoggin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoggin.Location = new System.Drawing.Point(189, 203);
            this.txtLoggin.Name = "txtLoggin";
            this.txtLoggin.Size = new System.Drawing.Size(256, 32);
            this.txtLoggin.TabIndex = 4;
            this.txtLoggin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPass.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(189, 281);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(256, 32);
            this.txtPass.TabIndex = 5;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbLoggin
            // 
            this.lbLoggin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbLoggin.AutoSize = true;
            this.lbLoggin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.lbLoggin.Font = new System.Drawing.Font("UTM Alberta Heavy", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoggin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbLoggin.Location = new System.Drawing.Point(244, 360);
            this.lbLoggin.Name = "lbLoggin";
            this.lbLoggin.Size = new System.Drawing.Size(145, 53);
            this.lbLoggin.TabIndex = 6;
            this.lbLoggin.Text = "LOGIN";
            this.lbLoggin.Click += new System.EventHandler(this.lbLogin_Click);
            this.lbLoggin.MouseLeave += new System.EventHandler(this.lbLogin_MouseLeave);
            this.lbLoggin.MouseHover += new System.EventHandler(this.lbLogin_MouseHover);
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Font = new System.Drawing.Font("UTM Nokia Standard", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarning.ForeColor = System.Drawing.Color.Red;
            this.lbWarning.Location = new System.Drawing.Point(184, 147);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(267, 22);
            this.lbWarning.TabIndex = 7;
            this.lbWarning.Text = "Tên đăng nhập hoặc mật khẩu sai";
            this.lbWarning.Visible = false;
            // 
            // pnBackgroundProcess
            // 
            this.pnBackgroundProcess.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnBackgroundProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.pnBackgroundProcess.Controls.Add(this.pnProcess);
            this.pnBackgroundProcess.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnBackgroundProcess.Location = new System.Drawing.Point(1, 445);
            this.pnBackgroundProcess.Name = "pnBackgroundProcess";
            this.pnBackgroundProcess.Size = new System.Drawing.Size(607, 15);
            this.pnBackgroundProcess.TabIndex = 8;
            this.pnBackgroundProcess.Visible = false;
            // 
            // pnProcess
            // 
            this.pnProcess.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnProcess.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnProcess.Location = new System.Drawing.Point(-150, 0);
            this.pnProcess.Name = "pnProcess";
            this.pnProcess.Size = new System.Drawing.Size(150, 15);
            this.pnProcess.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.LapThoiGian);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(607, 472);
            this.ControlBox = false;
            this.Controls.Add(this.pnBackgroundProcess);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.lbLoggin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLoggin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormDangNhap";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.pnBackgroundProcess.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoggin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lbLoggin;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Panel pnBackgroundProcess;
        private System.Windows.Forms.Panel pnProcess;
        private System.Windows.Forms.Timer timer1;
    }
}