namespace GoodreadsC
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panel1 = new Panel();
            Reload = new PictureBox();
            Search = new PictureBox();
            Refresh = new PictureBox();
            CBoxAutor = new ComboBox();
            Label2 = new Label();
            DataGVFichaB = new DataGridView();
            Label1 = new Label();
            PictureBox2 = new PictureBox();
            PanelM = new Panel();
            PictureBox8 = new PictureBox();
            PictureBox7 = new PictureBox();
            PictureBox6 = new PictureBox();
            PictureBox5 = new PictureBox();
            Button4 = new Button();
            Button3 = new Button();
            BtnAddA = new Button();
            btnAddB = new Button();
            PanelTitle = new Panel();
            PBMin = new PictureBox();
            PBRest = new PictureBox();
            PBMax = new PictureBox();
            PBClose = new PictureBox();
            PicBR = new PictureBox();
            picBMinimize = new PictureBox();
            PicBClose = new PictureBox();
            PicBMaximize = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Reload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Search).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Refresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGVFichaB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            PanelM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox5).BeginInit();
            PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBRest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBMaximize).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(Reload);
            panel1.Controls.Add(Search);
            panel1.Controls.Add(Refresh);
            panel1.Controls.Add(CBoxAutor);
            panel1.Controls.Add(Label2);
            panel1.Controls.Add(DataGVFichaB);
            panel1.Controls.Add(Label1);
            panel1.Controls.Add(PictureBox2);
            panel1.Controls.Add(PanelM);
            panel1.Controls.Add(PanelTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1015, 593);
            panel1.TabIndex = 0;
            // 
            // Reload
            // 
            Reload.Image = (Image)resources.GetObject("Reload.Image");
            Reload.Location = new Point(619, 134);
            Reload.Name = "Reload";
            Reload.Size = new Size(37, 36);
            Reload.SizeMode = PictureBoxSizeMode.StretchImage;
            Reload.TabIndex = 20;
            Reload.TabStop = false;
            Reload.Click += Reload_Click;
            // 
            // Search
            // 
            Search.Image = (Image)resources.GetObject("Search.Image");
            Search.Location = new Point(679, 124);
            Search.Name = "Search";
            Search.Size = new Size(53, 56);
            Search.SizeMode = PictureBoxSizeMode.StretchImage;
            Search.TabIndex = 19;
            Search.TabStop = false;
            Search.Click += Search_Click;
            // 
            // Refresh
            // 
            Refresh.Image = (Image)resources.GetObject("Refresh.Image");
            Refresh.Location = new Point(944, 124);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(53, 56);
            Refresh.SizeMode = PictureBoxSizeMode.StretchImage;
            Refresh.TabIndex = 18;
            Refresh.TabStop = false;
            Refresh.Click += Refresh_Click;
            // 
            // CBoxAutor
            // 
            CBoxAutor.FormattingEnabled = true;
            CBoxAutor.Location = new Point(345, 137);
            CBoxAutor.Name = "CBoxAutor";
            CBoxAutor.Size = new Size(268, 28);
            CBoxAutor.TabIndex = 17;
            CBoxAutor.SelectedIndexChanged += CBoxAutor_SelectedIndexChanged;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label2.Location = new Point(269, 141);
            Label2.Name = "Label2";
            Label2.Size = new Size(71, 24);
            Label2.TabIndex = 16;
            Label2.Text = "Autor:";
            // 
            // DataGVFichaB
            // 
            DataGVFichaB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGVFichaB.BackgroundColor = Color.Cornsilk;
            DataGVFichaB.ColumnHeadersHeight = 51;
            DataGVFichaB.GridColor = SystemColors.Info;
            DataGVFichaB.Location = new Point(264, 200);
            DataGVFichaB.Name = "DataGVFichaB";
            DataGVFichaB.RowHeadersWidth = 51;
            DataGVFichaB.Size = new Size(733, 371);
            DataGVFichaB.TabIndex = 13;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(506, 69);
            Label1.Name = "Label1";
            Label1.Size = new Size(249, 27);
            Label1.TabIndex = 15;
            Label1.Text = "Fichas Bibliográficas";
            // 
            // PictureBox2
            // 
            PictureBox2.Image = (Image)resources.GetObject("PictureBox2.Image");
            PictureBox2.Location = new Point(269, 56);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(53, 56);
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox2.TabIndex = 14;
            PictureBox2.TabStop = false;
            // 
            // PanelM
            // 
            PanelM.BackColor = Color.Tan;
            PanelM.Controls.Add(PictureBox8);
            PanelM.Controls.Add(PictureBox7);
            PanelM.Controls.Add(PictureBox6);
            PanelM.Controls.Add(PictureBox5);
            PanelM.Controls.Add(Button4);
            PanelM.Controls.Add(Button3);
            PanelM.Controls.Add(BtnAddA);
            PanelM.Controls.Add(btnAddB);
            PanelM.Dock = DockStyle.Left;
            PanelM.Location = new Point(0, 40);
            PanelM.Name = "PanelM";
            PanelM.Size = new Size(250, 553);
            PanelM.TabIndex = 2;
            // 
            // PictureBox8
            // 
            PictureBox8.Image = (Image)resources.GetObject("PictureBox8.Image");
            PictureBox8.Location = new Point(3, 341);
            PictureBox8.Name = "PictureBox8";
            PictureBox8.Size = new Size(50, 49);
            PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox8.TabIndex = 16;
            PictureBox8.TabStop = false;
            // 
            // PictureBox7
            // 
            PictureBox7.Image = (Image)resources.GetObject("PictureBox7.Image");
            PictureBox7.Location = new Point(3, 228);
            PictureBox7.Name = "PictureBox7";
            PictureBox7.Size = new Size(48, 49);
            PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox7.TabIndex = 15;
            PictureBox7.TabStop = false;
            // 
            // PictureBox6
            // 
            PictureBox6.Image = (Image)resources.GetObject("PictureBox6.Image");
            PictureBox6.Location = new Point(5, 283);
            PictureBox6.Name = "PictureBox6";
            PictureBox6.Size = new Size(43, 49);
            PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox6.TabIndex = 14;
            PictureBox6.TabStop = false;
            // 
            // PictureBox5
            // 
            PictureBox5.Image = (Image)resources.GetObject("PictureBox5.Image");
            PictureBox5.Location = new Point(3, 168);
            PictureBox5.Name = "PictureBox5";
            PictureBox5.Size = new Size(50, 49);
            PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox5.TabIndex = 13;
            PictureBox5.TabStop = false;
            // 
            // Button4
            // 
            Button4.FlatAppearance.BorderSize = 0;
            Button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(108, 59, 42);
            Button4.FlatStyle = FlatStyle.Flat;
            Button4.Font = new Font("Arial", 12F, FontStyle.Bold);
            Button4.ForeColor = SystemColors.ButtonHighlight;
            Button4.ImageAlign = ContentAlignment.MiddleRight;
            Button4.Location = new Point(0, 341);
            Button4.Name = "Button4";
            Button4.Size = new Size(250, 49);
            Button4.TabIndex = 4;
            Button4.Text = "Agregar Usuario";
            Button4.TextAlign = ContentAlignment.MiddleRight;
            Button4.UseVisualStyleBackColor = true;
            Button4.Click += Button4_Click;
            // 
            // Button3
            // 
            Button3.FlatAppearance.BorderSize = 0;
            Button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(108, 59, 42);
            Button3.FlatStyle = FlatStyle.Flat;
            Button3.Font = new Font("Arial", 12F, FontStyle.Bold);
            Button3.ForeColor = SystemColors.ButtonHighlight;
            Button3.ImageAlign = ContentAlignment.MiddleRight;
            Button3.Location = new Point(0, 228);
            Button3.Name = "Button3";
            Button3.Size = new Size(250, 49);
            Button3.TabIndex = 3;
            Button3.Text = "Editar Libro";
            Button3.TextAlign = ContentAlignment.MiddleRight;
            Button3.UseVisualStyleBackColor = true;
            Button3.Click += Button3_Click;
            // 
            // BtnAddA
            // 
            BtnAddA.FlatAppearance.BorderSize = 0;
            BtnAddA.FlatAppearance.MouseDownBackColor = Color.FromArgb(108, 59, 42);
            BtnAddA.FlatStyle = FlatStyle.Flat;
            BtnAddA.Font = new Font("Arial", 12F, FontStyle.Bold);
            BtnAddA.ForeColor = SystemColors.ButtonHighlight;
            BtnAddA.ImageAlign = ContentAlignment.MiddleRight;
            BtnAddA.Location = new Point(0, 283);
            BtnAddA.Name = "BtnAddA";
            BtnAddA.Size = new Size(250, 49);
            BtnAddA.TabIndex = 2;
            BtnAddA.Text = "Agregar Autor";
            BtnAddA.TextAlign = ContentAlignment.MiddleRight;
            BtnAddA.UseVisualStyleBackColor = true;
            BtnAddA.Click += BtnAddA_Click;
            // 
            // btnAddB
            // 
            btnAddB.FlatAppearance.BorderSize = 0;
            btnAddB.FlatAppearance.MouseDownBackColor = Color.FromArgb(108, 59, 42);
            btnAddB.FlatStyle = FlatStyle.Flat;
            btnAddB.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAddB.ForeColor = SystemColors.ButtonHighlight;
            btnAddB.ImageAlign = ContentAlignment.MiddleRight;
            btnAddB.Location = new Point(0, 163);
            btnAddB.Name = "btnAddB";
            btnAddB.Size = new Size(250, 49);
            btnAddB.TabIndex = 1;
            btnAddB.Text = "Agregar Libro";
            btnAddB.TextAlign = ContentAlignment.MiddleRight;
            btnAddB.UseVisualStyleBackColor = true;
            btnAddB.Click += btnAddB_Click;
            // 
            // PanelTitle
            // 
            PanelTitle.BackColor = Color.FromArgb(108, 59, 42);
            PanelTitle.Controls.Add(PBMin);
            PanelTitle.Controls.Add(PBRest);
            PanelTitle.Controls.Add(PBMax);
            PanelTitle.Controls.Add(PBClose);
            PanelTitle.Controls.Add(PicBR);
            PanelTitle.Controls.Add(picBMinimize);
            PanelTitle.Controls.Add(PicBClose);
            PanelTitle.Controls.Add(PicBMaximize);
            PanelTitle.Dock = DockStyle.Top;
            PanelTitle.Location = new Point(0, 0);
            PanelTitle.Name = "PanelTitle";
            PanelTitle.Size = new Size(1015, 40);
            PanelTitle.TabIndex = 1;
            PanelTitle.MouseMove += PanelTitle_MouseMove;
            // 
            // PBMin
            // 
            PBMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PBMin.Image = (Image)resources.GetObject("PBMin.Image");
            PBMin.Location = new Point(881, 8);
            PBMin.Name = "PBMin";
            PBMin.Size = new Size(27, 27);
            PBMin.SizeMode = PictureBoxSizeMode.StretchImage;
            PBMin.TabIndex = 8;
            PBMin.TabStop = false;
            PBMin.Click += PBMin_Click;
            // 
            // PBRest
            // 
            PBRest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PBRest.Image = (Image)resources.GetObject("PBRest.Image");
            PBRest.Location = new Point(924, 8);
            PBRest.Name = "PBRest";
            PBRest.Size = new Size(27, 27);
            PBRest.SizeMode = PictureBoxSizeMode.StretchImage;
            PBRest.TabIndex = 7;
            PBRest.TabStop = false;
            PBRest.Visible = false;
            PBRest.Click += PBRest_Click;
            // 
            // PBMax
            // 
            PBMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PBMax.Image = (Image)resources.GetObject("PBMax.Image");
            PBMax.Location = new Point(924, 8);
            PBMax.Name = "PBMax";
            PBMax.Size = new Size(27, 27);
            PBMax.SizeMode = PictureBoxSizeMode.StretchImage;
            PBMax.TabIndex = 6;
            PBMax.TabStop = false;
            PBMax.Click += PBMax_Click;
            // 
            // PBClose
            // 
            PBClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PBClose.Image = (Image)resources.GetObject("PBClose.Image");
            PBClose.Location = new Point(970, 8);
            PBClose.Name = "PBClose";
            PBClose.Size = new Size(27, 27);
            PBClose.SizeMode = PictureBoxSizeMode.StretchImage;
            PBClose.TabIndex = 5;
            PBClose.TabStop = false;
            PBClose.Click += PBClose_Click;
            // 
            // PicBR
            // 
            PicBR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PicBR.Image = (Image)resources.GetObject("PicBR.Image");
            PicBR.Location = new Point(2511, 7);
            PicBR.Name = "PicBR";
            PicBR.Size = new Size(27, 27);
            PicBR.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBR.TabIndex = 4;
            PicBR.TabStop = false;
            PicBR.Visible = false;
            // 
            // picBMinimize
            // 
            picBMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picBMinimize.Image = (Image)resources.GetObject("picBMinimize.Image");
            picBMinimize.Location = new Point(2467, 7);
            picBMinimize.Name = "picBMinimize";
            picBMinimize.Size = new Size(27, 27);
            picBMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            picBMinimize.TabIndex = 3;
            picBMinimize.TabStop = false;
            // 
            // PicBClose
            // 
            PicBClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PicBClose.Image = (Image)resources.GetObject("PicBClose.Image");
            PicBClose.Location = new Point(2555, 7);
            PicBClose.Name = "PicBClose";
            PicBClose.Size = new Size(27, 27);
            PicBClose.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBClose.TabIndex = 2;
            PicBClose.TabStop = false;
            // 
            // PicBMaximize
            // 
            PicBMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PicBMaximize.Image = (Image)resources.GetObject("PicBMaximize.Image");
            PicBMaximize.Location = new Point(2511, 7);
            PicBMaximize.Name = "PicBMaximize";
            PicBMaximize.Size = new Size(27, 27);
            PicBMaximize.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBMaximize.TabIndex = 1;
            PicBMaximize.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 593);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(680, 500);
            Name = "FormMenu";
            Text = "Form1";
            Load += FormMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Reload).EndInit();
            ((System.ComponentModel.ISupportInitialize)Search).EndInit();
            ((System.ComponentModel.ISupportInitialize)Refresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGVFichaB).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            PanelM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox5).EndInit();
            PanelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBRest).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBR).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBMaximize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        internal PictureBox Search;
        internal PictureBox Refresh;
        internal ComboBox CBoxAutor;
        internal Label Label2;
        internal DataGridView DataGVFichaB;
        internal Label Label1;
        internal PictureBox PictureBox2;
        internal Panel PanelM;
        internal PictureBox PictureBox8;
        internal PictureBox PictureBox7;
        internal PictureBox PictureBox6;
        internal PictureBox PictureBox5;
        internal Button Button4;
        internal Button Button3;
        internal Button BtnAddA;
        internal Button btnAddB;
        internal Panel PanelTitle;
        internal PictureBox PBMin;
        internal PictureBox PBRest;
        internal PictureBox PBMax;
        internal PictureBox PBClose;
        internal PictureBox PicBR;
        internal PictureBox picBMinimize;
        internal PictureBox PicBClose;
        internal PictureBox PicBMaximize;
        internal PictureBox Reload;
    }
}
