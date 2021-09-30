using Domain.Entities;
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
    public partial class FrmActivoFijo : Form
    {
        public ActivosFijoModel AModel { get; set; }

        public FrmActivoFijo()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ActivosFijo ac = new ActivosFijo()
            {

            }; 

        }
    }
}
