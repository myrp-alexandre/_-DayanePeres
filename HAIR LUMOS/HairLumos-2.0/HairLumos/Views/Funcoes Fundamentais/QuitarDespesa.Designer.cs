namespace HairLumos.Views.Funcoes_Fundamentais
{
    partial class QuitarDespesa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuitarParcial = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbReceber = new System.Windows.Forms.RadioButton();
            this.rdbPagar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.codtiposervico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiposerv_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiposerv_velor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiposerv_temposervico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnEstornar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.dgvServico);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BtnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnEstornar);
            this.splitContainer1.Panel2.Controls.Add(this.btnSair);
            this.splitContainer1.Panel2.Controls.Add(this.btnQuitar);
            this.splitContainer1.Size = new System.Drawing.Size(650, 467);
            this.splitContainer1.SplitterDistance = 390;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnQuitarParcial);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 130);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnQuitarParcial
            // 
            this.btnQuitarParcial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuitarParcial.Location = new System.Drawing.Point(481, 57);
            this.btnQuitarParcial.Name = "btnQuitarParcial";
            this.btnQuitarParcial.Size = new System.Drawing.Size(97, 38);
            this.btnQuitarParcial.TabIndex = 14;
            this.btnQuitarParcial.Text = "Quitar Parcial";
            this.btnQuitarParcial.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.rdbReceber);
            this.groupBox2.Controls.Add(this.rdbPagar);
            this.groupBox2.Location = new System.Drawing.Point(162, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 65);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contas";
            // 
            // rdbReceber
            // 
            this.rdbReceber.AutoSize = true;
            this.rdbReceber.Location = new System.Drawing.Point(105, 28);
            this.rdbReceber.Name = "rdbReceber";
            this.rdbReceber.Size = new System.Drawing.Size(66, 17);
            this.rdbReceber.TabIndex = 24;
            this.rdbReceber.TabStop = true;
            this.rdbReceber.Text = "Receber";
            this.rdbReceber.UseVisualStyleBackColor = true;
            // 
            // rdbPagar
            // 
            this.rdbPagar.AutoSize = true;
            this.rdbPagar.Location = new System.Drawing.Point(17, 28);
            this.rdbPagar.Name = "rdbPagar";
            this.rdbPagar.Size = new System.Drawing.Size(53, 17);
            this.rdbPagar.TabIndex = 23;
            this.rdbPagar.TabStop = true;
            this.rdbPagar.Text = "Pagar";
            this.rdbPagar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "De:";
            // 
            // dgvServico
            // 
            this.dgvServico.AllowUserToAddRows = false;
            this.dgvServico.AllowUserToDeleteRows = false;
            this.dgvServico.BackgroundColor = System.Drawing.Color.White;
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codtiposervico,
            this.tiposerv_descricao,
            this.tiposerv_velor,
            this.tiposerv_temposervico});
            this.dgvServico.Location = new System.Drawing.Point(21, 157);
            this.dgvServico.Name = "dgvServico";
            this.dgvServico.ReadOnly = true;
            this.dgvServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServico.Size = new System.Drawing.Size(604, 212);
            this.dgvServico.TabIndex = 12;
            // 
            // codtiposervico
            // 
            this.codtiposervico.DataPropertyName = "codtiposervico";
            this.codtiposervico.HeaderText = "Cód";
            this.codtiposervico.Name = "codtiposervico";
            this.codtiposervico.ReadOnly = true;
            this.codtiposervico.Width = 50;
            // 
            // tiposerv_descricao
            // 
            this.tiposerv_descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tiposerv_descricao.DataPropertyName = "tiposerv_descricao";
            this.tiposerv_descricao.HeaderText = "Tipo Serviço";
            this.tiposerv_descricao.Name = "tiposerv_descricao";
            this.tiposerv_descricao.ReadOnly = true;
            // 
            // tiposerv_velor
            // 
            this.tiposerv_velor.DataPropertyName = "tiposerv_velor";
            this.tiposerv_velor.HeaderText = "Valor Serviço (R$)";
            this.tiposerv_velor.Name = "tiposerv_velor";
            this.tiposerv_velor.ReadOnly = true;
            // 
            // tiposerv_temposervico
            // 
            this.tiposerv_temposervico.DataPropertyName = "tiposerv_temposervico";
            this.tiposerv_temposervico.HeaderText = "Tempo Estimado";
            this.tiposerv_temposervico.Name = "tiposerv_temposervico";
            this.tiposerv_temposervico.ReadOnly = true;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.Location = new System.Drawing.Point(550, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 46);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuitar.Location = new System.Drawing.Point(21, 12);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(90, 46);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(20, 93);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker2.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Até:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(206, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 17);
            this.radioButton1.TabIndex = 25;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Receber";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnEstornar
            // 
            this.btnEstornar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEstornar.Location = new System.Drawing.Point(117, 12);
            this.btnEstornar.Name = "btnEstornar";
            this.btnEstornar.Size = new System.Drawing.Size(90, 46);
            this.btnEstornar.TabIndex = 12;
            this.btnEstornar.Text = "Estornar";
            this.btnEstornar.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCancelar.Location = new System.Drawing.Point(213, 12);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(90, 46);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // QuitarDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(673, 488);
            this.Controls.Add(this.splitContainer1);
            this.Name = "QuitarDespesa";
            this.Text = "QuitarDespesa";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Button btnQuitarParcial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdbReceber;
        private System.Windows.Forms.RadioButton rdbPagar;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn codtiposervico;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposerv_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposerv_velor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposerv_temposervico;
        public System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.Button btnEstornar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnQuitar;
    }
}