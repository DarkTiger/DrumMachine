using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WFDrumMachine
{
    class GestioneSalvataggio
    {
        List<DataGridView> griglie;

        public GestioneSalvataggio(List<DataGridView> listaGriglie)
        {
            griglie = listaGriglie;
        }

        public XElement Tab
        {
            get
            {
                return new XElement("tab", new XAttribute("index", "1")
                    );
            }
        }

        public void Salva(string file)
        {
            XMLComponenti.Save(file);
        }

        public XElement XMLComponenti
        {
            get
            {
                return new XElement("tabs",
                                    from griglia in griglie
                                    select new XElement("tab", new XAttribute("index", griglie.IndexOf(griglia)),
                                        from DataGridViewRow riga in griglia.Rows
                                        select Componente(((Componente)riga.Tag).Tipo.ToString(), riga.Index, griglia)));
            }
        }

        public XElement Componente(string componente, int indiceComponente, DataGridView griglia)
        {
            List<XElement> listaElementi = NomeBattuta(griglia, indiceComponente);

            return new XElement("componente", new XAttribute("nome", componente),
                from tag in listaElementi
                select tag);
        }


        public List<XElement> NomeBattuta(DataGridView griglia, int indiceRiga)
        {
            List<XElement> lista = new List<XElement>();

            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <=4; j++)
                {
                    XName nome = "B"+i.ToString() + j.ToString();
                    
                    string nomeCella = i.ToString() +"/"+ j.ToString();
                    XElement elemento = new XElement(nome, ConvertValueCellaToString(griglia.Rows[indiceRiga].Cells[nomeCella]));

                    //string apriTag = "<" + i.ToString() + j.ToString() + ">";
                    //string chiudiTag = "</" + i.ToString() + j.ToString() + ">";

                    //lista.Add(apriTag + ConvertValueCellaToString(griglia.Rows[indiceRiga].Cells[nomeCella]) + chiudiTag);
                    lista.Add(elemento);
                }
            }
            return lista;
        }


        public string ConvertValueCellaToString(DataGridViewCell cella )
        {
            if (cella.Value == null)
            {
                return "0";
            }
            else
            {
                return "1";
            }
        }

    }
}
