using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadSViseFormi
{
    class Student
    {
       private string textboxIme, textBoxPrezime, textBoxBrojIndeksa, comboBoxSmjer;
       private DateTime DatumRodjenja;

        public Student(string textboxIme, string textBoxPrezime, string textBoxBrojIndeksa, string comboBoxSmjer, DateTime datumRodjenja)
        {
            this.textboxIme = textboxIme;
            this.textBoxPrezime = textBoxPrezime;
            this.textBoxBrojIndeksa = textBoxBrojIndeksa;
            this.comboBoxSmjer = comboBoxSmjer;
            DatumRodjenja = datumRodjenja;
        }

        public string TextboxIme { get => textboxIme; set => textboxIme = value; }
        public string TextBoxPrezime { get => textBoxPrezime; set => textBoxPrezime = value; }
        public string TextBoxBrojIndeksa { get => textBoxBrojIndeksa; set => textBoxBrojIndeksa = value; }
        public string ComboBoxSmjer { get => comboBoxSmjer; set => comboBoxSmjer = value; }
        public DateTime DatumRodjenja1 { get => DatumRodjenja; set => DatumRodjenja = value; }

    

        public override string ToString()
        {
            string ispis = "ime " +this.textboxIme+"prezime "+this.textBoxPrezime+"Indeks "+this.textBoxBrojIndeksa + "Smjer "+this.comboBoxSmjer
                + "datumRodenja"+this.DatumRodjenja;
            return base.ToString();
        }
    }
}
