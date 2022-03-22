using AppCore.IServices;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaDepreciacion
{
    public partial class Modificar : Form
    {
        public IActivoServices activoServices { get; set; }


        public Modificar()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Activo activo = new Activo()
            {
                Id = Convert.ToInt32(lblID.Text),
                Nombre = txtNombreMOD.Text,
                Valor = Convert.ToDouble(txtValorMOD.Text),
                VidaUtil = Convert.ToInt32(txtVidaUtilMOD.Text),
                ValorResidual = Convert.ToInt32(txtValorResidualMOD.Text)
            };

            activoServices.Update(activo, activo.Id);
            Dispose();
        }
    }
}
