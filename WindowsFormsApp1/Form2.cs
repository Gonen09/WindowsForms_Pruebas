using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ventanaSecundaria : Form
    {
        public ventanaSecundaria()
        {
            InitializeComponent();
        }

        #region Barra de menu

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChequearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chkChequear.Checked)
            {
                MessageBox.Show("El check ya esta chequeado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                chkChequear.Checked = true;
            }
        }

        private void NoChequearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!chkChequear.Checked)
            {
                MessageBox.Show("El check ya esta deschequeado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                chkChequear.Checked = false;
            }
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ventana secundaria de la aplicación de prueba", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Componentes centrales

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Presionaste el boton Aceptar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkVisitanos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkVisitanos.LinkVisited = true;
            System.Diagnostics.Process.Start("www.google.cl");
        }

        private void chkChequear_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChequear.Checked)
            {
                MessageBox.Show("El check esta chequeado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El check no esta chequeado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Temporizador

        private void temporizador_Tick(object sender, EventArgs e)
        {

            if (pgbCarga.Value < 100)
            {
                pgbCarga.Value++;
                porcentajeCarga.Text = pgbCarga.Value.ToString() + "%";
            }
                
            if (pgbCarga.Value == 100)
                temporizador.Stop();
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            temporizador.Start();
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            temporizador.Stop();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            temporizador.Stop();
            pgbCarga.Value = 0;
            porcentajeCarga.Text = pgbCarga.Value.ToString() + "%";
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Cuando se cierra la ventana desactivamos el temporizador en desuso

            temporizador.Stop();
        }

        #endregion
    }
}
