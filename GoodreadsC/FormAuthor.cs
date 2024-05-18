using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodreadsC
{
    public partial class FormAuthor : Form
    {
        private String query;
        public FormAuthor()
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void LlenarAutor()
        {
            query = "SELECT id, [Name] FROM Author";
            CBAuthor.DataSource = Connection.SelectQuery(query);
            CBAuthor.DisplayMember = "Name";
            CBAuthor.ValueMember = "id";
        }

        private void FormAuthor_Load(object sender, EventArgs e)
        {
            query = "SELECT id, [Name], AuthorId FROM Author";
            DataGVAuthor.DataSource = Connection.SelectQuery(query);
            LlenarAutor();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Por favor, revise que todos los campos estén llenos");
                return;
            }

            string nameAuthor = txtName.Text;
            int idUsuarioC = AppConfig.UserID;
            DateTime fechaCrea = DateAdd.Value.Date;

            Connection.InsertAuthor(nameAuthor, idUsuarioC, fechaCrea);
            MessageBox.Show("Registro guardado.");
        }

        private void DataGVAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = DataGVAuthor.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = DataGVAuthor.CurrentRow.Cells[1].Value.ToString();
            txtAID.Text = DataGVAuthor.CurrentRow.Cells[2].Value.ToString();
        }
        public string SelectedAuthor;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            query = "SELECT id, [Name], AuthorId FROM Author WHERE Name = '" + SelectedAuthor.Replace("'", "''") + "'";
            DataGVAuthor.DataSource = Connection.SelectQuery(query);
        }

        private void CBAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedAuthor = CBAuthor.Text;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Por favor, revise que todos los campos estén llenos");
                return;
            }

            int AuthorId = Convert.ToInt16(txtAID.Text);
            string AuthorName = txtName.Text;
            int idUsuarioMod = AppConfig.UserID;
            DateTime fechaMod = DateAdd.Value.Date;

            Connection.UpdateAuthor(AuthorId, AuthorName, idUsuarioMod, fechaMod);
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

            Connection.DeleteAuthor(id);
            MessageBox.Show("Registro eliminado.");
        }

        public void LoadD()
        {
            try
            {
                query = "SELECT id, [Name], AuthorId FROM Author";
                DataGVAuthor.DataSource = Connection.SelectQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
        public void LoadA()
        {
            try
            {
                query = "SELECT id, Autor FROM VW_FichaBibliografica";
                CBAuthor.DataSource = Connection.SelectQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadD();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            LoadA();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Functions.CleanB(panelTxt);
        }
    }
}
