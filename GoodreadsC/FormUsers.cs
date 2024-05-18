using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodreadsC
{
    public partial class FormUsers : Form
    {
        private string query;
        public FormUsers()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panel1.Region = region;
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnRest_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Functions.CleanB(panel3);
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM [User]";
            DataGVUsers.DataSource = Connection.SelectQuery(query);
        }

        public void LoadD()
        {
            try
            {
                query = "SELECT * FROM [User]";
                DataGVUsers.DataSource = Connection.SelectQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
    string.IsNullOrWhiteSpace(txtUser.Text) ||
    string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, revise que todos los campos estén llenos.");
                return;
            }

            string NameU = txtName.Text;
            string Username = txtUser.Text;
            string Password = txtPassword.Text;

            Connection.InsertUser(NameU, Username, Password);
            MessageBox.Show("Registro realizado.");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
    string.IsNullOrWhiteSpace(txtName.Text) ||
    string.IsNullOrWhiteSpace(txtUser.Text) ||
    string.IsNullOrWhiteSpace(txtPassword.Text) ||
    string.IsNullOrWhiteSpace(txtStatus.Text))
            {
                MessageBox.Show("Por favor, revise que todos los campos estén llenos");
                return;
            }

            int UserId = Convert.ToInt32(txtID.Text);
            string NameU = txtName.Text;
            string Username = txtUser.Text;
            string Password = txtPassword.Text;
            bool status = Convert.ToBoolean(txtStatus.Text);

            Connection.UpdateUser(UserId, NameU, Username, Password, status);
            MessageBox.Show("Registro editado.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Por favor, revise que todos los campos estén llenos");
                return;
            }

            int id = Convert.ToInt32(txtID.Text);

            Connection.DeleteUser(id);
            MessageBox.Show("Registro eliminado.");
        }

        private void DataGVUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = DataGVUsers.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = DataGVUsers.CurrentRow.Cells[1].Value.ToString();
            txtUser.Text = DataGVUsers.CurrentRow.Cells[2].Value.ToString();
            txtPassword.Text = DataGVUsers.CurrentRow.Cells[3].Value.ToString();
            txtStatus.Text = DataGVUsers.CurrentRow.Cells[4].Value.ToString();

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            LoadD();
        }
    }
}
