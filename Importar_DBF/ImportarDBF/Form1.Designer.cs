namespace ImportarDBF
{
    partial class Form1
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
            this.btnProcurar = new System.Windows.Forms.Button();
            this.gdvDados = new System.Windows.Forms.DataGridView();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.lblFilename = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(480, 19);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(32, 23);
            this.btnProcurar.TabIndex = 1;
            this.btnProcurar.Text = "...";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.button1_Click);
            // 
            // gdvDados
            // 
            this.gdvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvDados.Location = new System.Drawing.Point(12, 51);
            this.gdvDados.Name = "gdvDados";
            this.gdvDados.Size = new System.Drawing.Size(572, 261);
            this.gdvDados.TabIndex = 2;
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Location = new System.Drawing.Point(95, 21);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(379, 20);
            this.txtNomeArquivo.TabIndex = 28;
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename.Location = new System.Drawing.Point(15, 24);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(78, 13);
            this.lblFilename.TabIndex = 27;
            this.lblFilename.Text = "Arquivo DBF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 324);
            this.Controls.Add(this.txtNomeArquivo);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.gdvDados);
            this.Controls.Add(this.btnProcurar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar DBF ";
            ((System.ComponentModel.ISupportInitialize)(this.gdvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.DataGridView gdvDados;
        private System.Windows.Forms.TextBox txtNomeArquivo;
        private System.Windows.Forms.Label lblFilename;
    }
}

