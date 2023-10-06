using Microsoft.VisualBasic;

namespace ParcialRT
{
    public partial class Form1 : Form
    {
        Persona objPersona = new Persona();
        Libro objLibro = new Libro();
        Prestamo objPrestamo = new Prestamo();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void llenarFormulario()
        {


            objPersona.Nombre = txtNombre.Text;
            objPersona.Apellido = txtApellido.Text;
            objLibro.NombreLibro = txtLibro.Text;
            objPrestamo.FechaPrestamo = txtFecha.Text;



            MessageBox.Show("Formulario Guardado" +
                "\n Nombre: " + objPersona.Nombre +
                "\n Apellido: " + objPersona.Apellido +
                "\n Nombre del Libro:" + objLibro.NombreLibro +
                "\n Fecha: " + objPrestamo.FechaPrestamo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            llenarFormulario();
        }
    }
}
