using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacAdress
{
    public partial class Frm_ObtendoMacAdress : Form
    {
        public Frm_ObtendoMacAdress()
        {
            InitializeComponent();
        }
        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            
            try
            {
                Lb_Resultado.Items.Add(InfoMac.GetEnderecoMAC1());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Lb_Resultado.Items.Clear();
        }

    }
}


