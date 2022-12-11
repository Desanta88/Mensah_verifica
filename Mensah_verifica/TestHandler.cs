using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Globalization;

namespace Mensah_verifica
{
    public class TestHandler
    {
        private Verifica[] verifiche;
        private string _id;
        private int nVeri,pos=0;
        static int idCount = 0;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int nVeriche
        {
            get { return nVeri; }
        }
        public TestHandler(string id)
        {
            _id = id;
            verifiche = new Verifica[100];
            nVeri = 0;
        }
        public TestHandler() :this("xxxxx")
        {
         
        }
        public void Aggiungi(Verifica v)
        {
            if (v!=null && nVeri < 100)
            {
                verifiche[nVeri] = v;
                nVeri++;
            }
        }
        public static string getID()
        {
            idCount++;
            return "V"+idCount;
        }
        public void Elimina(Verifica v)
        {
            pos = Esiste(v);
            if (pos != -1)
                Ricompatta(pos);
        }
        public void Modifica(Verifica v,float nv)
        {
            pos = Esiste(v);
            if (pos != -1)
                CambiamentoVoto(v, nv);
        }
        public void CambiamentoVoto(Verifica v,float nv)
        {
            v.Voto = nv;
        }
        public Verifica[] getVerifiche()
        {
            return verifiche;
        }

        private int Esiste(Verifica v)
        {
            for (int i = 0; i < nVeri; i++)
            {
                if (v != null && verifiche[i].Equals(v))
                    return i;
            }
            return -1;
        }
        public Verifica Ricerca(string id)
        {

            for (int i=0;i< nVeri; i++)
            {
                if (id == verifiche[i].Id)
                    return verifiche[i];
            }
            return null;
        }
        private void Ricompatta(int posi)
        {
            for (int i = posi; i < nVeri - 1; i++)
            {
                verifiche[i] = verifiche[i + 1];
            }
            nVeri--;
        }
        public float Media(string id)
        {
            Verifica v = new Verifica();
            int count=0;
            float m = 0;
            v = Ricerca(id);
            for (int i = 0; i < nVeri; i++)
            {
                if (v.Materia == verifiche[i].Materia)
                {
                    count++;
                    m = verifiche[i].Voto + m;
                }
            }
            m = m / count;
            return m;
        }
        public void SortByDate()
        { 
            //verifiche = verifiche.OrderBy(ob => DateTime.ParseExact( ob, "d'/'M'/'yyyy", CultureInfo.InvariantCulture));
        }
    }
}
