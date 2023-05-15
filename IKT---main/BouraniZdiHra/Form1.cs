using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace BouraniZdiHra
{
    public partial class Form1 : Form
    {
        int lintX, lintY;

        // grafika pro kreslení
        Graphics mobjGrafika;

        // třída kulicky
        clsKulicka mobjKulicka;

        //třída vozíku
        clsVozicek mobjVozicek;

        vozicekKraj mobjKraj1;

        vozicekKraj mobjKraj2;

        bool rychlost = false;


        // pole cihel
        int mintPocetCihel;
        clsCihla[] mobjCihla;
        const int mintSirkaCihly = 80, mintVyskaCihly = 20;
        const int mintVelikostMezery = 20, mintPocetRadCihel = 3;

       

        // rychlost timeru
        const int mintRychlostTimeru = 10;



        

        private void Form1_Load(object sender, EventArgs e)
        {
            // init-nahrání timeru

            Timer tmrPrekresli = new Timer();
            tmrPrekresli.Interval = mintRychlostTimeru;
            tmrPrekresli.Tick += new EventHandler(tmrPrekresli_Tick);
            tmrPrekresli.Start();


        }

     
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            mobjVozicek.AktualizujPozici(-30, 0);
            mobjKraj1.AktualizujPozici(-30, 0);
            mobjKraj2.AktualizujPozici(-30, 0);
            
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            mobjVozicek.AktualizujPozici(30, 0);
            mobjKraj1.AktualizujPozici(30, 0);
            mobjKraj2.AktualizujPozici(30, 0);
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            mobjVozicek.AktualizujPozici(-50, 0);
            mobjKraj1.AktualizujPozici(-50, 0);
            mobjKraj2.AktualizujPozici(-50, 0);
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            mobjVozicek.AktualizujPozici(50, 0);
            mobjKraj1.AktualizujPozici(50, 0);
            mobjKraj2.AktualizujPozici(50, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public Form1()
        {
            InitializeComponent();

            
            
            // init proměnných
            mobjGrafika = pbPlatno.CreateGraphics();

            // vytvoření kulicky
            mobjKulicka = new clsKulicka(mobjGrafika);

            //vytvoření vozíku
            mobjVozicek = new clsVozicek(mobjGrafika, 480, 370, 60, 20);

            mobjKraj1 = new vozicekKraj(mobjGrafika, 450, 370, 30, 20);

            mobjKraj2 = new vozicekKraj(mobjGrafika, 540, 370, 30, 20);

            

            // vytvoreni pole
            mintPocetCihel = mintPocetRadCihel *
                ((pbPlatno.Width - mintVelikostMezery) /
                (mintSirkaCihly + mintVelikostMezery));

            mobjCihla = new clsCihla[mintPocetCihel];

            // vytvoreni cihel
            lintX = lintY = mintVelikostMezery;
            for (int i = 0; i < mintPocetCihel; i++)
            {
                //test změna souřadnic
                if ((lintX + mintSirkaCihly + mintVelikostMezery) > (pbPlatno.Width))
                {
                    lintX = mintVelikostMezery;
                    lintY = lintY + mintVelikostMezery + mintVyskaCihly;
                }

                //init jedné cihly
                mobjCihla[i] = new clsCihla(mobjGrafika, lintX, lintY, mintSirkaCihly, mintVyskaCihly);

                //finální změna souřadnic
                lintX = lintX + mintSirkaCihly + mintVelikostMezery;
            }

           

        }

       


        private void tmrPrekresli_Tick(object sender, EventArgs e)
        {
            // smazání scény
            mobjGrafika.Clear(Color.White);

            // pohyb kulicky
            mobjKulicka.Pohyb();

            //pohyb vozíčku jak zkontrolovat jestli je něco zmáčklé na klávesnici
            
            //zmenaPozice(this, );
            
            // test kolize všech cihel
            foreach (clsCihla objCihla in mobjCihla)
            {
                if (objCihla.TestKolize(mobjKulicka.intXK, mobjKulicka.intYK, mobjKulicka.intWK, mobjKulicka.intHK))
                {
                    mobjKulicka.otocYK(); 
                }
            }
            
            
            
            

            

            
            //vykreslení všech cihel

            foreach (clsCihla objCihla in mobjCihla)
            {
                objCihla.NakresliSe();
            }

            //test kolize se spodní hranou pb
            if (mobjKulicka.intYK + mobjKulicka.intHK >= pbPlatno.Height)
            {
                //zastavení hry
                Timer tmrPrekresli = (Timer)sender;
                tmrPrekresli.Stop();

                //zpráva
                MessageBox.Show("Prohra :(");

               

                
            }
            
            mobjVozicek.NakresliSe(); // vykreslíme vozíček na původní pozici
            mobjKraj1.NakresliSe();
            mobjKraj2.NakresliSe();
          

            
            bool kolize = mobjVozicek.Kolize(mobjKulicka, mobjVozicek);
            mobjKraj1.Kolize(mobjKulicka, mobjVozicek);
            mobjKraj2.Kolize(mobjKulicka, mobjVozicek);


        }



       
        private void ZkontrolujZniceniCihel()
        {
            //bool zničenoVše = true;

            foreach (Control c in pbPlatno.Controls)
            {
                if (!(c is PictureBox && (string)c.Tag == "cihla" && c.Visible == true))
                {
                    MessageBox.Show("Zničil jsi všechny cihly! Gratulujeme!", "Vítězství");
                    //zničenoVše = false;
                    // break;
                }
                
            }

          
        }
       

        





    }


}