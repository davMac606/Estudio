
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grpCons
            // 
            this.grpCons.Location = new System.Drawing.Point(12, 12);
            this.grpCons.Name = "grpCons";
            this.grpCons.Size = new System.Drawing.Size(529, 345);
            this.grpCons.TabIndex = 0;
            this.grpCons.TabStop = false;
            this.grpCons.Text = "Modalidades";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCons;
        private System.Windows.Forms.Button btnVoltar;
    }
}