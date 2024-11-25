namespace ProyectoDesarrollo
{
    partial class Login
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
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            label4 = new Label();
            btncancelar = new FontAwesome.Sharp.IconButton();
            btningresar = new FontAwesome.Sharp.IconButton();
            txtdocumento = new TextBox();
            txtcontaseña = new TextBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.SteelBlue;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(252, 359);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 243);
            label2.Name = "label2";
            label2.Size = new Size(219, 32);
            label2.TabIndex = 1;
            label2.Text = "Sistema de Ventas";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.SteelBlue;
            iconPictureBox1.ForeColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            iconPictureBox1.IconColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 187;
            iconPictureBox1.Location = new Point(12, 53);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(232, 187);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            label3.Location = new Point(324, 85);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 5;
            label3.Text = "Nro. Documento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            label4.Location = new Point(324, 155);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.FromArgb(192, 0, 0);
            btncancelar.Cursor = Cursors.Hand;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btncancelar.ForeColor = Color.White;
            btncancelar.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            btncancelar.IconColor = Color.White;
            btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btncancelar.IconSize = 40;
            btncancelar.Location = new Point(519, 264);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(124, 49);
            btncancelar.TabIndex = 8;
            btncancelar.Text = "Cancelar";
            btncancelar.TextAlign = ContentAlignment.MiddleRight;
            btncancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // btningresar
            // 
            btningresar.BackColor = Color.SteelBlue;
            btningresar.Cursor = Cursors.Hand;
            btningresar.FlatStyle = FlatStyle.Flat;
            btningresar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btningresar.ForeColor = Color.White;
            btningresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btningresar.IconColor = Color.White;
            btningresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btningresar.IconSize = 40;
            btningresar.Location = new Point(340, 264);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(124, 49);
            btningresar.TabIndex = 9;
            btningresar.Text = "Inicio";
            btningresar.TextAlign = ContentAlignment.MiddleRight;
            btningresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += btningresar_Click;
            // 
            // txtdocumento
            // 
            txtdocumento.Location = new Point(324, 103);
            txtdocumento.Name = "txtdocumento";
            txtdocumento.Size = new Size(300, 23);
            txtdocumento.TabIndex = 10;
            // 
            // txtcontaseña
            // 
            txtcontaseña.Location = new Point(324, 173);
            txtcontaseña.Name = "txtcontaseña";
            txtcontaseña.PasswordChar = '*';
            txtcontaseña.Size = new Size(300, 23);
            txtcontaseña.TabIndex = 11;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 359);
            Controls.Add(txtcontaseña);
            Controls.Add(txtdocumento);
            Controls.Add(btningresar);
            Controls.Add(btncancelar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(iconPictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btningresar;
        private TextBox txtdocumento;
        private TextBox txtcontaseña;
    }
}