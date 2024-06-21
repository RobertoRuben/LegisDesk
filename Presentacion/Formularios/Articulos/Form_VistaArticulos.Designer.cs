
namespace Presentacion.Formularios.Articulos
{
    partial class Form_VistaArticulos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxDescripcion = new Presentacion.CustomControls.RJTextBox();
            this.tboxDenominacion = new Presentacion.CustomControls.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxArticulo = new Presentacion.CustomControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxEstado = new Presentacion.CustomControls.RJTextBox();
            this.tboxPaginas = new Presentacion.CustomControls.RJTextBox();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panel2.Controls.Add(this.tboxPaginas);
            this.panel2.Controls.Add(this.tboxEstado);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tboxDescripcion);
            this.panel2.Controls.Add(this.tboxDenominacion);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tboxArticulo);
            this.panel2.Controls.Add(this.iconPictureBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 378);
            this.panel2.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label8.Location = new System.Drawing.Point(253, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 65;
            this.label8.Text = "Página";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label7.Location = new System.Drawing.Point(13, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 52;
            this.label7.Text = "Estado";
            // 
            // tboxDescripcion
            // 
            this.tboxDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.tboxDescripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxDescripcion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.tboxDescripcion.BorderRadius = 1;
            this.tboxDescripcion.BorderSize = 1;
            this.tboxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.tboxDescripcion.Location = new System.Drawing.Point(17, 220);
            this.tboxDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.tboxDescripcion.Multiline = true;
            this.tboxDescripcion.Name = "tboxDescripcion";
            this.tboxDescripcion.Padding = new System.Windows.Forms.Padding(7);
            this.tboxDescripcion.PasswordChar = false;
            this.tboxDescripcion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxDescripcion.PlaceholderText = "";
            this.tboxDescripcion.ReadOnly = true;
            this.tboxDescripcion.Size = new System.Drawing.Size(988, 65);
            this.tboxDescripcion.TabIndex = 51;
            this.tboxDescripcion.Texts = "";
            this.tboxDescripcion.UnderlinedStyle = false;
            // 
            // tboxDenominacion
            // 
            this.tboxDenominacion.BackColor = System.Drawing.SystemColors.Window;
            this.tboxDenominacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxDenominacion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.tboxDenominacion.BorderRadius = 1;
            this.tboxDenominacion.BorderSize = 1;
            this.tboxDenominacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDenominacion.ForeColor = System.Drawing.Color.DimGray;
            this.tboxDenominacion.Location = new System.Drawing.Point(17, 150);
            this.tboxDenominacion.Margin = new System.Windows.Forms.Padding(4);
            this.tboxDenominacion.Multiline = false;
            this.tboxDenominacion.Name = "tboxDenominacion";
            this.tboxDenominacion.Padding = new System.Windows.Forms.Padding(7);
            this.tboxDenominacion.PasswordChar = false;
            this.tboxDenominacion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxDenominacion.PlaceholderText = "";
            this.tboxDenominacion.ReadOnly = true;
            this.tboxDenominacion.Size = new System.Drawing.Size(988, 31);
            this.tboxDenominacion.TabIndex = 50;
            this.tboxDenominacion.Texts = "";
            this.tboxDenominacion.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(13, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 19);
            this.label6.TabIndex = 49;
            this.label6.Text = "Denominacíon";
            // 
            // tboxArticulo
            // 
            this.tboxArticulo.BackColor = System.Drawing.SystemColors.Window;
            this.tboxArticulo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxArticulo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.tboxArticulo.BorderRadius = 1;
            this.tboxArticulo.BorderSize = 1;
            this.tboxArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxArticulo.ForeColor = System.Drawing.Color.DimGray;
            this.tboxArticulo.Location = new System.Drawing.Point(14, 82);
            this.tboxArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.tboxArticulo.Multiline = false;
            this.tboxArticulo.Name = "tboxArticulo";
            this.tboxArticulo.Padding = new System.Windows.Forms.Padding(7);
            this.tboxArticulo.PasswordChar = false;
            this.tboxArticulo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxArticulo.PlaceholderText = "";
            this.tboxArticulo.ReadOnly = true;
            this.tboxArticulo.Size = new System.Drawing.Size(988, 31);
            this.tboxArticulo.TabIndex = 48;
            this.tboxArticulo.Texts = "";
            this.tboxArticulo.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(50, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "Datos del Artículo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(13, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Descripcion:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(10, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Artículo:";
            // 
            // tboxEstado
            // 
            this.tboxEstado.BackColor = System.Drawing.SystemColors.Window;
            this.tboxEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxEstado.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.tboxEstado.BorderRadius = 1;
            this.tboxEstado.BorderSize = 1;
            this.tboxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEstado.ForeColor = System.Drawing.Color.DimGray;
            this.tboxEstado.Location = new System.Drawing.Point(17, 324);
            this.tboxEstado.Margin = new System.Windows.Forms.Padding(4);
            this.tboxEstado.Multiline = false;
            this.tboxEstado.Name = "tboxEstado";
            this.tboxEstado.Padding = new System.Windows.Forms.Padding(7);
            this.tboxEstado.PasswordChar = false;
            this.tboxEstado.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxEstado.PlaceholderText = "";
            this.tboxEstado.ReadOnly = true;
            this.tboxEstado.Size = new System.Drawing.Size(215, 31);
            this.tboxEstado.TabIndex = 66;
            this.tboxEstado.Texts = "";
            this.tboxEstado.UnderlinedStyle = false;
            // 
            // tboxPaginas
            // 
            this.tboxPaginas.BackColor = System.Drawing.SystemColors.Window;
            this.tboxPaginas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.tboxPaginas.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.tboxPaginas.BorderRadius = 1;
            this.tboxPaginas.BorderSize = 1;
            this.tboxPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPaginas.ForeColor = System.Drawing.Color.DimGray;
            this.tboxPaginas.Location = new System.Drawing.Point(257, 324);
            this.tboxPaginas.Margin = new System.Windows.Forms.Padding(4);
            this.tboxPaginas.Multiline = false;
            this.tboxPaginas.Name = "tboxPaginas";
            this.tboxPaginas.Padding = new System.Windows.Forms.Padding(7);
            this.tboxPaginas.PasswordChar = false;
            this.tboxPaginas.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tboxPaginas.PlaceholderText = "";
            this.tboxPaginas.ReadOnly = true;
            this.tboxPaginas.Size = new System.Drawing.Size(103, 31);
            this.tboxPaginas.TabIndex = 67;
            this.tboxPaginas.Texts = "";
            this.tboxPaginas.UnderlinedStyle = false;
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
            this.btnSalir.Location = new System.Drawing.Point(884, 559);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 40);
            this.btnSalir.TabIndex = 68;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(119)))), ((int)(((byte)(135)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(119)))), ((int)(((byte)(135)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(14, 7);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 46;
            this.iconPictureBox2.TabStop = false;
            // 
            // Form_VistaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1044, 610);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_VistaArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Panel panel2;
        public CustomControls.RJTextBox tboxPaginas;
        public CustomControls.RJTextBox tboxEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public CustomControls.RJTextBox tboxDescripcion;
        public CustomControls.RJTextBox tboxDenominacion;
        private System.Windows.Forms.Label label6;
        public CustomControls.RJTextBox tboxArticulo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}