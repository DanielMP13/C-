namespace EjemploControles
{
    public partial class Form1 : Form
    {
        List<Cursos> listaCursos = new List<Cursos>();
        string rutaImagen = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btSaludar_Click(object sender, EventArgs e)
        {
        }

        private void cargarControles()
        {
            cbFamilia.Items.Add("Infórmatica y Comunicaciones");
            cbFamilia.Items.Add("Administrativo");
            cbFamilia.Items.Add("Sanidad");
            cbFamilia.SelectedIndex = 0;

            lbxPoblacion.Items.Add("Avilés");
            lbxPoblacion.Items.Add("Gijón");
            lbxPoblacion.Items.Add("Oviedo");
            lbxPoblacion.SelectedIndex = 0;

            rbDesempleados.Checked = true;
        }

        private bool validarEntero(string dato)
        {
            if (int.TryParse(dato, out int id))
            { return true; }
            return false;
        }
        private bool validarTexto(string dato)
        {
            if (string.IsNullOrEmpty(dato))
            { return false; }
            return true;
        }
        private void txCodigo_Leave(object sender, EventArgs e)
        {
            bool resultado = validarEntero(txCodigo.Text);
            if (!resultado)
            {
                aviso.Show("Tiene que ser un número entero", txCodigo, 0, txCodigo.Height + 5, 2000);
                txCodigo.Focus();
            }
        }
        private void txNombre_Leave(object sender, EventArgs e)
        {
            bool resultado = validarTexto(txNombre.Text);
            if (!resultado)
            {
                aviso.Show("El campo no puede estar vacío", txNombre, 0, txNombre.Height + 5, 2000);
                txNombre.Focus();
            }
        }
        private void btCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rutaImagen = ofd.FileName;
                pbFoto.Image = Image.FromFile(rutaImagen);
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseas agregar el registro", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                Cursos c = new Cursos();
                c.Codigo = int.Parse(txCodigo.Text);
                c.Curso = txNombre.Text;
                c.Familia = cbFamilia.Text;
                c.Poblacion = lbxPoblacion.Text;
                c.Colectivo = rbDesempleados.Checked ? rbDesempleados.Text : rbOcupados.Text;
                c.Certificado = cbCertificado.Checked;
                c.FechaInicio = dtpFecha.Value;
                c.Ruta = rutaImagen;

                listaCursos.Add(c);
                dgvCursos.DataSource = null;
                dgvCursos.DataSource = listaCursos;
                MessageBox.Show("Registro agregado");
            }
        }
        private void dgvCursos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCursos.CurrentRow?.DataBoundItem is Cursos c)
            {
                txCodigo.Text = c.Codigo.ToString();
                txNombre.Text = c.Curso.ToString();
                cbFamilia.SelectedItem = c.Familia.ToString();
                lbxPoblacion.SelectedItem = c.Poblacion.ToString();
                if (c.Colectivo == rbDesempleados.Text)
                {
                    rbDesempleados.Checked = true;
                }
                else
                {
                    rbOcupados.Checked = true;
                }
                cbCertificado.Checked = c.Certificado;
                dtpFecha.Value = c.FechaInicio;
                if (string.IsNullOrEmpty(c.Ruta))
                {
                    pbFoto.Image = null;
                }
                else
                {
                    pbFoto.Image = Image.FromFile(c.Ruta);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarControles();
        }
    }
}
