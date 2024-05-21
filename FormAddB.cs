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
    public partial class FormAddB : Form
    {
        public FormAddB()
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
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelFondo.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
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

        private void PanelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PBLimpiar_Click(object sender, EventArgs e)
        {
            Functions.CleanB(panelFondo);
        }

        private void PBAgregar_Click(object sender, EventArgs e)
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
        string.IsNullOrWhiteSpace(txtBoxDate.Text) ||
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

            string username = "nombre_de_usuario";
            int idUsuarioC = Connection.ObtenerIdUsuario(username);

            if (idUsuarioC != -1)
            {
                Console.WriteLine("El ID del usuario " + username + " es: " + idUsuarioC);
            }
            else
            {
                Console.WriteLine("El usuario " + username + " no fue encontrado en la base de datos.");
            }

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
            DateTime fechaCrea = Convert.ToDateTime(txtBoxDate.Text);
            string ratingD1 = txtBoxR1.Text;
            string ratingD2 = txtBoxR2.Text;
            string ratingD3 = txtBoxR3.Text;
            string ratingD4 = txtBoxR4.Text;
            string ratingD5 = txtBoxR5.Text;
            string ratingDTotal = txtBoxRT.Text;

            Connection.InsertBookWithRating(name, pagesNumber, publishMonth, publishDay, publishYear, publisher, isbn, language, rating, countsOfReview, authorId, idUsuarioC, fechaCrea, ratingD1, ratingD2, ratingD3, ratingD4, ratingD5, ratingDTotal);
            {
                MessageBox.Show("Libro ingresado con éxito.");

            }
        }
    }
}

