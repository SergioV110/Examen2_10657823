namespace SistemaVentas.Vistas.Interfaz
{
    partial class vistadeinterfaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vistadeinterfaz));
            panelContenedor = new Panel();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panelhijo = new Panel();
            pictureBox3 = new PictureBox();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelhijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.DimGray;
            panelContenedor.Controls.Add(button4);
            panelContenedor.Controls.Add(button2);
            panelContenedor.Controls.Add(button1);
            panelContenedor.Controls.Add(pictureBox2);
            panelContenedor.Controls.Add(label1);
            panelContenedor.Dock = DockStyle.Left;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(304, 537);
            panelContenedor.TabIndex = 0;
            panelContenedor.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.Font = new Font("Impact", 18F);
            button4.Location = new Point(30, 356);
            button4.Name = "button4";
            button4.Size = new Size(235, 48);
            button4.TabIndex = 10;
            button4.Text = "PROVEEDOR";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Impact", 18F);
            button2.Location = new Point(30, 268);
            button2.Name = "button2";
            button2.Size = new Size(235, 48);
            button2.TabIndex = 9;
            button2.Text = "VENDEDOR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Impact", 18F);
            button1.Location = new Point(30, 172);
            button1.Name = "button1";
            button1.Size = new Size(235, 48);
            button1.TabIndex = 8;
            button1.Text = "GERENTE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(266, 491);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(1, 9);
            label1.Name = "label1";
            label1.Size = new Size(303, 59);
            label1.TabIndex = 1;
            label1.Text = "INICIAR SESION";
            label1.Click += label1_Click;
            // 
            // panelhijo
            // 
            panelhijo.BackColor = Color.FromArgb(97, 71, 46);
            panelhijo.Controls.Add(pictureBox3);
            panelhijo.Dock = DockStyle.Fill;
            panelhijo.Location = new Point(304, 0);
            panelhijo.Name = "panelhijo";
            panelhijo.Size = new Size(573, 537);
            panelhijo.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(48, 97);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(490, 329);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // vistadeinterfaz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(877, 537);
            Controls.Add(panelhijo);
            Controls.Add(panelContenedor);
            Name = "vistadeinterfaz";
            Text = "vistadeinterfaz";
            Load += vistadeinterfaz_Load;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelhijo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private PictureBox pictureBox2;
        private Button button4;
        private Button button2;
        private Button button1;
        private Panel panelhijo;
        private PictureBox pictureBox3;
        private Label label1;
    }
}