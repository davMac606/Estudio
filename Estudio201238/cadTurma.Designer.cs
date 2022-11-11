
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
            this.txtIDModal = new System.Windows.Forms.TextBox();
            this.dtHoraComeco = new System.Windows.Forms.DateTimePicker();
            this.chkAtiva = new System.Windows.Forms.CheckBox();
            this.btnModal = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.lsbDias = new System.Windows.Forms.ListBox();
            this.txtAlunos = new System.Windows.Forms.TextBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtHoraFim = new System.Windows.Forms.DateTimePicker();
            this.lblLimite = new System.Windows.Forms.Label();
            this.grpCadTurma.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCadTurma
            // 
            this.grpCadTurma.Controls.Add(this.lblLimite);
            this.grpCadTurma.Controls.Add(this.dtHoraFim);
            this.grpCadTurma.Controls.Add(this.label6);
            this.grpCadTurma.Controls.Add(this.label5);
            this.grpCadTurma.Controls.Add(this.label4);
            this.grpCadTurma.Controls.Add(this.txtIDModal);
            this.grpCadTurma.Controls.Add(this.dtHoraComeco);
            this.grpCadTurma.Controls.Add(this.chkAtiva);
            this.grpCadTurma.Controls.Add(this.btnModal);
            this.grpCadTurma.Controls.Add(this.btnCadastro);
            this.grpCadTurma.Controls.Add(this.lsbDias);
            this.grpCadTurma.Controls.Add(this.txtAlunos);
            this.grpCadTurma.Controls.Add(this.txtProfessor);
            this.grpCadTurma.Controls.Add(this.label3);
            this.grpCadTurma.Controls.Add(this.label2);
            this.grpCadTurma.Controls.Add(this.label1);
            this.grpCadTurma.Location = new System.Drawing.Point(12, 12);
            this.grpCadTurma.Name = "grpCadTurma";
            this.grpCadTurma.Size = new System.Drawing.Size(737, 591);
            this.grpCadTurma.TabIndex = 0;
            this.grpCadTurma.TabStop = false;
            this.grpCadTurma.Text = "Turmas";
            // 
            // txtIDModal
            // 
            this.txtIDModal.Location = new System.Drawing.Point(49, 202);
            this.txtIDModal.Name = "txtIDModal";
            this.txtIDModal.Size = new System.Drawing.Size(29, 29);
            this.txtIDModal.TabIndex = 15;
            // 
            // dtHoraComeco
            // 
            this.dtHoraComeco.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraComeco.Location = new System.Drawing.Point(130, 159);
            this.dtHoraComeco.Name = "dtHoraComeco";
            this.dtHoraComeco.Size = new System.Drawing.Size(200, 29);
            this.dtHoraComeco.TabIndex = 14;
            this.dtHoraComeco.ValueChanged += new System.EventHandler(this.dtHoraComeco_ValueChanged);
            // 
            // chkAtiva
            // 
            this.chkAtiva.AutoSize = true;
            this.chkAtiva.Checked = true;
            this.chkAtiva.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtiva.Enabled = false;
            this.chkAtiva.Location = new System.Drawing.Point(667, 65);
            this.chkAtiva.Name = "chkAtiva";
            this.chkAtiva.Size = new System.Drawing.Size(64, 25);
            this.chkAtiva.TabIndex = 13;
            this.chkAtiva.Text = "Ativa";
            this.chkAtiva.UseVisualStyleBackColor = true;
            // 
            // btnModal
            // 
            this.btnModal.Location = new System.Drawing.Point(84, 198);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(200, 35);
            this.btnModal.TabIndex = 12;
            this.btnModal.Text = "Escolha uma Modalidade";
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.btnModal_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(10, 533);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(721, 43);
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
            this.lsbDias.Location = new System.Drawing.Point(136, 65);
            this.lsbDias.Name = "lsbDias";
            this.lsbDias.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsbDias.Size = new System.Drawing.Size(120, 88);
            this.lsbDias.TabIndex = 10;
            // 
            // txtAlunos
            // 
            this.txtAlunos.Location = new System.Drawing.Point(460, 22);
            this.txtAlunos.Name = "txtAlunos";
            this.txtAlunos.Size = new System.Drawing.Size(271, 29);
            this.txtAlunos.TabIndex = 5;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(91, 22);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(213, 29);
            this.txtProfessor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de Alunos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dias da Semana:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Professor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hora de início:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Hora de encerramento:";
            // 
            // dtHoraFim
            // 
            this.dtHoraFim.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraFim.Location = new System.Drawing.Point(511, 159);
            this.dtHoraFim.Name = "dtHoraFim";
            this.dtHoraFim.Size = new System.Drawing.Size(220, 29);
            this.dtHoraFim.TabIndex = 19;
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(480, 54);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(0, 21);
            this.lblLimite.TabIndex = 20;
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
        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.CheckBox chkAtiva;
        private System.Windows.Forms.DateTimePicker dtHoraComeco;
        public System.Windows.Forms.TextBox txtIDModal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtHoraFim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLimite;
    }
}