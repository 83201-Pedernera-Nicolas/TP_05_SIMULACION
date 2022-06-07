using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_5_COLAS
{
    public class Medico
    {

        private String estado;
        private int id;
        private double inicioOcupacion;

        public int Id { get => id; set => id = value; }
        public string Estado { get => estado; set => estado = value; }
        public double InicioOcupacion { get => inicioOcupacion; set => inicioOcupacion = value; }

        public Medico()
        {
            this.estado = "libre";
        }


    }
}
