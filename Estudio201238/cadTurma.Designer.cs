
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.txtAlunos = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.grpCadTurma.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCadTurma
            // 
            this.grpCadTurma.Controls.Add(this.btnCadastro);
            this.grpCadTurma.Controls.Add(this.listBox1);
            this.grpCadTurma.Controls.Add(this.txtAlunos);
            this.grpCadTurma.Controls.Add(this.txtProfessor);
            this.grpCadTurma.Controls.Add(this.label3);
            this.grpCadTurma.Controls.Add(this.label2);
            this.grpCadTurma.Controls.Add(this.label1);
            this.grpCadTurma.Location = new System.Drawing.Point(12, 12);
            this.grpCadTurma.Name = "grpCadTurma";
            this.grpCadTurma.Size = new System.Drawing.Size(694, 591);
            this.grpCadTurma.TabIndex = 0;
            this.grpCadTurma.TabStop = false;
            this.grpCadTurma.Text = "Turmas";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dias da Semana:";
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
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(91, 22);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(213, 29);
            this.txtProfessor.TabIndex = 3;
            // 
            // txtAlunos
            // 
            this.txtAlunos.Location = new System.Drawing.Point(460, 22);
            this.txtAlunos.Name = "txtAlunos";
            this.txtAlunos.Size = new System.Drawing.Size(213, 29);
            this.txtAlunos.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Items.AddRange(new object[] {
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira"});
            this.listBox1.Location = new System.Drawing.Point(136, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(120, 88);
            this.listBox1.TabIndex = 10;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(10, 533);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(678, 43);
            this.btnCadastro.TabIndex = 11;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCadastro;
    }
}