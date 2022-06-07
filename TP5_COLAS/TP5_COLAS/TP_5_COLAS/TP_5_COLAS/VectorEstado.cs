using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_5_COLAS
{
    public class VectorEstado
    {

        private String evento;
        private double reloj;
        private double rndLlegadaConsulta;
        private double llegadaConsulta;
        private double proximaLlegadaConsulta;
        private double rndCategoria;
        private String categoria;

        private double rndPacienteAtencionFinalizada1;
        private double tiempoAtencionFinalizada1;
        private double finAtencionFinalizada1;


        private double rndPacienteAtencionFinalizada2;
        private double tiempoAtencionFinalizada2;
        private double finAtencionFinalizada2;


        private Medico medico1;
        private Medico medico2;

        private Queue<Paciente> pacienteUrgente;
        private Queue<Paciente> pacienteLeve;

        
        private int pacienteEnColaUrgente;
        private int pacienteEnColaLeve;

        private int urgenteFinalizado;
        private int leveFinalizado;

        public double RndPacienteAtencionFinalizada1 { get => rndPacienteAtencionFinalizada1; set => rndPacienteAtencionFinalizada1 = value; }
        public double TiempoAtencionFinalizada1 { get => tiempoAtencionFinalizada1; set => tiempoAtencionFinalizada1 = value; }
        public double FinAtencionFinalizada1 { get => finAtencionFinalizada1; set => finAtencionFinalizada1 = value; }


        public double RndPacienteAtencionFinalizada2 { get => rndPacienteAtencionFinalizada2; set => rndPacienteAtencionFinalizada2 = value; }
        public double TiempoAtencionFinalizada2 { get => tiempoAtencionFinalizada2; set => tiempoAtencionFinalizada2 = value; }
        public double FinAtencionFinalizada2 { get => finAtencionFinalizada2; set => finAtencionFinalizada2 = value; }

        public string Evento { get => evento; set => evento = value; }
        public double Reloj { get => reloj; set => reloj = value; }
        public double RndLlegadaConsulta { get => rndLlegadaConsulta; set => rndLlegadaConsulta = value; }
        public double LlegadaConsulta { get => llegadaConsulta; set => llegadaConsulta = value; }
        public double ProximaLlegadaConsulta { get => proximaLlegadaConsulta; set => proximaLlegadaConsulta = value; }
        public double RndCategoria { get => rndCategoria; set => rndCategoria = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        

        public Queue<Paciente> PacientesUrgente { get => pacienteUrgente; set => pacienteUrgente = value; }
        public Queue<Paciente> PacientesLeve { get => pacienteLeve; set => pacienteLeve = value; }

        public Medico Medico1 { get => medico1; set => medico1 = value; }
        public Medico Medico2 { get => medico2; set => medico2 = value; }

        public int PacienteEnColaUrgente { get => pacienteEnColaUrgente; set => pacienteEnColaUrgente = value; }
        public int PacienteEnColaLeve { get => pacienteEnColaLeve; set => pacienteEnColaLeve = value; }
        public int UrgenteFinalizado { get => urgenteFinalizado; set => urgenteFinalizado = value; }
        public int LeveFinalizado { get => leveFinalizado; set => leveFinalizado = value; }




    }
}
