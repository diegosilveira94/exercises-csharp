namespace tabuada
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
            lblNumero = new Label();
            txtNumero = new TextBox();
            lstTabuada = new ListBox();
            btnCalcular = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNumero.Location = new Point(66, 27);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(91, 25);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(162, 30);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // lstTabuada
            // 
            lstTabuada.FormattingEnabled = true;
            lstTabuada.ItemHeight = 15;
            lstTabuada.Location = new Point(23, 87);
            lstTabuada.Name = "lstTabuada";
            lstTabuada.Size = new Size(191, 334);
            lstTabuada.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(231, 261);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(99, 43);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(231, 320);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(99, 43);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(231, 378);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(99, 43);
            btnSair.TabIndex = 5;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 450);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(lstTabuada);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Name = "Form1";
            Text = "Tábuada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private TextBox txtNumero;
        private ListBox lstTabuada;
        private Button btnCalcular;
        private Button btnLimpar;
        private Button btnSair;
    }
}
