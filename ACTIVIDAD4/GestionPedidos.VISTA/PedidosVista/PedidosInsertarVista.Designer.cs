namespace GestionPedidos.VISTA.PedidosVista
{
    partial class PedidosInsertarVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidosInsertarVista));
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            buttoning = new Button();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 5);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(252, 195);
            dataGridView1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(105, 50);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(165, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(106, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 23);
            textBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pendiente", "En Proceso", "Completado", "Cancelado" });
            comboBox1.Location = new Point(106, 140);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 23);
            comboBox1.TabIndex = 10;
            // 
            // buttoning
            // 
            buttoning.BackColor = Color.White;
            buttoning.BackgroundImageLayout = ImageLayout.Zoom;
            buttoning.Cursor = Cursors.Hand;
            buttoning.Dock = DockStyle.Top;
            buttoning.FlatAppearance.BorderColor = Color.FromArgb(94, 142, 62);
            buttoning.FlatAppearance.CheckedBackColor = Color.Silver;
            buttoning.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttoning.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttoning.FlatStyle = FlatStyle.Flat;
            buttoning.Font = new Font("Arial Rounded MT Bold", 9.75F);
            buttoning.ForeColor = Color.Black;
            buttoning.ImageAlign = ContentAlignment.MiddleLeft;
            buttoning.Location = new Point(0, 195);
            buttoning.Name = "buttoning";
            buttoning.Size = new Size(252, 30);
            buttoning.TabIndex = 16;
            buttoning.Text = "SELECCIONAR";
            buttoning.UseVisualStyleBackColor = false;
            buttoning.Click += buttoning_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.White;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(94, 142, 62);
            button1.FlatAppearance.CheckedBackColor = Color.Silver;
            button1.FlatAppearance.MouseDownBackColor = Color.Gray;
            button1.FlatAppearance.MouseOverBackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 9.75F);
            button1.ForeColor = Color.Black;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(21, 180);
            button1.Name = "button1";
            button1.Size = new Size(249, 30);
            button1.TabIndex = 17;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(18, 9);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 18;
            label5.Text = "CLIENTE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 144);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 19;
            label6.Text = "ESTADO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(33, 99);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 20;
            label7.Text = "TOTAL";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(30, 54);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 21;
            label8.Text = "FECHA";
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(252, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 260);
            panel1.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttoning);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(252, 260);
            panel2.TabIndex = 23;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            button3.FlatAppearance.MouseOverBackColor = Color.Red;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 12F);
            button3.ForeColor = Color.Red;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(184, 219);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(86, 32);
            button3.TabIndex = 22;
            button3.Text = "SALIR";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // PedidosInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(122, 198, 94);
            ClientSize = new Size(531, 260);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PedidosInsertarVista";
            Text = "PedidosInsertarVista";
            Load += PedidosInsertarVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button buttoning;
        private Button button1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel1;
        private Panel panel2;
        private Button button3;
    }
}