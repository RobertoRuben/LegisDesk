
namespace Presentacion.Usuarios
{
    partial class Form_RegistrarUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboxRol = new Presentacion.CustomControls.RJComboBox();
            this.cboxTrabajadores = new Presentacion.CustomControls.RJComboBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxNombreUsuario = new Presentacion.CustomControls.RJTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbtnInactivo = new Presentacion.CustomControls.RJRadioButton();
            this.rbtnActivo = new Presentacion.CustomControls.RJRadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxContraseña = new Presentacion.CustomControls.RJTextBox();
            this.tboxConfirmacion = new Presentacion.CustomControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.cboxRol);
            this.panel1.Controls.Add(this.cboxTrabajadores);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tboxNombreUsuario);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.rbtnInactivo);
            this.panel1.Controls.Add(this.rbtnActivo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tboxContraseña);
            this.panel1.Controls.Add(this.tboxConfirmacion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 428);
            this.panel1.TabIndex = 46;
            // 
            // cboxRol
            // 
            this.cboxRol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxRol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxRol.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboxRol.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.cboxRol.BorderSize = 1;
            this.cboxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboxRol.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.cboxRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.cboxRol.IconColor = System.Drawing.Color.Silver;
            this.cboxRol.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboxRol.ListTextColor = System.Drawing.Color.DimGray;
            this.cboxRol.Location = new System.Drawing.Point(15, 373);
            this.cboxRol.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboxRol.Name = "cboxRol";
            this.cboxRol.Padding = new System.Windows.Forms.Padding(1);
            this.cboxRol.SelectedValue = null;
            this.cboxRol.Size = new System.Drawing.Size(476, 34);
            this.cboxRol.TabIndex = 50;
            this.cboxRol.Texts = "";
            // 
            // cboxTrabajadores
            // 
            this.cboxTrabajadores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxTrabajadores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxTrabajadores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboxTrabajadores.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.cboxTrabajadores.BorderSize = 1;
            this.cboxTrabajadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboxTrabajadores.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.cboxTrabajadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.cboxTrabajadores.IconColor = System.Drawing.Color.Silver;
            this.cboxTrabajadores.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboxTrabajadores.ListTextColor = System.Drawing.Color.DimGray;
            this.cboxTrabajadores.Location = new System.Drawing.Point(13, 91);
            this.cboxTrabajadores.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboxTrabajadores.Name = "cboxTrabajadores";
            this.cboxTrabajadores.Padding = new System.Windows.Forms.Padding(1);
            this.cboxTrabajadores.SelectedValue = null;
            this.cboxTrabajadores.Size = new System.Drawing.Size(987, 34);
            this.cboxTrabajadores.TabIndex = 49;
            this.cboxTrabajadores.Texts = "";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(119)))), ((int)(((byte)(135)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(119)))), ((int)(((byte)(135)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(13, 13);
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
            this.label6.Location = new System.Drawing.Point(9, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 19);
            this.label6.TabIndex = 45;
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
            this.tboxNombreUsuario.Location = new System.Drawing.Point(13, 159);
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
            this.label9.Location = new System.Drawing.Point(43, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 23);
            this.label9.TabIndex = 43;
            this.label9.Text = "Datos de Usuario";
            // 
            // rbtnInactivo
            // 
            this.rbtnInactivo.AutoSize = true;
            this.rbtnInactivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.rbtnInactivo.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.rbtnInactivo.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.rbtnInactivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.rbtnInactivo.Location = new System.Drawing.Point(604, 383);
            this.rbtnInactivo.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnInactivo.Name = "rbtnInactivo";
            this.rbtnInactivo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnInactivo.Size = new System.Drawing.Size(99, 24);
            this.rbtnInactivo.TabIndex = 20;
            this.rbtnInactivo.Text = "Inactivo";
            this.rbtnInactivo.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnInactivo.UseVisualStyleBackColor = false;
            // 
            // rbtnActivo
            // 
            this.rbtnActivo.AutoSize = true;
            this.rbtnActivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.rbtnActivo.Checked = true;
            this.rbtnActivo.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.rbtnActivo.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.rbtnActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.rbtnActivo.Location = new System.Drawing.Point(512, 383);
            this.rbtnActivo.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnActivo.Name = "rbtnActivo";
            this.rbtnActivo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnActivo.Size = new System.Drawing.Size(86, 24);
            this.rbtnActivo.TabIndex = 19;
            this.rbtnActivo.TabStop = true;
            this.rbtnActivo.Text = "Activo";
            this.rbtnActivo.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnActivo.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(11, 205);
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
            this.label3.Location = new System.Drawing.Point(11, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Confirmar Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(508, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Estado";
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
            this.tboxContraseña.Location = new System.Drawing.Point(15, 230);
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
            this.tboxConfirmacion.Location = new System.Drawing.Point(15, 303);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(11, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(9, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Trabajador";
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
            this.btnGuardar.TabIndex = 55;
            this.btnGuardar.Text = "    Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 32;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(166, 558);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 40);
            this.btnCancelar.TabIndex = 56;
            this.btnCancelar.Text = "    Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
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
            this.btnSalir.TabIndex = 57;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form_RegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1044, 610);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_RegistrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_RegistrarUsuarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public CustomControls.RJRadioButton rbtnInactivo;
        public CustomControls.RJRadioButton rbtnActivo;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public CustomControls.RJComboBox cboxTrabajadores;
        public CustomControls.RJComboBox cboxRol;
        public CustomControls.RJTextBox tboxNombreUsuario;
        public CustomControls.RJTextBox tboxContraseña;
        public CustomControls.RJTextBox tboxConfirmacion;
    }
}