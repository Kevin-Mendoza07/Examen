using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ActivosFijo
    {
        public int Id { get; set; }
        public string CodigoActivo { get; set; }
        public string NombreActivo { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorActivo { get; set; }
        public DateTime FechaAdquisicion { get; set;}
        public TipoActivo TipoActivo { get; set; }
    }
}
