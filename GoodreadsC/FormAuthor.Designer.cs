namespace GoodreadsC
{
    partial class FormAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthor));
            panel1 = new Panel();
            Reload = new PictureBox();
            btnRefresh = new PictureBox();
            btnBuscar = new PictureBox();
            Label2 = new Label();
            CBAuthor = new ComboBox();
            DataGVAuthor = new DataGridView();
            panelTxt = new Panel();
            pictureBox2 = new PictureBox();
            Label4 = new Label();
            txtID = new TextBox();
            Label3 = new Label();
            txtAID = new TextBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnGuardar = new Button();
            labelName = new Label();
            LabelDate = new Label();
            txtName = new TextBox();
            panel2 = new Panel();
            BtnClose = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            DateAdd = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Reload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGVAuthor).BeginInit();
            panelTxt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(Reload);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(Label2);
            panel1.Controls.Add(CBAuthor);
            panel1.Controls.Add(DataGVAuthor);
            panel1.Controls.Add(panelTxt);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1119, 545);
            panel1.TabIndex = 0;
            // 
            // Reload
            // 
            Reload.Image = (Image)resources.GetObject("Reload.Image");
            Reload.Location = new Point(836, 75);
            Reload.Name = "Reload";
            Reload.Size = new Size(38, 37);
            Reload.SizeMode = PictureBoxSizeMode.StretchImage;
            Reload.TabIndex = 66;
            Reload.TabStop = false;
            Reload.Click += Reload_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(1035, 63);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(53, 56);
            btnRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRefresh.TabIndex = 65;
            btnRefresh.TabStop = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(892, 66);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(53, 53);
            btnBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnBuscar.TabIndex = 64;
            btnBuscar.TabStop = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(423, 80);
            Label2.Name = "Label2";
            Label2.Size = new Size(69, 24);
            Label2.TabIndex = 63;
            Label2.Text = "Autor:";
            // 
            // CBAuthor
            // 
            CBAuthor.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBAuthor.FormattingEnabled = true;
            CBAuthor.Location = new Point(498, 77);
            CBAuthor.Name = "CBAuthor";
            CBAuthor.Size = new Size(335, 31);
            CBAuthor.TabIndex = 62;
            CBAuthor.SelectedIndexChanged += CBAuthor_SelectedIndexChanged;
            // 
            // DataGVAuthor
            // 
            DataGVAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGVAuthor.BackgroundColor = Color.Cornsilk;
            DataGVAuthor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGVAuthor.Location = new Point(423, 141);
            DataGVAuthor.Name = "DataGVAuthor";
            DataGVAuthor.RowHeadersWidth = 51;
            DataGVAuthor.Size = new Size(672, 377);
            DataGVAuthor.TabIndex = 61;
            DataGVAuthor.CellContentClick += DataGVAuthor_CellContentClick;
            // 
            // panelTxt
            // 
            panelTxt.BackColor = Color.Tan;
            panelTxt.Controls.Add(DateAdd);
            panelTxt.Controls.Add(pictureBox2);
            panelTxt.Controls.Add(Label4);
            panelTxt.Controls.Add(txtID);
            panelTxt.Controls.Add(Label3);
            panelTxt.Controls.Add(txtAID);
            panelTxt.Controls.Add(pictureBox6);
            panelTxt.Controls.Add(pictureBox7);
            panelTxt.Controls.Add(pictureBox8);
            panelTxt.Controls.Add(btnDelete);
            panelTxt.Controls.Add(btnEdit);
            panelTxt.Controls.Add(btnGuardar);
            panelTxt.Controls.Add(labelName);
            panelTxt.Controls.Add(LabelDate);
            panelTxt.Controls.Add(txtName);
            panelTxt.Dock = DockStyle.Left;
            panelTxt.Location = new Point(0, 38);
            panelTxt.Name = "panelTxt";
            panelTxt.Size = new Size(402, 507);
            panelTxt.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(174, 437);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 81;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.Location = new Point(12, 91);
            Label4.Name = "Label4";
            Label4.Size = new Size(34, 24);
            Label4.TabIndex = 79;
            Label4.Text = "Id:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Arial", 12F);
            txtID.Location = new Point(135, 88);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(253, 30);
            txtID.TabIndex = 80;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(12, 46);
            Label3.Name = "Label3";
            Label3.Size = new Size(100, 24);
            Label3.TabIndex = 77;
            Label3.Text = "AuthorID:";
            // 
            // txtAID
            // 
            txtAID.Enabled = false;
            txtAID.Font = new Font("Arial", 12F);
            txtAID.Location = new Point(135, 43);
            txtAID.Name = "txtAID";
            txtAID.ReadOnly = true;
            txtAID.Size = new Size(253, 30);
            txtAID.TabIndex = 78;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 378);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(53, 53);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 76;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(3, 313);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(53, 53);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 75;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(3, 233);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(53, 53);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 74;
            pictureBox8.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(108, 59, 42);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(1, 382);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(398, 49);
            btnDelete.TabIndex = 72;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(108, 59, 42);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(1, 317);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(398, 49);
            btnEdit.TabIndex = 71;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(108, 59, 42);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(1, 233);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(398, 49);
            btnGuardar.TabIndex = 70;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.Location = new Point(12, 140);
            labelName.Name = "labelName";
            labelName.Size = new Size(91, 24);
            labelName.TabIndex = 67;
            labelName.Text = "Nombre:";
            // 
            // LabelDate
            // 
            LabelDate.AutoSize = true;
            LabelDate.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelDate.Location = new Point(12, 185);
            LabelDate.Name = "LabelDate";
            LabelDate.Size = new Size(74, 24);
            LabelDate.TabIndex = 68;
            LabelDate.Text = "Fecha:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Arial", 12F);
            txtName.Location = new Point(135, 137);
            txtName.Name = "txtName";
            txtName.Size = new Size(253, 30);
            txtName.TabIndex = 69;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(108, 59, 42);
            panel2.Controls.Add(BtnClose);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1119, 38);
            panel2.TabIndex = 0;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // BtnClose
            // 
            BtnClose.Image = (Image)resources.GetObject("BtnClose.Image");
            BtnClose.Location = new Point(1053, 2);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(35, 35);
            BtnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnClose.TabIndex = 2;
            BtnClose.TabStop = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(55, 3);
            label1.Name = "label1";
            label1.Size = new Size(203, 32);
            label1.TabIndex = 1;
            label1.Text = "Agregar Autor";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // DateAdd
            // 
            DateAdd.Location = new Point(135, 185);
            DateAdd.Name = "DateAdd";
            DateAdd.Size = new Size(253, 27);
            DateAdd.TabIndex = 82;
            // 
            // FormAuthor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 545);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAuthor";
            Text = "FormAuthor";
            Load += FormAuthor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Reload).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGVAuthor).EndInit();
            panelTxt.ResumeLayout(false);
            panelTxt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelTxt;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox BtnClose;
        private Label label1;
        internal Label Label4;
        internal TextBox txtID;
        internal Label Label3;
        internal TextBox txtAID;
        internal PictureBox pictureBox6;
        internal PictureBox pictureBox7;
        internal PictureBox pictureBox8;
        internal Button btnDelete;
        internal Button btnEdit;
        internal Button btnGuardar;
        internal Label labelName;
        internal Label LabelDate;
        internal TextBox txtName;
        internal PictureBox btnRefresh;
        internal PictureBox btnBuscar;
        internal Label Label2;
        internal ComboBox CBAuthor;
        internal DataGridView DataGVAuthor;
        internal PictureBox pictureBox2;
        internal PictureBox Reload;
        private DateTimePicker DateAdd;
    }
}