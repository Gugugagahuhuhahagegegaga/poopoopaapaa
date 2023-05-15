using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BouraniZdiHra
{
    class clsCihla
    {
        // grafika pro kreslení
        Graphics mobjGrafika;

        // proměnná cihly
        int mintXCihly, mintYCihly;
        int mintVyskaCihly, mintSirkaCihly;
        bool mblJeVidet;

        //------------------------------------------------
        // konstruktor
        //------------------------------------------------

        public clsCihla(Graphics objPlatno, int intXCihly, int intYCihly, int intSirkaCihly, int intVyskaCihly)
        {
            mobjGrafika = objPlatno;
            mintXCihly = intXCihly;
            mintYCihly = intYCihly;
            mintVyskaCihly = intVyskaCihly;
            mintSirkaCihly = intSirkaCihly;
            mblJeVidet = true;

        }
        //------------------------------------------------
        // vykreslení cihly
        //------------------------------------------------

        public void NakresliSe()
        {
            // test viditelnosti cihly
            if (mblJeVidet == false) return;

            // vykreslení cihly
            mobjGrafika.FillRectangle(Brushes.Orange, mintXCihly, mintYCihly, mintSirkaCihly, mintVyskaCihly);
        }

        //------------------------------------------------
        // test kolize cihly s kulickou
        // - vrací true pokud došlo ke kolizi
        //------------------------------------------------

        public void ZnicSe()
        {
            mobjGrafika.FillRectangle(Brushes.White, mintXCihly, mintYCihly, mintSirkaCihly, mintVyskaCihly);
            mblJeVidet = false;
        }

        public bool TestKolize(int intXK, int intYK, int intWK, int intHK)
        {
            // test vyditelnosti cihly
            if (mblJeVidet == false) return false;

            //test kolize
            if (intXK >= mintXCihly && intXK <= mintXCihly + mintSirkaCihly &&
                intYK >= mintYCihly && intYK <= mintYCihly + mintVyskaCihly)
            {

                //zničení cihly
                ZnicSe();
                return true;
            }
            else
            {
                //nedošlo ke kolizi
                return false;
            }
            

            
        }
        
    }
}
    

