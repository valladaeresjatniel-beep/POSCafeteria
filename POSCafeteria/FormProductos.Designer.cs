namespace POSCafeteria
{
    partial class FormProductos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnGuardarproducto = new FontAwesome.Sharp.IconButton();
            btnEliminarproducto = new FontAwesome.Sharp.IconButton();
            txtNombreproducto = new TextBox();
            label4 = new Label();
            txtMarcaproducto = new TextBox();
            txtPrecio = new TextBox();
            txtDescripción = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtvProductos = new DataGridView();
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            btnvolverproducto = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtvProductos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(517, 36);
            label1.TabIndex = 0;
            label1.Text = "Mueblería Expo Muebles Cruz ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 110);
            label2.Name = "label2";
            label2.Size = new Size(298, 25);
            label2.TabIndex = 1;
            label2.Text = "Administración de productos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 148);
            label3.Name = "label3";
            label3.Size = new Size(211, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre del Producto";
            // 
            // btnGuardarproducto
            // 
            btnGuardarproducto.BackColor = Color.ForestGreen;
            btnGuardarproducto.FlatStyle = FlatStyle.Flat;
            btnGuardarproducto.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarproducto.ForeColor = Color.White;
            btnGuardarproducto.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardarproducto.IconColor = Color.White;
            btnGuardarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarproducto.Location = new Point(257, 511);
            btnGuardarproducto.Name = "btnGuardarproducto";
            btnGuardarproducto.Size = new Size(94, 81);
            btnGuardarproducto.TabIndex = 3;
            btnGuardarproducto.Text = "Guardar";
            btnGuardarproducto.TextAlign = ContentAlignment.BottomCenter;
            btnGuardarproducto.UseVisualStyleBackColor = false;
            // 
            // btnEliminarproducto
            // 
            btnEliminarproducto.BackColor = Color.Firebrick;
            btnEliminarproducto.FlatStyle = FlatStyle.Flat;
            btnEliminarproducto.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarproducto.ForeColor = Color.White;
            btnEliminarproducto.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminarproducto.IconColor = Color.White;
            btnEliminarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarproducto.Location = new Point(146, 511);
            btnEliminarproducto.Name = "btnEliminarproducto";
            btnEliminarproducto.Size = new Size(94, 81);
            btnEliminarproducto.TabIndex = 4;
            btnEliminarproducto.Text = "Eliminar";
            btnEliminarproducto.TextAlign = ContentAlignment.BottomCenter;
            btnEliminarproducto.UseVisualStyleBackColor = false;
            // 
            // txtNombreproducto
            // 
            txtNombreproducto.Location = new Point(29, 181);
            txtNombreproducto.Name = "txtNombreproducto";
            txtNombreproducto.Size = new Size(346, 27);
            txtNombreproducto.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 138);
            label4.Name = "label4";
            label4.Size = new Size(192, 20);
            label4.TabIndex = 7;
            label4.Text = "Marca del Producto";
            // 
            // txtMarcaproducto
            // 
            txtMarcaproducto.Location = new Point(28, 161);
            txtMarcaproducto.Name = "txtMarcaproducto";
            txtMarcaproducto.Size = new Size(346, 27);
            txtMarcaproducto.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(28, 232);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(346, 27);
            txtPrecio.TabIndex = 9;
            // 
            // txtDescripción
            // 
            txtDescripción.Location = new Point(28, 310);
            txtDescripción.Name = "txtDescripción";
            txtDescripción.Size = new Size(346, 27);
            txtDescripción.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 209);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 11;
            label5.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(28, 287);
            label6.Name = "label6";
            label6.Size = new Size(247, 20);
            label6.TabIndex = 12;
            label6.Text = "Descripción del Producto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(530, 127);
            label7.Name = "label7";
            label7.Size = new Size(195, 25);
            label7.TabIndex = 13;
            label7.Text = "Lista de Productos";
            // 
            // dtvProductos
            // 
            dtvProductos.BackgroundColor = Color.SeaShell;
            dtvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvProductos.Location = new Point(400, 181);
            dtvProductos.Name = "dtvProductos";
            dtvProductos.RowHeadersWidth = 51;
            dtvProductos.Size = new Size(713, 429);
            dtvProductos.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(iconPictureBox1);
            panel1.Location = new Point(396, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 519);
            panel1.TabIndex = 15;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.AntiqueWhite;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Table;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(92, 31);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnvolverproducto);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtPrecio);
            panel2.Controls.Add(txtMarcaproducto);
            panel2.Controls.Add(txtDescripción);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(0, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 519);
            panel2.TabIndex = 16;
            // 
            // btnvolverproducto
            // 
            btnvolverproducto.BackColor = Color.LightCoral;
            btnvolverproducto.FlatStyle = FlatStyle.Flat;
            btnvolverproducto.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnvolverproducto.ForeColor = Color.White;
            btnvolverproducto.IconChar = FontAwesome.Sharp.IconChar.Reply;
            btnvolverproducto.IconColor = Color.White;
            btnvolverproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnvolverproducto.Location = new Point(32, 415);
            btnvolverproducto.Name = "btnvolverproducto";
            btnvolverproducto.Size = new Size(94, 81);
            btnvolverproducto.TabIndex = 13;
            btnvolverproducto.Text = "Volver";
            btnvolverproducto.TextAlign = ContentAlignment.BottomCenter;
            btnvolverproducto.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(0, -8);
            panel3.Name = "panel3";
            panel3.Size = new Size(1113, 97);
            panel3.TabIndex = 17;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1115, 617);
            Controls.Add(dtvProductos);
            Controls.Add(label7);
            Controls.Add(txtNombreproducto);
            Controls.Add(btnEliminarproducto);
            Controls.Add(btnGuardarproducto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "FormProductos";
            Text = "FormProductos";
            ((System.ComponentModel.ISupportInitialize)dtvProductos).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnGuardarproducto;
        private FontAwesome.Sharp.IconButton btnEliminarproducto;
        private TextBox txtNombreproducto;
        private Label label4;
        private TextBox txtMarcaproducto;
        private TextBox txtPrecio;
        private TextBox txtDescripción;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dtvProductos;
        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnvolverproducto;
        private Panel panel3;
    }
}