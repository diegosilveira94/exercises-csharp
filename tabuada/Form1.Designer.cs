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
            label1 = new Label();
            textBox1 = new TextBox();
            lbResult = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 21);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 0;
            label1.Text = "Número:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // lbResult
            // 
            lbResult.FormattingEnabled = true;
            lbResult.ItemHeight = 15;
            lbResult.Location = new Point(12, 66);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(141, 304);
            lbResult.TabIndex = 2;
            lbResult.SelectedIndexChanged += lbResult_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold);
            button1.Location = new Point(168, 105);
            button1.Name = "button1";
            button1.Size = new Size(93, 37);
            button1.TabIndex = 3;
            button1.Text = "&TABUADA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold);
            button2.Location = new Point(168, 185);
            button2.Name = "button2";
            button2.Size = new Size(93, 36);
            button2.TabIndex = 4;
            button2.Text = "&LIMPAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold);
            button3.Location = new Point(168, 269);
            button3.Name = "button3";
            button3.Size = new Size(93, 36);
            button3.TabIndex = 5;
            button3.Text = "&SAIR";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 384);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbResult);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tábuada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ListBox lbResult;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
