using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouraniZdiHra
{
    internal class clsVozicek
    {
        // grafika pro kreslení
        Graphics mobjGrafika;

        
        // proměnná vozicku
        int mintXVozicku, mintYVozicku;
        int mintVyskaVozicku, mintSirkaVozicku;

        //------------------------------------------------
        // konstruktor
        //------------------------------------------------
        public clsVozicek(Graphics objPlatno, int intXVozicku, int intYVozicku, int intSirkaVozicku, int intVyskaVozicku)
        {
            mobjGrafika = objPlatno;
            mintXVozicku = intXVozicku;
            mintYVozicku = intYVozicku;
            mintVyskaVozicku = intVyskaVozicku;
            mintSirkaVozicku = intSirkaVozicku;
        }
        
        //------------------------------------------------
        // vykreslení vozicku
        //------------------------------------------------
        public void NakresliSe()
        {
            // vykreslení vozicku
            mobjGrafika.FillRectangle(Brushes.Black, mintXVozicku, mintYVozicku, mintSirkaVozicku, mintVyskaVozicku);
        }
        public void AktualizujPozici(int x, int y)
        {
            // vymažeme původní pozici vozíčku
            mobjGrafika.FillRectangle(Brushes.White, mintXVozicku, mintYVozicku, mintSirkaVozicku, mintVyskaVozicku);

            // uložíme nové souřadnice vozíčku
            mintXVozicku += x;
            mintYVozicku += y;

            // vykreslíme vozíček na nové pozici
            mobjGrafika.FillRectangle(Brushes.Black, mintXVozicku, mintYVozicku, mintSirkaVozicku, mintVyskaVozicku);
        }


        public bool Kolize(clsKulicka kulicka, clsVozicek vozicek)
        {


            // Test kolize
            if (kulicka.intXK >= mintXVozicku && kulicka.intXK <= mintXVozicku + mintSirkaVozicku &&
                kulicka.intYK >= mintYVozicku && kulicka.intYK <= mintYVozicku + mintVyskaVozicku)
            {
                kulicka.odrazKraj2();

                return true;
            }
            
            else
                return false;
        }

        public void lokaceVozicku(int x)
        {

        }
    }
}
   
  
    
