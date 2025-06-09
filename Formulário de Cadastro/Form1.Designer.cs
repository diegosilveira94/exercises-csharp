namespace Terceiro_projeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtTitulo = new Label();
            txtNome = new Label();
            txtCelular = new Label();
            txtNascimento = new Label();
            txtFoto = new Label();
            tbxNome = new TextBox();
            calendario = new MonthCalendar();
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            listBox1 = new ListBox();
            btnFechar = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            btnFoto = new Button();
            pictboxFoto = new GroupBox();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pictboxFoto.SuspendLayout();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(89, 22);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(396, 33);
            txtTitulo.TabIndex = 0;
            txtTitulo.Text = "FORMULÁRIO DE CADASTRO";
            txtTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNome
            // 
            txtNome.AutoSize = true;
            txtNome.Font = new Font("Arial", 10F);
            txtNome.Location = new Point(41, 96);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(47, 16);
            txtNome.TabIndex = 1;
            txtNome.Text = "Nome:";
            // 
            // txtCelular
            // 
            txtCelular.AutoSize = true;
            txtCelular.Font = new Font("Arial", 10F);
            txtCelular.Location = new Point(41, 145);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(56, 16);
            txtCelular.TabIndex = 2;
            txtCelular.Text = "Celular:";
            // 
            // txtNascimento
            // 
            txtNascimento.AutoSize = true;
            txtNascimento.Font = new Font("Arial", 10F);
            txtNascimento.Location = new Point(41, 223);
            txtNascimento.Name = "txtNascimento";
            txtNascimento.Size = new Size(138, 16);
            txtNascimento.TabIndex = 3;
            txtNascimento.Text = "Data de Nascimento:";
            // 
            // txtFoto
            // 
            txtFoto.AutoSize = true;
            txtFoto.Font = new Font("Arial", 10F);
            txtFoto.Location = new Point(367, 94);
            txtFoto.Name = "txtFoto";
            txtFoto.Size = new Size(40, 16);
            txtFoto.TabIndex = 4;
            txtFoto.Text = "Foto:";
            // 
            // tbxNome
            // 
            tbxNome.Location = new Point(94, 95);
            tbxNome.Name = "tbxNome";
            tbxNome.Size = new Size(199, 23);
            tbxNome.TabIndex = 5;
            // 
            // calendario
            // 
            calendario.Location = new Point(41, 268);
            calendario.Name = "calendario";
            calendario.TabIndex = 7;
            calendario.DateChanged += calendario_DateChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F);
            label1.Location = new Point(340, 281);
            label1.Name = "label1";
            label1.Size = new Size(55, 16);
            label1.TabIndex = 8;
            label1.Text = "Estado:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(103, 143);
            maskedTextBox1.Mask = "(00) 00000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(112, 23);
            maskedTextBox1.TabIndex = 9;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "SC - Santa Catarina", "SP - São Paulo", "PR - Paraná" });
            listBox1.Location = new Point(312, 317);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(117, 64);
            listBox1.TabIndex = 10;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Arial", 10F);
            btnFechar.Location = new Point(489, 443);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(85, 34);
            btnFechar.TabIndex = 11;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(184, 221);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(108, 23);
            textBox1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnFoto
            // 
            btnFoto.BackColor = SystemColors.ButtonFace;
            btnFoto.Image = (Image)resources.GetObject("btnFoto.Image");
            btnFoto.Location = new Point(359, 114);
            btnFoto.Name = "btnFoto";
            btnFoto.RightToLeft = RightToLeft.Yes;
            btnFoto.Size = new Size(58, 62);
            btnFoto.TabIndex = 14;
            btnFoto.UseVisualStyleBackColor = false;
            btnFoto.Click += btnFoto_Click;
            // 
            // pictboxFoto
            // 
            pictboxFoto.Controls.Add(pictureBox1);
            pictboxFoto.Location = new Point(423, 84);
            pictboxFoto.Name = "pictboxFoto";
            pictboxFoto.Size = new Size(162, 166);
            pictboxFoto.TabIndex = 15;
            pictboxFoto.TabStop = false;
            pictboxFoto.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 472);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 16;
            label2.Text = "© É os Gurizes";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10F);
            button1.Location = new Point(389, 443);
            button1.Name = "button1";
            button1.Size = new Size(85, 34);
            button1.TabIndex = 17;
            button1.Text = "Próximo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 510);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(pictboxFoto);
            Controls.Add(btnFoto);
            Controls.Add(textBox1);
            Controls.Add(btnFechar);
            Controls.Add(listBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Controls.Add(calendario);
            Controls.Add(tbxNome);
            Controls.Add(txtFoto);
            Controls.Add(txtNascimento);
            Controls.Add(txtCelular);
            Controls.Add(txtNome);
            Controls.Add(txtTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Formulário de Cadastro";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pictboxFoto.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtTitulo;
        private Label txtNome;
        private Label txtCelular;
        private Label txtNascimento;
        private Label txtFoto;
        private TextBox tbxNome;
        private MonthCalendar calendario;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private ListBox listBox1;
        private Button btnFechar;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button btnFoto;
        private GroupBox pictboxFoto;
        private Label label2;
        private Button button1;
    }
}
