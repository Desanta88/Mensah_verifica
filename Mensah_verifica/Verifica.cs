using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensah_verifica
{
    public class Verifica
    {
        private string _id;
        private string _materia;
        private float _voto;
        private string _data;
        public Verifica(string id, string materia, float voto, string data)
        {
            Id = id;
            Materia = materia;
            Voto = voto;
            Data = data;
            Id = id;
            Materia = materia;
            Voto = voto;
            Data = data;
        }
        public Verifica() : this("xxxx", "N/A", 10, "9/9/9999")
        {

        }
        public Verifica(string id,string materia,float voto) : this(id, materia, voto, "9/9/9999")
        {

        }
        public Verifica(string id, string materia, string data) : this(id, materia,10, data)
        {

        }
        public Verifica(string id, float voto, string data) : this(id,"matematica",voto, data)
        {

        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Materia
        {
            get { return _materia; }
            set { _materia = value; }
        }
        public float Voto
        {
            get { return _voto; }
            set { _voto = value; }
        }
        public string Data
        {
            get { return _data; }
            set { _data = value; }
        }
        public string ToString()
        {
            return Id + " " + Materia + " " + Voto.ToString() + " " + Data;
        }
        public bool Equals(Verifica v)
        {
            if(v==null) return false;
            if(this == v) return true;

            return(v.Id==this.Id);
        }
    }
}
