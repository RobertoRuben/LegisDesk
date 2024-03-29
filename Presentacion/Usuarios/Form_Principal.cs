using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Presentacion
{
    public partial class Form_Main : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public Form_Main()
        {
            InitializeComponent();
            PersonalizarDiseño();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pMenuLateral.Controls.Add(leftBorderBtn);
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
           
        }

        private void PersonalizarDiseño()
        {
            pSubMenuUsuarios.Visible = false;
        }
        private void OcultarSubMenu()
        {
            if(pSubMenuUsuarios.Visible == true)
            {
                pSubMenuUsuarios.Visible = false;
            }
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private struct RGBColors
        {
            public static Color color = Color.FromArgb(0, 80, 200);
            public static Color color2 = Color.FromArgb(200, 241, 51, 51);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null)
            {
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(26, 32, 40);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            ActivateButton(sender, RGBColors.color);
            
        }

        private void btnNormas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            MostrarSubMenu(pSubMenuUsuarios);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            ActivateButton(sender, RGBColors.color);
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OcultarSubMenu();
            this.Close();
        }

        //Sub Menu Normas
        private void btnArticulos_Click(object sender, EventArgs e)
        {
            //Proximo Codigo

            OcultarSubMenu();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            //Proximo Codigo
            OcultarSubMenu();
        }
    }
}
