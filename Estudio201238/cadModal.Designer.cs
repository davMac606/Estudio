
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpCadModal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCadModal
            // 
            this.grpCadModal.Controls.Add(this.label1);
            this.grpCadModal.Location = new System.Drawing.Point(18, 19);
            this.grpCadModal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCadModal.Name = "grpCadModal";
            this.grpCadModal.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCadModal.Size = new System.Drawing.Size(560, 481);
            this.grpCadModal.TabIndex = 0;
            this.grpCadModal.TabStop = false;
            this.grpCadModal.Text = "Modalidades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descricao:";
            // 
            // cadModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.grpCadModal);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
    }
}