namespace prBD
{
    partial class Gerencia
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
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btn_registrarUsuario = new Button();
            txt_password = new TextBox();
            txt_usuario = new TextBox();
            txt_id = new TextBox();
            txt_nombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            btn_registrarPuesto = new Button();
            comboBox2 = new ComboBox();
            label9 = new Label();
            txt_nPuesto = new TextBox();
            label8 = new Label();
            label7 = new Label();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(310, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(462, 498);
            dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(792, 548);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_registrarUsuario);
            tabPage1.Controls.Add(txt_password);
            tabPage1.Controls.Add(txt_usuario);
            tabPage1.Controls.Add(txt_id);
            tabPage1.Controls.Add(txt_nombre);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(784, 515);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "empleados";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btn_registrarUsuario
            // 
            btn_registrarUsuario.Location = new Point(131, 222);
            btn_registrarUsuario.Name = "btn_registrarUsuario";
            btn_registrarUsuario.Size = new Size(87, 29);
            btn_registrarUsuario.TabIndex = 12;
            btn_registrarUsuario.Text = "registrar";
            btn_registrarUsuario.UseVisualStyleBackColor = true;
            btn_registrarUsuario.Click += btn_registrarUsuario_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(90, 189);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(180, 27);
            txt_password.TabIndex = 11;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(90, 156);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(180, 27);
            txt_usuario.TabIndex = 10;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(90, 84);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(180, 27);
            txt_id.TabIndex = 9;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(90, 51);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(181, 27);
            txt_nombre.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 195);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 7;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 159);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 6;
            label5.Text = "Usuario";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 88);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 5;
            label4.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 54);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 121);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 3;
            label2.Text = "Puesto";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(90, 118);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(181, 28);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 15);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 1;
            label1.Text = "Crear Empleado";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btn_registrarPuesto);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(txt_nPuesto);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(784, 515);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "puestos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_registrarPuesto
            // 
            btn_registrarPuesto.Location = new Point(130, 110);
            btn_registrarPuesto.Name = "btn_registrarPuesto";
            btn_registrarPuesto.Size = new Size(94, 29);
            btn_registrarPuesto.TabIndex = 6;
            btn_registrarPuesto.Text = "registrar";
            btn_registrarPuesto.UseVisualStyleBackColor = true;
            btn_registrarPuesto.Click += btn_registrarPuesto_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(104, 76);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 79);
            label9.Name = "label9";
            label9.Size = new Size(43, 20);
            label9.TabIndex = 4;
            label9.Text = "Nivel";
            // 
            // txt_nPuesto
            // 
            txt_nPuesto.Location = new Point(104, 43);
            txt_nPuesto.Name = "txt_nPuesto";
            txt_nPuesto.Size = new Size(151, 27);
            txt_nPuesto.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 45);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 2;
            label8.Text = "N Puesto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 16);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 1;
            label7.Text = "Crear Puesto";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(309, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(469, 492);
            dataGridView2.TabIndex = 0;
            // 
            // Gerencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 553);
            Controls.Add(tabControl1);
            Name = "Gerencia";
            Text = "Gerencia";
            Load += Gerencia_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox txt_id;
        private TextBox txt_nombre;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btn_registrarUsuario;
        private TextBox txt_password;
        private TextBox txt_usuario;
        private Button btn_registrarPuesto;
        private ComboBox comboBox2;
        private Label label9;
        private TextBox txt_nPuesto;
        private Label label8;
        private Label label7;
        private DataGridView dataGridView2;
    }
}