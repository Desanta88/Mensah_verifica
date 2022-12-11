namespace Mensah_verifica
{
    public partial class listaVerifiche : Form
    {
        public TestHandler TH = new TestHandler();
        public Verifica[] V;
        public Verifica VCerc;
        public string VerificaCerc,Verifica, VerificaCerc2;
        public int selezionato,count;
        public float media=0;
        public int[] v = new int[100];
        public string[] intes = new string[4] { "ID","Materia", "Voto", "Data" };
        public listaVerifiche()
        {
            InitializeComponent();
            V = new Verifica[100];
            V = TH.getVerifiche();
            for(int i = 0; i < intes.Length; i++)
            {
                listView1.Columns.Add(intes[i]);
            }
            
        }

        private void buttonVisualizzazione_Click(object sender, EventArgs e)
        {
            Visualizzazione visua = new Visualizzazione();
            visua.ShowDialog();
        }

        private void EV_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
                selezionato = listView1.SelectedIndices[0];
            VerificaCerc = listView1.SelectedItems[0].Text;
            VCerc = TH.Ricerca(VerificaCerc);
            listView1.Items.RemoveAt(selezionato);
            TH.Elimina(VCerc);       
        }

        private void MV_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
                selezionato = listView1.SelectedIndices[0];
            VerificaCerc2 = listView1.SelectedItems[0].Text;
            ModificaForm MF = new ModificaForm();
            MF.ShowDialog();
            
        }

        private void Ricarica_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Visualizza();
        }

        private void OD_Click(object sender, EventArgs e)
        {
            TH.SortByDate();
            listView1.Items.Clear();
            Visualizza();
        }

        public void Visualizza()
        {
            for(int i = 0; i < TH.nVeriche; i++)
            {
                ListViewItem A = new ListViewItem(V[i].ToString().Split(" "));
                listView1.Items.Add(A);
            }
        }

        private void AggiungiVerifica_Click(object sender, EventArgs e)
        {
            Verifica VTemp = new Verifica(TestHandler.getID(),textBoxMateria.Text,float.Parse(textBoxVoto.Text),textBoxData.Text);
            Verifica = VTemp.ToString();
            TH.Aggiungi(VTemp);
            ListViewItem A = new ListViewItem(Verifica.Split(" "));
            listView1.Items.Add(A);
        }

        private void CM_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
                selezionato = listView1.SelectedIndices[0];
            VerificaCerc = listView1.SelectedItems[0].Text;
            MessageBox.Show("la media è:" + TH.Media(VerificaCerc));
        }
    }
}