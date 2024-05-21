namespace GoodreadsC
{
    partial class Login
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
            PanelFondo = new Panel();
            PanelC = new Panel();
            btnLogin = new Button();
            Label4 = new Label();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            PanelTitle = new Panel();
            PanelFondo.SuspendLayout();
            PanelC.SuspendLayout();
            SuspendLayout();
            // 
            // PanelFondo
            // 
            PanelFondo.Controls.Add(PanelC);
            PanelFondo.Controls.Add(PanelTitle);
            PanelFondo.Dock = DockStyle.Fill;
            PanelFondo.Location = new Point(0, 0);
            PanelFondo.Name = "PanelFondo";
            PanelFondo.Size = new Size(480, 661);
            PanelFondo.TabIndex = 1;
            // 
            // PanelC
            // 
            PanelC.BackColor = Color.Cornsilk;
            PanelC.Controls.Add(btnLogin);
            PanelC.Controls.Add(Label4);
            PanelC.Controls.Add(txtPassword);
            PanelC.Controls.Add(txtUser);
            PanelC.Controls.Add(Label3);
            PanelC.Controls.Add(Label2);
            PanelC.Controls.Add(Label1);
            PanelC.Dock = DockStyle.Fill;
            PanelC.ForeColor = SystemColors.ControlLightLight;
            PanelC.Location = new Point(0, 72);
            PanelC.Name = "PanelC";
            PanelC.Size = new Size(480, 589);
            PanelC.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin.Location = new Point(0, 419);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(481, 58);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Arial Narrow", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Label4.ForeColor = SystemColors.ActiveCaptionText;
            Label4.Location = new Point(177, 509);
            Label4.Name = "Label4";
            Label4.Size = new Size(128, 24);
            Label4.TabIndex = 5;
            Label4.Text = "Agregar Usuario";
            Label4.Click += Label4_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(43, 331);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(394, 34);
            txtPassword.TabIndex = 4;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(43, 201);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(394, 34);
            txtUser.TabIndex = 3;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            Label3.ForeColor = SystemColors.ActiveCaptionText;
            Label3.Location = new Point(43, 278);
            Label3.Name = "Label3";
            Label3.Size = new Size(141, 27);
            Label3.TabIndex = 2;
            Label3.Text = "Contraseña";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            Label2.ForeColor = SystemColors.ActiveCaptionText;
            Label2.Location = new Point(43, 151);
            Label2.Name = "Label2";
            Label2.Size = new Size(100, 27);
            Label2.TabIndex = 1;
            Label2.Text = "Usuario";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label1.ForeColor = SystemColors.ActiveCaptionText;
            Label1.Location = new Point(153, 52);
            Label1.Name = "Label1";
            Label1.Size = new Size(175, 34);
            Label1.TabIndex = 0;
            Label1.Text = "Bienvenido";
            // 
            // PanelTitle
            // 
            PanelTitle.BackColor = Color.FromArgb(108, 59, 42);
            PanelTitle.Dock = DockStyle.Top;
            PanelTitle.Location = new Point(0, 0);
            PanelTitle.Name = "PanelTitle";
            PanelTitle.Size = new Size(480, 72);
            PanelTitle.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 661);
            Controls.Add(PanelFondo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            PanelFondo.ResumeLayout(false);
            PanelC.ResumeLayout(false);
            PanelC.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        internal Panel PanelFondo;
        internal Panel PanelC;
        internal Button btnLogin;
        internal Label Label4;
        internal TextBox txtPassword;
        internal TextBox txtUser;
        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        internal Panel PanelTitle;
    }
}