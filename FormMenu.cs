using System.Runtime.InteropServices;

namespace GoodreadsC
{
    public partial class FormMenu : Form
    {
        private string query;
        public FormMenu()
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

        private void PBClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int lx, ly, sw, sh;

        private void PBMax_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            PBMax.Visible = false;
            PBRest.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void PBRest_Click(object sender, EventArgs e)
        {
            PBMax.Visible = true;
            PBRest.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void PBMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAddB_Click(object sender, EventArgs e)
        {
            FormAddB formAddb = new FormAddB();
            formAddb.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FormEditB formEditb = new FormEditB();
            formEditb.Show();
        }

        private void BtnAddA_Click(object sender, EventArgs e)
        {
            FormAuthor formAuthor = new FormAuthor();
            formAuthor.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM VW_FichaBibliografica";
            DataGVFichaB.DataSource = Connection.SelectQuery(query);
            LlenarAutor();
        }


        public void LlenarAutor()
        {
            query = "SELECT id, Autor FROM VW_FichaBibliografica";
            CBoxAutor.DataSource = Connection.SelectQuery(query);
            CBoxAutor.DisplayMember = "Autor";
            CBoxAutor.ValueMember = "id";
        }

        public void LoadD()
        {
            try
            {
                query = "SELECT * FROM VW_FichaBibliografica";
                DataGVFichaB.DataSource = Connection.SelectQuery(query);
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
                CBoxAutor.DataSource = Connection.SelectQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }


        public static string SelectedAuthor;

        private void CBoxAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedAuthor = CBoxAutor.Text;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM VW_FichaBibliografica WHERE [Autor] = '" + SelectedAuthor.Replace("'", "''") + "'";
            DataGVFichaB.DataSource = Connection.SelectQuery(query);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadD();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            LoadA();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FormUsers formUsers = new FormUsers();
            formUsers.Show();
        }
    }
}

