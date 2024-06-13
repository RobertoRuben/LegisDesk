
namespace Presentacion.Formularios.Usuarios
{
    partial class Form_UsuarioActualizarCredenciales
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
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxNombreUsuario = new Presentacion.CustomControls.RJTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxContraseña = new Presentacion.CustomControls.RJTextBox();
            this.tboxConfirmacion = new Presentacion.CustomControls.RJTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(884, 558);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 40);
            this.btnSalir.TabIndex = 61;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnGuardar.IconSize = 32;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(12, 558);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 40);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "    Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tboxNombreUsuario);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tboxContraseña);
            this.panel1.Controls.Add(this.tboxConfirmacion);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 289);
            this.panel1.TabIndex = 58;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(119)))), ((int)(((byte)(135)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(119)))), ((int)(((byte)(135)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(13, 6);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 46;
            this.iconPictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(9, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre de Usuario";
            // 
            // tboxNombreUsuario
            // 
            this.tboxNombreUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.tboxNombreUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxNombreUsuario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.tboxNombreUsuario.BorderRadius = 1;
            this.tboxNombreUsuario.BorderSize = 1;
            this.tboxNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tboxNombreUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.tboxNombreUsuario.Location = new System.Drawing.Point(13, 80);
            this.tboxNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tboxNombreUsuario.Multiline = false;
            this.tboxNombreUsuario.Name = "tboxNombreUsuario";
            this.tboxNombreUsuario.Padding = new System.Windows.Forms.Padding(7);
            this.tboxNombreUsuario.PasswordChar = false;
            this.tboxNombreUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxNombreUsuario.PlaceholderText = "";
            this.tboxNombreUsuario.ReadOnly = false;
            this.tboxNombreUsuario.Size = new System.Drawing.Size(987, 35);
            this.tboxNombreUsuario.TabIndex = 0;
            this.tboxNombreUsuario.Texts = "";
            this.tboxNombreUsuario.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(43, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Actualizar Credenciales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(11, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(11, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Confirmar Contraseña";
            // 
            // tboxContraseña
            // 
            this.tboxContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.tboxContraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxContraseña.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.tboxContraseña.BorderRadius = 1;
            this.tboxContraseña.BorderSize = 1;
            this.tboxContraseña.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tboxContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.tboxContraseña.Location = new System.Drawing.Point(15, 151);
            this.tboxContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.tboxContraseña.Multiline = false;
            this.tboxContraseña.Name = "tboxContraseña";
            this.tboxContraseña.Padding = new System.Windows.Forms.Padding(7);
            this.tboxContraseña.PasswordChar = true;
            this.tboxContraseña.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxContraseña.PlaceholderText = "";
            this.tboxContraseña.ReadOnly = false;
            this.tboxContraseña.Size = new System.Drawing.Size(985, 35);
            this.tboxContraseña.TabIndex = 0;
            this.tboxContraseña.Texts = "";
            this.tboxContraseña.UnderlinedStyle = false;
            // 
            // tboxConfirmacion
            // 
            this.tboxConfirmacion.BackColor = System.Drawing.SystemColors.Window;
            this.tboxConfirmacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxConfirmacion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.tboxConfirmacion.BorderRadius = 1;
            this.tboxConfirmacion.BorderSize = 1;
            this.tboxConfirmacion.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tboxConfirmacion.ForeColor = System.Drawing.Color.DimGray;
            this.tboxConfirmacion.Location = new System.Drawing.Point(15, 224);
            this.tboxConfirmacion.Margin = new System.Windows.Forms.Padding(4);
            this.tboxConfirmacion.Multiline = false;
            this.tboxConfirmacion.Name = "tboxConfirmacion";
            this.tboxConfirmacion.Padding = new System.Windows.Forms.Padding(7);
            this.tboxConfirmacion.PasswordChar = true;
            this.tboxConfirmacion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxConfirmacion.PlaceholderText = "";
            this.tboxConfirmacion.ReadOnly = false;
            this.tboxConfirmacion.Size = new System.Drawing.Size(985, 35);
            this.tboxConfirmacion.TabIndex = 0;
            this.tboxConfirmacion.Texts = "";
            this.tboxConfirmacion.UnderlinedStyle = false;
            // 
            // Form_UsuarioActualizarCredenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1044, 610);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_UsuarioActualizarCredenciales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_UsuarioActualizarCredenciales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label6;
        public CustomControls.RJTextBox tboxNombreUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public CustomControls.RJTextBox tboxContraseña;
        public CustomControls.RJTextBox tboxConfirmacion;
    }
}