namespace MASHKAPG
{
    partial class ListaClientes
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaClientes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editarToolStripMenuItem = new ToolStripMenuItem();
            todoToolStripMenuItem = new ToolStripMenuItem();
            nombreToolStripMenuItem = new ToolStripMenuItem();
            nombreToolStripMenuItem3 = new ToolStripMenuItem();
            apellidoToolStripMenuItem1 = new ToolStripMenuItem();
            ingresoToolStripMenuItem1 = new ToolStripMenuItem();
            salidaToolStripMenuItem1 = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            filaToolStripMenuItem = new ToolStripMenuItem();
            nombreToolStripMenuItem1 = new ToolStripMenuItem();
            nombreToolStripMenuItem2 = new ToolStripMenuItem();
            apellidoToolStripMenuItem = new ToolStripMenuItem();
            ingresoToolStripMenuItem = new ToolStripMenuItem();
            salidaToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1113, 138);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1113, 138);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(559, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(551, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(550, 138);
            label1.TabIndex = 1;
            label1.Text = "Lista de clientes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(comboBox1, 1, 0);
            tableLayoutPanel3.Controls.Add(textBox1, 2, 0);
            tableLayoutPanel3.Controls.Add(button1, 3, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel3.Size = new Size(1113, 40);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 33);
            label2.TabIndex = 0;
            label2.Text = "Buscar por:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Black;
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Apellido", "Ingreso", "Nombre" });
            comboBox1.Location = new Point(225, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 29);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 0;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            comboBox1.TextChanged += comboBox1_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Dock = DockStyle.Fill;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(391, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(550, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(947, 3);
            button1.Name = "button1";
            button1.Size = new Size(163, 40);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Black;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1113, 457);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem, eliminarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(118, 48);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { todoToolStripMenuItem, nombreToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(117, 22);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // todoToolStripMenuItem
            // 
            todoToolStripMenuItem.Name = "todoToolStripMenuItem";
            todoToolStripMenuItem.Size = new Size(100, 22);
            todoToolStripMenuItem.Text = "Todo";
            // 
            // nombreToolStripMenuItem
            // 
            nombreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nombreToolStripMenuItem3, apellidoToolStripMenuItem1, ingresoToolStripMenuItem1, salidaToolStripMenuItem1 });
            nombreToolStripMenuItem.Name = "nombreToolStripMenuItem";
            nombreToolStripMenuItem.Size = new Size(100, 22);
            nombreToolStripMenuItem.Text = "Dato";
            nombreToolStripMenuItem.Click += nombreToolStripMenuItem_Click;
            // 
            // nombreToolStripMenuItem3
            // 
            nombreToolStripMenuItem3.Name = "nombreToolStripMenuItem3";
            nombreToolStripMenuItem3.Size = new Size(118, 22);
            nombreToolStripMenuItem3.Text = "Nombre";
            // 
            // apellidoToolStripMenuItem1
            // 
            apellidoToolStripMenuItem1.Name = "apellidoToolStripMenuItem1";
            apellidoToolStripMenuItem1.Size = new Size(118, 22);
            apellidoToolStripMenuItem1.Text = "Apellido";
            // 
            // ingresoToolStripMenuItem1
            // 
            ingresoToolStripMenuItem1.Name = "ingresoToolStripMenuItem1";
            ingresoToolStripMenuItem1.Size = new Size(118, 22);
            ingresoToolStripMenuItem1.Text = "Ingreso";
            // 
            // salidaToolStripMenuItem1
            // 
            salidaToolStripMenuItem1.Name = "salidaToolStripMenuItem1";
            salidaToolStripMenuItem1.Size = new Size(118, 22);
            salidaToolStripMenuItem1.Text = "Salida";
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { filaToolStripMenuItem, nombreToolStripMenuItem1 });
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(117, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // filaToolStripMenuItem
            // 
            filaToolStripMenuItem.Name = "filaToolStripMenuItem";
            filaToolStripMenuItem.Size = new Size(99, 22);
            filaToolStripMenuItem.Text = "Fila";
            filaToolStripMenuItem.Click += filaToolStripMenuItem_Click;
            // 
            // nombreToolStripMenuItem1
            // 
            nombreToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { nombreToolStripMenuItem2, apellidoToolStripMenuItem, ingresoToolStripMenuItem, salidaToolStripMenuItem });
            nombreToolStripMenuItem1.Name = "nombreToolStripMenuItem1";
            nombreToolStripMenuItem1.Size = new Size(99, 22);
            nombreToolStripMenuItem1.Text = "Dato";
            nombreToolStripMenuItem1.Click += nombreToolStripMenuItem1_Click;
            // 
            // nombreToolStripMenuItem2
            // 
            nombreToolStripMenuItem2.Name = "nombreToolStripMenuItem2";
            nombreToolStripMenuItem2.Size = new Size(118, 22);
            nombreToolStripMenuItem2.Text = "Nombre";
            nombreToolStripMenuItem2.Click += nombreToolStripMenuItem2_Click;
            // 
            // apellidoToolStripMenuItem
            // 
            apellidoToolStripMenuItem.Name = "apellidoToolStripMenuItem";
            apellidoToolStripMenuItem.Size = new Size(118, 22);
            apellidoToolStripMenuItem.Text = "Apellido";
            apellidoToolStripMenuItem.Click += apellidoToolStripMenuItem_Click;
            // 
            // ingresoToolStripMenuItem
            // 
            ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            ingresoToolStripMenuItem.Size = new Size(118, 22);
            ingresoToolStripMenuItem.Text = "Ingreso";
            ingresoToolStripMenuItem.Click += ingresoToolStripMenuItem_Click;
            // 
            // salidaToolStripMenuItem
            // 
            salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            salidaToolStripMenuItem.Size = new Size(118, 22);
            salidaToolStripMenuItem.Text = "Salida";
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(1113, 40);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 178);
            panel3.Name = "panel3";
            panel3.Size = new Size(1113, 457);
            panel3.TabIndex = 5;
            // 
            // ListaClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1113, 647);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ListaClientes";
            Text = "ListaClientes";
            Load += ListaClientes_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem todoToolStripMenuItem;
        private ToolStripMenuItem nombreToolStripMenuItem;
        private ToolStripMenuItem filaToolStripMenuItem;
        private ToolStripMenuItem nombreToolStripMenuItem1;
        private ToolStripMenuItem nombreToolStripMenuItem2;
        private ToolStripMenuItem apellidoToolStripMenuItem;
        private ToolStripMenuItem ingresoToolStripMenuItem;
        private ToolStripMenuItem salidaToolStripMenuItem;
        private ToolStripMenuItem nombreToolStripMenuItem3;
        private ToolStripMenuItem apellidoToolStripMenuItem1;
        private ToolStripMenuItem ingresoToolStripMenuItem1;
        private ToolStripMenuItem salidaToolStripMenuItem1;
        private Panel panel2;
        private Panel panel3;
    }
}