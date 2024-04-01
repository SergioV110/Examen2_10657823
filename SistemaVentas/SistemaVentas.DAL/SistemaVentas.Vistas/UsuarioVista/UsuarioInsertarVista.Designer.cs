namespace SistemaVentas.Vistas.UsuarioVista
{
    partial class UsuarioInsertarVista
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 311);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 11;
            label4.Text = "FEHCA REGISTRO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 236);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 10;
            label3.Text = "PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 158);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 9;
            label2.Text = "NOMBRE USUARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 79);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 8;
            label1.Text = "PERSONA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(359, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(359, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(359, 236);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '#';
            textBox3.Size = new Size(250, 27);
            textBox3.TabIndex = 14;
            textBox3.UseSystemPasswordChar = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(359, 304);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(515, 79);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "SELECIONAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(419, 357);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 17;
            button2.Text = "GUARDAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(579, 357);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 18;
            button3.Text = "CANCELAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // UsuarioInsertarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UsuarioInsertarVista";
            Text = "UsuarioInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}