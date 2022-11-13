
namespace Estudio201238
{
    partial class cadTurma
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
            this.grpCadTurma = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.grpListas = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxDesc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDModal = new System.Windows.Forms.TextBox();
            this.lblLimite = new System.Windows.Forms.Label();
            this.dtHoraFim = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtHoraComeco = new System.Windows.Forms.DateTimePicker();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.lsbDias = new System.Windows.Forms.ListBox();
            this.txtAlunos = new System.Windows.Forms.TextBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.grpCadTurma.SuspendLayout();
            this.grpListas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCadTurma
            // 
            this.grpCadTurma.Controls.Add(this.btnVoltar);
            this.grpCadTurma.Controls.Add(this.txtNome);
            this.grpCadTurma.Controls.Add(this.label7);
            this.grpCadTurma.Controls.Add(this.txtHora);
            this.grpCadTurma.Controls.Add(this.txtDias);
            this.grpCadTurma.Controls.Add(this.grpListas);
            this.grpCadTurma.Controls.Add(this.lblLimite);
            this.grpCadTurma.Controls.Add(this.dtHoraFim);
            this.grpCadTurma.Controls.Add(this.label6);
            this.grpCadTurma.Controls.Add(this.label5);
            this.grpCadTurma.Controls.Add(this.dtHoraComeco);
            this.grpCadTurma.Controls.Add(this.btnCadastro);
            this.grpCadTurma.Controls.Add(this.lsbDias);
            this.grpCadTurma.Controls.Add(this.txtAlunos);
            this.grpCadTurma.Controls.Add(this.txtProfessor);
            this.grpCadTurma.Controls.Add(this.label3);
            this.grpCadTurma.Controls.Add(this.label2);
            this.grpCadTurma.Controls.Add(this.label1);
            this.grpCadTurma.Location = new System.Drawing.Point(12, 12);
            this.grpCadTurma.Name = "grpCadTurma";
            this.grpCadTurma.Size = new System.Drawing.Size(1176, 702);
            this.grpCadTurma.TabIndex = 0;
            this.grpCadTurma.TabStop = false;
            this.grpCadTurma.Text = "Turmas";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(136, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(213, 29);
            this.txtNome.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Nome da Turma:";
            // 
            // txtHora
            // 
            this.txtHora.Enabled = false;
            this.txtHora.Location = new System.Drawing.Point(728, 290);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 29);
            this.txtHora.TabIndex = 27;
            this.txtHora.TextChanged += new System.EventHandler(this.txtHora_TextChanged);
            // 
            // txtDias
            // 
            this.txtDias.Enabled = false;
            this.txtDias.Location = new System.Drawing.Point(262, 229);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(181, 29);
            this.txtDias.TabIndex = 26;
            // 
            // grpListas
            // 
            this.grpListas.Controls.Add(this.label8);
            this.grpListas.Controls.Add(this.cbxDesc);
            this.grpListas.Controls.Add(this.label4);
            this.grpListas.Controls.Add(this.txtIDModal);
            this.grpListas.Location = new System.Drawing.Point(252, 325);
            this.grpListas.Name = "grpListas";
            this.grpListas.Size = new System.Drawing.Size(572, 322);
            this.grpListas.TabIndex = 25;
            this.grpListas.TabStop = false;
            this.grpListas.Text = "ID\'s e suas Modalidades:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "Modalidade:";
            // 
            // cbxDesc
            // 
            this.cbxDesc.FormattingEnabled = true;
            this.cbxDesc.Location = new System.Drawing.Point(175, 79);
            this.cbxDesc.Name = "cbxDesc";
            this.cbxDesc.Size = new System.Drawing.Size(391, 29);
            this.cbxDesc.TabIndex = 24;
            this.cbxDesc.SelectedIndexChanged += new System.EventHandler(this.cbxDesc_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID:";
            // 
            // txtIDModal
            // 
            this.txtIDModal.Location = new System.Drawing.Point(175, 113);
            this.txtIDModal.Name = "txtIDModal";
            this.txtIDModal.Size = new System.Drawing.Size(29, 29);
            this.txtIDModal.TabIndex = 15;
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(480, 54);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(0, 21);
            this.lblLimite.TabIndex = 20;
            // 
            // dtHoraFim
            // 
            this.dtHoraFim.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraFim.Location = new System.Drawing.Point(502, 290);
            this.dtHoraFim.Name = "dtHoraFim";
            this.dtHoraFim.Size = new System.Drawing.Size(220, 29);
            this.dtHoraFim.TabIndex = 19;
            this.dtHoraFim.Value = new System.DateTime(2022, 11, 12, 0, 0, 0, 0);
            this.dtHoraFim.ValueChanged += new System.EventHandler(this.dtHoraFim_ValueChanged);
            this.dtHoraFim.Leave += new System.EventHandler(this.dtHoraFim_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Hora de encerramento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hora de início:";
            // 
            // dtHoraComeco
            // 
            this.dtHoraComeco.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraComeco.Location = new System.Drawing.Point(121, 290);
            this.dtHoraComeco.Name = "dtHoraComeco";
            this.dtHoraComeco.Size = new System.Drawing.Size(200, 29);
            this.dtHoraComeco.TabIndex = 14;
            this.dtHoraComeco.Value = new System.DateTime(2022, 11, 12, 0, 0, 0, 0);
            this.dtHoraComeco.ValueChanged += new System.EventHandler(this.dtHoraComeco_ValueChanged);
            this.dtHoraComeco.Leave += new System.EventHandler(this.dtHoraComeco_Leave);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(6, 653);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(1164, 43);
            this.btnCadastro.TabIndex = 11;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // lsbDias
            // 
            this.lsbDias.FormattingEnabled = true;
            this.lsbDias.ItemHeight = 21;
            this.lsbDias.Items.AddRange(new object[] {
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira"});
            this.lsbDias.Location = new System.Drawing.Point(136, 196);
            this.lsbDias.Name = "lsbDias";
            this.lsbDias.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsbDias.Size = new System.Drawing.Size(120, 88);
            this.lsbDias.TabIndex = 10;
            this.lsbDias.SelectedIndexChanged += new System.EventHandler(this.lsbDias_SelectedIndexChanged);
            this.lsbDias.Leave += new System.EventHandler(this.lsbDias_Leave);
            // 
            // txtAlunos
            // 
            this.txtAlunos.Location = new System.Drawing.Point(493, 161);
            this.txtAlunos.Name = "txtAlunos";
            this.txtAlunos.Size = new System.Drawing.Size(335, 29);
            this.txtAlunos.TabIndex = 5;
            this.txtAlunos.Leave += new System.EventHandler(this.txtAlunos_Leave);
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(136, 161);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(213, 29);
            this.txtProfessor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de Alunos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dias da Semana:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Professor:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(1020, 25);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(150, 50);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cadTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 726);
            this.Controls.Add(this.grpCadTurma);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "cadTurma";
            this.Text = "Cadastro de Turmas";
            this.Load += new System.EventHandler(this.cadTurma_Load);
            this.grpCadTurma.ResumeLayout(false);
            this.grpCadTurma.PerformLayout();
            this.grpListas.ResumeLayout(false);
            this.grpListas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCadTurma;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlunos;
        private System.Windows.Forms.ListBox lsbDias;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.DateTimePicker dtHoraComeco;
        public System.Windows.Forms.TextBox txtIDModal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtHoraFim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.ComboBox cbxDesc;
        private System.Windows.Forms.GroupBox grpListas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnVoltar;
    }
}