using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    public class CNPaciente
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Domicilio { set; get; }
    }
}
