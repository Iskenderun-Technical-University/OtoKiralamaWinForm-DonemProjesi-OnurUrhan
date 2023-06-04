namespace OtoKiralama
{
    partial class frmArabaEkle
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArabaEkle));
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar1 = new DevExpress.XtraBars.Bar();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            textBox1 = new TextBox();
            btnAracListele = new DevExpress.XtraEditors.SimpleButton();
            layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            pictureBox1 = new PictureBox();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            popupMenu1 = new DevExpress.XtraBars.PopupMenu(components);
            layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl4).BeginInit();
            layoutControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl2).BeginInit();
            layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
            SuspendLayout();
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItem1, barButtonItem3 });
            barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            bar1.BarName = "Tools";
            bar1.DockCol = 0;
            bar1.DockRow = 0;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItem1), new DevExpress.XtraBars.LinkPersistInfo(barButtonItem3) });
            bar1.Text = "Tools";
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "Yenile";
            barButtonItem1.Id = 0;
            barButtonItem1.ImageOptions.Image = (Image)resources.GetObject("barButtonItem1.ImageOptions.Image");
            barButtonItem1.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem1.ImageOptions.LargeImage");
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            barButtonItem1.ItemClick += barButtonItem1_ItemClick;
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "Kapat";
            barButtonItem3.Id = 4;
            barButtonItem3.ImageOptions.Image = (Image)resources.GetObject("barButtonItem3.ImageOptions.Image");
            barButtonItem3.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem3.ImageOptions.LargeImage");
            barButtonItem3.Name = "barButtonItem3";
            barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            barButtonItem3.ItemClick += barButtonItem3_ItemClick;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Margin = new Padding(3, 2, 3, 2);
            barDockControlTop.Size = new Size(1120, 24);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 495);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Margin = new Padding(3, 2, 3, 2);
            barDockControlBottom.Size = new Size(1120, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 24);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Margin = new Padding(3, 2, 3, 2);
            barDockControlLeft.Size = new Size(0, 471);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(1120, 24);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Margin = new Padding(3, 2, 3, 2);
            barDockControlRight.Size = new Size(0, 471);
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(textBox1);
            layoutControl1.Controls.Add(btnAracListele);
            layoutControl1.Controls.Add(layoutControl4);
            layoutControl1.Controls.Add(layoutControl2);
            layoutControl1.Dock = DockStyle.Top;
            layoutControl1.Location = new Point(0, 24);
            layoutControl1.Margin = new Padding(3, 2, 3, 2);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(1120, 168);
            layoutControl1.TabIndex = 4;
            layoutControl1.Text = "layoutControl1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 20);
            textBox1.TabIndex = 3;
            // 
            // btnAracListele
            // 
            btnAracListele.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAracListele.Appearance.Options.UseFont = true;
            btnAracListele.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnAracListele.ImageOptions.SvgImage");
            btnAracListele.Location = new Point(12, 120);
            btnAracListele.Margin = new Padding(3, 2, 3, 2);
            btnAracListele.Name = "btnAracListele";
            btnAracListele.Size = new Size(473, 36);
            btnAracListele.StyleController = layoutControl1;
            btnAracListele.TabIndex = 4;
            btnAracListele.Text = "Aracı Kaydet";
            btnAracListele.Click += btnAracListele_Click_1;
            // 
            // layoutControl4
            // 
            layoutControl4.Controls.Add(comboBox2);
            layoutControl4.Controls.Add(comboBox1);
            layoutControl4.Controls.Add(textBox3);
            layoutControl4.Controls.Add(textBox2);
            layoutControl4.Location = new Point(12, 12);
            layoutControl4.Margin = new Padding(3, 2, 3, 2);
            layoutControl4.Name = "layoutControl4";
            layoutControl4.Root = layoutControlGroup3;
            layoutControl4.Size = new Size(473, 80);
            layoutControl4.TabIndex = 0;
            layoutControl4.Text = "layoutControl4";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(335, 37);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(126, 21);
            comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(335, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(126, 21);
            comboBox1.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(123, 20);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(123, 20);
            textBox2.TabIndex = 4;
            // 
            // layoutControlGroup3
            // 
            layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup3.GroupBordersVisible = false;
            layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem5, layoutControlItem7, layoutControlItem9 });
            layoutControlGroup3.Name = "layoutControlGroup3";
            layoutControlGroup3.Size = new Size(473, 80);
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = textBox2;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(225, 24);
            layoutControlItem1.Text = "Modelini Giriniz";
            layoutControlItem1.TextSize = new Size(86, 13);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = textBox3;
            layoutControlItem5.Location = new Point(0, 24);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(225, 36);
            layoutControlItem5.Text = "Plakayı Giriniz";
            layoutControlItem5.TextSize = new Size(86, 13);
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = comboBox1;
            layoutControlItem7.Location = new Point(225, 0);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new Size(228, 25);
            layoutControlItem7.Text = "Model Yılını Seçiniz";
            layoutControlItem7.TextSize = new Size(86, 13);
            // 
            // layoutControlItem9
            // 
            layoutControlItem9.Control = comboBox2;
            layoutControlItem9.Location = new Point(225, 25);
            layoutControlItem9.Name = "layoutControlItem9";
            layoutControlItem9.Size = new Size(228, 35);
            layoutControlItem9.Text = "Markayı Seçiniz";
            layoutControlItem9.TextSize = new Size(86, 13);
            // 
            // layoutControl2
            // 
            layoutControl2.Controls.Add(pictureBox1);
            layoutControl2.Controls.Add(simpleButton1);
            layoutControl2.Location = new Point(489, 12);
            layoutControl2.Margin = new Padding(3, 2, 3, 2);
            layoutControl2.Name = "layoutControl2";
            layoutControl2.Root = layoutControlGroup1;
            layoutControl2.Size = new Size(375, 144);
            layoutControl2.TabIndex = 2;
            layoutControl2.Text = "layoutControl2";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(113, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new Point(12, 110);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(351, 22);
            simpleButton1.StyleController = layoutControl2;
            simpleButton1.TabIndex = 5;
            simpleButton1.Text = "Araç Resmi Seçin";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem6, layoutControlItem8 });
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new Size(375, 144);
            layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = pictureBox1;
            layoutControlItem6.Location = new Point(0, 0);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(355, 98);
            layoutControlItem6.Text = "Araç Resmi Ekleyin";
            layoutControlItem6.TextSize = new Size(89, 13);
            // 
            // layoutControlItem8
            // 
            layoutControlItem8.Control = simpleButton1;
            layoutControlItem8.Location = new Point(0, 98);
            layoutControlItem8.Name = "layoutControlItem8";
            layoutControlItem8.Size = new Size(355, 26);
            layoutControlItem8.TextSize = new Size(0, 0);
            layoutControlItem8.TextVisible = false;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem3, layoutControlItem4, layoutControlItem2, layoutControlItem10, emptySpaceItem2 });
            Root.Name = "Root";
            Root.Size = new Size(1120, 168);
            Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = layoutControl2;
            layoutControlItem3.Location = new Point(477, 0);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(379, 148);
            layoutControlItem3.TextSize = new Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = layoutControl4;
            layoutControlItem4.Location = new Point(0, 0);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(477, 84);
            layoutControlItem4.TextSize = new Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = btnAracListele;
            layoutControlItem2.Location = new Point(0, 108);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(477, 40);
            layoutControlItem2.TextSize = new Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            layoutControlItem10.Control = textBox1;
            layoutControlItem10.Location = new Point(0, 84);
            layoutControlItem10.Name = "layoutControlItem10";
            layoutControlItem10.Size = new Size(477, 24);
            layoutControlItem10.Text = "Aracın Günlük Ücretini Girin";
            layoutControlItem10.TextSize = new Size(128, 13);
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new Point(856, 0);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new Size(244, 148);
            emptySpaceItem2.TextSize = new Size(0, 0);
            // 
            // popupMenu1
            // 
            popupMenu1.Manager = barManager1;
            popupMenu1.Name = "popupMenu1";
            // 
            // layoutControlGroup2
            // 
            layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup2.GroupBordersVisible = false;
            layoutControlGroup2.Location = new Point(0, 0);
            layoutControlGroup2.Name = "layoutControlGroup3";
            layoutControlGroup2.Size = new Size(294, 30);
            // 
            // frmArabaEkle
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 495);
            Controls.Add(layoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmArabaEkle";
            Text = "Araç Ekle";
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl4).EndInit();
            layoutControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl2).EndInit();
            layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem10).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraEditors.SimpleButton btnAracListele;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControl layoutControl4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private TextBox textBox1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
    }
}