namespace Limites
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
            btnLimpar = new Button();
            btnLimites = new Button();
            btnSair = new Button();
            txtInicial = new TextBox();
            txtLimite = new TextBox();
            ltbLista = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F);
            label1.Location = new Point(39, 57);
            label1.Name = "label1";
            label1.Size = new Size(138, 24);
            label1.TabIndex = 0;
            label1.Text = "Limite Inicial: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F);
            label2.Location = new Point(39, 128);
            label2.Name = "label2";
            label2.Size = new Size(129, 24);
            label2.TabIndex = 1;
            label2.Text = "Limite Final: ";
            label2.Click += label2_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLimpar.Location = new Point(169, 196);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(123, 42);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnLimites
            // 
            btnLimites.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLimites.Location = new Point(36, 196);
            btnLimites.Name = "btnLimites";
            btnLimites.Size = new Size(123, 42);
            btnLimites.TabIndex = 4;
            btnLimites.Text = "LIMITES";
            btnLimites.UseVisualStyleBackColor = true;
            btnLimites.Click += btnLimites_Click;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSair.Location = new Point(305, 196);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(123, 42);
            btnSair.TabIndex = 5;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // txtInicial
            // 
            txtInicial.Location = new Point(183, 60);
            txtInicial.Name = "txtInicial";
            txtInicial.Size = new Size(142, 23);
            txtInicial.TabIndex = 6;
            // 
            // txtLimite
            // 
            txtLimite.Location = new Point(183, 131);
            txtLimite.Name = "txtLimite";
            txtLimite.Size = new Size(142, 23);
            txtLimite.TabIndex = 7;
            // 
            // ltbLista
            // 
            ltbLista.FormattingEnabled = true;
            ltbLista.ItemHeight = 15;
            ltbLista.Location = new Point(39, 264);
            ltbLista.Name = "ltbLista";
            ltbLista.Size = new Size(389, 169);
            ltbLista.TabIndex = 8;
            ltbLista.SelectedIndexChanged += ltbLista_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 450);
            Controls.Add(ltbLista);
            Controls.Add(txtLimite);
            Controls.Add(txtInicial);
            Controls.Add(btnSair);
            Controls.Add(btnLimites);
            Controls.Add(btnLimpar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "PROGRAMA LIMITES";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnLimpar;
        private Button btnLimites;
        private Button btnSair;
        private TextBox txtInicial;
        private TextBox txtLimite;
        private ListBox ltbLista;
    }
}
