namespace practica2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMonto = new TextBox();
            montoInicial = new Label();
            porcentaje = new Label();
            txtPorcentaje = new TextBox();
            btnCalcular = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(96, 82);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(276, 23);
            txtMonto.TabIndex = 1;
            // 
            // montoInicial
            // 
            montoInicial.AutoSize = true;
            montoInicial.BackColor = SystemColors.ButtonFace;
            montoInicial.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            montoInicial.ForeColor = Color.FromArgb(0, 192, 0);
            montoInicial.Location = new Point(99, 41);
            montoInicial.Name = "montoInicial";
            montoInicial.Size = new Size(273, 25);
            montoInicial.TabIndex = 2;
            montoInicial.Text = "INGRESE UN MONTO INICIAL";
            // 
            // porcentaje
            // 
            porcentaje.AutoSize = true;
            porcentaje.BackColor = SystemColors.ButtonFace;
            porcentaje.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            porcentaje.Location = new Point(100, 131);
            porcentaje.Name = "porcentaje";
            porcentaje.Size = new Size(275, 30);
            porcentaje.TabIndex = 3;
            porcentaje.Text = "INGRESE UN PORCENTAJE";
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.Location = new Point(96, 197);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.Size = new Size(276, 23);
            txtPorcentaje.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.ForeColor = SystemColors.HotTrack;
            btnCalcular.Location = new Point(143, 249);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(190, 102);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(605, 131);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 15);
            lblMensaje.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMensaje);
            Controls.Add(btnCalcular);
            Controls.Add(txtPorcentaje);
            Controls.Add(porcentaje);
            Controls.Add(montoInicial);
            Controls.Add(txtMonto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMonto;
        private Label montoInicial;
        private Label porcentaje;
        private TextBox txtPorcentaje;
        private Button btnCalcular;
        private Label lblMensaje;
    }
}