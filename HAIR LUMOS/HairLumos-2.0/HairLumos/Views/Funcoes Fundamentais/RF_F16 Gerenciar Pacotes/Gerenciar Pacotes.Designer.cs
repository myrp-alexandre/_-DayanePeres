namespace HairLumos.Views
{
    partial class Cadastro_Pacotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
       

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDtFim = new System.Windows.Forms.DateTimePicker();
            this.dtpDtInicio = new System.Windows.Forms.DateTimePicker();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbServico = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluirServico = new System.Windows.Forms.Button();
            this.servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
           
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtpDtFim);
            this.groupBox2.Controls.Add(this.dtpDtInicio);
            this.groupBox2.Controls.Add(this.btnIncluir);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbbServico);
            this.groupBox2.Location = new System.Drawing.Point(21, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 155);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serviços do Pacote:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Data Fim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Data Início";
            // 
            // dtpDtFim
            // 
            this.dtpDtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtFim.Location = new System.Drawing.Point(425, 77);
            this.dtpDtFim.Name = "dtpDtFim";
            this.dtpDtFim.Size = new System.Drawing.Size(100, 20);
            this.dtpDtFim.TabIndex = 35;
            // 
            // dtpDtInicio
            // 
            this.dtpDtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtInicio.Location = new System.Drawing.Point(311, 77);
            this.dtpDtInicio.Name = "dtpDtInicio";
            this.dtpDtInicio.Size = new System.Drawing.Size(100, 20);
            this.dtpDtInicio.TabIndex = 34;
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIncluir.Location = new System.Drawing.Point(486, 118);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(79, 27);
            this.btnIncluir.TabIndex = 26;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Serviço do Pacote*";
            // 
            // cbbServico
            // 
            this.cbbServico.FormattingEnabled = true;
            this.cbbServico.Location = new System.Drawing.Point(18, 77);
            this.cbbServico.Name = "cbbServico";
            this.cbbServico.Size = new System.Drawing.Size(269, 21);
            this.cbbServico.TabIndex = 32;
            // [
            // 
            // ttbPacote
            // 
            // 
            // label1
            //
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluirServico);
            this.groupBox1.Location = new System.Drawing.Point(21, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 134);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serviços Inclusos no Pacote";
            // 
            // btnExcluirServico
            // 
            this.btnExcluirServico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcluirServico.Location = new System.Drawing.Point(514, 57);
            this.btnExcluirServico.Name = "btnExcluirServico";
            this.btnExcluirServico.Size = new System.Drawing.Size(60, 27);
            this.btnExcluirServico.TabIndex = 13;
            this.btnExcluirServico.Text = "Excluir";
            this.btnExcluirServico.UseVisualStyleBackColor = false;
            
            this.servico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.servico.DataPropertyName = "servico";
            this.servico.HeaderText = "Serviço";
            this.servico.Name = "servico";
            this.servico.ReadOnly = true;
            // 
            
            
            this.btnPesquisa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisa.Location = new System.Drawing.Point(264, 9);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 38);
            this.btnPesquisa.TabIndex = 13;
            this.btnPesquisa.Text = "Pesquisa";
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(640, 421);
            this.ControlBox = false;
            this.Name = "Cadastro_Pacotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H.L - GERENCIAR PACOTES";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnExcluirServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn servico;
        public System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnIncluir;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbServico;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDtFim;
        private System.Windows.Forms.DateTimePicker dtpDtInicio;
    }
}