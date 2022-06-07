using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP_5_COLAS
{
    public partial class Form1 : Form
    {

        int numSim;

        VectorEstado anterior;
        VectorEstado actual;
        VectorEstado aux;
        Random random = new Random();



        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        Boolean empezoSimulacion;
        Boolean inicio = false;


        private void btnSimular_Click(object sender, EventArgs e)
        {
            dgvSimulacion.Rows.Clear();
            anterior = new VectorEstado();
            actual = new VectorEstado();
            aux = new VectorEstado();
            actual.Reloj = 0;
            actual.Evento = "inicio_simulacion";
            actual.Medico1 = new Medico();
            actual.Medico2 = new Medico();
            double dia = 14.5;
            double auxiliar = 0;
            Boolean tasaAlta = false;
            
            actual.PacientesLeve = new Queue<Paciente>();
            actual.PacientesUrgente = new Queue<Paciente>();

            List<Paciente> pacientes = new List<Paciente>();
            Paciente pacienteAtendido = new Paciente();
            empezoSimulacion = false;

            for (int i = 0; i < Convert.ToInt32(txtSim.Text); i++)
            {
                anterior = actual;
                actual = new VectorEstado();

                copiarAnterior();
                buscarEvento();

                    switch (actual.Evento)
                    {
                        case "inicio_simulacion":
                            resetearCampos();
                            actual.RndLlegadaConsulta = random.NextDouble();
                            actual.LlegadaConsulta = aleatorioTasaAlta(actual.RndLlegadaConsulta);
                            actual.ProximaLlegadaConsulta = actual.Reloj + actual.LlegadaConsulta;
                            empezoSimulacion = true;
                            break;

                        case "llegada_paciente":
                            resetearCampos();

                            actual.RndLlegadaConsulta = random.NextDouble();
                            actual.LlegadaConsulta = aleatorioTasaAlta(actual.RndLlegadaConsulta);

                            /*
                            auxiliar += actual.Reloj;

                            if (auxiliar >= 24)
                            {
                                auxiliar = auxiliar - 24;
                            }

                            if (auxiliar <= 14.5)
                            {
                                actual.LlegadaConsulta = aleatorioTasaAlta(actual.RndLlegadaConsulta);
                            }

                            else
                            {
                                actual.LlegadaConsulta = aleatorioTasaBaja(actual.RndLlegadaConsulta);
                            }
                            */
                        
                            
                            
                            actual.ProximaLlegadaConsulta = actual.Reloj + actual.LlegadaConsulta;

                            Paciente nuevo = new Paciente();

                            actual.RndCategoria = random.NextDouble();
                            actual.Categoria = aleatorioPacientes(actual.RndCategoria);

                            nuevo.TipoPaciente = actual.Categoria;

                            nuevo.Nombre = "Paciente" + (pacientes.Count + 1);
                            nuevo.Estado = "esperando";

                            pacientes.Add(nuevo);

                            if(nuevo.TipoPaciente == "leve")
                            {
                                if(!(actual.PacientesUrgente.Count > 0))
                                {
                                    if (actual.Medico1.Estado == "ocupado")
                                    {
                                        actual.PacientesLeve.Enqueue(nuevo);
                                    }
                                    else
                                    {
                                        pacienteAtendido = nuevo;
                                        pacienteAtendido.Estado = "siendo atendido";

                                        actual.Medico1.Estado = "ocupado";

                                        actual.RndPacienteAtencionFinalizada1 = random.NextDouble();
                                        actual.TiempoAtencionFinalizada1 = aleatorioFinAtencion(actual.RndPacienteAtencionFinalizada1);
                                        actual.FinAtencionFinalizada1 = actual.Reloj + actual.TiempoAtencionFinalizada1;
                                    }

                                }

                            }

                            if(nuevo.TipoPaciente == "grave")
                            {
                                if (actual.Medico1.Estado == "ocupado")
                                {
                                    actual.PacientesUrgente.Enqueue(nuevo);
                                }
                                else
                                {
                                    pacienteAtendido = nuevo;
                                    pacienteAtendido.Estado = "siendo atendido";

                                    actual.Medico1.Estado = "ocupado";

                                    actual.RndPacienteAtencionFinalizada1 = random.NextDouble();
                                    actual.TiempoAtencionFinalizada1 = aleatorioFinAtencion(actual.RndPacienteAtencionFinalizada1);
                                    actual.FinAtencionFinalizada1 = actual.Reloj + actual.TiempoAtencionFinalizada1;
                            }

                        }
                            break;

                        case "fin_de_atencion":
                            resetearCampos();
                            
                            if (actual.PacientesLeve.Count == 0)
                            {
                                actual.RndPacienteAtencionFinalizada1 = random.NextDouble();
                                actual.TiempoAtencionFinalizada1 = aleatorioFinAtencion(actual.RndPacienteAtencionFinalizada1);
                                actual.FinAtencionFinalizada1 = actual.Reloj + actual.TiempoAtencionFinalizada1;
                                actual.ProximaLlegadaConsulta = anterior.ProximaLlegadaConsulta; 
                            }
                           
                            if (actual.PacientesUrgente.Count != 0 )
                            {
                                pacienteAtendido = actual.PacientesUrgente.Dequeue();
                                pacienteAtendido.Estado = "siendo atendido";

                                actual.RndPacienteAtencionFinalizada1 = random.NextDouble();
                                actual.TiempoAtencionFinalizada1 = aleatorioFinAtencion(actual.RndPacienteAtencionFinalizada1);
                                actual.FinAtencionFinalizada1 = actual.Reloj + actual.TiempoAtencionFinalizada1;
                                actual.ProximaLlegadaConsulta = anterior.ProximaLlegadaConsulta;

                        }
                            if (actual.PacientesLeve.Count != 0)
                            {
                                pacienteAtendido = actual.PacientesLeve.Dequeue();
                                pacienteAtendido.Estado = "siendo atendido";

                                actual.RndPacienteAtencionFinalizada1 = random.NextDouble();
                                actual.TiempoAtencionFinalizada1 = aleatorioFinAtencion(actual.RndPacienteAtencionFinalizada1);
                                actual.FinAtencionFinalizada1 = actual.Reloj + actual.TiempoAtencionFinalizada1;
                                actual.ProximaLlegadaConsulta = anterior.ProximaLlegadaConsulta;
                        }
                            else
                                {
                                    actual.Medico1.Estado = "libre";
                                    actual.FinAtencionFinalizada1 = -1;
                                }

                            break;

 
                    }

                if (i >= Convert.ToInt32(txtMostrarDesde.Text) - 1 && i + 1 < Convert.ToInt32(txtMostrarDesde.Text) + Convert.ToInt32(txtCantMostrar.Text))
                {
                    agregarDatosDGV(actual);

                    agregarPacientesDGV(pacientes);
                }

                
            }
        }

        private void agregarDatosDGV(VectorEstado actual)
        {
            double reloj = Math.Round(actual.Reloj, 4);
            String evento = actual.Evento;

            String colaPacientesL = actual.PacientesLeve.Count.ToString();
            String colaPacientesU = actual.PacientesUrgente.Count.ToString();
            String estadoMedico1 = actual.Medico1.Estado;

            String rndLlegadaConsulta, tiempoEntreLlegada, proximaLLegada, rndCategoria, categoria, rndAtencionFinalizada1, tiempoAtencionfin1,finAtencionfinalizado1;

            rndLlegadaConsulta = tiempoEntreLlegada = proximaLLegada = rndCategoria = categoria = rndAtencionFinalizada1 = tiempoAtencionfin1 = finAtencionfinalizado1
                =  "";



            if (actual.RndLlegadaConsulta != -1) rndLlegadaConsulta = Math.Round(actual.RndLlegadaConsulta, 4).ToString();
            if (actual.LlegadaConsulta != -1) tiempoEntreLlegada = Math.Round(actual.LlegadaConsulta, 4).ToString();
            if (actual.ProximaLlegadaConsulta != -1) proximaLLegada = Math.Round(actual.ProximaLlegadaConsulta, 4).ToString();
            if (actual.RndCategoria != -1) rndCategoria = Math.Round(actual.RndCategoria, 4).ToString();
            if (actual.RndPacienteAtencionFinalizada1 != -1) rndAtencionFinalizada1 = Math.Round(actual.RndPacienteAtencionFinalizada1, 4).ToString();
            if (actual.FinAtencionFinalizada1 != -1) finAtencionfinalizado1 = Math.Round(actual.FinAtencionFinalizada1, 4).ToString();
            if (actual.TiempoAtencionFinalizada1 != -1) tiempoAtencionfin1 = Math.Round(actual.TiempoAtencionFinalizada1, 4).ToString();
            categoria = actual.Categoria;



            dgvSimulacion.Rows.Add( evento, reloj, rndLlegadaConsulta, tiempoEntreLlegada, proximaLLegada, rndCategoria,
                categoria, colaPacientesU , colaPacientesL, rndAtencionFinalizada1, tiempoAtencionfin1, finAtencionfinalizado1, estadoMedico1);


        }



        private void agregarPacientesDGV(List<Paciente> pacientes)
        {
            for (int k = 0; k < pacientes.Count; k++)
            {
                Paciente p = pacientes.ElementAt(k);
                if (dgvSimulacion.Columns.Contains(p.Nombre))
                {
                    dgvSimulacion.Rows[dgvSimulacion.Rows.Count - 1].Cells[p.Nombre].Value = p.Estado;
                }
                else
                {
                    DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                    columna.HeaderText = "Estado " + p.Nombre;
                    columna.Name = p.Nombre;
                    dgvSimulacion.Columns.Add(columna);
                    dgvSimulacion.Rows[dgvSimulacion.Rows.Count - 1].Cells[p.Nombre].Value = p.Estado;
                }
            }
        }


        private void copiarAnterior()
        {
            actual.Evento = anterior.Evento;
            actual.Reloj = anterior.Reloj;
            actual.RndLlegadaConsulta = anterior.RndLlegadaConsulta;
            actual.LlegadaConsulta = anterior.LlegadaConsulta;
            actual.ProximaLlegadaConsulta = anterior.ProximaLlegadaConsulta;
            actual.RndCategoria = anterior.RndCategoria;
            actual.Categoria = anterior.Categoria;

            actual.PacientesLeve = anterior.PacientesLeve;
            actual.PacientesUrgente = anterior.PacientesUrgente;

            
            actual.RndPacienteAtencionFinalizada1 = anterior.RndPacienteAtencionFinalizada1;
            actual.TiempoAtencionFinalizada1 = anterior.TiempoAtencionFinalizada1;
            actual.FinAtencionFinalizada1 = anterior.FinAtencionFinalizada1;

            actual.Medico1 = anterior.Medico1;
            actual.Medico2 = anterior.Medico2;

            

        }

        private void buscarEvento()
        {
            string evento = "";
            double minimo = 0;

            if (actual.Reloj == 0 && !empezoSimulacion)
            {
                evento = "inicio_simulacion";
                inicio = true;
                return;
            }



            if (anterior.ProximaLlegadaConsulta <= anterior.FinAtencionFinalizada1 )
            {
                evento = "llegada_paciente";
                minimo = anterior.ProximaLlegadaConsulta;
            }
            else
            {

                if (anterior.FinAtencionFinalizada1 == 0 && inicio==true)
                {
                    evento = "llegada_paciente";
                    minimo = anterior.ProximaLlegadaConsulta;
                    inicio = false;
                }
                else
                {
                    evento = "fin_de_atencion";
                    minimo = anterior.FinAtencionFinalizada1;
                }
            }



            actual.Reloj = minimo;
            actual.Evento = evento;

        }

        private void resetearCampos()
        {
            actual.RndLlegadaConsulta = -1;
            actual.LlegadaConsulta = -1;
            actual.RndCategoria = -1;
            actual.ProximaLlegadaConsulta = -1;
            
            
            


        }

        private double aleatorioTasaBaja(double aleatorio)
        {
            return ((double)-1/(double)3) * Math.Log(1 - aleatorio);
        }

        private double aleatorioTasaAlta(double aleatorio)
        {
            double valor;
            valor = ( (double)-1 / (double)6) * Math.Log(1 - aleatorio);
            return valor;
        }

        private double aleatorioFinAtencion(double aleatorio)
        {
            return ((double)-1 / (double)12) * Math.Log(1 - aleatorio);
        }
        private String aleatorioPacientes (double aleatorio)
        {
            if(aleatorio >= 0.20)
            {
                return "leve";
            }
            else
            {
                return "grave";
            }
        }

    }
}
