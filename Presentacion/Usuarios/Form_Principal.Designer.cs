
namespace Presentacion
{
    partial class Form_Main
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
            this.pMenuLateral = new System.Windows.Forms.Panel();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.pSubMenuUsuarios = new System.Windows.Forms.Panel();
            this.btnTipoNormas = new FontAwesome.Sharp.IconButton();
            this.btnArticulos = new FontAwesome.Sharp.IconButton();
            this.btnNormas = new FontAwesome.Sharp.IconButton();
            this.btnConsultas = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBarraSuperior = new System.Windows.Forms.Panel();
            this.pContenedor = new System.Windows.Forms.Panel();
            this.pMenuLateral.SuspendLayout();
            this.pSubMenuUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenuLateral
            // 
            this.pMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pMenuLateral.Controls.Add(this.btnSalir);
            this.pMenuLateral.Controls.Add(this.btnUsuarios);
            this.pMenuLateral.Controls.Add(this.pSubMenuUsuarios);
            this.pMenuLateral.Controls.Add(this.btnNormas);
            this.pMenuLateral.Controls.Add(this.btnConsultas);
            this.pMenuLateral.Controls.Add(this.panel1);
            this.pMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pMenuLateral.Name = "pMenuLateral";
            this.pMenuLateral.Size = new System.Drawing.Size(220, 681);
            this.pMenuLateral.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.btnSalir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 621);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSalir.Size = new System.Drawing.Size(220, 60);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnUsuarios.IconColor = System.Drawing.Color.White;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 32;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 369);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(220, 60);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // pSubMenuUsuarios
            // 
            this.pSubMenuUsuarios.Controls.Add(this.btnTipoNormas);
            this.pSubMenuUsuarios.Controls.Add(this.btnArticulos);
            this.pSubMenuUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSubMenuUsuarios.Location = new System.Drawing.Point(0, 272);
            this.pSubMenuUsuarios.Name = "pSubMenuUsuarios";
            this.pSubMenuUsuarios.Size = new System.Drawing.Size(220, 97);
            this.pSubMenuUsuarios.TabIndex = 4;
            // 
            // btnTipoNormas
            // 
            this.btnTipoNormas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTipoNormas.FlatAppearance.BorderSize = 0;
            this.btnTipoNormas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoNormas.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoNormas.ForeColor = System.Drawing.Color.White;
            this.btnTipoNormas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTipoNormas.IconColor = System.Drawing.Color.Black;
            this.btnTipoNormas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTipoNormas.Location = new System.Drawing.Point(0, 40);
            this.btnTipoNormas.Name = "btnTipoNormas";
            this.btnTipoNormas.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.btnTipoNormas.Size = new System.Drawing.Size(220, 40);
            this.btnTipoNormas.TabIndex = 1;
            this.btnTipoNormas.Text = "Tipo de Norma";
            this.btnTipoNormas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoNormas.UseVisualStyleBackColor = true;
            this.btnTipoNormas.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnArticulos
            // 
            this.btnArticulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArticulos.FlatAppearance.BorderSize = 0;
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulos.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.ForeColor = System.Drawing.Color.White;
            this.btnArticulos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnArticulos.IconColor = System.Drawing.Color.Black;
            this.btnArticulos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArticulos.Location = new System.Drawing.Point(0, 0);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.btnArticulos.Size = new System.Drawing.Size(220, 40);
            this.btnArticulos.TabIndex = 0;
            this.btnArticulos.Text = "Articulos";
            this.btnArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArticulos.UseVisualStyleBackColor = true;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // btnNormas
            // 
            this.btnNormas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNormas.FlatAppearance.BorderSize = 0;
            this.btnNormas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormas.ForeColor = System.Drawing.Color.White;
            this.btnNormas.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnNormas.IconColor = System.Drawing.Color.White;
            this.btnNormas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNormas.IconSize = 32;
            this.btnNormas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNormas.Location = new System.Drawing.Point(0, 212);
            this.btnNormas.Name = "btnNormas";
            this.btnNormas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNormas.Size = new System.Drawing.Size(220, 60);
            this.btnNormas.TabIndex = 3;
            this.btnNormas.Text = "Normas";
            this.btnNormas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNormas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNormas.UseVisualStyleBackColor = true;
            this.btnNormas.Click += new System.EventHandler(this.btnNormas_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnConsultas.IconColor = System.Drawing.Color.White;
            this.btnConsultas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultas.IconSize = 32;
            this.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.Location = new System.Drawing.Point(0, 152);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnConsultas.Size = new System.Drawing.Size(220, 60);
            this.btnConsultas.TabIndex = 1;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 152);
            this.panel1.TabIndex = 0;
            // 
            // pBarraSuperior
            // 
            this.pBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.pBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBarraSuperior.Location = new System.Drawing.Point(220, 0);
            this.pBarraSuperior.Name = "pBarraSuperior";
            this.pBarraSuperior.Size = new System.Drawing.Size(1044, 71);
            this.pBarraSuperior.TabIndex = 1;
            // 
            // pContenedor
            // 
            this.pContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenedor.Location = new System.Drawing.Point(220, 71);
            this.pContenedor.Name = "pContenedor";
            this.pContenedor.Size = new System.Drawing.Size(1044, 610);
            this.pContenedor.TabIndex = 2;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pContenedor);
            this.Controls.Add(this.pBarraSuperior);
            this.Controls.Add(this.pMenuLateral);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Main";
            this.Text = "Form_RegistroUsuarios";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.pMenuLateral.ResumeLayout(false);
            this.pSubMenuUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenuLateral;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private System.Windows.Forms.Panel pSubMenuUsuarios;
        private FontAwesome.Sharp.IconButton btnTipoNormas;
        private FontAwesome.Sharp.IconButton btnArticulos;
        private FontAwesome.Sharp.IconButton btnNormas;
        private FontAwesome.Sharp.IconButton btnConsultas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pBarraSuperior;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Panel pContenedor;
    }
}