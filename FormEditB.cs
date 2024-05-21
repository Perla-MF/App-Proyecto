using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GoodreadsC
{
    public partial class FormEditB : Form
    {
        private string query = "";
        public FormEditB()
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
            this.panelFondo.Region = region;
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

        private void Clean_Click(object sender, EventArgs e)
        {
            Functions.CleanB(PanelInfo);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadA();
        }

        private void PanelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void LoadA()
        {
            try
            {
                query = "SELECT DISTINCT id, Autor FROM VW_BooksAndRatings";
                CBoxAutor.DataSource = Connection.SelectQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void FormEditB_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM VW_BooksAndRatings";
            DataGVBooks.DataSource = Connection.SelectQuery(query);
            LlenarAutor();
        }
        public void LlenarAutor()
        {
            query = "SELECT DISTINCT id, Autor FROM VW_BooksAndRatings";
            CBoxAutor.DataSource = Connection.SelectQuery(query);
            CBoxAutor.DisplayMember = "Autor";
            CBoxAutor.ValueMember = "id";
        }
        public static string SelectedAuthor;
        private void CBoxAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedAuthor = CBoxAutor.Text;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM VW_BooksAndRatings WHERE [Autor] = '" + SelectedAuthor.Replace("'", "''") + "'";
            DataGVBooks.DataSource = Connection.SelectQuery(query);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            LoadD();
        }

        public void LoadD()
        {
            try
            {
                query = "SELECT * FROM VW_BooksAndRatings";
                DataGVBooks.DataSource = Connection.SelectQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void DataGVBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = DataGVBooks.CurrentRow.Cells[0].Value.ToString();
            txtBoxTitulo.Text = DataGVBooks.CurrentRow.Cells[1].Value.ToString();
            txtBoxPaginas.Text = DataGVBooks.CurrentRow.Cells[2].Value.ToString();
            txtBoxMes.Text = DataGVBooks.CurrentRow.Cells[3].Value.ToString();
            txtBoxDia.Text = DataGVBooks.CurrentRow.Cells[4].Value.ToString();
            txtBoxAño.Text = DataGVBooks.CurrentRow.Cells[5].Value.ToString();
            txtBoxEditorial.Text = DataGVBooks.CurrentRow.Cells[6].Value.ToString();
            txtBoxISBN.Text= DataGVBooks.CurrentRow.Cells[7].Value.ToString();
            txtBoxIdioma.Text= DataGVBooks.CurrentRow.Cells[8].Value.ToString();
            txtBoxRating.Text= DataGVBooks.CurrentRow.Cells[9].Value.ToString();
            txtBoxReseñas.Text= DataGVBooks.CurrentRow.Cells[10].Value.ToString();
            txtBoxAutor.Text= DataGVBooks.CurrentRow.Cells[11].Value.ToString();
            txtBoxR1.Text= DataGVBooks.CurrentRow.Cells[12].Value.ToString();
            txtBoxR2.Text= DataGVBooks.CurrentRow.Cells[13].Value.ToString();
            txtBoxR3.Text= DataGVBooks.CurrentRow.Cells[14].Value.ToString();
            txtBoxR4.Text= DataGVBooks.CurrentRow.Cells[15].Value.ToString();
            txtBoxR5.Text= DataGVBooks.CurrentRow.Cells[16].Value.ToString();
            txtBoxRT.Text= DataGVBooks.CurrentRow.Cells[17].Value.ToString();
        }

        private void txtBoxTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxTitulo.Text) ||
    string.IsNullOrWhiteSpace(txtBoxPaginas.Text) ||
    string.IsNullOrWhiteSpace(txtBoxMes.Text) ||
    string.IsNullOrWhiteSpace(txtBoxDia.Text) ||
    string.IsNullOrWhiteSpace(txtBoxAño.Text) ||
    string.IsNullOrWhiteSpace(txtBoxEditorial.Text) ||
    string.IsNullOrWhiteSpace(txtBoxISBN.Text) ||
    string.IsNullOrWhiteSpace(txtBoxIdioma.Text) ||
    string.IsNullOrWhiteSpace(txtBoxRating.Text) ||
    string.IsNullOrWhiteSpace(txtBoxReseñas.Text) ||
    string.IsNullOrWhiteSpace(txtBoxAutor.Text) ||
    string.IsNullOrWhiteSpace(txtBoxR1.Text) ||
    string.IsNullOrWhiteSpace(txtBoxR2.Text) ||
    string.IsNullOrWhiteSpace(txtBoxR3.Text) ||
    string.IsNullOrWhiteSpace(txtBoxR4.Text) ||
    string.IsNullOrWhiteSpace(txtBoxR5.Text) ||
    string.IsNullOrWhiteSpace(txtBoxRT.Text))
            {
                MessageBox.Show("Por favor, revise que todos los campos estén llenos");
                return;
            }

            int id = Convert.ToInt32(txtID.Text);
            string name = txtBoxTitulo.Text;
            int pagesNumber = Convert.ToInt32(txtBoxPaginas.Text);
            int publishMonth = Convert.ToInt32(txtBoxMes.Text);
            int publishDay = Convert.ToInt32(txtBoxDia.Text);
            int publishYear = Convert.ToInt32(txtBoxAño.Text);
            string publisher = txtBoxEditorial.Text;
            string isbn = txtBoxISBN.Text;
            string language = txtBoxIdioma.Text;
            double rating = Convert.ToDouble(txtBoxRating.Text);
            int countsOfReview = Convert.ToInt32(txtBoxReseñas.Text);
            string authorId = txtBoxAutor.Text;
            int idUsuarioMod = AppConfig.UserID;
            DateTime fechaMod = DateAdd.Value.Date;
            string ratingD1 = txtBoxR1.Text;
            string ratingD2 = txtBoxR2.Text;
            string ratingD3 = txtBoxR3.Text;
            string ratingD4 = txtBoxR4.Text;
            string ratingD5 = txtBoxR5.Text;
            string ratingDTotal = txtBoxRT.Text;

            Connection.UpdateBookWithRating(id, name, pagesNumber, publishMonth, publishDay, publishYear, publisher, isbn, language, rating, countsOfReview, authorId, idUsuarioMod, fechaMod, ratingD1, ratingD2, ratingD3, ratingD4, ratingD5, ratingDTotal);
            MessageBox.Show("Registro editado.");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Por favor, revise que todos los campos estén llenos");
                return;
            }

            int id = Convert.ToInt32(txtID.Text);

            Connection.DeleteBookAndRatings(id);
            MessageBox.Show("Registro eliminado.");
        }
    }


}

