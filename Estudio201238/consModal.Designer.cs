
namespace Estudio201238
{
    partial class consModal
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
            this.grpCons = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtAulas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlunos = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDesc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.grpCons.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCons
            // 
            this.grpCons.Controls.Add(this.txtID);
            this.grpCons.Controls.Add(this.label5);
            this.grpCons.Controls.Add(this.btnSalvar);
            this.grpCons.Controls.Add(this.btnAtualizar);
            this.grpCons.Controls.Add(this.txtAulas);
            this.grpCons.Controls.Add(this.label4);
            this.grpCons.Controls.Add(this.label3);
            this.grpCons.Controls.Add(this.txtAlunos);
            this.grpCons.Controls.Add(this.txtPreco);
            this.grpCons.Controls.Add(this.label2);
            this.grpCons.Controls.Add(this.cbxDesc);
            this.grpCons.Controls.Add(this.label1);
            this.grpCons.Location = new System.Drawing.Point(12, 12);
            this.grpCons.Name = "grpCons";
            this.grpCons.Size = new System.Drawing.Size(614, 414);
            this.grpCons.TabIndex = 0;
            this.grpCons.TabStop = false;
            this.grpCons.Text = "Modalidades";
            this.grpCons.Enter += new System.EventHandler(this.grpCons_Enter);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(506, 166);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 51);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(6, 367);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(595, 41);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtAulas
            // 
            this.txtAulas.Location = new System.Drawing.Point(170, 131);
            this.txtAulas.Name = "txtAulas";
            this.txtAulas.Size = new System.Drawing.Size(431, 29);
            this.txtAulas.TabIndex = 6;
            this.txtAulas.TextChanged += new System.EventHandler(this.txtAulas_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Qtd. de Aulas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Qtd. de Alunos:";
            // 
            // txtAlunos
            // 
            this.txtAlunos.Location = new System.Drawing.Point(170, 96);
            this.txtAlunos.Name = "txtAlunos";
            this.txtAlunos.Size = new System.Drawing.Size(431, 29);
            this.txtAlunos.TabIndex = 4;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(170, 61);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(431, 29);
            this.txtPreco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço:";
            // 
            // cbxDesc
            // 
            this.cbxDesc.FormattingEnabled = true;
            this.cbxDesc.Location = new System.Drawing.Point(170, 28);
            this.cbxDesc.Name = "cbxDesc";
            this.cbxDesc.Size = new System.Drawing.Size(431, 29);
            this.cbxDesc.TabIndex = 1;
            this.cbxDesc.SelectedIndexChanged += new System.EventHandler(this.cbxDesc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(1101, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 51);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID da Modalidade:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(307, 173);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(29, 29);
            this.txtID.TabIndex = 10;
            // 
            // consModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.grpCons);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "consModal";
            this.Text = "Consulta de Modalidade";
            this.Load += new System.EventHandler(this.consModal_Load);
            this.grpCons.ResumeLayout(false);
            this.grpCons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCons;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtAulas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlunos;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
    }
}