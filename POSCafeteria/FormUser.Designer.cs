namespace POSCafeteria
{
    partial class FormUser
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
            btnguardaruser = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnborraruser = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnguardaruser
            // 
            btnguardaruser.BackColor = Color.ForestGreen;
            btnguardaruser.FlatStyle = FlatStyle.Popup;
            btnguardaruser.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnguardaruser.ForeColor = Color.White;
            btnguardaruser.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnguardaruser.IconColor = Color.White;
            btnguardaruser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardaruser.Location = new Point(324, 296);
            btnguardaruser.Name = "btnguardaruser";
            btnguardaruser.Size = new Size(85, 76);
            btnguardaruser.TabIndex = 0;
            btnguardaruser.Text = "Guardar";
            btnguardaruser.TextAlign = ContentAlignment.BottomCenter;
            btnguardaruser.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 20);
            label1.Name = "label1";
            label1.Size = new Size(507, 36);
            label1.TabIndex = 1;
            label1.Text = "Mueblería Expo Muebles Cruz";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(125, 55);
            label2.Name = "label2";
            label2.Size = new Size(284, 25);
            label2.TabIndex = 2;
            label2.Text = "Administración de Usuario ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(177, 28);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 3;
            label3.Text = "Nombre Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(168, 81);
            label4.Name = "label4";
            label4.Size = new Size(182, 20);
            label4.TabIndex = 4;
            label4.Text = "Contraseña Actual";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(169, 134);
            label5.Name = "label5";
            label5.Size = new Size(181, 20);
            label5.TabIndex = 5;
            label5.Text = "Contraseña Nueva";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(158, 197);
            label6.Name = "label6";
            label6.Size = new Size(216, 20);
            label6.TabIndex = 6;
            label6.Text = "Confirmar Contraseña";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(352, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(90, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(352, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(90, 104);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(352, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(90, 220);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(352, 27);
            textBox4.TabIndex = 11;
            // 
            // btnborraruser
            // 
            btnborraruser.BackColor = Color.Firebrick;
            btnborraruser.FlatStyle = FlatStyle.Popup;
            btnborraruser.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnborraruser.ForeColor = Color.White;
            btnborraruser.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnborraruser.IconColor = Color.White;
            btnborraruser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnborraruser.Location = new Point(212, 296);
            btnborraruser.Name = "btnborraruser";
            btnborraruser.Size = new Size(87, 76);
            btnborraruser.TabIndex = 12;
            btnborraruser.Text = "Borrar";
            btnborraruser.TextAlign = ContentAlignment.BottomCenter;
            btnborraruser.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.LightCoral;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Reply;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(101, 296);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(87, 76);
            iconButton3.TabIndex = 13;
            iconButton3.Text = "Volver";
            iconButton3.TextAlign = ContentAlignment.BottomCenter;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(btnborraruser);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnguardaruser);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 406);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(523, 99);
            panel2.TabIndex = 15;
            panel2.Paint += panel2_Paint;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(560, 548);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "FormUser";
            Text = "FormUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnguardaruser;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private FontAwesome.Sharp.IconButton btnborraruser;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Panel panel1;
        private Panel panel2;
    }
}