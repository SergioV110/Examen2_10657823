namespace SistemaVentas.Vistas.Interfaz
{
    partial class InterfazVendedor
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
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            listView1 = new ListView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(97, 71, 46);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1181, 106);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(403, 24);
            label1.Name = "label1";
            label1.Size = new Size(364, 54);
            label1.TabIndex = 0;
            label1.Text = "INTERFAZ VENDEDOR";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1157, 213);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Area de Venta";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBox2
            // 
            comboBox2.Location = new Point(53, 147);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(211, 28);
            comboBox2.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Location = new Point(53, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 28);
            comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(391, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 458);
            listView1.Name = "listView1";
            listView1.Size = new Size(1157, 101);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1058, 580);
            button1.Name = "button1";
            button1.Size = new Size(111, 44);
            button1.TabIndex = 3;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Impact", 16.2F);
            button2.Location = new Point(417, 381);
            button2.Name = "button2";
            button2.Size = new Size(155, 44);
            button2.TabIndex = 4;
            button2.Text = "Registrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Impact", 16.2F);
            button3.Location = new Point(612, 381);
            button3.Name = "button3";
            button3.Size = new Size(155, 44);
            button3.TabIndex = 5;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12F);
            label2.Location = new Point(53, 33);
            label2.Name = "label2";
            label2.Size = new Size(198, 25);
            label2.TabIndex = 3;
            label2.Text = "Seleccione el Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 110);
            label3.Name = "label3";
            label3.Size = new Size(208, 25);
            label3.TabIndex = 4;
            label3.Text = "Seleccione Tipo de Pago";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 12F);
            label4.Location = new Point(405, 33);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 5;
            label4.Text = "Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(928, 33);
            label5.Name = "label5";
            label5.Size = new Size(170, 25);
            label5.TabIndex = 6;
            label5.Text = "Precio del Producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(966, 71);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 7;
            label6.Text = "LblPrecio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(877, 127);
            label7.Name = "label7";
            label7.Size = new Size(123, 25);
            label7.TabIndex = 6;
            label7.Text = "Fecha Actual :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(1006, 127);
            label8.Name = "label8";
            label8.Size = new Size(80, 25);
            label8.TabIndex = 7;
            label8.Text = "lblFecha";
            label8.Click += label8_Click;
            // 
            // InterfazVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1181, 646);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "InterfazVendedor";
            Text = "InterfazVendedor";
            Load += InterfazVendedor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListView listView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label7;
        private Label label8;
    }
}