namespace POSCafeteria
{
    partial class FormCrédito
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
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label6 = new Label();
            dtvcrédito = new DataGridView();
            panel2 = new Panel();
            txtprecio = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtclientecrédito = new TextBox();
            txtproducto = new TextBox();
            btneliminarcrédito = new FontAwesome.Sharp.IconButton();
            btnguardarcrédito = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtvcrédito).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(493, 34);
            label1.TabIndex = 0;
            label1.Text = "Mueblería Expo Muebles Cruz ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(143, 88);
            label2.Name = "label2";
            label2.Size = new Size(279, 25);
            label2.TabIndex = 1;
            label2.Text = "Administración de créditos\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 74);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 2;
            label3.Text = "Producto";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dtvcrédito);
            panel1.Location = new Point(395, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 586);
            panel1.TabIndex = 3;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Linen;
            iconPictureBox1.BorderStyle = BorderStyle.Fixed3D;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.InitialImage = null;
            iconPictureBox1.Location = new Point(30, 13);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(76, 19);
            label6.Name = "label6";
            label6.Size = new Size(198, 25);
            label6.TabIndex = 1;
            label6.Text = "Lista de creditos";
            // 
            // dtvcrédito
            // 
            dtvcrédito.AllowUserToOrderColumns = true;
            dtvcrédito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvcrédito.Location = new Point(3, 74);
            dtvcrédito.Name = "dtvcrédito";
            dtvcrédito.RowHeadersWidth = 51;
            dtvcrédito.Size = new Size(881, 507);
            dtvcrédito.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnguardarcrédito);
            panel2.Controls.Add(btneliminarcrédito);
            panel2.Controls.Add(txtprecio);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtclientecrédito);
            panel2.Controls.Add(txtproducto);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 586);
            panel2.TabIndex = 4;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(17, 240);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(346, 27);
            txtprecio.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 217);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 6;
            label5.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 146);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 5;
            label4.Text = "Cliente\r\n";
            // 
            // txtclientecrédito
            // 
            txtclientecrédito.Location = new Point(17, 169);
            txtclientecrédito.Name = "txtclientecrédito";
            txtclientecrédito.Size = new Size(346, 27);
            txtclientecrédito.TabIndex = 4;
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(17, 97);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(346, 27);
            txtproducto.TabIndex = 0;
            // 
            // btneliminarcrédito
            // 
            btneliminarcrédito.BackColor = Color.IndianRed;
            btneliminarcrédito.FlatStyle = FlatStyle.Popup;
            btneliminarcrédito.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneliminarcrédito.ForeColor = Color.White;
            btneliminarcrédito.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btneliminarcrédito.IconColor = Color.White;
            btneliminarcrédito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneliminarcrédito.Location = new Point(139, 444);
            btneliminarcrédito.Name = "btneliminarcrédito";
            btneliminarcrédito.Size = new Size(94, 81);
            btneliminarcrédito.TabIndex = 10;
            btneliminarcrédito.Text = "Eliminar";
            btneliminarcrédito.TextAlign = ContentAlignment.BottomCenter;
            btneliminarcrédito.UseVisualStyleBackColor = false;
            // 
            // btnguardarcrédito
            // 
            btnguardarcrédito.BackColor = Color.ForestGreen;
            btnguardarcrédito.FlatStyle = FlatStyle.Popup;
            btnguardarcrédito.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnguardarcrédito.ForeColor = Color.White;
            btnguardarcrédito.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnguardarcrédito.IconColor = Color.White;
            btnguardarcrédito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardarcrédito.Location = new Point(269, 444);
            btnguardarcrédito.Name = "btnguardarcrédito";
            btnguardarcrédito.Size = new Size(94, 81);
            btnguardarcrédito.TabIndex = 11;
            btnguardarcrédito.Text = "Guardar";
            btnguardarcrédito.TextAlign = ContentAlignment.BottomCenter;
            btnguardarcrédito.UseVisualStyleBackColor = false;
            // 
            // FormCrédito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1282, 722);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCrédito";
            Text = "FormCrédito";
            Load += FormCrédito_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtvcrédito).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private DataGridView dtvcrédito;
        private Panel panel2;
        private TextBox txtproducto;
        private Label label4;
        private TextBox txtclientecrédito;
        private TextBox txtprecio;
        private Label label5;
        private Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btneliminarcrédito;
        private FontAwesome.Sharp.IconButton btnguardarcrédito;
    }
}