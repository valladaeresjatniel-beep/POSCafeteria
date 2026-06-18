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
            label1 = new Label();
            lblBienvenido = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            lblUsuario = new Label();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            lblFecha = new Label();
            label8 = new Label();
            btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            btnUsuarioprincipal = new FontAwesome.Sharp.IconButton();
            btnVentasprincipal = new FontAwesome.Sharp.IconButton();
            btnClientesprincipal = new FontAwesome.Sharp.IconButton();
            btnAbonoprincipal = new FontAwesome.Sharp.IconButton();
            btnProductoprincipal = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
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
            lblBienvenido.BackColor = Color.AntiqueWhite;
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
            iconPictureBox1.BackColor = Color.AntiqueWhite;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 30;
            iconPictureBox1.Location = new Point(573, 53);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(30, 30);
            iconPictureBox1.TabIndex = 5;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AntiqueWhite;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(609, 49);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 6;
            label3.Text = "Usuario:";
            label3.UseWaitCursor = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.AntiqueWhite;
            lblUsuario.Location = new Point(609, 69);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 20);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "User";
            lblUsuario.UseWaitCursor = true;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.AntiqueWhite;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 30;
            iconPictureBox3.Location = new Point(706, 49);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(30, 30);
            iconPictureBox3.TabIndex = 11;
            iconPictureBox3.TabStop = false;
            iconPictureBox3.UseWaitCursor = true;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.AntiqueWhite;
            lblFecha.Location = new Point(742, 73);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(77, 20);
            lblFecha.TabIndex = 13;
            lblFecha.Text = "29/5/2026";
            lblFecha.UseWaitCursor = true;
            lblFecha.Click += lblFecha_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.AntiqueWhite;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(742, 53);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 12;
            label8.Text = "Fecha:";
            label8.UseWaitCursor = true;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Firebrick;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnCerrarSesion.IconColor = Color.White;
            btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleRight;
            btnCerrarSesion.Location = new Point(857, 22);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(175, 45);
            btnCerrarSesion.TabIndex = 15;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.UseWaitCursor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnUsuarioprincipal
            // 
            btnUsuarioprincipal.BackColor = Color.Linen;
            btnUsuarioprincipal.FlatStyle = FlatStyle.Popup;
            btnUsuarioprincipal.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarioprincipal.ForeColor = SystemColors.ControlText;
            btnUsuarioprincipal.IconChar = FontAwesome.Sharp.IconChar.User;
            btnUsuarioprincipal.IconColor = Color.Black;
            btnUsuarioprincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarioprincipal.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarioprincipal.Location = new Point(3, 247);
            btnUsuarioprincipal.Name = "btnUsuarioprincipal";
            btnUsuarioprincipal.Size = new Size(297, 55);
            btnUsuarioprincipal.TabIndex = 16;
            btnUsuarioprincipal.Text = "Usuarios";
            btnUsuarioprincipal.UseVisualStyleBackColor = false;
            btnUsuarioprincipal.UseWaitCursor = true;
            btnUsuarioprincipal.Click += btnUsuarioprincipal_Click;
            // 
            // btnVentasprincipal
            // 
            btnVentasprincipal.BackColor = Color.Linen;
            btnVentasprincipal.FlatStyle = FlatStyle.Popup;
            btnVentasprincipal.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentasprincipal.IconChar = FontAwesome.Sharp.IconChar.Shop;
            btnVentasprincipal.IconColor = Color.Black;
            btnVentasprincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVentasprincipal.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentasprincipal.Location = new Point(3, 3);
            btnVentasprincipal.Name = "btnVentasprincipal";
            btnVentasprincipal.Size = new Size(297, 55);
            btnVentasprincipal.TabIndex = 17;
            btnVentasprincipal.Text = "Ventas";
            btnVentasprincipal.UseVisualStyleBackColor = false;
            btnVentasprincipal.UseWaitCursor = true;
            btnVentasprincipal.Click += btnVentasprincipal_Click;
            // 
            // btnClientesprincipal
            // 
            btnClientesprincipal.BackColor = Color.Linen;
            btnClientesprincipal.FlatStyle = FlatStyle.Popup;
            btnClientesprincipal.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientesprincipal.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            btnClientesprincipal.IconColor = Color.Black;
            btnClientesprincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClientesprincipal.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientesprincipal.Location = new Point(3, 125);
            btnClientesprincipal.Name = "btnClientesprincipal";
            btnClientesprincipal.Size = new Size(297, 55);
            btnClientesprincipal.TabIndex = 18;
            btnClientesprincipal.Text = "Clientes";
            btnClientesprincipal.UseVisualStyleBackColor = false;
            btnClientesprincipal.UseWaitCursor = true;
            btnClientesprincipal.Click += btnClientesprincipal_Click;
            // 
            // btnAbonoprincipal
            // 
            btnAbonoprincipal.BackColor = Color.Linen;
            btnAbonoprincipal.FlatStyle = FlatStyle.Popup;
            btnAbonoprincipal.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAbonoprincipal.IconChar = FontAwesome.Sharp.IconChar.Coins;
            btnAbonoprincipal.IconColor = Color.Black;
            btnAbonoprincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAbonoprincipal.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbonoprincipal.Location = new Point(3, 64);
            btnAbonoprincipal.Name = "btnAbonoprincipal";
            btnAbonoprincipal.Size = new Size(297, 55);
            btnAbonoprincipal.TabIndex = 19;
            btnAbonoprincipal.Text = "Abono";
            btnAbonoprincipal.UseVisualStyleBackColor = false;
            btnAbonoprincipal.UseWaitCursor = true;
            btnAbonoprincipal.Click += btnAbonoprincipal_Click;
            // 
            // btnProductoprincipal
            // 
            btnProductoprincipal.BackColor = Color.Linen;
            btnProductoprincipal.FlatStyle = FlatStyle.Popup;
            btnProductoprincipal.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductoprincipal.IconChar = FontAwesome.Sharp.IconChar.Table;
            btnProductoprincipal.IconColor = Color.Black;
            btnProductoprincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProductoprincipal.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductoprincipal.Location = new Point(3, 186);
            btnProductoprincipal.Name = "btnProductoprincipal";
            btnProductoprincipal.Size = new Size(297, 55);
            btnProductoprincipal.TabIndex = 20;
            btnProductoprincipal.Text = "Producto";
            btnProductoprincipal.UseVisualStyleBackColor = false;
            btnProductoprincipal.UseWaitCursor = true;
            btnProductoprincipal.Click += btnProductoprincipal_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 137);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 21;
            label2.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AntiqueWhite;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(423, 23);
            label4.Name = "label4";
            label4.Size = new Size(243, 25);
            label4.TabIndex = 22;
            label4.Text = "Módulos del Sistema";
            label4.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(-1, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 488);
            panel1.TabIndex = 23;
            panel1.UseWaitCursor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.NavajoWhite;
            flowLayoutPanel1.Controls.Add(btnVentasprincipal);
            flowLayoutPanel1.Controls.Add(btnAbonoprincipal);
            flowLayoutPanel1.Controls.Add(btnClientesprincipal);
            flowLayoutPanel1.Controls.Add(btnProductoprincipal);
            flowLayoutPanel1.Controls.Add(btnUsuarioprincipal);
            flowLayoutPanel1.Location = new Point(389, 63);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(303, 308);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.UseWaitCursor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AntiqueWhite;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(-1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(530, 120);
            panel2.TabIndex = 24;
            panel2.UseWaitCursor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1047, 512);
            Controls.Add(label2);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblFecha);
            Controls.Add(label8);
            Controls.Add(iconPictureBox3);
            Controls.Add(lblUsuario);
            Controls.Add(label3);
            Controls.Add(iconPictureBox1);
            Controls.Add(lblBienvenido);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            UseWaitCursor = true;
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton btnUsuarioprincipal;
        private FontAwesome.Sharp.IconButton btnVentasprincipal;
        private FontAwesome.Sharp.IconButton btnClientesprincipal;
        private FontAwesome.Sharp.IconButton btnAbonoprincipal;
        private FontAwesome.Sharp.IconButton btnProductoprincipal;
        private Label label2;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}