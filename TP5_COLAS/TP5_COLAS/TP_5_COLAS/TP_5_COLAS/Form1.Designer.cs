
namespace TP_5_COLAS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSimulacion = new System.Windows.Forms.DataGridView();
            this.btnSimular = new System.Windows.Forms.Button();
            this.txtSim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMostrarDesde = new System.Windows.Forms.TextBox();
            this.txtCantMostrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RndLlegadaPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoEntreLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RndCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaUrgente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaLeve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNDAtencionFinMed1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoFinalizacion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinAtencion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medico1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSimulacion
            // 
            this.dgvSimulacion.AllowUserToAddRows = false;
            this.dgvSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimulacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Evento,
            this.Reloj,
            this.RndLlegadaPaciente,
            this.TiempoEntreLlegada,
            this.ProxLlegada,
            this.RndCategoria,
            this.Categoria,
            this.ColaUrgente,
            this.ColaLeve,
            this.RNDAtencionFinMed1,
            this.TiempoFinalizacion1,
            this.FinAtencion1,
            this.Medico1});
            this.dgvSimulacion.Location = new System.Drawing.Point(12, 155);
            this.dgvSimulacion.Name = "dgvSimulacion";
            this.dgvSimulacion.Size = new System.Drawing.Size(977, 261);
            this.dgvSimulacion.TabIndex = 0;
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(18, 87);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 1;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // txtSim
            // 
            this.txtSim.Location = new System.Drawing.Point(146, 13);
            this.txtSim.Name = "txtSim";
            this.txtSim.Size = new System.Drawing.Size(58, 20);
            this.txtSim.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero de simulaciones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mostrar desde:";
            // 
            // txtMostrarDesde
            // 
            this.txtMostrarDesde.Location = new System.Drawing.Point(98, 36);
            this.txtMostrarDesde.Name = "txtMostrarDesde";
            this.txtMostrarDesde.Size = new System.Drawing.Size(57, 20);
            this.txtMostrarDesde.TabIndex = 5;
            // 
            // txtCantMostrar
            // 
            this.txtCantMostrar.Location = new System.Drawing.Point(192, 56);
            this.txtCantMostrar.Name = "txtCantMostrar";
            this.txtCantMostrar.Size = new System.Drawing.Size(57, 20);
            this.txtCantMostrar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero de simulaciones a mostrar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSimular);
            this.groupBox1.Controls.Add(this.txtCantMostrar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMostrarDesde);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 116);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulación";
            // 
            // Evento
            // 
            this.Evento.HeaderText = "Evento";
            this.Evento.Name = "Evento";
            // 
            // Reloj
            // 
            this.Reloj.HeaderText = "Reloj";
            this.Reloj.Name = "Reloj";
            // 
            // RndLlegadaPaciente
            // 
            this.RndLlegadaPaciente.HeaderText = "RndLlegadaPaciente";
            this.RndLlegadaPaciente.Name = "RndLlegadaPaciente";
            // 
            // TiempoEntreLlegada
            // 
            this.TiempoEntreLlegada.HeaderText = "TiempoEntreLlegada";
            this.TiempoEntreLlegada.Name = "TiempoEntreLlegada";
            // 
            // ProxLlegada
            // 
            this.ProxLlegada.HeaderText = "ProxLlegada";
            this.ProxLlegada.Name = "ProxLlegada";
            // 
            // RndCategoria
            // 
            this.RndCategoria.HeaderText = "RndCategoria";
            this.RndCategoria.Name = "RndCategoria";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // ColaUrgente
            // 
            this.ColaUrgente.HeaderText = "ColaUrgente";
            this.ColaUrgente.Name = "ColaUrgente";
            // 
            // ColaLeve
            // 
            this.ColaLeve.HeaderText = "ColaLeve";
            this.ColaLeve.Name = "ColaLeve";
            // 
            // RNDAtencionFinMed1
            // 
            this.RNDAtencionFinMed1.HeaderText = "RNDAtencionFinMed1";
            this.RNDAtencionFinMed1.Name = "RNDAtencionFinMed1";
            // 
            // TiempoFinalizacion1
            // 
            this.TiempoFinalizacion1.HeaderText = "TiempoFinalizacion1";
            this.TiempoFinalizacion1.Name = "TiempoFinalizacion1";
            // 
            // FinAtencion1
            // 
            this.FinAtencion1.HeaderText = "FinAtencion1";
            this.FinAtencion1.Name = "FinAtencion1";
            // 
            // Medico1
            // 
            this.Medico1.HeaderText = "Medico1";
            this.Medico1.Name = "Medico1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 454);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSimulacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSimulacion;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.TextBox txtSim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMostrarDesde;
        private System.Windows.Forms.TextBox txtCantMostrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn RndLlegadaPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoEntreLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn RndCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaUrgente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaLeve;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNDAtencionFinMed1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoFinalizacion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinAtencion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico1;
    }
}

