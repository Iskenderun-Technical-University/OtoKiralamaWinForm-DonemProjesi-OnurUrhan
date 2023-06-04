namespace OtelForm
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            txtUserName = new DevExpress.XtraEditors.TextEdit();
            txtPassword = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)txtUserName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(254, 188);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(213, 20);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(254, 235);
            txtPassword.Name = "txtPassword";
            txtPassword.Properties.UseSystemPasswordChar = true;
            txtPassword.Size = new Size(213, 20);
            txtPassword.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(173, 191);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(56, 13);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "User Name:";
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(176, 238);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(53, 13);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "Password :";
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new Point(254, 292);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(83, 25);
            simpleButton1.TabIndex = 4;
            simpleButton1.Text = "Login";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // simpleButton2
            // 
            simpleButton2.Location = new Point(384, 292);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(83, 25);
            simpleButton2.TabIndex = 5;
            simpleButton2.Text = "Cancel";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // checkEdit1
            // 
            checkEdit1.Location = new Point(254, 265);
            checkEdit1.Name = "checkEdit1";
            checkEdit1.Properties.Caption = "Remember me";
            checkEdit1.Size = new Size(93, 20);
            checkEdit1.TabIndex = 6;
            // 
            // formLogin
            // 
            ActiveGlowColor = Color.White;
            Appearance.BackColor = Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayoutStore = ImageLayout.Tile;
            BackgroundImageStore = (Image)resources.GetObject("$this.BackgroundImageStore");
            ClientSize = new Size(1101, 605);
            ControlBox = false;
            Controls.Add(checkEdit1);
            Controls.Add(simpleButton2);
            Controls.Add(simpleButton1);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            FormBorderStyle = FormBorderStyle.None;
            IconOptions.Image = (Image)resources.GetObject("formLogin.IconOptions.Image");
            ImeMode = ImeMode.On;
            InactiveGlowColor = Color.White;
            Name = "formLogin";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            MouseDown += formLogin_MouseDown;
            ((System.ComponentModel.ISupportInitialize)txtUserName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkEdit1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}