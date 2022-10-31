
namespace Estudio201238
{
    partial class cadModal
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
            this.grpCadModal = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAulas = new System.Windows.Forms.TextBox();
            this.txtAlunos = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCadModal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCadModal
            // 
            this.grpCadModal.Controls.Add(this.btnSair);
            this.grpCadModal.Controls.Add(this.btnExcluir);
            this.grpCadModal.Controls.Add(this.btnCad);
            this.grpCadModal.Controls.Add(this.label4);
            this.grpCadModal.Controls.Add(this.label3);
            this.grpCadModal.Controls.Add(this.label2);
            this.grpCadModal.Controls.Add(this.txtAulas);
            this.grpCadModal.Controls.Add(this.txtAlunos);
            this.grpCadModal.Controls.Add(this.txtPreco);
            this.grpCadModal.Controls.Add(this.txtDesc);
            this.grpCadModal.Controls.Add(this.label1);
            this.grpCadModal.Location = new System.Drawing.Point(18, 19);
            this.grpCadModal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCadModal.Name = "grpCadModal";
            this.grpCadModal.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCadModal.Size = new System.Drawing.Size(614, 481);
            this.grpCadModal.TabIndex = 0;
            this.grpCadModal.TabStop = false;
            this.grpCadModal.Text = "Modalidades";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(492, 425);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(115, 48);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(11, 252);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(596, 43);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(11, 180);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(596, 43);
            this.btnCad.TabIndex = 1;
            this.btnCad.Text = "Cadastrar ";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Qtd. de Aulas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Qtd. de Alunos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preço:";
            // 
            // txtAulas
            // 
            this.txtAulas.Location = new System.Drawing.Point(128, 132);
            this.txtAulas.Name = "txtAulas";
            this.txtAulas.Size = new System.Drawing.Size(460, 29);
            this.txtAulas.TabIndex = 4;
            // 
            // txtAlunos
            // 
            this.txtAlunos.Location = new System.Drawing.Point(128, 97);
            this.txtAlunos.Name = "txtAlunos";
            this.txtAlunos.Size = new System.Drawing.Size(460, 29);
            this.txtAlunos.TabIndex = 3;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(128, 62);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(460, 29);
            this.txtPreco.TabIndex = 2;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(128, 27);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(460, 29);
            this.txtDesc.TabIndex = 1;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            this.txtDesc.Leave += new System.EventHandler(this.txtDesc_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // cadModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.grpCadModal);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "cadModal";
            this.Text = "Cadastro de Modalidades";
            this.grpCadModal.ResumeLayout(false);
            this.grpCadModal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCadModal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAulas;
        private System.Windows.Forms.TextBox txtAlunos;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
    }
}