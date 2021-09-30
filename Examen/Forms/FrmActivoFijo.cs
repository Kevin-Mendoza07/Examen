using Domain.Entities;
using Domain.Enums;
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

        private void button1_Click(object sender, EventArgs e)
        {
            ActivosFijo ac = new ActivosFijo()
            {
                Id=AModel.GetLastId()+1,
                CodigoActivo=txtCodigo.Text,
                NombreActivo=txtNombre.Text,
                Descripcion=txtDescripcion.Text,
                ValorActivo=nudValor.Value,
                FechaAdquisicion=dtpAdquisicion.Value,
                TipoActivo=(TipoActivo)cmbTipoActivo.SelectedIndex

            };
            AModel.Add(ac);
            Dispose();

        }

        private void FrmActivoFijo_Load(object sender, EventArgs e)
        {
            cmbTipoActivo.Items.AddRange(Enum.GetValues(typeof(TipoActivo)).Cast<Object>().ToArray());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
