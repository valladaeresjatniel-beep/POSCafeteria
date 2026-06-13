namespace POSCafeteria
{
    partial class FormAbono
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
            btnguardarAbono = new FontAwesome.Sharp.IconButton();
            btneliminarAbono = new FontAwesome.Sharp.IconButton();
            btnvolverAbono = new FontAwesome.Sharp.IconButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbcréditoabono = new ComboBox();
            txtmontoabono = new TextBox();
            panel1 = new Panel();
            dtvabono = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtvabono).BeginInit();
            SuspendLayout();
            // 
            // btnguardarAbono
            // 
            btnguardarAbono.BackColor = Color.ForestGreen;
            btnguardarAbono.FlatStyle = FlatStyle.Flat;
            btnguardarAbono.Font = new Font("Verdana", 7.8F, FontStyle.Bold);
            btnguardarAbono.ForeColor = Color.White;
            btnguardarAbono.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnguardarAbono.IconColor = Color.White;
            btnguardarAbono.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardarAbono.Location = new Point(261, 495);
            btnguardarAbono.Name = "btnguardarAbono";
            btnguardarAbono.Size = new Size(94, 81);
            btnguardarAbono.TabIndex = 0;
            btnguardarAbono.Text = "Guardar";
            btnguardarAbono.TextAlign = ContentAlignment.BottomCenter;
            btnguardarAbono.UseVisualStyleBackColor = false;
            // 
            // btneliminarAbono
            // 
            btneliminarAbono.BackColor = Color.Firebrick;
            btneliminarAbono.FlatStyle = FlatStyle.Flat;
            btneliminarAbono.Font = new Font("Verdana", 7.8F, FontStyle.Bold);
            btneliminarAbono.ForeColor = Color.White;
            btneliminarAbono.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btneliminarAbono.IconColor = Color.White;
            btneliminarAbono.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneliminarAbono.Location = new Point(148, 495);
            btneliminarAbono.Name = "btneliminarAbono";
            btneliminarAbono.Size = new Size(94, 81);
            btneliminarAbono.TabIndex = 1;
            btneliminarAbono.Text = "Eliminar";
            btneliminarAbono.TextAlign = ContentAlignment.BottomCenter;
            btneliminarAbono.UseVisualStyleBackColor = false;
            // 
            // btnvolverAbono
            // 
            btnvolverAbono.BackColor = Color.LightCoral;
            btnvolverAbono.FlatStyle = FlatStyle.Flat;
            btnvolverAbono.Font = new Font("Verdana", 7.8F, FontStyle.Bold);
            btnvolverAbono.ForeColor = Color.White;
            btnvolverAbono.IconChar = FontAwesome.Sharp.IconChar.Reply;
            btnvolverAbono.IconColor = Color.White;
            btnvolverAbono.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnvolverAbono.Location = new Point(31, 495);
            btnvolverAbono.Name = "btnvolverAbono";
            btnvolverAbono.Size = new Size(94, 81);
            btnvolverAbono.TabIndex = 2;
            btnvolverAbono.Text = "Volver";
            btnvolverAbono.TextAlign = ContentAlignment.BottomCenter;
            btnvolverAbono.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.AntiqueWhite;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Coins;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(479, 148);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(45, 40);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(517, 36);
            label1.TabIndex = 4;
            label1.Text = "Mueblería Expo Muebles Cruz ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 148);
            label2.Name = "label2";
            label2.Size = new Size(273, 25);
            label2.TabIndex = 5;
            label2.Text = "Administración de Abonos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 185);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 6;
            label3.Text = "Monto a Pagar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 261);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 7;
            label4.Text = "Crédito";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(526, 163);
            label5.Name = "label5";
            label5.Size = new Size(259, 25);
            label5.TabIndex = 8;
            label5.Text = "Lista de Abonos Pagados";
            // 
            // cmbcréditoabono
            // 
            cmbcréditoabono.FormattingEnabled = true;
            cmbcréditoabono.Location = new Point(31, 295);
            cmbcréditoabono.Name = "cmbcréditoabono";
            cmbcréditoabono.Size = new Size(346, 28);
            cmbcréditoabono.TabIndex = 9;
            // 
            // txtmontoabono
            // 
            txtmontoabono.Location = new Point(31, 217);
            txtmontoabono.Name = "txtmontoabono";
            txtmontoabono.Size = new Size(346, 27);
            txtmontoabono.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(406, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(836, 558);
            panel1.TabIndex = 11;
            // 
            // dtvabono
            // 
            dtvabono.BackgroundColor = Color.SeaShell;
            dtvabono.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvabono.Location = new Point(414, 217);
            dtvabono.Name = "dtvabono";
            dtvabono.RowHeadersWidth = 51;
            dtvabono.Size = new Size(828, 461);
            dtvabono.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(8, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 551);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(8, -17);
            panel3.Name = "panel3";
            panel3.Size = new Size(1234, 140);
            panel3.TabIndex = 14;
            // 
            // FormAbono
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1247, 683);
            Controls.Add(dtvabono);
            Controls.Add(txtmontoabono);
            Controls.Add(cmbcréditoabono);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(iconPictureBox1);
            Controls.Add(btnvolverAbono);
            Controls.Add(btneliminarAbono);
            Controls.Add(btnguardarAbono);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormAbono";
            Text = "FormAbono";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtvabono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnguardarAbono;
        private FontAwesome.Sharp.IconButton btneliminarAbono;
        private FontAwesome.Sharp.IconButton btnvolverAbono;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbcréditoabono;
        private TextBox txtmontoabono;
        private Panel panel1;
        private DataGridView dtvabono;
        private Panel panel2;
        private Panel panel3;
    }
}