namespace MASHKAPG
{
    partial class RegistroClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroClientes));
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label13 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            nombres = new TextBox();
            apellidos = new TextBox();
            edad = new NumericUpDown();
            peso = new NumericUpDown();
            sexo = new ComboBox();
            email = new TextBox();
            celular = new TextBox();
            ciudad = new ComboBox();
            barrio = new TextBox();
            calles = new TextBox();
            observaciones = new RichTextBox();
            label12 = new Label();
            button1 = new Button();
            label8 = new Label();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)edad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peso).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1156, 137);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label13, 0, 0);
            tableLayoutPanel2.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1156, 137);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Century Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(3, 0);
            label13.Name = "label13";
            label13.Size = new Size(572, 137);
            label13.TabIndex = 1;
            label13.Text = "Registro de clientes";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(581, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(572, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 5);
            tableLayoutPanel1.Controls.Add(label3, 0, 6);
            tableLayoutPanel1.Controls.Add(label9, 0, 7);
            tableLayoutPanel1.Controls.Add(label10, 0, 8);
            tableLayoutPanel1.Controls.Add(label11, 0, 9);
            tableLayoutPanel1.Controls.Add(nombres, 1, 0);
            tableLayoutPanel1.Controls.Add(apellidos, 1, 1);
            tableLayoutPanel1.Controls.Add(edad, 1, 2);
            tableLayoutPanel1.Controls.Add(peso, 1, 3);
            tableLayoutPanel1.Controls.Add(sexo, 1, 4);
            tableLayoutPanel1.Controls.Add(email, 1, 5);
            tableLayoutPanel1.Controls.Add(celular, 1, 6);
            tableLayoutPanel1.Controls.Add(ciudad, 1, 7);
            tableLayoutPanel1.Controls.Add(barrio, 1, 8);
            tableLayoutPanel1.Controls.Add(calles, 1, 9);
            tableLayoutPanel1.Controls.Add(observaciones, 1, 10);
            tableLayoutPanel1.Controls.Add(label12, 0, 10);
            tableLayoutPanel1.Controls.Add(button1, 1, 11);
            tableLayoutPanel1.Controls.Add(label8, 0, 12);
            tableLayoutPanel1.Controls.Add(button2, 0, 11);
            tableLayoutPanel1.Controls.Add(button3, 1, 12);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 137);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 13;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tableLayoutPanel1.Size = new Size(1156, 570);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(281, 43);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(4, 43);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(281, 43);
            label2.TabIndex = 1;
            label2.Text = "Apellidos:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(4, 86);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(281, 43);
            label5.TabIndex = 4;
            label5.Text = "Edad:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(4, 129);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(281, 43);
            label6.TabIndex = 5;
            label6.Text = "Peso(Kg):";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(4, 172);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(281, 43);
            label7.TabIndex = 6;
            label7.Text = "Sexo:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(4, 215);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(281, 43);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(4, 258);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(281, 43);
            label3.TabIndex = 2;
            label3.Text = "Celular:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(4, 301);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(281, 43);
            label9.TabIndex = 8;
            label9.Text = "Ciudad:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(4, 344);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(281, 43);
            label10.TabIndex = 9;
            label10.Text = "Barrio:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(4, 387);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(281, 43);
            label11.TabIndex = 10;
            label11.Text = "Calles:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nombres
            // 
            nombres.BackColor = Color.Black;
            nombres.BorderStyle = BorderStyle.FixedSingle;
            nombres.Dock = DockStyle.Fill;
            nombres.ForeColor = Color.White;
            nombres.Location = new Point(293, 4);
            nombres.Margin = new Padding(4);
            nombres.Name = "nombres";
            nombres.Size = new Size(859, 27);
            nombres.TabIndex = 11;
            // 
            // apellidos
            // 
            apellidos.BackColor = Color.Black;
            apellidos.BorderStyle = BorderStyle.FixedSingle;
            apellidos.Dock = DockStyle.Fill;
            apellidos.ForeColor = Color.White;
            apellidos.Location = new Point(293, 47);
            apellidos.Margin = new Padding(4);
            apellidos.Name = "apellidos";
            apellidos.Size = new Size(859, 27);
            apellidos.TabIndex = 12;
            // 
            // edad
            // 
            edad.BackColor = Color.Black;
            edad.BorderStyle = BorderStyle.FixedSingle;
            edad.Dock = DockStyle.Fill;
            edad.ForeColor = Color.White;
            edad.Location = new Point(293, 90);
            edad.Margin = new Padding(4);
            edad.Name = "edad";
            edad.Size = new Size(859, 27);
            edad.TabIndex = 13;
            edad.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // peso
            // 
            peso.BackColor = Color.Black;
            peso.BorderStyle = BorderStyle.FixedSingle;
            peso.DecimalPlaces = 2;
            peso.Dock = DockStyle.Fill;
            peso.ForeColor = Color.White;
            peso.Location = new Point(293, 133);
            peso.Margin = new Padding(4);
            peso.Name = "peso";
            peso.Size = new Size(859, 27);
            peso.TabIndex = 14;
            peso.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // sexo
            // 
            sexo.BackColor = Color.Black;
            sexo.Dock = DockStyle.Fill;
            sexo.FlatStyle = FlatStyle.Flat;
            sexo.ForeColor = Color.White;
            sexo.FormattingEnabled = true;
            sexo.Items.AddRange(new object[] { "Femenino", "Masculino" });
            sexo.Location = new Point(293, 176);
            sexo.Margin = new Padding(4);
            sexo.Name = "sexo";
            sexo.Size = new Size(859, 29);
            sexo.Sorted = true;
            sexo.TabIndex = 15;
            sexo.Text = "Femenino";
            // 
            // email
            // 
            email.BackColor = Color.Black;
            email.BorderStyle = BorderStyle.FixedSingle;
            email.Dock = DockStyle.Fill;
            email.ForeColor = Color.White;
            email.Location = new Point(293, 219);
            email.Margin = new Padding(4);
            email.Name = "email";
            email.Size = new Size(859, 27);
            email.TabIndex = 16;
            // 
            // celular
            // 
            celular.BackColor = Color.Black;
            celular.BorderStyle = BorderStyle.FixedSingle;
            celular.Dock = DockStyle.Fill;
            celular.ForeColor = Color.White;
            celular.Location = new Point(293, 262);
            celular.Margin = new Padding(4);
            celular.Name = "celular";
            celular.Size = new Size(859, 27);
            celular.TabIndex = 17;
            // 
            // ciudad
            // 
            ciudad.BackColor = Color.Black;
            ciudad.Dock = DockStyle.Fill;
            ciudad.FlatStyle = FlatStyle.Flat;
            ciudad.ForeColor = Color.White;
            ciudad.FormattingEnabled = true;
            ciudad.Items.AddRange(new object[] { "La Maná", "Latacunga ", "Pangua", "Pujilí", "Salcedo", "Saquisilí" });
            ciudad.Location = new Point(293, 305);
            ciudad.Margin = new Padding(4);
            ciudad.Name = "ciudad";
            ciudad.Size = new Size(859, 29);
            ciudad.Sorted = true;
            ciudad.TabIndex = 18;
            ciudad.Text = "Latacunga ";
            // 
            // barrio
            // 
            barrio.BackColor = Color.Black;
            barrio.BorderStyle = BorderStyle.FixedSingle;
            barrio.Dock = DockStyle.Fill;
            barrio.ForeColor = Color.White;
            barrio.Location = new Point(293, 348);
            barrio.Margin = new Padding(4);
            barrio.Name = "barrio";
            barrio.Size = new Size(859, 27);
            barrio.TabIndex = 19;
            // 
            // calles
            // 
            calles.BackColor = Color.Black;
            calles.BorderStyle = BorderStyle.FixedSingle;
            calles.Dock = DockStyle.Fill;
            calles.ForeColor = Color.White;
            calles.Location = new Point(293, 391);
            calles.Margin = new Padding(4);
            calles.Name = "calles";
            calles.Size = new Size(859, 27);
            calles.TabIndex = 20;
            // 
            // observaciones
            // 
            observaciones.BackColor = Color.Black;
            observaciones.BorderStyle = BorderStyle.FixedSingle;
            observaciones.Dock = DockStyle.Fill;
            observaciones.ForeColor = Color.White;
            observaciones.Location = new Point(293, 434);
            observaciones.Margin = new Padding(4);
            observaciones.Name = "observaciones";
            observaciones.Size = new Size(859, 35);
            observaciones.TabIndex = 21;
            observaciones.Text = "Ninguna";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point(4, 430);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(281, 43);
            label12.TabIndex = 22;
            label12.Text = "Observaciones:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(293, 477);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(859, 35);
            button1.TabIndex = 23;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 516);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 21);
            label8.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(4, 477);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(281, 35);
            button2.TabIndex = 24;
            button2.Text = "Aceptar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Dock = DockStyle.Fill;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(293, 520);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(859, 46);
            button3.TabIndex = 25;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = false;
            // 
            // RegistroClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1156, 707);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "RegistroClientes";
            Text = "Registro de Clientes";
            Load += RegistroClientes_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)edad).EndInit();
            ((System.ComponentModel.ISupportInitialize)peso).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label13;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox nombres;
        private TextBox apellidos;
        private NumericUpDown edad;
        private NumericUpDown peso;
        private ComboBox sexo;
        private TextBox email;
        private TextBox celular;
        private ComboBox ciudad;
        private TextBox barrio;
        private TextBox calles;
        private RichTextBox observaciones;
        private Label label12;
        private Button button1;
        private Label label8;
        private Button button2;
        private Button button3;
    }
}