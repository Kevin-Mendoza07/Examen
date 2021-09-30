using Infraestructure.Activos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Forms
{
    public partial class FrmGestionActivo : Form
    {

        private ActivosFijoModel activosFijoModels; 
        public FrmGestionActivo()
        {
            activosFijoModels = new ActivosFijoModel(); 
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmActivoFijo frmActivoFijo = new FrmActivoFijo();
            frmActivoFijo.AModel = activosFijoModels;
            frmActivoFijo.ShowDialog();

            rtbActivoFijoView.Text = activosFijoModels.Imprimirtexto();

        }
    }
}
