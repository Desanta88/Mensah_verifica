using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mensah_verifica
{
    public partial class ModificaForm : Form
    {
        listaVerifiche lv = new listaVerifiche();
        private int selected=0;
        private string cercVer;
        private Verifica ver = new Verifica();
        private TestHandler TH = new TestHandler();
        public ModificaForm()
        {
            InitializeComponent();
        }

        private void ModificaVotoButton_Click(object sender, EventArgs e)
        {
            selected = lv.selezionato;
            cercVer = lv.VerificaCerc;
            ver = TH.Ricerca(cercVer);
            TH.Modifica(ver, float.Parse(textBox1.Text));
        }
    }
}
