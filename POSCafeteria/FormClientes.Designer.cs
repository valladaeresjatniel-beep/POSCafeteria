namespace POSCafeteria
{
    partial class FormClientes
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
            btnGuardarClientes = new FontAwesome.Sharp.IconButton();
            btnVolverclientes = new FontAwesome.Sharp.IconButton();
            btnEliminarClientes = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label2 = new Label();
            txtTelefono = new TextBox();
            txtNombreclientes = new TextBox();
            txtDirección = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            dtvClientes = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtvClientes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardarClientes
            // 
            btnGuardarClientes.BackColor = Color.ForestGreen;
            btnGuardarClientes.FlatStyle = FlatStyle.Flat;
            btnGuardarClientes.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarClientes.ForeColor = Color.White;
            btnGuardarClientes.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardarClientes.IconColor = Color.White;
            btnGuardarClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarClientes.Location = new Point(258, 475);
            btnGuardarClientes.Name = "btnGuardarClientes";
            btnGuardarClientes.Size = new Size(94, 81);
            btnGuardarClientes.TabIndex = 0;
            btnGuardarClientes.Text = "Guardar";
            btnGuardarClientes.TextAlign = ContentAlignment.BottomCenter;
            btnGuardarClientes.UseVisualStyleBackColor = false;
            btnGuardarClientes.Click += btnGuardarClientes_Click_1;
            // 
            // btnVolverclientes
            // 
            btnVolverclientes.BackColor = Color.LightCoral;
            btnVolverclientes.FlatStyle = FlatStyle.Flat;
            btnVolverclientes.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverclientes.ForeColor = Color.White;
            btnVolverclientes.IconChar = FontAwesome.Sharp.IconChar.Reply;
            btnVolverclientes.IconColor = Color.White;
            btnVolverclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVolverclientes.Location = new Point(33, 475);
            btnVolverclientes.Name = "btnVolverclientes";
            btnVolverclientes.Size = new Size(94, 81);
            btnVolverclientes.TabIndex = 1;
            btnVolverclientes.Text = "Volver";
            btnVolverclientes.TextAlign = ContentAlignment.BottomCenter;
            btnVolverclientes.UseVisualStyleBackColor = false;
            btnVolverclientes.Click += btnVolverclientes_Click;
            // 
            // btnEliminarClientes
            // 
            btnEliminarClientes.BackColor = Color.Firebrick;
            btnEliminarClientes.FlatStyle = FlatStyle.Flat;
            btnEliminarClientes.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarClientes.ForeColor = Color.White;
            btnEliminarClientes.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminarClientes.IconColor = Color.White;
            btnEliminarClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarClientes.Location = new Point(142, 475);
            btnEliminarClientes.Name = "btnEliminarClientes";
            btnEliminarClientes.Size = new Size(94, 81);
            btnEliminarClientes.TabIndex = 2;
            btnEliminarClientes.Text = "Eliminar";
            btnEliminarClientes.TextAlign = ContentAlignment.BottomCenter;
            btnEliminarClientes.UseVisualStyleBackColor = false;
            btnEliminarClientes.Click += btnEliminarClientes_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(517, 36);
            label1.TabIndex = 3;
            label1.Text = "Mueblería Expo Muebles Cruz ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 33);
            label2.Name = "label2";
            label2.Size = new Size(275, 25);
            label2.TabIndex = 4;
            label2.Text = "Adminstración de Clientes";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(28, 252);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(346, 27);
            txtTelefono.TabIndex = 5;
            // 
            // txtNombreclientes
            // 
            txtNombreclientes.Location = new Point(28, 109);
            txtNombreclientes.Name = "txtNombreclientes";
            txtNombreclientes.Size = new Size(346, 27);
            txtNombreclientes.TabIndex = 6;
            // 
            // txtDirección
            // 
            txtDirección.BackColor = SystemColors.Window;
            txtDirección.Location = new Point(28, 179);
            txtDirección.Name = "txtDirección";
            txtDirección.Size = new Size(346, 27);
            txtDirección.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 86);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 8;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 151);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 9;
            label4.Text = "Dirección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 229);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 10;
            label5.Text = "Teléfono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(527, 97);
            label6.Name = "label6";
            label6.Size = new Size(185, 25);
            label6.TabIndex = 11;
            label6.Text = "Lista de Clientes ";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.AntiqueWhite;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(481, 97);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 12;
            iconPictureBox1.TabStop = false;
            // 
            // dtvClientes
            // 
            dtvClientes.BackgroundColor = Color.SeaShell;
            dtvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvClientes.Location = new Point(414, 156);
            dtvClientes.Name = "dtvClientes";
            dtvClientes.RowHeadersWidth = 51;
            dtvClientes.Size = new Size(764, 423);
            dtvClientes.TabIndex = 13;
            dtvClientes.CellContentClick += dtvClientes_CellContentClick;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtNombreclientes);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtDirección);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(4, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 501);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(410, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(768, 501);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(2, -8);
            panel3.Name = "panel3";
            panel3.Size = new Size(1176, 80);
            panel3.TabIndex = 16;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1182, 584);
            Controls.Add(dtvClientes);
            Controls.Add(iconPictureBox1);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(btnEliminarClientes);
            Controls.Add(btnVolverclientes);
            Controls.Add(btnGuardarClientes);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormClientes";
            Text = "FormClientes";
            Load += FormClientes_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtvClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnGuardarClientes;
        private FontAwesome.Sharp.IconButton btnVolverclientes;
        private FontAwesome.Sharp.IconButton btnEliminarClientes;
        private Label label1;
        private Label label2;
        private TextBox txtTelefono;
        private TextBox txtNombreclientes;
        private TextBox txtDirección;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private DataGridView dtvClientes;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}