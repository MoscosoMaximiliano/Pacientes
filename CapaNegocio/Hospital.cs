using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class Hospital
    {
        public static List<CNPaciente> ObtenerPacientes() => new List<CNPaciente>
        {
            new CNPaciente
            {
                ID = "1",
                Nombre = "Nombre #1",
                Apellido = "Apellido #1",
                Edad = 20,
                Domicilio = "Domicilio #1"
            },
            new CNPaciente
            {
                ID = "2",
                Nombre = "Nombre #2",
                Apellido = "Apellido #2",
                Edad = 30,
                Domicilio = "Domicilio #2"
            },
            new CNPaciente
            {
                ID = "3",
                Nombre = "Nombre #3",
                Apellido = "Apellido #3",
                Edad = 40,
                Domicilio = "Domicilio #3"
            }
        };
    }
}
