using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Banque
{
    public partial class BanqueForm : Form
    {
        private static int etat;
        private Client c;
        private StreamWriter wr;
        private StreamReader sr;
        private string ficnom,jsondata;

        public BanqueForm()
        {
            InitializeComponent();
            rtbOuput.SelectAll();
            rtbOuput.SelectionAlignment = HorizontalAlignment.Center;
            etat = 0;
            Nom();
        }

        public void Nom()
        {
            rtbOuput.AppendText("Veuillez entrer votre nom");
            rtbOuput.AppendText("\n\n");
        }

        public void Start()
        {
            rtbOuput.AppendText("1. Voir montant\n2. Faire un virement\n3. Faire un retrait");
            rtbOuput.AppendText("\n");
            etat = 1;

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            switch (etat)
            {
                case 0: ficnom = "Client_" + tbInput.Text + ".txt"; Lecture();  Start();  break;

                case 1:

                    int choix;
                    bool verif = Int32.TryParse(tbInput.Text, out choix);

                    if(!verif)
                    {
                        choix = 0;
                    }

                    switch (choix)
                        {
                        case 1: VoirMontant(); break;

                        case 2: etat = 2; MessageVirement(); break;

                        case 3: etat = 3; MessageRetrait(); break;

                        default : rtbOuput.AppendText("\nVeuillez entrer un choix correct\n"); break;

                    } break;

                case 2: try { Virement(Double.Parse(tbInput.Text)); } catch { rtbOuput.AppendText("\nVeuillez entrer une valeur\n"); etat = 2; } ; break;

                case 3: try { Retrait(Double.Parse(tbInput.Text)); } catch { rtbOuput.AppendText("\nVeuillez entrer une valeur\n"); etat = 3; }; break;

            }

            tbInput.Clear();
        }

        public void VoirMontant()
        {
            rtbOuput.AppendText("\n\n");
            rtbOuput.AppendText("Vous avez "+ c.Montant.ToString() + " euros sur votre compte\n");
            rtbOuput.AppendText("\n");
            Start();
        }

        public void MessageVirement()
        {
            rtbOuput.AppendText("\n");
            rtbOuput.AppendText("Veuillez entrer le montant du virement en euros");
            rtbOuput.AppendText("\n");
        }

        public void MessageRetrait()
        {
            rtbOuput.AppendText("\n");
            rtbOuput.AppendText("Veuillez entrer le montant du retrait en euros");
            rtbOuput.AppendText("\n");
        }

        public void Virement(double v)
        {
            c.FaireVirement(v);
            rtbOuput.AppendText("\n\nVirement effectué !");
            VoirMontant();
        }

        public void Retrait(double r)
        {
            if(r < c.Montant )
            {
                c.FaireRetrait(r);
                rtbOuput.AppendText("\n\nRetrait effectué !");
            }
            else
                rtbOuput.AppendText("\n\nFond insuffisant !");

            VoirMontant();
        }

        private void rtbOuput_TextChanged(object sender, EventArgs e)
        {
            rtbOuput.ScrollToCaret();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try
            {
                wr = new StreamWriter(ficnom);

                jsondata = JsonConvert.SerializeObject(c);

                wr.Write(jsondata);

                wr.Close();
            }
            catch { base.OnFormClosing(e); }

            base.OnFormClosing(e);
        }

        public void Lecture()
        {

            if (File.Exists(ficnom))
            {
                sr = new StreamReader(ficnom);

                jsondata = sr.ReadToEnd();

                c = JsonConvert.DeserializeObject<Client>(jsondata);

                sr.Close();

            }
            else
                 c = new Client(tbInput.Text);

        }

    }

    public class Client
    {
        private string nom;
        private double montant;
        private List<double> virement, retrait;

        public Client(string n)
        {
            this.nom = n;
            this.montant = 0;
            virement = new List<double>();
            retrait = new List<double>();
        }

        public void FaireVirement(double v)
        {
            virement.Add(v);
            montant = montant + v;
        }

        public void FaireRetrait(double r)
        {
            retrait.Add(r);
            montant = montant - r;
        }

        public double Montant { get => montant; set => montant = value; }
        public List<double> Virement { get => virement; set => virement = value; }
        public List<double> Retrait { get => retrait; set => retrait = value; }
        public string Nom { get => nom; set => nom = value; }
    }

}