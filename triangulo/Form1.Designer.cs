namespace triangulo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnVerificar = new Button();
            txbLado1 = new TextBox();
            txbLado2 = new TextBox();
            txbLado3 = new TextBox();
            lbResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(25, 17);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Lado 1:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(25, 62);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Lado 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(25, 109);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Lado 3:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 207);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 3;
            label4.Text = "Resultado:";
            // 
            // btnVerificar
            // 
            btnVerificar.Font = new Font("Microsoft Sans Serif", 12F);
            btnVerificar.Location = new Point(81, 151);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(119, 36);
            btnVerificar.TabIndex = 4;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // txbLado1
            // 
            txbLado1.Location = new Point(100, 17);
            txbLado1.Name = "txbLado1";
            txbLado1.Size = new Size(113, 23);
            txbLado1.TabIndex = 5;
            // 
            // txbLado2
            // 
            txbLado2.Location = new Point(100, 63);
            txbLado2.Name = "txbLado2";
            txbLado2.Size = new Size(113, 23);
            txbLado2.TabIndex = 6;
            // 
            // txbLado3
            // 
            txbLado3.Location = new Point(100, 106);
            txbLado3.Name = "txbLado3";
            txbLado3.Size = new Size(113, 23);
            txbLado3.TabIndex = 7;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Enabled = false;
            lbResult.Font = new Font("Microsoft Sans Serif", 10F);
            lbResult.Location = new Point(120, 209);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(48, 17);
            lbResult.TabIndex = 8;
            lbResult.Text = "Result";
            lbResult.Click += lbResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 247);
            Controls.Add(lbResult);
            Controls.Add(txbLado3);
            Controls.Add(txbLado2);
            Controls.Add(txbLado1);
            Controls.Add(btnVerificar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "TRIÂNGULOS";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnVerificar;
        private TextBox txbLado1;
        private TextBox txbLado2;
        private TextBox txbLado3;
        private Label lbResult;
    }
}
