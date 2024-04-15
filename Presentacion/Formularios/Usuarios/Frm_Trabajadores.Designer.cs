
namespace Presentacion.Usuarios
{
    partial class Frm_Trabajadores
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbtnFemino = new Presentacion.CustomControls.RJRadioButton();
            this.rbtnMasculino = new Presentacion.CustomControls.RJRadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxApellidoMaterno = new Presentacion.CustomControls.RJTextBox();
            this.tboxApellidoPaterno = new Presentacion.CustomControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxNombres = new Presentacion.CustomControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxDni = new Presentacion.CustomControls.RJTextBox();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.rbtnFemino);
            this.panel1.Controls.Add(this.rbtnMasculino);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tboxApellidoMaterno);
            this.panel1.Controls.Add(this.tboxApellidoPaterno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tboxNombres);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tboxDni);
            this.panel1.Location = new System.Drawing.Point(12, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 526);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(119)))), ((int)(((byte)(135)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(119)))), ((int)(((byte)(135)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(11, 9);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 48;
            this.iconPictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(47, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 23);
            this.label9.TabIndex = 47;
            this.label9.Text = "Datos del Trabajador";
            // 
            // rbtnFemino
            // 
            this.rbtnFemino.AutoSize = true;
            this.rbtnFemino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.rbtnFemino.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.rbtnFemino.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.rbtnFemino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.rbtnFemino.Location = new System.Drawing.Point(151, 376);
            this.rbtnFemino.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnFemino.Name = "rbtnFemino";
            this.rbtnFemino.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnFemino.Size = new System.Drawing.Size(108, 24);
            this.rbtnFemino.TabIndex = 20;
            this.rbtnFemino.TabStop = true;
            this.rbtnFemino.Text = "Femenino";
            this.rbtnFemino.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnFemino.UseVisualStyleBackColor = false;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.rbtnMasculino.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(86)))));
            this.rbtnMasculino.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.rbtnMasculino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.rbtnMasculino.Location = new System.Drawing.Point(16, 376);
            this.rbtnMasculino.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnMasculino.Size = new System.Drawing.Size(112, 24);
            this.rbtnMasculino.TabIndex = 19;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnMasculino.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(12, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Apellido Materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(12, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Apellido Paterno";
            // 
            // tboxApellidoMaterno
            // 
            this.tboxApellidoMaterno.BackColor = System.Drawing.SystemColors.Window;
            this.tboxApellidoMaterno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxApellidoMaterno.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tboxApellidoMaterno.BorderRadius = 1;
            this.tboxApellidoMaterno.BorderSize = 1;
            this.tboxApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxApellidoMaterno.ForeColor = System.Drawing.Color.DimGray;
            this.tboxApellidoMaterno.Location = new System.Drawing.Point(16, 231);
            this.tboxApellidoMaterno.Margin = new System.Windows.Forms.Padding(4);
            this.tboxApellidoMaterno.Multiline = false;
            this.tboxApellidoMaterno.Name = "tboxApellidoMaterno";
            this.tboxApellidoMaterno.Padding = new System.Windows.Forms.Padding(7);
            this.tboxApellidoMaterno.PasswordChar = false;
            this.tboxApellidoMaterno.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxApellidoMaterno.PlaceholderText = "";
            this.tboxApellidoMaterno.ReadOnly = false;
            this.tboxApellidoMaterno.Size = new System.Drawing.Size(981, 31);
            this.tboxApellidoMaterno.TabIndex = 13;
            this.tboxApellidoMaterno.Texts = "";
            this.tboxApellidoMaterno.UnderlinedStyle = false;
            // 
            // tboxApellidoPaterno
            // 
            this.tboxApellidoPaterno.BackColor = System.Drawing.SystemColors.Window;
            this.tboxApellidoPaterno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxApellidoPaterno.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tboxApellidoPaterno.BorderRadius = 1;
            this.tboxApellidoPaterno.BorderSize = 1;
            this.tboxApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxApellidoPaterno.ForeColor = System.Drawing.Color.DimGray;
            this.tboxApellidoPaterno.Location = new System.Drawing.Point(16, 303);
            this.tboxApellidoPaterno.Margin = new System.Windows.Forms.Padding(4);
            this.tboxApellidoPaterno.Multiline = false;
            this.tboxApellidoPaterno.Name = "tboxApellidoPaterno";
            this.tboxApellidoPaterno.Padding = new System.Windows.Forms.Padding(7);
            this.tboxApellidoPaterno.PasswordChar = false;
            this.tboxApellidoPaterno.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxApellidoPaterno.PlaceholderText = "";
            this.tboxApellidoPaterno.ReadOnly = false;
            this.tboxApellidoPaterno.Size = new System.Drawing.Size(981, 31);
            this.tboxApellidoPaterno.TabIndex = 12;
            this.tboxApellidoPaterno.Texts = "";
            this.tboxApellidoPaterno.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombres";
            // 
            // tboxNombres
            // 
            this.tboxNombres.BackColor = System.Drawing.SystemColors.Window;
            this.tboxNombres.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxNombres.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tboxNombres.BorderRadius = 1;
            this.tboxNombres.BorderSize = 1;
            this.tboxNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNombres.ForeColor = System.Drawing.Color.DimGray;
            this.tboxNombres.Location = new System.Drawing.Point(16, 152);
            this.tboxNombres.Margin = new System.Windows.Forms.Padding(4);
            this.tboxNombres.Multiline = false;
            this.tboxNombres.Name = "tboxNombres";
            this.tboxNombres.Padding = new System.Windows.Forms.Padding(7);
            this.tboxNombres.PasswordChar = false;
            this.tboxNombres.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxNombres.PlaceholderText = "";
            this.tboxNombres.ReadOnly = false;
            this.tboxNombres.Size = new System.Drawing.Size(981, 31);
            this.tboxNombres.TabIndex = 10;
            this.tboxNombres.Texts = "";
            this.tboxNombres.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dni";
            // 
            // tboxDni
            // 
            this.tboxDni.BackColor = System.Drawing.SystemColors.Window;
            this.tboxDni.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxDni.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tboxDni.BorderRadius = 1;
            this.tboxDni.BorderSize = 1;
            this.tboxDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDni.ForeColor = System.Drawing.Color.DimGray;
            this.tboxDni.Location = new System.Drawing.Point(16, 77);
            this.tboxDni.Margin = new System.Windows.Forms.Padding(4);
            this.tboxDni.Multiline = false;
            this.tboxDni.Name = "tboxDni";
            this.tboxDni.Padding = new System.Windows.Forms.Padding(7);
            this.tboxDni.PasswordChar = false;
            this.tboxDni.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxDni.PlaceholderText = "";
            this.tboxDni.ReadOnly = false;
            this.tboxDni.Size = new System.Drawing.Size(981, 31);
            this.tboxDni.TabIndex = 7;
            this.tboxDni.Texts = "";
            this.tboxDni.UnderlinedStyle = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
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
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "    Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
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
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "    Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(884, 558);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(148, 40);
            this.iconButton1.TabIndex = 57;
            this.iconButton1.Text = "Cancelar";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // Frm_Trabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1044, 610);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Trabajadores";
            this.Text = "Frm_Normas";
            this.Load += new System.EventHandler(this.Frm_Normas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJTextBox tboxDni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJTextBox tboxApellidoMaterno;
        private CustomControls.RJTextBox tboxApellidoPaterno;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJTextBox tboxNombres;
        public CustomControls.RJRadioButton rbtnFemino;
        public CustomControls.RJRadioButton rbtnMasculino;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label9;
    }
}