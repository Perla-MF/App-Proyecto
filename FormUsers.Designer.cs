namespace GoodreadsC
{
    partial class FormUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            panel1 = new Panel();
            PictureBox3 = new PictureBox();
            DataGVUsers = new DataGridView();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            Label3 = new Label();
            txtID = new TextBox();
            txtStatus = new TextBox();
            Label2 = new Label();
            txtPassword = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnGuardar = new Button();
            labelName = new Label();
            LabelPassword = new Label();
            txtName = new TextBox();
            txtUser = new TextBox();
            LabelUser = new Label();
            panel2 = new Panel();
            BtnClose = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGVUsers).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(PictureBox3);
            panel1.Controls.Add(DataGVUsers);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1083, 543);
            panel1.TabIndex = 0;
            // 
            // PictureBox3
            // 
            PictureBox3.Image = (Image)resources.GetObject("PictureBox3.Image");
            PictureBox3.Location = new Point(1014, 53);
            PictureBox3.Name = "PictureBox3";
            PictureBox3.Size = new Size(53, 56);
            PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox3.TabIndex = 13;
            PictureBox3.TabStop = false;
            PictureBox3.Click += PictureBox3_Click;
            // 
            // DataGVUsers
            // 
            DataGVUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGVUsers.BackgroundColor = Color.Cornsilk;
            DataGVUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGVUsers.Location = new Point(428, 117);
            DataGVUsers.Name = "DataGVUsers";
            DataGVUsers.RowHeadersWidth = 51;
            DataGVUsers.Size = new Size(639, 394);
            DataGVUsers.TabIndex = 12;
            DataGVUsers.CellContentClick += DataGVUsers_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Tan;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(Label3);
            panel3.Controls.Add(txtID);
            panel3.Controls.Add(txtStatus);
            panel3.Controls.Add(Label2);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(labelName);
            panel3.Controls.Add(LabelPassword);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(txtUser);
            panel3.Controls.Add(LabelUser);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(411, 505);
            panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(182, 431);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(20, 23);
            Label3.Name = "Label3";
            Label3.Size = new Size(36, 24);
            Label3.TabIndex = 49;
            Label3.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Arial", 12F);
            txtID.Location = new Point(147, 23);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(253, 30);
            txtID.TabIndex = 50;
            // 
            // txtStatus
            // 
            txtStatus.Enabled = false;
            txtStatus.Font = new Font("Arial", 12F);
            txtStatus.Location = new Point(147, 187);
            txtStatus.Name = "txtStatus";
            txtStatus.PasswordChar = '*';
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(253, 30);
            txtStatus.TabIndex = 48;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(20, 193);
            Label2.Name = "Label2";
            Label2.Size = new Size(89, 24);
            Label2.TabIndex = 47;
            Label2.Text = "Estatus:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 12F);
            txtPassword.Location = new Point(147, 151);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(253, 30);
            txtPassword.TabIndex = 46;
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(108, 59, 42);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(3, 376);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(408, 49);
            btnDelete.TabIndex = 45;
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
            btnEdit.Location = new Point(3, 311);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(408, 49);
            btnEdit.TabIndex = 44;
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
            btnGuardar.Location = new Point(3, 247);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(408, 49);
            btnGuardar.TabIndex = 43;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.Location = new Point(20, 82);
            labelName.Name = "labelName";
            labelName.Size = new Size(91, 24);
            labelName.TabIndex = 38;
            labelName.Text = "Nombre:";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelPassword.Location = new Point(20, 151);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(110, 24);
            LabelPassword.TabIndex = 40;
            LabelPassword.Text = "Password:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Arial", 12F);
            txtName.Location = new Point(147, 79);
            txtName.Name = "txtName";
            txtName.Size = new Size(253, 30);
            txtName.TabIndex = 41;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Arial", 12F);
            txtUser.Location = new Point(147, 115);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(253, 30);
            txtUser.TabIndex = 42;
            // 
            // LabelUser
            // 
            LabelUser.AutoSize = true;
            LabelUser.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelUser.Location = new Point(20, 118);
            LabelUser.Name = "LabelUser";
            LabelUser.Size = new Size(112, 24);
            LabelUser.TabIndex = 39;
            LabelUser.Text = "Username:";
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
            panel2.Size = new Size(1083, 38);
            panel2.TabIndex = 1;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // BtnClose
            // 
            BtnClose.Image = (Image)resources.GetObject("BtnClose.Image");
            BtnClose.Location = new Point(1032, 1);
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
            label1.Size = new Size(135, 32);
            label1.TabIndex = 1;
            label1.Text = "Usuarios";
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
            // FormUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 543);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUsers";
            Text = "FormUsers";
            Load += FormUsers_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGVUsers).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox BtnClose;
        private Label label1;
        private PictureBox pictureBox1;
        internal PictureBox PictureBox3;
        internal DataGridView DataGVUsers;
        private Panel panel3;
        internal Label Label3;
        internal TextBox txtID;
        internal TextBox txtStatus;
        internal Label Label2;
        internal TextBox txtPassword;
        internal Button btnDelete;
        internal Button btnEdit;
        internal Button btnGuardar;
        internal Label labelName;
        internal Label LabelPassword;
        internal TextBox txtName;
        internal TextBox txtUser;
        internal Label LabelUser;
        internal PictureBox pictureBox2;
    }
}