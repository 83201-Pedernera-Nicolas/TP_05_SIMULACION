using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_5_COLAS
{
    public class Paciente
    {

        private String nombre;
        private int idPaciente;
        private String estado;
        private String tipoPaciente;

        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string TipoPaciente { get => tipoPaciente; set => tipoPaciente = value; }



    }
}
