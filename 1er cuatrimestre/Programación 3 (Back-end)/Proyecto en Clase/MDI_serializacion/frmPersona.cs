using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mdi_Clases;

namespace MDI_serializacion
{
    public partial class frmPersona : Form
    {
        private List<Persona> listaPersona;
        private PersistenciaXML persistenciaXML;

        private String archvivoXML = "persona.xml";


        public frmPersona()
        {
            InitializeComponent();

            listaPersona = new List<Persona>();
            persistenciaXML = new PersistenciaXML();
        }

        private void frmPersona_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                persistenciaXML.Guardar(archvivoXML, listaPersona);
                MessageBox.Show("Exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btoGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Direccion direccion = new Direccion(
                    txtCalle.Text.Trim(),
                    txtNro.Text.Trim(),
                    txtCiudad.Text.Trim(),
                    cbProvincia.Text.Trim()
                    );

                Persona persona = new Persona(
                    Int32.Parse(txtID.Text.Trim()),
                    txtNombre.Text.Trim(),
                    txtApellido.Text.Trim(),
                    DateTime.Parse(dtFechaNacimiento.Text.Trim()),
                    direccion
                    );

                listaPersona.Add(persona);
                ActualizarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la creación de la persona  " + ex.Message);
            }
        }

        private void ActualizarGrilla()
        {
            // throw new NotImplementedException();
            dgwDatosPersona.DataSource = null;
            dgwDatosPersona.DataSource = listaPersona;
        }

        private void LimpiarCampos()
        {
            txtCalle.Text = "";
            txtNro.Text = "";
            txtCiudad.Text = "";
            cbProvincia.Text = "";

            txtID.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtFechaNacimiento.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
