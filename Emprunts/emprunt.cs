using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Menu
{
    public partial class calculemprunt : Form
    {
        public calculemprunt()
        {
            InitializeComponent();
        }

        ErrorProvider erreurcapital; //initialisation de l'errorprovider
        double taux;//

        /// <summary>
        /// Initialise les paramètres par défaut au chargement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculemprunt_Load(object sender, EventArgs e)
        {
            TextNom.Focus();//focus sur le champs nom
            listeperiodicite.SelectedIndex = 0;//sélectionnne la première entrée de la liste
            Scrollduree.Minimum = 1;//valeur minimum de la scrool bar
            Scrollduree.Maximum = 180;//valeur max
            Scrollduree.SmallChange = 1;//cran en cliquant sur la fléche
            Scrollduree.LargeChange = 1;//cran en cliquant sur la barre
            Scrollduree.Value = 1;//point de départ du curseur
            EtiDur.Text = Scrollduree.Value.ToString();//Initialise l'étiquette de la scrollbar pour l'affichage de départ
            erreurcapital = new ErrorProvider();//instanciation de l'objet
            taux = 0.07;//taux de départ
            
        }

        /// <summary>
        /// Change l'échelle de la scrollbar en fonction de la période de paiement choisi et le point de départ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listeperiodicite.SelectedIndex == 1)//Paramètre bimestrielle
            {
                Scrollduree.SmallChange = 2;
                Scrollduree.LargeChange = 2;
                Scrollduree.Minimum = 2;
                Scrollduree.Value = 2;
            }

            else if (listeperiodicite.SelectedIndex == 2)//Paramètre trimestrielle
            {
                Scrollduree.SmallChange = 3;
                Scrollduree.LargeChange = 3;
                Scrollduree.Minimum = 3;
                Scrollduree.Value = 3;
            }

            else if (listeperiodicite.SelectedIndex == 3)//Paramètre semiestrielle
            {
                Scrollduree.SmallChange = 6;
                Scrollduree.LargeChange = 6;
                Scrollduree.Minimum = 6;
                Scrollduree.Value = 6;
            }

            else if (listeperiodicite.SelectedIndex == 4)//Paramètre Annuelle
            {
                Scrollduree.SmallChange = 12;
                Scrollduree.LargeChange = 12;
                Scrollduree.Minimum = 12;
                Scrollduree.Value = 12;
            }

            else//sinon paramètre par défaut en mensuel
            {
                Scrollduree.SmallChange = 1;
                Scrollduree.LargeChange = 1;
                Scrollduree.Minimum = 1;
                Scrollduree.Value = 1;
            }

            EtiDur.Text = Scrollduree.Value.ToString();//Affiche la valeur de la scroolbar dans l'étiquette
            calculremb();//lance le calcul pour afficher le nombre de remboursement
        }

        /// <summary>
        /// Calcule du nombre de remboursement
        /// </summary>
        private void calculremb()
        {
            int duree = Convert.ToInt32(EtiDur.Text);
            int periode = Scrollduree.SmallChange;
            int NbRemb = duree / periode;
            
            if ((duree % periode) !=  0  )//si la division ne tombe pas juste, je rajout 1
            {
                NbRemb += 1;
            }
            EtiNbRemb.Text = NbRemb.ToString();// je lance l'affichage
            
        }


        /// <summary>
        /// Si je ferme la fenêtre ; j'affiche une fenêtre pour demander si je veux vraiment fermer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculemprunt_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult fermer = MessageBox.Show("Voulez vous quitter l'application ?","Fermeture d'application",MessageBoxButtons.YesNo,MessageBoxIcon.Hand);
            //je stocke dans fermer la réponse à la question
            if (fermer == DialogResult.No)//si réponse non
            {
                e.Cancel = true;//j'annule la fermeture
            }
        }

        /// <summary>
        /// Mise à jour de l'étiquette quand je bouge le curseur et lance le calcul du nombre de remboursement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Scrollduree_Scroll(object sender, ScrollEventArgs e)
        {
            EtiDur.Text = Scrollduree.Value.ToString();//mise à jour de l'étiquette
            calculremb();
        }

        /// <summary>
        /// Vérifie le champ capital et lance le calcul de remboursement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Valide_Click(object sender, EventArgs e)
        {
           if(Convert.ToInt32(TextCapital.Text)<0)//valide que le capital est positif
            {
                MessageBox.Show("La valeur du capital n'est pas valide", "?!!!?!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextCapital.Focus();// revient sur le champs capital
            }

            double k = Convert.ToDouble(TextCapital.Text);//récupère le capital emprunté
            double t;

            //divise le taux selon la période choisie
            if (listeperiodicite.SelectedIndex == 0)//mensuel
            {
                t = taux / 12;
            }

            else if (listeperiodicite.SelectedIndex == 1)//bimestrielle
            {
                t = taux / 6;
            }

            else if (listeperiodicite.SelectedIndex == 2)//trimestirelle
            {
                t = taux / 4;
            }

            else if (listeperiodicite.SelectedIndex == 3)//semestrielle
            {
                t = taux / 2;
            }

            else//annuelle
            {
                t = taux;
            }
            
            double n = Convert.ToDouble(EtiNbRemb.Text);//récupère le nombre de paiement
            double result = Math.Round((k*(t/(1-(Math.Pow(1+t,-n))))),2);//calcul du remboursement et arrondi
            Montant.Text = result.ToString();//affiche le montant
        }

        /// <summary>
        /// Réinitialise les choix si le montant du capital change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextCapital_TextChanged(object sender, EventArgs e)
        {
            radioButton7.Checked = true;
            listeperiodicite.SelectedIndex = 0;
            Scrollduree.Value = 1;
            EtiDur.Refresh();//rafraichit l'étiquette de durée
        }

        /// <summary>
        /// Quand je quitte le champ capital, je vérifie si le capital est bon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextCapital_Leave(object sender, EventArgs e)
        {
            Regex myregex = new Regex("^[0-9]{2,10}$");//regex de contôle chiffre max à 10
            string capital = TextCapital.Text;

            if (!myregex.IsMatch(capital))//vérifie si c'est bon
            {
                erreurcapital.SetError(TextCapital, "Erreur de saisie\nLe capital doit être de 10 chiffres maximum\nSans séparateur décimal");//contenu de l'erreur provider
                TextCapital.Focus();
                Valide.Enabled = false;//si non le bouton pour calculer reste inactif
            }

            else
            {
                erreurcapital.Clear();//sinon efface l'erreur provider
                Valide.Enabled = true;
                Taux.Enabled = true;
                Scrollduree.Enabled = true;
            } 
        }

        /// <summary>
        /// Récupère la valeur du tag du bouton radio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton boutontaux = sender as RadioButton;//cast d'évènement en bouton radio

            taux = Convert.ToDouble(boutontaux.Tag as string);//cast l'objet tag en string et converti le string en double  
            
        }
        /// <summary>
        /// clique sur annule demande de valider si on efface le contenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Annule_Click(object sender, EventArgs e)
        {
            DialogResult efface = MessageBox.Show("Vous allez effacer tous les paramètres ?", "Effacement de saisie", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (efface == DialogResult.Yes)
            {
                radioButton7.Checked = true;
                listeperiodicite.SelectedIndex = 0;
                Scrollduree.Value = 1;
                EtiDur.Refresh();
                Montant.Text = string.Empty;
                TextCapital.Text = string.Empty;
                TextNom.Text = string.Empty;
            }

        }
    }
}
