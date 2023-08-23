using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemplo2.Formularios
{
    public partial class FormCalculoArea : Form
    {
        public FormCalculoArea()
        {
            InitializeComponent();
            txtHipotenusa.Visible = false;
            txtArea.Visible = false;
            lbHipotenusa.Visible = false;
            lbArea.Visible = false;
            txtArea.BackColor = Color.LightGreen;
            txtArea.ReadOnly = true;
        }

        private void cbTipoCalculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipoCalculo = cbTipoCalculo.SelectedIndex;
            switch (tipoCalculo)
            {
                case 0:
                    {
                        txtHipotenusa.Visible = false;
                        lbHipotenusa.Visible = false;
                        txtArea.Visible = true;
                        lbArea.Visible = true;
                        txtCatetoA.BackColor = Color.White;
                        txtCatetoB.BackColor = Color.White;
                        break;
                    }
                case 1:
                    {
                        txtArea.Visible = false;
                        lbArea.Visible = false;
                        txtHipotenusa.Visible = true;
                        lbHipotenusa.Visible = true;
                        txtCatetoA.BackColor = Color.LightGreen;
                        txtCatetoB.BackColor = Color.White;
                        txtHipotenusa.BackColor = Color.White;
                        txtCatetoA.ReadOnly = true;
                        txtArea.ReadOnly = false;
                        break;
                    }
                case 2:
                    {
                        txtArea.Visible = false;
                        lbArea.Visible = false;
                        txtCatetoB.BackColor = Color.LightGreen;
                        txtCatetoA.BackColor = Color.White;
                        txtHipotenusa.BackColor = Color.White;
                        txtCatetoB.ReadOnly = true;
                        txtCatetoA.ReadOnly = false;
                        break;
                    }
                case 3:
                    {
                        txtArea.Visible = false;
                        lbArea.Visible = false;
                        lbHipotenusa.Visible = true;
                        txtHipotenusa.Visible= true;
                        txtCatetoA.BackColor = Color.White;
                        txtCatetoB.BackColor = Color.White;
                        txtHipotenusa.BackColor = Color.LightGreen;
                        txtHipotenusa.ReadOnly = true;
                        txtCatetoB.ReadOnly = false;
                        break;
                    }
            }
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int tipoCalculo = cbTipoCalculo.SelectedIndex;
            double catetoA, catetoB, hipotenusa, area;

            switch(tipoCalculo)
            {
                case 0:
                    {
                        catetoA = Convert.ToDouble(txtCatetoA.Text);
                        catetoB = Convert.ToDouble(txtCatetoB.Text);
                        area = (catetoA * catetoB) / 2;
                        txtArea.Text = area.ToString("F2");
                        break;
                    }
                case 1:
                    {
                        catetoB = Convert.ToDouble(txtCatetoB.Text);
                        hipotenusa = Convert.ToDouble(txtHipotenusa.Text);
                        break;
                    }
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            //teste do git
        }
    }
}
