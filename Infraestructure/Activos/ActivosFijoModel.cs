using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Activos
{
    public class ActivosFijoModel
    {
        private ActivosFijo[] activosFijos;
        
        public void Add(ActivosFijo ac)
        {
            Add(ac, ref activosFijos);
        }
        public int GetLastId()
        {
            return activosFijos == null ? 0 : activosFijos[activosFijos.Length - 1].Id;
        }

        public string Imprimirtexto() {

            string imp = "";

            if (activosFijos == null)
            {
                throw new ArgumentException("");
            }
            foreach(ActivosFijo ac in activosFijos)
            {
                imp = $@"Id         Codigo          Nombre            Valor               Fecha Adquisicion          Tipo Activo
 {ac.Id}          {ac.CodigoActivo}                 {ac.NombreActivo}                    {ac.ValorActivo}                {ac.FechaAdquisicion}               {ac.TipoActivo}";
            }
            return imp; 
        }
        public void Add(ActivosFijo ac, ref ActivosFijo[] cs)
        {
            if (cs==null)
            {
                cs = new ActivosFijo[1];
                cs[cs.Length - 1] = ac;
                return;

            }
            ActivosFijo[] tmp = new ActivosFijo[cs.Length + 1];
            Array.Copy(cs, tmp, cs.Length);
            tmp[tmp.Length - 1] = ac;
            cs = tmp;
        }

        }
    }

