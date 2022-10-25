
namespace Estudio201238
{
    partial class gerenModal
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
            this.btnCadModal = new System.Windows.Forms.Button();
            this.btnConsModal = new System.Windows.Forms.Button();
            this.btnExcModal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadModal
            // 
            this.btnCadModal.Location = new System.Drawing.Point(18, 19);
            this.btnCadModal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadModal.Name = "btnCadModal";
            this.btnCadModal.Size = new System.Drawing.Size(201, 37);
            this.btnCadModal.TabIndex = 1;
            this.btnCadModal.Text = "Cadastrar Modalidade";
            this.btnCadModal.UseVisualStyleBackColor = true;
            this.btnCadModal.Click += new System.EventHandler(this.btnCadModal_Click);
            // 
            // btnConsModal
            // 
            this.btnConsModal.Location = new System.Drawing.Point(18, 64);
            this.btnConsModal.Name = "btnConsModal";
            this.btnConsModal.Size = new System.Drawing.Size(201, 35);
            this.btnConsModal.TabIndex = 2;
            this.btnConsModal.Text = "Consultar Modalidade";
            this.btnConsModal.UseVisualStyleBackColor = true;
            // 
            // btnExcModal
            // 
            this.btnExcModal.Location = new System.Drawing.Point(18, 105);
            this.btnExcModal.Name = "btnExcModal";
            this.btnExcModal.Size = new System.Drawing.Size(201, 35);
            this.btnExcModal.TabIndex = 3;
            this.btnExcModal.Text = "Excluir Modalidade";
            this.btnExcModal.UseVisualStyleBackColor = true;
            // 
            // gerenModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.btnExcModal);
            this.Controls.Add(this.btnConsModal);
            this.Controls.Add(this.btnCadModal);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "gerenModal";
            this.Text = "gerenModal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadModal;
        private System.Windows.Forms.Button btnConsModal;
        private System.Windows.Forms.Button btnExcModal;
    }
}