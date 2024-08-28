using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Xml.Linq;


namespace WFDrumMachine
{
    public class Componente
    {

        Type tipo;

        public Type Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        

        public enum Type
        {
            Snare,
            Kick,
            HiHatOpen,
            HiHatClose,
            Ride,
            China,
            Crash,
            Tom1,
            Tom2
        }


        string soundPath;

        public string SoundPath
        {
            get { return soundPath; }
            set
            {
                //if (File.Exists(value))
                //{
                    soundPath = value;
                //}
                //else
                //{
                 //   throw new Exception("File non esistente: '" + value + "'");
                //}
            }
        }

        float soundVolume;

        public float SoundVolume
        {
            get { return soundVolume; }
            set { soundVolume = value; }
        }


        Color colore;

        public Color Colore
        {
            get { return colore; }
            set { colore = value; }
        }
        

        public Componente(Type tipo, Color colore, string filename, float soundVolume)
        {
            this.Tipo = tipo;
            this.SoundPath = filename;
            this.SoundVolume = soundVolume;
            this.Colore = colore;
        }


        public override string ToString()
        {
            return this.Tipo.ToString();
        }


        public XElement Xml
        {
            get
            {
                return new XElement("componente",
                    new XElement("tipo", Tipo.ToString()),
                    new XElement("soundPath", SoundPath),
                    new XElement("soundGain", SoundVolume.ToString()),
                    new XElement("coloreR", Colore.R.ToString()),
                    new XElement("coloreG", Colore.G.ToString()),
                    new XElement("coloreB", Colore.B.ToString()));
            }
        }


        public Componente(XElement xml)
        {
            try
            {
                this.Tipo = (Type)Enum.Parse(typeof(Type),
                    xml.Element("tipo").Value);
                this.SoundPath = xml.Element("soundPath").Value;
                this.SoundVolume = Convert.ToSingle(xml.Element("soundGain").Value);
                this.Colore = Color.FromArgb(255, Convert.ToInt32(xml.Element("coloreR").Value), Convert.ToInt32(xml.Element("coloreG").Value), Convert.ToInt32(xml.Element("coloreB").Value));

                //if (!File.Exists(this.SoundPath))
                //{
                //    throw new Exception("FIle non esiste3nte");  
                //}
            
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void SaveToXML(string filename)
        {
            try
            {
                this.Xml.Save(filename);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore nel salvataggio dei componenti\n" + ex.Message);
            }
        }


        //Time lunghezza;

        //public Time Lunghezza
        //{
        //    get { return lunghezza; }
        //    set { lunghezza = value; }
        //}

        //public enum Time
        //{
        //    semibreve,
        //    minima,
        //    semiminima,
        //    croma,
        //    semicroma,
        //    semibiscroma
        //}
    }
}
