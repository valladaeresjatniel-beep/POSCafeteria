namespace POSCafeteria
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            label1 = new Label();
            lblBienvenido = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            lblUsuario = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            lblRol = new Label();
            label6 = new Label();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            lblFecha = new Label();
            label8 = new Label();
            btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(507, 36);
            label1.TabIndex = 3;
            label1.Text = "Mueblería Expo Muebles Cruz";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBienvenido.ForeColor = Color.Black;
            lblBienvenido.Location = new Point(142, 64);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(163, 28);
            lblBienvenido.TabIndex = 4;
            lblBienvenido.Text = "¡Bienvenido(a) !";
            lblBienvenido.UseWaitCursor = true;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Linen;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 30;
            iconPictureBox1.Location = new Point(648, 102);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(30, 30);
            iconPictureBox1.TabIndex = 5;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(684, 98);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 6;
            label3.Text = "Usuario:";
            label3.UseWaitCursor = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(684, 118);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 20);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "User";
            lblUsuario.UseWaitCursor = true;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Linen;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ShieldBlank;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 30;
            iconPictureBox2.Location = new Point(851, 102);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(30, 30);
            iconPictureBox2.TabIndex = 8;
            iconPictureBox2.TabStop = false;
            iconPictureBox2.UseWaitCursor = true;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(887, 122);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(104, 20);
            lblRol.TabIndex = 10;
            lblRol.Text = "Administrador";
            lblRol.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(887, 102);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 9;
            label6.Text = "Rol:";
            label6.UseWaitCursor = true;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.Linen;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 30;
            iconPictureBox3.Location = new Point(1043, 98);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(30, 30);
            iconPictureBox3.TabIndex = 11;
            iconPictureBox3.TabStop = false;
            iconPictureBox3.UseWaitCursor = true;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(1079, 122);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(77, 20);
            lblFecha.TabIndex = 13;
            lblFecha.Text = "29/5/2026";
            lblFecha.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(1079, 102);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 12;
            label8.Text = "Fecha:";
            label8.UseWaitCursor = true;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Brown;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnCerrarSesion.IconColor = Color.White;
            btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleRight;
            btnCerrarSesion.Location = new Point(1101, 25);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(119, 45);
            btnCerrarSesion.TabIndex = 15;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.UseWaitCursor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // button2
            // 
            button2.Location = new Point(684, 14);
            button2.Name = "button2";
            button2.Size = new Size(129, 38);
            button2.TabIndex = 17;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            // 
            // button3
            // 
            button3.Location = new Point(824, 9);
            button3.Name = "button3";
            button3.Size = new Size(140, 45);
            button3.TabIndex = 18;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.AntiqueWhite;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(33, 143);
            button1.Name = "button1";
            button1.Size = new Size(130, 117);
            button1.TabIndex = 19;
            button1.Text = "Cliente";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.AntiqueWhite;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(30, 282);
            button4.Name = "button4";
            button4.Size = new Size(133, 108);
            button4.TabIndex = 20;
            button4.Text = "Crédito";
            button4.UseVisualStyleBackColor = false;
            button4.UseWaitCursor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1276, 696);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblFecha);
            Controls.Add(label8);
            Controls.Add(iconPictureBox3);
            Controls.Add(lblRol);
            Controls.Add(label6);
            Controls.Add(iconPictureBox2);
            Controls.Add(lblUsuario);
            Controls.Add(label3);
            Controls.Add(iconPictureBox1);
            Controls.Add(lblBienvenido);
            Controls.Add(label1);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            UseWaitCursor = true;
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblBienvenido;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label3;
        private Label lblUsuario;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label lblRol;
        private Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label lblFecha;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private Button button2;
        private Button button3;
        private Button button1;
        private Button button4;
    }
}