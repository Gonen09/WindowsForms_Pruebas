using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ventanaPrincipal : Form
    {

        public ventanaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblRespuesta.Text = "";
        }

        private void tbCantidad_Scroll(object sender, EventArgs e)
        {
            lblCantidad.Text = tbCantidad.Value.ToString();
        }

        #region Menu Principal

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ventana principal de la aplicación de prueba", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Botones

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblRespuesta.Text = "Hola Mundo !!!";
            tssEstadoboton.Text = "Botón: Saludo";
        }

        private void btnDespedida_Click(object sender, EventArgs e)
        {
            lblRespuesta.Text = "Adios !!!";
            tssEstadoboton.Text = "Botón: Despedida";
        }

        private void btnVentana_Click(object sender, EventArgs e)
        {
            ventanaSecundaria miforma = new ventanaSecundaria();

            tssEstadoboton.Text = "Botón: Ventana";
            miforma.ShowDialog();
        }


        #endregion

        #region Barra Herramientas

        private void tsbPlay_Click(object sender, EventArgs e)
        {
            tbRespuestas.Enabled = true;
            tbRespuestas.Text = "Ingrese contenido aqui";
        }

        private void tsbStop_Click(object sender, EventArgs e)
        {
            if (tbRespuestas.Enabled == true)
            {
                tbRespuestas.Text = "";
            }
            else
            {
                MessageBox.Show("Control deshabilitado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbInfo_Click(object sender, EventArgs e)
        {
            if(tbRespuestas.Enabled == true)
            {
                if (tbRespuestas.Text == "")
                {
                    MessageBox.Show("No hay información", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {               
                    MessageBox.Show(tbRespuestas.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Control deshabilitado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbStar_Click(object sender, EventArgs e)
        {
            if (tbRespuestas.Enabled == true)
            {
                Random rnd = new Random();
                int valor = rnd.Next(0, 100);
                tbRespuestas.Text = valor.ToString();
            }
            else
            {
                MessageBox.Show("Control deshabilitado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Grupo radio boton

        private void rbgOpcion1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgOpcion1.Checked)
            {
                tssEstadogrupo.Text = "Opción Grupo: 1";
            }
        }

        private void rbgOpcion2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgOpcion2.Checked)
            {
                tssEstadogrupo.Text = "Opción Grupo: 2";
            }
        }

        private void rbgOpcion3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgOpcion3.Checked)
            {
                tssEstadogrupo.Text = "Opción Grupo: 3";
            }
        }

        #endregion

        #region Radio boton

        private void rbOpcion1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOpcion1.Checked)
            {
                tssEstadoradio.Text = "Opción: 1";
            }
        }

        private void rbOpcion2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOpcion2.Checked)
            {
                tssEstadoradio.Text = "Opción: 2";
            }
        }

        private void rbOpcion3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOpcion3.Checked)
            {
                tssEstadoradio.Text = "Opción: 3";
            }
        }

        #endregion

        #region Listas de elementos

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (tbAgregarElemento.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre de elemento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                clbListaChequeo.Items.Add(tbAgregarElemento.Text);
                cbListaOpciones.Items.Add(tbAgregarElemento.Text);
                tbAgregarElemento.Text = "";
            }
        }

        private void ClbListaChequeo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = clbListaChequeo.SelectedIndex;

            if (indice == -1)
            {
                lblListaCheckR.Text = "< "+ indice.ToString() + " , Ninguno >";
            }
            else
            {
                lblListaCheckR.Text = "< " + indice.ToString() + " , " + clbListaChequeo.Items[indice].ToString() + " >";
            }
        }

        private void CbListaOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cbListaOpciones.SelectedIndex;

            if (indice == -1)
            {
                lblListaComboR.Text = String.Format("< {0} , Ninguno >", indice.ToString());
            }
            else
            {
                lblListaComboR.Text = String.Format("< {0} , {1} >",indice.ToString(), cbListaOpciones.Items[indice].ToString());
            }
        }

        private void tsmBorrarCheck_Click(object sender, EventArgs e)
        {
            clbListaChequeo.Items.Clear();
            lblListaCheckR.Text = "< -1 , Ninguno >";
        }

        private void tsmBorrarCombo_Click(object sender, EventArgs e)
        {
            cbListaOpciones.Items.Clear();
            cbListaOpciones.Text = "";
            lblListaComboR.Text = "< -1 , Ninguno >";
        }

        #endregion
    }
}
