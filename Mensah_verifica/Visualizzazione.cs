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
    public partial class Visualizzazione : Form
    {
        public listaVerifiche f=new listaVerifiche();
        public Verifica[] ver;
        public Visualizzazione()
        {
            ver = new Verifica[100];
            ver = f.TH.getVerifiche();
            InitializeComponent();
            for(int i = 0; i < f.TH.nVeriche; i++)
            {
                ListViewItem B = new ListViewItem(ver[i].ToString());
                listView2.Items.Add(B);
            }
        }
    }
}
