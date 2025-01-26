namespace CalculadoraMotor3F
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
            label1 = new Label();
            textBoxPotencia = new TextBox();
            textBoxTensao = new TextBox();
            textBoxRendimento = new TextBox();
            textBoxFatorPotencia = new TextBox();
            buttonCalcular = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonLimparCampos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.BackColor = Color.LightBlue;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(68, 48);
            label1.Name = "label1";
            label1.Size = new Size(500, 33);
            label1.TabIndex = 0;
            label1.Text = "CALCULE A CORRENTE NOMINAL DE MOTOR TRIFÁSICO";
            // 
            // textBoxPotencia
            // 
            textBoxPotencia.BackColor = Color.LightBlue;
            textBoxPotencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPotencia.Location = new Point(69, 137);
            textBoxPotencia.Name = "textBoxPotencia";
            textBoxPotencia.Size = new Size(140, 29);
            textBoxPotencia.TabIndex = 1;
            // 
            // textBoxTensao
            // 
            textBoxTensao.BackColor = Color.LightBlue;
            textBoxTensao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxTensao.Location = new Point(69, 213);
            textBoxTensao.Name = "textBoxTensao";
            textBoxTensao.Size = new Size(140, 29);
            textBoxTensao.TabIndex = 2;
            // 
            // textBoxRendimento
            // 
            textBoxRendimento.BackColor = Color.LightBlue;
            textBoxRendimento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxRendimento.Location = new Point(69, 291);
            textBoxRendimento.Name = "textBoxRendimento";
            textBoxRendimento.Size = new Size(140, 29);
            textBoxRendimento.TabIndex = 3;
            // 
            // textBoxFatorPotencia
            // 
            textBoxFatorPotencia.BackColor = Color.LightBlue;
            textBoxFatorPotencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxFatorPotencia.Location = new Point(69, 371);
            textBoxFatorPotencia.Name = "textBoxFatorPotencia";
            textBoxFatorPotencia.Size = new Size(140, 29);
            textBoxFatorPotencia.TabIndex = 4;
            // 
            // buttonCalcular
            // 
            buttonCalcular.BackColor = Color.LightBlue;
            buttonCalcular.Cursor = Cursors.Hand;
            buttonCalcular.FlatAppearance.BorderColor = Color.Blue;
            buttonCalcular.FlatAppearance.BorderSize = 2;
            buttonCalcular.FlatStyle = FlatStyle.Popup;
            buttonCalcular.Font = new Font("Microsoft Sans Serif", 16.75F, FontStyle.Bold);
            buttonCalcular.ForeColor = Color.MidnightBlue;
            buttonCalcular.Image = (Image)resources.GetObject("buttonCalcular.Image");
            buttonCalcular.Location = new Point(290, 113);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(278, 129);
            buttonCalcular.TabIndex = 5;
            buttonCalcular.Text = "CALCULAR";
            buttonCalcular.UseVisualStyleBackColor = false;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightBlue;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(69, 113);
            label2.Name = "label2";
            label2.Size = new Size(140, 21);
            label2.TabIndex = 7;
            label2.Text = "Potência em Watts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightBlue;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(69, 189);
            label3.Name = "label3";
            label3.Size = new Size(123, 21);
            label3.TabIndex = 8;
            label3.Text = "Tensão em Volts";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightBlue;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(69, 267);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 9;
            label4.Text = "Rendimento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightBlue;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(69, 347);
            label5.Name = "label5";
            label5.Size = new Size(132, 21);
            label5.TabIndex = 10;
            label5.Text = "Fator de potência";
            // 
            // buttonLimparCampos
            // 
            buttonLimparCampos.BackColor = Color.LightBlue;
            buttonLimparCampos.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimparCampos.Location = new Point(290, 351);
            buttonLimparCampos.Name = "buttonLimparCampos";
            buttonLimparCampos.Size = new Size(278, 49);
            buttonLimparCampos.TabIndex = 11;
            buttonLimparCampos.Text = "LIMPAR";
            buttonLimparCampos.UseVisualStyleBackColor = false;
            buttonLimparCampos.Click += buttonLimparCampos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(642, 455);
            Controls.Add(buttonLimparCampos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonCalcular);
            Controls.Add(textBoxFatorPotencia);
            Controls.Add(textBoxRendimento);
            Controls.Add(textBoxTensao);
            Controls.Add(textBoxPotencia);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(658, 494);
            MinimumSize = new Size(658, 494);
            Name = "Form1";
            ShowIcon = false;
            Text = "Calculo Motor Trifásico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxPotencia;
        private TextBox textBoxTensao;
        private TextBox textBoxRendimento;
        private TextBox textBoxFatorPotencia;
        public Button buttonCalcular;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonLimparCampos;
    }
}
