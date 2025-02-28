using System.Windows.Forms;

namespace Aplicacion2
{
    public partial class PRIMER_FORM : Form
    {
        public PRIMER_FORM()
        {
            InitializeComponent();
        }
        private void TxtInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 32)
            {
                MessageBox.Show("PRESIONASTE ENTER");
                txt_Nombre.Focus();
            }
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 32)
            {
                Txt_NUMERO.Focus();
            }
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Txt_NUMERO_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 32)
            {
                TXT_CORREO.Focus();
            }
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TXT_CORREO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 32)
            {
                TXT_CORREO.Focus();
            }
        }
    }
}