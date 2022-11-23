
namespace Estudio201238
{
    partial class excModal
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
            this.grpExcModal = new System.Windows.Forms.GroupBox();
            this.cbxDesc = new System.Windows.Forms.ComboBox();
            this.btnExcModal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpExcModal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpExcModal
            // 
            this.grpExcModal.Controls.Add(this.cbxDesc);
            this.grpExcModal.Controls.Add(this.btnExcModal);
            this.grpExcModal.Controls.Add(this.label1);
            this.grpExcModal.Location = new System.Drawing.Point(18, 19);
            this.grpExcModal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpExcModal.Name = "grpExcModal";
            this.grpExcModal.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpExcModal.Size = new System.Drawing.Size(477, 375);
            this.grpExcModal.TabIndex = 0;
            this.grpExcModal.TabStop = false;
            this.grpExcModal.Text = "Modalidades";
            this.grpExcModal.Enter += new System.EventHandler(this.grpExcModal_Enter);
            // 
            // cbxDesc
            // 
            this.cbxDesc.FormattingEnabled = true;
            this.cbxDesc.Location = new System.Drawing.Point(93, 66);
            this.cbxDesc.Name = "cbxDesc";
            this.cbxDesc.Size = new System.Drawing.Size(373, 29);
            this.cbxDesc.Sorted = true;
            this.cbxDesc.TabIndex = 4;
            this.cbxDesc.SelectedIndexChanged += new System.EventHandler(this.cbxDesc_SelectedIndexChanged);
            // 
            // btnExcModal
            // 
            this.btnExcModal.Location = new System.Drawing.Point(7, 331);
            this.btnExcModal.Name = "btnExcModal";
            this.btnExcModal.Size = new System.Drawing.Size(459, 36);
            this.btnExcModal.TabIndex = 3;
            this.btnExcModal.Text = "Excluir";
            this.btnExcModal.UseVisualStyleBackColor = true;
            this.btnExcModal.Click += new System.EventHandler(this.btnExcModal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição:";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1093, 19);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(95, 51);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Voltar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // excModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.grpExcModal);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "excModal";
            this.Text = "Excluir Modalidade";
            this.Load += new System.EventHandler(this.excModal_Load);
            this.grpExcModal.ResumeLayout(false);
            this.grpExcModal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpExcModal;
        private System.Windows.Forms.Button btnExcModal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDesc;
        private System.Windows.Forms.Button btnSair;
    }
}