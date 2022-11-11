
namespace Estudio201238
{
    partial class gerenTurma
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
            this.btnCadastroTurma = new System.Windows.Forms.Button();
            this.btnConsultaTurma = new System.Windows.Forms.Button();
            this.btnBuscaTurma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroTurma
            // 
            this.btnCadastroTurma.Location = new System.Drawing.Point(12, 12);
            this.btnCadastroTurma.Name = "btnCadastroTurma";
            this.btnCadastroTurma.Size = new System.Drawing.Size(201, 37);
            this.btnCadastroTurma.TabIndex = 0;
            this.btnCadastroTurma.Text = "Cadastrar Turma";
            this.btnCadastroTurma.UseVisualStyleBackColor = true;
            this.btnCadastroTurma.Click += new System.EventHandler(this.btnCadastroTurma_Click);
            // 
            // btnConsultaTurma
            // 
            this.btnConsultaTurma.Location = new System.Drawing.Point(12, 65);
            this.btnConsultaTurma.Name = "btnConsultaTurma";
            this.btnConsultaTurma.Size = new System.Drawing.Size(201, 37);
            this.btnConsultaTurma.TabIndex = 1;
            this.btnConsultaTurma.Text = "Consultar Turma";
            this.btnConsultaTurma.UseVisualStyleBackColor = true;
            // 
            // btnBuscaTurma
            // 
            this.btnBuscaTurma.Location = new System.Drawing.Point(12, 117);
            this.btnBuscaTurma.Name = "btnBuscaTurma";
            this.btnBuscaTurma.Size = new System.Drawing.Size(201, 37);
            this.btnBuscaTurma.TabIndex = 2;
            this.btnBuscaTurma.Text = "Buscar Turma";
            this.btnBuscaTurma.UseVisualStyleBackColor = true;
            // 
            // gerenTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 726);
            this.Controls.Add(this.btnBuscaTurma);
            this.Controls.Add(this.btnConsultaTurma);
            this.Controls.Add(this.btnCadastroTurma);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "gerenTurma";
            this.Text = "gerenTurma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroTurma;
        private System.Windows.Forms.Button btnConsultaTurma;
        private System.Windows.Forms.Button btnBuscaTurma;
    }
}