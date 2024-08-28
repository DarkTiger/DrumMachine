using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Linq;


namespace WFDrumMachine
{
    public class Componenti:List<Componente>
    {

        public new int IndexOf(Componente item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this[i].Tipo==item.Tipo)
                {
                    return i;
                }
            }
            return -1;
        }


        public new void Add(Componente item)
        {
            if (this.IndexOf(item)<0)
            {
                base.Add(item);
            }
            else
            {
                throw new Exception("Componente già inserito.");
            }
        }


        public XElement Xml
        {
            get
            {
                return new XElement("componenti",
                    from c in this
                    select c.Xml
                    );
            }
        }


        public void Salva(string file)
        {
            Xml.Save(file);
        }

        public Componenti()
        { }

        public Componenti(XElement xml)
        {
            try
            {
                var componenti = (from bloccoComp in xml.Element("Componenti").Elements("Componente")
                                  select new Componente(bloccoComp));

                foreach (Componente item in componenti)
                {
                    this.Add(item);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Errore nel salvataggio dei componenti\n" + ex.Message);
            }
        }

        public void OpenXMLFile(string filename)
        {
            try
            {
                this.Clear();

                XElement tmp = XElement.Load(filename);
                Componenti nuovi = new Componenti();

                this.AddRange(from ElementXMLComponente in tmp.Elements("componente")
                              select new Componente(ElementXMLComponente));
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
        }


        /*
        public Componenti()
        {
            Componente c1 = new Componente(Componente.Type.HiHat, Color.DodgerBlue);
            Componente c2 = new Componente(Componente.Type.Snare, Color.Gold);
            Componente c3 = new Componente(Componente.Type.Kick, Color.Lime);
            Componente c4 = new Componente(Componente.Type.Tom1, Color.Orange);
            Componente c5 = new Componente(Componente.Type.Tom2, Color.Fuchsia);
            Componente c6 = new Componente(Componente.Type.Crash, Color.LightSteelBlue);
            this.cList = new List<Componente>();
            this.cList.Add(c1);
            this.cList.Add(c2);
            this.cList.Add(c3);
            this.cList.Add(c4);
            this.cList.Add(c5); 
            this.cList.Add(c6);
        }
        
        public List<Componente> GetComponenti()
        {
            return this.cList;
        }
        */
    }
}
