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
            añadircredito = new Button();
            label7 = new Label();
            txtPrecioventa = new TextBox();
            cmbClienteventa = new ComboBox();
            cmbProductoventa = new ComboBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnguardarcrédito = new FontAwesome.Sharp.IconButton();
            btneliminarcrédito = new FontAwesome.Sharp.IconButton();
            txtCantidadventa = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel3 = new Panel();
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
            label2.Location = new Point(45, 19);
            label2.Name = "label2";
            label2.Size = new Size(279, 25);
            label2.TabIndex = 1;
            label2.Text = "Administración de créditos\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 86);
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
            panel1.Location = new Point(395, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 638);
            panel1.TabIndex = 3;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.AntiqueWhite;
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
            dtvcrédito.BackgroundColor = Color.SeaShell;
            dtvcrédito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvcrédito.Location = new Point(3, 74);
            dtvcrédito.Name = "dtvcrédito";
            dtvcrédito.RowHeadersWidth = 51;
            dtvcrédito.Size = new Size(881, 465);
            dtvcrédito.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(añadircredito);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtPrecioventa);
            panel2.Controls.Add(cmbClienteventa);
            panel2.Controls.Add(cmbProductoventa);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(btnguardarcrédito);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btneliminarcrédito);
            panel2.Controls.Add(txtCantidadventa);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 638);
            panel2.TabIndex = 4;
            // 
            // añadircredito
            // 
            
           
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 293);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 7;
            label7.Text = "Precio";
            // 
            // txtPrecioventa
            // 
            txtPrecioventa.Location = new Point(17, 316);
            txtPrecioventa.Name = "txtPrecioventa";
            txtPrecioventa.Size = new Size(346, 27);
            txtPrecioventa.TabIndex = 15;
            // 
            // cmbClienteventa
            // 
            cmbClienteventa.FormattingEnabled = true;
            cmbClienteventa.Location = new Point(18, 175);
            cmbClienteventa.Name = "cmbClienteventa";
            cmbClienteventa.Size = new Size(345, 28);
            cmbClienteventa.TabIndex = 14;
            // 
            // cmbProductoventa
            // 
            cmbProductoventa.FormattingEnabled = true;
            cmbProductoventa.Location = new Point(20, 109);
            cmbProductoventa.Name = "cmbProductoventa";
            cmbProductoventa.Size = new Size(343, 28);
            cmbProductoventa.TabIndex = 13;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.LightCoral;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Reply;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(17, 436);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(94, 81);
            iconButton1.TabIndex = 12;
            iconButton1.Text = "Volver";
            iconButton1.TextAlign = ContentAlignment.BottomCenter;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click_1;
            // 
            // btnguardarcrédito
            // 
            btnguardarcrédito.BackColor = Color.ForestGreen;
            btnguardarcrédito.FlatStyle = FlatStyle.Flat;
            btnguardarcrédito.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnguardarcrédito.ForeColor = Color.White;
            btnguardarcrédito.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnguardarcrédito.IconColor = Color.White;
            btnguardarcrédito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardarcrédito.Location = new Point(270, 436);
            btnguardarcrédito.Name = "btnguardarcrédito";
            btnguardarcrédito.Size = new Size(94, 81);
            btnguardarcrédito.TabIndex = 11;
            btnguardarcrédito.Text = "Guardar";
            btnguardarcrédito.TextAlign = ContentAlignment.BottomCenter;
            btnguardarcrédito.UseVisualStyleBackColor = false;
            btnguardarcrédito.Click += btnguardarcrédito_Click_1;
            // 
            // btneliminarcrédito
            // 
            btneliminarcrédito.BackColor = Color.Firebrick;
            btneliminarcrédito.FlatStyle = FlatStyle.Flat;
            btneliminarcrédito.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneliminarcrédito.ForeColor = Color.White;
            btneliminarcrédito.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btneliminarcrédito.IconColor = Color.White;
            btneliminarcrédito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneliminarcrédito.Location = new Point(141, 436);
            btneliminarcrédito.Name = "btneliminarcrédito";
            btneliminarcrédito.Size = new Size(94, 81);
            btneliminarcrédito.TabIndex = 10;
            btneliminarcrédito.Text = "Eliminar";
            btneliminarcrédito.TextAlign = ContentAlignment.BottomCenter;
            btneliminarcrédito.UseVisualStyleBackColor = false;
            btneliminarcrédito.Click += btneliminarcrédito_Click_1;
            // 
            // txtCantidadventa
            // 
            txtCantidadventa.Location = new Point(17, 246);
            txtCantidadventa.Name = "txtCantidadventa";
            txtCantidadventa.Size = new Size(346, 27);
            txtCantidadventa.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 223);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 6;
            label5.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 152);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 5;
            label4.Text = "Cliente\r\n";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(3, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(1277, 81);
            panel3.TabIndex = 5;
            // 
            // FormCrédito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1282, 631);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel3);
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
        private Label label4;
        private TextBox txtCantidadventa;
        private Label label5;
        private Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btneliminarcrédito;
        private FontAwesome.Sharp.IconButton btnguardarcrédito;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel3;
        private ComboBox cmbClienteventa;
        private ComboBox cmbProductoventa;
        private Label label7;
        private TextBox txtPrecioventa;
        private Button añadircredito;
    }
}