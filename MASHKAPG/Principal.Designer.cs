namespace MASHKAPG
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            VERHORARIOS = new Button();
            REGISTRARCLIENTES = new Button();
            VERCLIENTES = new Button();
            panelheader = new Panel();
            btclose = new Button();
            mainpanel = new Panel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelheader.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 30);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 663);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Black;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(VERHORARIOS, 0, 4);
            tableLayoutPanel1.Controls.Add(REGISTRARCLIENTES, 0, 3);
            tableLayoutPanel1.Controls.Add(VERCLIENTES, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(200, 663);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 97);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // VERHORARIOS
            // 
            VERHORARIOS.BackColor = Color.Black;
            VERHORARIOS.BackgroundImageLayout = ImageLayout.Zoom;
            VERHORARIOS.FlatAppearance.BorderSize = 0;
            VERHORARIOS.FlatStyle = FlatStyle.Flat;
            VERHORARIOS.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            VERHORARIOS.ForeColor = Color.White;
            VERHORARIOS.ImageAlign = ContentAlignment.MiddleLeft;
            VERHORARIOS.Location = new Point(3, 443);
            VERHORARIOS.Name = "VERHORARIOS";
            VERHORARIOS.Size = new Size(194, 70);
            VERHORARIOS.TabIndex = 2;
            VERHORARIOS.Text = "Ver horarios";
            VERHORARIOS.UseVisualStyleBackColor = false;
            VERHORARIOS.MouseLeave += VERHORARIOS_MouseLeave;
            VERHORARIOS.MouseHover += VERHORARIOS_MouseHover;
            // 
            // REGISTRARCLIENTES
            // 
            REGISTRARCLIENTES.BackColor = Color.Black;
            REGISTRARCLIENTES.BackgroundImageLayout = ImageLayout.Zoom;
            REGISTRARCLIENTES.FlatAppearance.BorderSize = 0;
            REGISTRARCLIENTES.FlatStyle = FlatStyle.Flat;
            REGISTRARCLIENTES.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            REGISTRARCLIENTES.ForeColor = Color.White;
            REGISTRARCLIENTES.ImageAlign = ContentAlignment.MiddleLeft;
            REGISTRARCLIENTES.Location = new Point(3, 333);
            REGISTRARCLIENTES.Name = "REGISTRARCLIENTES";
            REGISTRARCLIENTES.Size = new Size(194, 70);
            REGISTRARCLIENTES.TabIndex = 0;
            REGISTRARCLIENTES.Text = "Registrar Clientes";
            REGISTRARCLIENTES.UseVisualStyleBackColor = false;
            REGISTRARCLIENTES.Click += REGISTRARCLIENTES_Click;
            REGISTRARCLIENTES.MouseLeave += REGISTRARCLIENTES_MouseLeave;
            REGISTRARCLIENTES.MouseHover += REGISTRARCLIENTES_MouseHover;
            // 
            // VERCLIENTES
            // 
            VERCLIENTES.BackColor = Color.Black;
            VERCLIENTES.BackgroundImageLayout = ImageLayout.Zoom;
            VERCLIENTES.FlatAppearance.BorderSize = 0;
            VERCLIENTES.FlatStyle = FlatStyle.Flat;
            VERCLIENTES.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            VERCLIENTES.ForeColor = Color.White;
            VERCLIENTES.ImageAlign = ContentAlignment.MiddleLeft;
            VERCLIENTES.Location = new Point(3, 223);
            VERCLIENTES.Name = "VERCLIENTES";
            VERCLIENTES.Size = new Size(194, 70);
            VERCLIENTES.TabIndex = 1;
            VERCLIENTES.Text = "Ver Clientes";
            VERCLIENTES.UseVisualStyleBackColor = false;
            VERCLIENTES.Click += VERCLIENTES_Click;
            VERCLIENTES.MouseLeave += VERCLIENTES_MouseLeave;
            VERCLIENTES.MouseHover += VERCLIENTES_MouseHover;
            // 
            // panelheader
            // 
            panelheader.BackColor = Color.FromArgb(43, 43, 43);
            panelheader.Controls.Add(btclose);
            panelheader.Dock = DockStyle.Top;
            panelheader.Location = new Point(0, 0);
            panelheader.Name = "panelheader";
            panelheader.Size = new Size(1063, 30);
            panelheader.TabIndex = 1;
            panelheader.Paint += panelheader_Paint;
            panelheader.MouseDown += panelheader_MouseDown;
            // 
            // btclose
            // 
            btclose.BackColor = SystemColors.ControlDarkDark;
            btclose.BackgroundImageLayout = ImageLayout.Zoom;
            btclose.Dock = DockStyle.Right;
            btclose.FlatAppearance.BorderSize = 0;
            btclose.FlatStyle = FlatStyle.Flat;
            btclose.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btclose.ForeColor = Color.White;
            btclose.ImageAlign = ContentAlignment.MiddleLeft;
            btclose.Location = new Point(1033, 0);
            btclose.Name = "btclose";
            btclose.Size = new Size(30, 30);
            btclose.TabIndex = 4;
            btclose.Text = "x";
            btclose.UseVisualStyleBackColor = false;
            btclose.Click += btclose_Click;
            // 
            // mainpanel
            // 
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(200, 30);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(863, 663);
            mainpanel.TabIndex = 2;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 693);
            Controls.Add(mainpanel);
            Controls.Add(panel1);
            Controls.Add(panelheader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Principal";
            Text = "Principal";
            MouseDown += Principal_MouseDown;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelheader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelheader;
        private Panel mainpanel;
        private Button REGISTRARCLIENTES;
        private Button VERHORARIOS;
        private Button VERCLIENTES;
        private PictureBox pictureBox1;
        private Button btclose;
        private TableLayoutPanel tableLayoutPanel1;
    }
}