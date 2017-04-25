using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dactylo
{
    public partial class frmPrincipale : Form
    {
        private Dactylo _monDactylo;
        public frmPrincipale()
        {
            InitializeComponent();
        }

        internal Dactylo MonDactylo
        {
            get
            {
                return _monDactylo;
            }

            set
            {
                _monDactylo = value;
            }
        }
        public void UpdateView()
        {
            rbxTexteExemple.Text = MonDactylo.TexteExemple;
        }
        private void tsiNouveau_Click(object sender, EventArgs e)
        {
            MonDactylo = new Dactylo("JeTesteToutCaQuoi");
            UpdateView();
        }

        private void tbxTextCopie_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxTextCopie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != MonDactylo.TexteExemple[MonDactylo.Progression])
            {
                e.Handled = true;
            }
            else
            {
                MonDactylo.Progression += 1;
            }

            if(MonDactylo.Progression == MonDactylo.Total)
            {
                MessageBox.Show("Félicitation vous avez fini ! ");
            }
        }
    }
}
