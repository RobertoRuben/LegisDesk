
namespace Presentacion
{
    partial class Form_Principal
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
            this.components = new System.ComponentModel.Container();
            this.pMenuLateral = new System.Windows.Forms.Panel();
            this.pSubMenuUsuarios = new System.Windows.Forms.Panel();
            this.btnRoles = new FontAwesome.Sharp.IconButton();
            this.btnTrabajadores = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.pSubMenuNormas = new System.Windows.Forms.Panel();
            this.btnTipoNormas = new FontAwesome.Sharp.IconButton();
            this.btnNormas = new FontAwesome.Sharp.IconButton();
            this.btnConsultas = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.pBarraSuperior = new System.Windows.Forms.Panel();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPerfil = new FontAwesome.Sharp.IconButton();
            this.lblFormularioHijo = new System.Windows.Forms.Label();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.pContenedor = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.timerHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.pMenuLateral.SuspendLayout();
            this.pSubMenuUsuarios.SuspendLayout();
            this.pSubMenuNormas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.pBarraSuperior.SuspendLayout();
            this.pContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenuLateral
            // 
            this.pMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pMenuLateral.Controls.Add(this.pSubMenuUsuarios);
            this.pMenuLateral.Controls.Add(this.btnSalir);
            this.pMenuLateral.Controls.Add(this.btnUsuarios);
            this.pMenuLateral.Controls.Add(this.pSubMenuNormas);
            this.pMenuLateral.Controls.Add(this.btnNormas);
            this.pMenuLateral.Controls.Add(this.btnConsultas);
            this.pMenuLateral.Controls.Add(this.panel1);
            this.pMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pMenuLateral.Name = "pMenuLateral";
            this.pMenuLateral.Size = new System.Drawing.Size(220, 681);
            this.pMenuLateral.TabIndex = 0;
            // 
            // pSubMenuUsuarios
            // 
            this.pSubMenuUsuarios.Controls.Add(this.btnRoles);
            this.pSubMenuUsuarios.Controls.Add(this.btnTrabajadores);
            this.pSubMenuUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSubMenuUsuarios.Location = new System.Drawing.Point(0, 415);
            this.pSubMenuUsuarios.Name = "pSubMenuUsuarios";
            this.pSubMenuUsuarios.Size = new System.Drawing.Size(220, 89);
            this.pSubMenuUsuarios.TabIndex = 7;
            // 
            // btnRoles
            // 
            this.btnRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.ForeColor = System.Drawing.Color.White;
            this.btnRoles.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRoles.IconColor = System.Drawing.Color.Black;
            this.btnRoles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRoles.Location = new System.Drawing.Point(0, 40);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.btnRoles.Size = new System.Drawing.Size(220, 40);
            this.btnRoles.TabIndex = 2;
            this.btnRoles.Text = "Roles";
            this.btnRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnTrabajadores
            // 
            this.btnTrabajadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrabajadores.FlatAppearance.BorderSize = 0;
            this.btnTrabajadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrabajadores.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrabajadores.ForeColor = System.Drawing.Color.White;
            this.btnTrabajadores.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTrabajadores.IconColor = System.Drawing.Color.Black;
            this.btnTrabajadores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrabajadores.Location = new System.Drawing.Point(0, 0);
            this.btnTrabajadores.Name = "btnTrabajadores";
            this.btnTrabajadores.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.btnTrabajadores.Size = new System.Drawing.Size(220, 40);
            this.btnTrabajadores.TabIndex = 1;
            this.btnTrabajadores.Text = "Trabajadores";
            this.btnTrabajadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrabajadores.UseVisualStyleBackColor = true;
            this.btnTrabajadores.Click += new System.EventHandler(this.btnTrabajadores_Click);
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
            this.btnUsuarios.Location = new System.Drawing.Point(0, 355);
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
            // pSubMenuNormas
            // 
            this.pSubMenuNormas.Controls.Add(this.btnTipoNormas);
            this.pSubMenuNormas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSubMenuNormas.Location = new System.Drawing.Point(0, 310);
            this.pSubMenuNormas.Name = "pSubMenuNormas";
            this.pSubMenuNormas.Size = new System.Drawing.Size(220, 45);
            this.pSubMenuNormas.TabIndex = 4;
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
            this.btnTipoNormas.Location = new System.Drawing.Point(0, 0);
            this.btnTipoNormas.Name = "btnTipoNormas";
            this.btnTipoNormas.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.btnTipoNormas.Size = new System.Drawing.Size(220, 40);
            this.btnTipoNormas.TabIndex = 1;
            this.btnTipoNormas.Text = "Tipo de Norma";
            this.btnTipoNormas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoNormas.UseVisualStyleBackColor = true;
            this.btnTipoNormas.Click += new System.EventHandler(this.btnCategoria_Click);
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
            this.btnNormas.Location = new System.Drawing.Point(0, 250);
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
            this.btnConsultas.Location = new System.Drawing.Point(0, 190);
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
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 190);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::Presentacion.Properties.Resources.MunicipalidadEsperanza__1_;
            this.btnHome.Location = new System.Drawing.Point(12, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(201, 137);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pBarraSuperior
            // 
            this.pBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.pBarraSuperior.Controls.Add(this.lblRol);
            this.pBarraSuperior.Controls.Add(this.lblUsuario);
            this.pBarraSuperior.Controls.Add(this.label2);
            this.pBarraSuperior.Controls.Add(this.label1);
            this.pBarraSuperior.Controls.Add(this.btnPerfil);
            this.pBarraSuperior.Controls.Add(this.lblFormularioHijo);
            this.pBarraSuperior.Controls.Add(this.btnMinimizar);
            this.pBarraSuperior.Controls.Add(this.btnMaximizar);
            this.pBarraSuperior.Controls.Add(this.btnCerrar);
            this.pBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBarraSuperior.Location = new System.Drawing.Point(220, 0);
            this.pBarraSuperior.Name = "pBarraSuperior";
            this.pBarraSuperior.Size = new System.Drawing.Size(1044, 71);
            this.pBarraSuperior.TabIndex = 1;
            this.pBarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBarraSuperior_MouseDown);
            // 
            // lblRol
            // 
            this.lblRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.lblRol.Location = new System.Drawing.Point(791, 43);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(0, 17);
            this.lblRol.TabIndex = 15;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.lblUsuario.Location = new System.Drawing.Point(790, 20);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 17);
            this.lblUsuario.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(752, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Rol:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(725, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuario:";
            // 
            // btnPerfil
            // 
            this.btnPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.btnPerfil.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPerfil.IconSize = 55;
            this.btnPerfil.Location = new System.Drawing.Point(665, 16);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(57, 48);
            this.btnPerfil.TabIndex = 11;
            this.btnPerfil.UseVisualStyleBackColor = true;
            // 
            // lblFormularioHijo
            // 
            this.lblFormularioHijo.AutoSize = true;
            this.lblFormularioHijo.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormularioHijo.ForeColor = System.Drawing.Color.Black;
            this.lblFormularioHijo.Location = new System.Drawing.Point(14, 17);
            this.lblFormularioHijo.Name = "lblFormularioHijo";
            this.lblFormularioHijo.Size = new System.Drawing.Size(178, 37);
            this.lblFormularioHijo.TabIndex = 10;
            this.lblFormularioHijo.Text = "Bienvenido";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(149)))), ((int)(((byte)(161)))));
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 18;
            this.btnMinimizar.Location = new System.Drawing.Point(967, 1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(23, 17);
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.UpRightFromSquare;
            this.btnMaximizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(149)))), ((int)(((byte)(161)))));
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 18;
            this.btnMaximizar.Location = new System.Drawing.Point(994, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(23, 17);
            this.btnMaximizar.TabIndex = 8;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(149)))), ((int)(((byte)(161)))));
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 18;
            this.btnCerrar.Location = new System.Drawing.Point(1020, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 17);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pContenedor
            // 
            this.pContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.pContenedor.Controls.Add(this.lblFecha);
            this.pContenedor.Controls.Add(this.lblHora);
            this.pContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenedor.Location = new System.Drawing.Point(220, 71);
            this.pContenedor.Name = "pContenedor";
            this.pContenedor.Size = new System.Drawing.Size(1044, 610);
            this.pContenedor.TabIndex = 2;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 42F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.lblHora.Location = new System.Drawing.Point(394, 179);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(284, 66);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "hh:mm:ss";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 32F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.lblFecha.Location = new System.Drawing.Point(220, 280);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(644, 49);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Domingo, 20 de Abril del 2024";
            // 
            // timerHoraFecha
            // 
            this.timerHoraFecha.Enabled = true;
            this.timerHoraFecha.Tick += new System.EventHandler(this.timerHoraFecha_Tick);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pContenedor);
            this.Controls.Add(this.pBarraSuperior);
            this.Controls.Add(this.pMenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_RegistroUsuarios";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.pMenuLateral.ResumeLayout(false);
            this.pSubMenuUsuarios.ResumeLayout(false);
            this.pSubMenuNormas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.pBarraSuperior.ResumeLayout(false);
            this.pBarraSuperior.PerformLayout();
            this.pContenedor.ResumeLayout(false);
            this.pContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenuLateral;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private System.Windows.Forms.Panel pSubMenuNormas;
        private FontAwesome.Sharp.IconButton btnTipoNormas;
        private FontAwesome.Sharp.IconButton btnNormas;
        private FontAwesome.Sharp.IconButton btnConsultas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pBarraSuperior;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Panel pContenedor;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Label lblFormularioHijo;
        private System.Windows.Forms.Panel pSubMenuUsuarios;
        private FontAwesome.Sharp.IconButton btnRoles;
        private FontAwesome.Sharp.IconButton btnTrabajadores;
        private FontAwesome.Sharp.IconButton btnPerfil;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timerHoraFecha;
    }
}