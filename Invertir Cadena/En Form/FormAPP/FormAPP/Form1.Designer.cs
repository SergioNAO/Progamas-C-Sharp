
namespace FormAPP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnInvertir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.Info;
            this.txtInput.Location = new System.Drawing.Point(117, 59);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(153, 20);
            this.txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.Info;
            this.txtOutput.Location = new System.Drawing.Point(117, 155);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(153, 20);
            this.txtOutput.TabIndex = 1;
            // 
            // btnInvertir
            // 
            this.btnInvertir.BackColor = System.Drawing.Color.Transparent;
            this.btnInvertir.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvertir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInvertir.Location = new System.Drawing.Point(138, 105);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(116, 23);
            this.btnInvertir.TabIndex = 2;
            this.btnInvertir.Text = "Invertir Texto";
            this.btnInvertir.UseVisualStyleBackColor = false;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(71, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresa el texto que deseas invertir:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(414, 199);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInvertir);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Ejercicio 1 Invertir Cadena";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.Label label1;
    }
}

