namespace Calculadora_Simples
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
            label5 = new Label();
            txbNum1 = new TextBox();
            txbNum2 = new TextBox();
            txbResult = new TextBox();
            btnSum = new Button();
            btnSubtract = new Button();
            btnClean = new Button();
            label4 = new Label();
            btnDivision = new Button();
            btnMultiple = new Button();
            btnExp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(47, 93);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 1;
            label2.Text = "Número 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.Location = new Point(47, 151);
            label3.Name = "label3";
            label3.Size = new Size(111, 30);
            label3.TabIndex = 2;
            label3.Text = "Número 2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(47, 211);
            label5.Name = "label5";
            label5.Size = new Size(116, 30);
            label5.TabIndex = 4;
            label5.Text = "Resultado:";
            label5.Click += label5_Click;
            // 
            // txbNum1
            // 
            txbNum1.Location = new Point(164, 100);
            txbNum1.Name = "txbNum1";
            txbNum1.Size = new Size(122, 23);
            txbNum1.TabIndex = 5;
            txbNum1.TextAlign = HorizontalAlignment.Center;
            txbNum1.TextChanged += txbNum1_TextChanged;
            // 
            // txbNum2
            // 
            txbNum2.Location = new Point(164, 158);
            txbNum2.Name = "txbNum2";
            txbNum2.Size = new Size(122, 23);
            txbNum2.TabIndex = 7;
            txbNum2.TextAlign = HorizontalAlignment.Center;
            txbNum2.TextChanged += txbNum2_TextChanged;
            // 
            // txbResult
            // 
            txbResult.Location = new Point(164, 218);
            txbResult.Name = "txbResult";
            txbResult.Size = new Size(122, 23);
            txbResult.TabIndex = 8;
            txbResult.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSum
            // 
            btnSum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSum.Location = new Point(16, 269);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(98, 49);
            btnSum.TabIndex = 9;
            btnSum.Text = "SOMAR";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubtract.Location = new Point(120, 271);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(98, 49);
            btnSubtract.TabIndex = 11;
            btnSubtract.Text = "DIMINUIR";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += button1_Click;
            // 
            // btnClean
            // 
            btnClean.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClean.Location = new Point(224, 323);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(98, 49);
            btnClean.TabIndex = 12;
            btnClean.Text = "LIMPAR";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += txbClean_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 28);
            label4.Name = "label4";
            label4.Size = new Size(257, 30);
            label4.TabIndex = 13;
            label4.Text = "CALCULADORA SIMPLES";
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivision.Location = new Point(120, 323);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(98, 49);
            btnDivision.TabIndex = 14;
            btnDivision.Text = "DIVIDIR";
            btnDivision.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnMultiple
            // 
            btnMultiple.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiple.Location = new Point(16, 322);
            btnMultiple.Name = "btnMultiple";
            btnMultiple.Size = new Size(98, 49);
            btnMultiple.TabIndex = 15;
            btnMultiple.Text = "MULTIPLICAR";
            btnMultiple.UseVisualStyleBackColor = true;
            btnMultiple.Click += button2_Click;
            // 
            // btnExp
            // 
            btnExp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExp.Location = new Point(224, 271);
            btnExp.Name = "btnExp";
            btnExp.Size = new Size(98, 49);
            btnExp.TabIndex = 16;
            btnExp.Text = "EXPONENCIAR";
            btnExp.UseVisualStyleBackColor = true;
            btnExp.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 377);
            Controls.Add(btnExp);
            Controls.Add(btnMultiple);
            Controls.Add(btnDivision);
            Controls.Add(label4);
            Controls.Add(btnClean);
            Controls.Add(btnSubtract);
            Controls.Add(btnSum);
            Controls.Add(txbResult);
            Controls.Add(txbNum2);
            Controls.Add(txbNum1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculadora Simples";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txbNum1;
        private TextBox txbNum2;
        private TextBox txbResult;
        private Button btnSum;
        private Button btnSubtract;
        private Button btnClean;
        private Label label4;
        private Button btnDivision;
        private Button btnMultiple;
        private Button btnExp;
    }
}
