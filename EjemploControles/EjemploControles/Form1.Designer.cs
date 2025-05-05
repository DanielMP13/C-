namespace EjemploControles
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            lbNombre = new Label();
            txNombre = new TextBox();
            btSaludar = new Button();
            lbCodigo = new Label();
            txCodigo = new TextBox();
            lbFamiliaProfesional = new Label();
            cbFamilia = new ComboBox();
            lbPoblacion = new Label();
            lbxPoblacion = new ListBox();
            rbDesempleados = new RadioButton();
            rbOcupados = new RadioButton();
            gbColectivo = new GroupBox();
            cbCertificado = new CheckBox();
            lbFechaDeInicio = new Label();
            dtpFecha = new DateTimePicker();
            pbFoto = new PictureBox();
            btCargarImagen = new Button();
            btAgregar = new Button();
            dgvCursos = new DataGridView();
            aviso = new ToolTip(components);
            gbColectivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).BeginInit();
            SuspendLayout();
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(245, 41);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(51, 15);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre";
            // 
            // txNombre
            // 
            txNombre.Location = new Point(346, 38);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(100, 23);
            txNombre.TabIndex = 1;
            // 
            // btSaludar
            // 
            btSaludar.Location = new Point(515, 213);
            btSaludar.Name = "btSaludar";
            btSaludar.Size = new Size(75, 23);
            btSaludar.TabIndex = 2;
            btSaludar.Text = "Saludar";
            btSaludar.UseVisualStyleBackColor = true;
            btSaludar.Click += btSaludar_Click;
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.Location = new Point(12, 43);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(46, 15);
            lbCodigo.TabIndex = 3;
            lbCodigo.Text = "Codigo";
            // 
            // txCodigo
            // 
            txCodigo.Location = new Point(88, 40);
            txCodigo.Name = "txCodigo";
            txCodigo.Size = new Size(100, 23);
            txCodigo.TabIndex = 4;
            // 
            // lbFamiliaProfesional
            // 
            lbFamiliaProfesional.AutoSize = true;
            lbFamiliaProfesional.Location = new Point(515, 41);
            lbFamiliaProfesional.Name = "lbFamiliaProfesional";
            lbFamiliaProfesional.Size = new Size(110, 15);
            lbFamiliaProfesional.TabIndex = 5;
            lbFamiliaProfesional.Text = "Familia Profesional ";
            // 
            // cbFamilia
            // 
            cbFamilia.FormattingEnabled = true;
            cbFamilia.Location = new Point(659, 38);
            cbFamilia.Name = "cbFamilia";
            cbFamilia.Size = new Size(205, 23);
            cbFamilia.TabIndex = 6;
            // 
            // lbPoblacion
            // 
            lbPoblacion.AutoSize = true;
            lbPoblacion.Location = new Point(14, 98);
            lbPoblacion.Name = "lbPoblacion";
            lbPoblacion.Size = new Size(60, 15);
            lbPoblacion.TabIndex = 7;
            lbPoblacion.Text = "Población";
            // 
            // lbxPoblacion
            // 
            lbxPoblacion.FormattingEnabled = true;
            lbxPoblacion.ItemHeight = 15;
            lbxPoblacion.Location = new Point(80, 98);
            lbxPoblacion.Name = "lbxPoblacion";
            lbxPoblacion.Size = new Size(120, 94);
            lbxPoblacion.TabIndex = 8;
            // 
            // rbDesempleados
            // 
            rbDesempleados.AutoSize = true;
            rbDesempleados.Location = new Point(15, 39);
            rbDesempleados.Name = "rbDesempleados";
            rbDesempleados.Size = new Size(102, 19);
            rbDesempleados.TabIndex = 9;
            rbDesempleados.TabStop = true;
            rbDesempleados.Text = "Desempleados";
            rbDesempleados.UseVisualStyleBackColor = true;
            // 
            // rbOcupados
            // 
            rbOcupados.AutoSize = true;
            rbOcupados.Location = new Point(148, 39);
            rbOcupados.Name = "rbOcupados";
            rbOcupados.Size = new Size(79, 19);
            rbOcupados.TabIndex = 10;
            rbOcupados.TabStop = true;
            rbOcupados.Text = "Ocupados";
            rbOcupados.UseVisualStyleBackColor = true;
            // 
            // gbColectivo
            // 
            gbColectivo.Controls.Add(rbDesempleados);
            gbColectivo.Controls.Add(rbOcupados);
            gbColectivo.Location = new Point(245, 98);
            gbColectivo.Name = "gbColectivo";
            gbColectivo.Size = new Size(261, 89);
            gbColectivo.TabIndex = 11;
            gbColectivo.TabStop = false;
            gbColectivo.Text = "Colectivo";
            // 
            // cbCertificado
            // 
            cbCertificado.AutoSize = true;
            cbCertificado.Location = new Point(560, 137);
            cbCertificado.Name = "cbCertificado";
            cbCertificado.Size = new Size(84, 19);
            cbCertificado.TabIndex = 12;
            cbCertificado.Text = "Certificado";
            cbCertificado.UseVisualStyleBackColor = true;
            // 
            // lbFechaDeInicio
            // 
            lbFechaDeInicio.AutoSize = true;
            lbFechaDeInicio.Location = new Point(688, 139);
            lbFechaDeInicio.Name = "lbFechaDeInicio";
            lbFechaDeInicio.Size = new Size(86, 15);
            lbFechaDeInicio.TabIndex = 13;
            lbFechaDeInicio.Text = "Fecha de inicio";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(791, 137);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(105, 23);
            dtpFecha.TabIndex = 14;
            // 
            // pbFoto
            // 
            pbFoto.BorderStyle = BorderStyle.FixedSingle;
            pbFoto.Location = new Point(993, 38);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(138, 149);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 15;
            pbFoto.TabStop = false;
            // 
            // btCargarImagen
            // 
            btCargarImagen.Location = new Point(1149, 43);
            btCargarImagen.Name = "btCargarImagen";
            btCargarImagen.Size = new Size(116, 23);
            btCargarImagen.TabIndex = 16;
            btCargarImagen.Text = "Cargar Imagen";
            btCargarImagen.UseVisualStyleBackColor = true;
            btCargarImagen.Click += btCargarImagen_Click;
            // 
            // btAgregar
            // 
            btAgregar.Location = new Point(1162, 164);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(75, 23);
            btAgregar.TabIndex = 17;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = true;
            btAgregar.Click += btAgregar_Click;
            // 
            // dgvCursos
            // 
            dgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.Location = new Point(64, 285);
            dgvCursos.Name = "dgvCursos";
            dgvCursos.Size = new Size(1074, 138);
            dgvCursos.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 444);
            Controls.Add(dgvCursos);
            Controls.Add(btAgregar);
            Controls.Add(btCargarImagen);
            Controls.Add(pbFoto);
            Controls.Add(dtpFecha);
            Controls.Add(lbFechaDeInicio);
            Controls.Add(cbCertificado);
            Controls.Add(gbColectivo);
            Controls.Add(lbxPoblacion);
            Controls.Add(lbPoblacion);
            Controls.Add(cbFamilia);
            Controls.Add(lbFamiliaProfesional);
            Controls.Add(txCodigo);
            Controls.Add(lbCodigo);
            Controls.Add(btSaludar);
            Controls.Add(txNombre);
            Controls.Add(lbNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbColectivo.ResumeLayout(false);
            gbColectivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNombre;
        private TextBox txNombre;
        private Button btSaludar;
        private Label lbCodigo;
        private TextBox txCodigo;
        private Label lbFamiliaProfesional;
        private ComboBox cbFamilia;
        private Label lbPoblacion;
        private ListBox lbxPoblacion;
        private RadioButton rbDesempleados;
        private RadioButton rbOcupados;
        private GroupBox gbColectivo;
        private CheckBox cbCertificado;
        private Label lbFechaDeInicio;
        private DateTimePicker dtpFecha;
        private PictureBox pbFoto;
        private Button btCargarImagen;
        private Button btAgregar;
        private DataGridView dgvCursos;
        private ToolTip aviso;
    }
}
