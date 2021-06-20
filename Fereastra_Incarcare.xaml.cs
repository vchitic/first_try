using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace first_try
{
    /// <summary>
    /// Interaction logic for Fereastra_Incarcare.xaml
    /// </summary>
    /// 

    enum ActionState
    {
        New,
        Edit,
        Delete,
        Nothing
    }
    public partial class Fereastra_Incarcare : Window
    {

        ActionState action = ActionState.Nothing;
        BazaDeDateDataSet bazaDeDateDataSet = new BazaDeDateDataSet();
        BazaDeDateDataSetTableAdapters.DateFormIncarcareTableAdapter
        tblDateFormAdapter = new BazaDeDateDataSetTableAdapters.DateFormIncarcareTableAdapter();
        //header
        Binding txtNrBinding = new Binding();
        Binding txtPlatitiBinding = new Binding();
        Binding txtNumarInCuvinteBinding = new Binding();
        //platitor
        Binding txtPlatBinding = new Binding();
        Binding txtCodPlatBinding = new Binding();
        Binding txtAdresaPlatBinding = new Binding();
        Binding txtIbanPlatBinding = new Binding();
        Binding txtBicPlatBinding = new Binding();
        Binding txtDeLaBinding = new Binding();
        Binding txtAngajamentBinding = new Binding();
        Binding txtIndicatorBinding = new Binding();
        Binding txtCodProgrBinding = new Binding();
        //beneficiar
        Binding txtBenefBinding = new Binding();
        Binding txtCodBenefBinding = new Binding();
        Binding txtIbanBenefBinding = new Binding();
        Binding txtBicBenefBinding = new Binding();
        Binding txtLaBinding = new Binding();
        Binding txtNrEvidBinding = new Binding();
        Binding txtReprezBinding = new Binding();
        //data
        Binding dtDataEmitBinding = new Binding();

        public Fereastra_Incarcare()
        {
            InitializeComponent();
            grdIncarcare.DataContext = bazaDeDateDataSet.DateFormIncarcare;

            txtNrBinding.Path = new PropertyPath("nr");
            txtPlatitiBinding.Path = new PropertyPath("platiti");
            txtNumarInCuvinteBinding.Path = new PropertyPath("numarInCuvinte");

            txtPlatBinding.Path = new PropertyPath("plat");
            txtCodPlatBinding.Path = new PropertyPath("codPlat");
            txtAdresaPlatBinding.Path = new PropertyPath("adresaPlat");
            txtIbanPlatBinding.Path = new PropertyPath("ibanPlat");
            txtBicPlatBinding.Path = new PropertyPath("bicPlat");
            txtDeLaBinding.Path = new PropertyPath("deLa");
            txtAngajamentBinding.Path = new PropertyPath("angajament");
            txtIndicatorBinding.Path = new PropertyPath("indicator");
            txtCodProgrBinding.Path = new PropertyPath("codProgr");

            txtBenefBinding.Path = new PropertyPath("benef");
            txtCodBenefBinding.Path = new PropertyPath("codBenef");
            txtIbanBenefBinding.Path = new PropertyPath("ibanBenef");
            txtBicBenefBinding.Path = new PropertyPath("bicBenef");
            txtLaBinding.Path = new PropertyPath("la");
            txtNrEvidBinding.Path = new PropertyPath("nrEvid");
            txtReprezBinding.Path = new PropertyPath("reprez");

            dtDataEmitBinding.Path = new PropertyPath("dataEmit");

            txtNr.SetBinding(TextBox.TextProperty, txtNrBinding);
            txtPlatiti.SetBinding(TextBox.TextProperty, txtPlatitiBinding);
            txtNumarInCuvinte.SetBinding(TextBox.TextProperty, txtNumarInCuvinteBinding);

            txtPlat.SetBinding(TextBox.TextProperty, txtPlatBinding);
            txtCodPlat.SetBinding(TextBox.TextProperty, txtCodPlatBinding);
            txtAdresaPlat.SetBinding(TextBox.TextProperty, txtAdresaPlatBinding);
            txtIbanPlat.SetBinding(TextBox.TextProperty, txtIbanPlatBinding);
            txtBicPlat.SetBinding(TextBox.TextProperty, txtBicPlatBinding);
            txtDeLa.SetBinding(TextBox.TextProperty, txtDeLaBinding);
            txtAngajament.SetBinding(TextBox.TextProperty, txtAngajamentBinding);
            txtIndicator.SetBinding(TextBox.TextProperty, txtIndicatorBinding);
            txtCodProgr.SetBinding(TextBox.TextProperty, txtCodProgrBinding);

            txtBenef.SetBinding(TextBox.TextProperty, txtBenefBinding);
            txtCodBenef.SetBinding(TextBox.TextProperty, txtCodBenefBinding);
            txtIbanBenef.SetBinding(TextBox.TextProperty, txtIbanBenefBinding);
            txtBicBenef.SetBinding(TextBox.TextProperty, txtBicBenefBinding);
            txtLa.SetBinding(TextBox.TextProperty, txtLaBinding);
            txtNrEvid.SetBinding(TextBox.TextProperty, txtNrEvidBinding);
            txtReprez.SetBinding(TextBox.TextProperty, txtReprezBinding);

            dtDataEmit.SetBinding(TextBox.TextProperty, dtDataEmitBinding);
        }

        private void lstDateLoad()
        {
            tblDateFormAdapter.Fill(bazaDeDateDataSet.DateFormIncarcare);
        }

        private void frmIncarcare_Loaded(object sender, RoutedEventArgs e)
        {
            //BazaDeDateDataSet bazaDeDateDataSet = ((BazaDeDateDataSet)(this.FindResource("bazaDeDateDataSet")));
            //System.Windows.Data.CollectionViewSource bazaDeDateViewSource =
            //((System.Windows.Data.CollectionViewSource)(this.FindResource("bazaDeDateViewSource")));
            //bazaDeDateViewSource.View.MoveCurrentToFirst();
            
            ICollectionView navigationView =
             CollectionViewSource.GetDefaultView(bazaDeDateDataSet.DateFormIncarcare);
            navigationView.MoveCurrentToFirst();
            
            this.Top = 0;
        }

        private void grdIncarcare_Loaded(object sender, RoutedEventArgs e)
        {
            lstDateLoad();
        }

        private void LegislatieClick(object sender, RoutedEventArgs e)
        {      
            Fereastra_Legislatie legislatie = new Fereastra_Legislatie();
            legislatie.Show();
        }

        private void InstrClick(object sender, RoutedEventArgs e)
        {
            Fereastra_Instructiuni instructiuni = new Fereastra_Instructiuni();
            instructiuni.Show();
        }

        private void InfUtile(object sender, RoutedEventArgs e)
        {
            Fereastra_InfUtile infUtile = new Fereastra_InfUtile();
            infUtile.Show();
        }

        private void SugestiiClick(object sender, RoutedEventArgs e)
        {
            Fereastra_Sugestii sugestii = new Fereastra_Sugestii();
            sugestii.Show();
        }

        private void ExportareClick(object sender, RoutedEventArgs e)
        {
            //exportare ca PDF
            //btnComplBenef.Visibility = System.Windows.Visibility.Hidden;
            gbButoane.Visibility = System.Windows.Visibility.Hidden;
            try
            {
                //this.IsEnabled = false;

                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                { 
                    printDialog.PrintVisual(grdIncarcare, "OP");
                }
            }
            finally
            {
                //this.IsEnabled = true;
            }

            gbButoane.Visibility = System.Windows.Visibility.Visible;
           
        }

        public static int NumarDeCifre(int numar)
        {

            int NumarDeCifre = 0;
            int numar_lucru = numar;
            while (numar_lucru != 0)
            {
                numar_lucru /= 10; // impartim la zece
                NumarDeCifre++;
            }

            if (numar == 0) NumarDeCifre++;  // avem o exceptie: cand numarul este 0 avem o cifra

            return NumarDeCifre;

        }

        public static int RidicareLaPutere(int numar, int putere)
        {

            int calculat = 1;
            while (putere != 0)
            {
                calculat *= 10; // inmultim cu zece
                putere--;
            }

            return calculat;

        }

        public static int CifraDeLaPozitie(int numar, int pozitie)
        {
            pozitie--;
            int divizor = RidicareLaPutere(10, pozitie);
            return numar / divizor;  // imparte pentru a obtine cifra de la pozitie
        }

        static string[] cifre_lit = new string[] { "o", "două", "trei", "patru", "cinci", "șase", "șapte", "opt", "nouă" };

        public static string CifraLaLiteral(int cifra, int numar_de_cifre, bool EsteFeminin)
        {
            if (numar_de_cifre == 2 && cifra == 6)  // exceptie 16 - saisprezece, 64
                return "șai";  // sai nu sase

            switch (cifra)
            {
                case 1:
                    if (EsteFeminin && numar_de_cifre != 10)  // miliarde este un miliard - masculin la singular
                        return "o";
                    else
                        return "un";
                case 2:
                    if (EsteFeminin)
                        return "două";
                    else
                        return "doi";

                default:
                    if ((cifra >= 0) && ((cifra - 1) < cifre_lit.Length))
                        return cifre_lit[cifra - 1];
                    else
                        return "";
            }
        }

        public static bool EstePlural(int cifra)
        {
            if (cifra > 1)
                return true;
            else
                return false;
        }

        static string[] cifre_lit2 = new string[] { "zece", "unsprezece", "doisprezece", "treisprezece", "paisprezece", "cincisprezece", "șaisprezece", "șaptesprezece", "optsprezece", "nouăsprezece" };

        static string GetSprezece(int numar)
        {

            if ((numar >= 10) && ((numar - 10) < cifre_lit2.Length))
                return cifre_lit2[numar - 10];
            else
                return "";

        }

        public static string ConversieNumarIntreg(int numar)
        {
            if (numar == 0) return "zero";

            string construit = "";
            int numar_de_cifre = NumarDeCifre(numar);
            while (numar_de_cifre != 0)
            {
                int numar_de_la_pozitie = CifraDeLaPozitie(numar, numar_de_cifre);

                if (numar_de_la_pozitie > 0)  // cifrele cu zero nu ne intereseaza
                {
                    bool EsteFeminin = false;
                    bool bool_EstePlural = EstePlural(numar_de_la_pozitie);
                    switch (numar_de_cifre)
                    {
                        case 10:  // miliarde
                        case 9:  // sute de milioane
                        case 6:  // sute de mii
                        case 3:  // sute

                            EsteFeminin = true;
                            construit += CifraLaLiteral(numar_de_la_pozitie, numar_de_cifre, EsteFeminin) + " ";

                            if (numar_de_cifre == 10)  // miliarde
                            {
                                if (bool_EstePlural)
                                    construit += "miliarde ";
                                else
                                    construit += "miliard ";
                            }
                            else if (numar_de_cifre == 9 || numar_de_cifre == 6 || numar_de_cifre == 3) // sute de milioane || sute de milioane || sute
                            {
                                if (bool_EstePlural)
                                    construit += "sute ";
                                else
                                    construit += "sută ";
                            }
                            break;

                        case 8:  //  daca este 1 prima cifra: sprezece, altfel doua zeci de milioane
                        case 5:  //  daca este 1 prima cifra: sprezece, altfel zeci de mii
                        case 2:  //  daca este 1 prima cifra: sprezece, altfel zeci

                            EsteFeminin = true;
                            if (numar_de_la_pozitie == 1)
                            {  // iau doua cifre acum
                                int numar_de_cifre_vechi = numar_de_cifre;
                                numar_de_cifre--;
                                numar_de_la_pozitie = CifraDeLaPozitie(numar, numar_de_cifre);  //  int doua_numere_de_la_pozitie
                                if (numar_de_la_pozitie > 1)
                                    bool_EstePlural = true;

                                construit += GetSprezece(numar_de_la_pozitie);
                                if (numar_de_cifre_vechi == 8)  // (numar_de_cifre+1) deoarece am scazut 1
                                {
                                    if (bool_EstePlural)
                                        construit += " milioane";
                                    else
                                        construit += " milion";
                                }
                                else if (numar_de_cifre_vechi == 5)
                                {
                                    if (bool_EstePlural)
                                        construit += " mii";
                                    else
                                        construit += " mie";
                                }
                                else if (numar_de_cifre_vechi == 2)  // nu a mai ramas nimic
                                {
                                    construit += " ";
                                }
                            }
                            else
                            {
                                construit += CifraLaLiteral(numar_de_la_pozitie, numar_de_cifre, EsteFeminin);
                                if (bool_EstePlural)
                                    construit += "zeci";
                            }
                            construit += " ";
                            break;

                        case 7:  // un numar singur urmat: "si numar de milioane"
                        case 4:  // si "numar" de mii
                        case 1:  // si "numar"
                            EsteFeminin = false;
                            if (bool_EstePlural)
                                EsteFeminin = true;
                            else if (numar_de_cifre == 7)
                                EsteFeminin = false;
                            else if (numar_de_cifre == 4)
                                EsteFeminin = true;

                            bool EraGol = false;

                            if (construit.Length > 0)
                                construit += "și ";
                            else
                                EraGol = true;

                            construit += CifraLaLiteral(numar_de_la_pozitie, numar_de_cifre, EsteFeminin);
                            if (numar_de_cifre == 7)
                            {
                                if (bool_EstePlural)
                                {
                                    if (!EraGol)
                                        construit += " de milioane "; // plural = feminin
                                }
                                else
                                {
                                    construit += " milion ";  // singular = masculin
                                }
                            }
                            else if (numar_de_cifre == 4)  // si "numar" de mii
                            {
                                if (bool_EstePlural)
                                {
                                    if (!EraGol)
                                        construit += " de mii "; // plural = feminin
                                }
                                else
                                {
                                    construit += " mie ";  // singular = feminin
                                }
                            }
                            else if (numar_de_cifre == 1 && (!bool_EstePlural))  // si "numar"
                            {
                                construit += "u";  // un + u = unu
                            }
                            break;
                        default:
                            break;
                    }

                }

                int ridicat = 1;

                if ((numar_de_cifre - 1) > 0)  // verifica ca puterea sa fie mai mare ca zero
                    ridicat = RidicareLaPutere(10, numar_de_cifre - 1);

                int de_scazut = numar_de_la_pozitie * ridicat;  // eliminam numarul care a fost deja printat
                numar = numar - de_scazut;

                numar_de_cifre--;

            }

            return construit;

        }

        private void TextChangedNumbers(object sender, TextChangedEventArgs e)
        {
            if (txtPlatiti.Text != "")
            {
                string errMsg = "Introduceți doar numere în câmpul PLĂTIȚI";
                try
                {
                    txtNumarInCuvinte.Text = ConversieNumarIntreg(Convert.ToInt32(txtPlatiti.Text));
                }
                catch (Exception) { MessageBox.Show(errMsg); }
            }
            txtPlatiti2.Text = txtPlatiti.Text;
        }    

        /*private void ComplBenefClick(object sender, RoutedEventArgs e)
        {
            ComplBenef completare = new ComplBenef();
            completare.Show();
        }*/

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            action = ActionState.New;
            btnNew.IsEnabled = false;
            btnEdit.IsEnabled = false;
            btnDelete.IsEnabled = false;

            btnSalvare.IsEnabled = true;
            btnCancel.IsEnabled = true;
            lstDate.IsEnabled = false;
            btnPrevious.IsEnabled = false;
            btnNext.IsEnabled = false;

            txtNr.IsEnabled = true;
            txtPlatiti.IsEnabled = true;
            txtNumarInCuvinte.IsEnabled = true;

            txtPlat.IsEnabled = true;
            txtCodPlat.IsEnabled = true;
            txtAdresaPlat.IsEnabled = true;
            txtIbanPlat.IsEnabled = true;
            txtBicPlat.IsEnabled = true;
            txtDeLa.IsEnabled = true;
            txtAngajament.IsEnabled = true;
            txtIndicator.IsEnabled = true;
            txtCodProgr.IsEnabled = true;

            txtBenef.IsEnabled = true;
            txtCodBenef.IsEnabled = true;
            txtIbanBenef.IsEnabled = true;
            txtBicBenef.IsEnabled = true;
            txtLa.IsEnabled = true;
            txtNrEvid.IsEnabled = true;
            txtReprez.IsEnabled = true;

            dtDataEmit.IsEnabled = true;

            BindingOperations.ClearBinding(txtNr, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtPlatiti, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtNumarInCuvinte, TextBox.TextProperty);

            BindingOperations.ClearBinding(txtPlat, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtCodPlat, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtAdresaPlat, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtIbanPlat, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtBicPlat, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtDeLa, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtAngajament, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtIndicator, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtCodProgr, TextBox.TextProperty);

            BindingOperations.ClearBinding(txtBenef, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtCodBenef, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtIbanBenef, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtBicBenef, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtLa, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtNrEvid, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtReprez, TextBox.TextProperty);
            BindingOperations.ClearBinding(dtDataEmit, TextBox.TextProperty);

            txtNr.Text = "";
            txtPlatiti.Text = "";
            txtNumarInCuvinte.Text = "";

            txtPlat.Text = "";
            txtCodPlat.Text = "";
            txtAdresaPlat.Text = "";
            txtIbanPlat.Text = "";
            txtBicPlat.Text = "";
            txtDeLa.Text = "";
            txtAngajament.Text = "";
            txtIndicator.Text = "";
            txtCodProgr.Text = "";

            txtBenef.Text = "";
            txtCodBenef.Text = "";
            txtIbanBenef.Text = "";
            txtBicBenef.Text = "";
            txtLa.Text = "";
            txtNrEvid.Text = "";
            txtReprez.Text = "";

            dtDataEmit.Text = "";

            Keyboard.Focus(txtNr);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            action = ActionState.Edit;
            string tempNr = txtNr.Text.ToString();
            string tempPlatiti = txtPlatiti.Text.ToString();
            string tempNrInCuvinte = txtNumarInCuvinte.Text.ToString();
            string tempPlat = txtPlat.Text.ToString();
            string tempCodPlat = txtCodPlat.Text.ToString();
            string tempAdPlat = txtAdresaPlat.Text.ToString();
            string tempIbanPlat = txtIbanPlat.Text.ToString();
            string tempBicPlat = txtBicPlat.Text.ToString();
            string tempDeLa = txtDeLa.Text.ToString();
            string tempAngaj = txtAngajament.Text.ToString();
            string tempIndicator = txtIndicator.Text.ToString();
            string tempCodProgr = txtCodProgr.Text.ToString();

            string tempBenef = txtBenef.Text.ToString();
            string tempCodBenef = txtCodBenef.Text.ToString();
            string tempIbanBenef = txtIbanBenef.Text.ToString();
            string tempBicBenef = txtBicBenef.Text.ToString();
            string tempLa = txtLa.Text.ToString();
            string tempNrEvid = txtNrEvid.Text.ToString();
            string tempReprez = txtReprez.Text.ToString();
            string tempDataEmit = dtDataEmit.Text.ToString();

            btnNew.IsEnabled = false;
            btnEdit.IsEnabled = false;
            btnDelete.IsEnabled = false;

            btnSalvare.IsEnabled = true;
            btnCancel.IsEnabled = true;
            lstDate.IsEnabled = false;
            btnPrevious.IsEnabled = false;
            btnNext.IsEnabled = false;

            txtNr.IsEnabled = true;
            txtPlatiti.IsEnabled = true;
            txtNumarInCuvinte.IsEnabled = true;

            txtPlat.IsEnabled = true;
            txtCodPlat.IsEnabled = true;
            txtAdresaPlat.IsEnabled = true;
            txtIbanPlat.IsEnabled = true;
            txtBicPlat.IsEnabled = true;
            txtDeLa.IsEnabled = true;
            txtAngajament.IsEnabled = true;
            txtIndicator.IsEnabled = true;
            txtCodProgr.IsEnabled = true;

            txtBenef.IsEnabled = true;
            txtCodBenef.IsEnabled = true;
            txtIbanBenef.IsEnabled = true;
            txtBicBenef.IsEnabled = true;
            txtLa.IsEnabled = true;
            txtNrEvid.IsEnabled = true;
            txtReprez.IsEnabled = true;

            dtDataEmit.IsEnabled = true;

            BindingOperations.ClearBinding(txtNr, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtPlatiti, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtNumarInCuvinte, TextBox.TextProperty);

            BindingOperations.ClearBinding(txtPlat, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtCodPlat, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtAdresaPlat, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtIbanPlat, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtBicPlat, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtDeLa, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtAngajament, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtIndicator, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtCodProgr, TextBox.TextProperty);

            BindingOperations.ClearBinding(txtBenef, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtCodBenef, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtIbanBenef, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtBicBenef, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtLa, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtNrEvid, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtReprez, TextBox.TextProperty);
            BindingOperations.ClearBinding(dtDataEmit, TextBox.TextProperty);

            txtNr.Text = tempNr;
            txtPlatiti.Text = tempPlatiti;
            txtNumarInCuvinte.Text = tempNrInCuvinte;

            txtPlat.Text = tempPlat;
            txtCodPlat.Text = tempCodPlat;
            txtAdresaPlat.Text = tempAdPlat;
            txtIbanPlat.Text = tempIbanPlat;
            txtBicPlat.Text = tempBicPlat;
            txtDeLa.Text = tempDeLa;
            txtAngajament.Text = tempAngaj;
            txtIndicator.Text = tempIndicator;
            txtCodProgr.Text = tempCodProgr;

            txtBenef.Text = tempBenef;
            txtCodBenef.Text = tempCodBenef;
            txtIbanBenef.Text = tempIbanBenef;
            txtBicBenef.Text = tempBicBenef;
            txtLa.Text = tempLa;
            txtNrEvid.Text = tempNrEvid;
            txtReprez.Text = tempReprez;

            dtDataEmit.Text = tempDataEmit;

            Keyboard.Focus(txtNr);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            action = ActionState.Delete;
            string tempNr = txtNr.Text.ToString();
            string tempPlatiti = txtPlatiti.Text.ToString();
            string tempNrInCuvinte = txtNumarInCuvinte.Text.ToString();
            string tempPlat = txtPlat.Text.ToString();
            string tempCodPlat = txtCodPlat.Text.ToString();
            string tempAdPlat = txtAdresaPlat.Text.ToString();
            string tempIbanPlat = txtIbanPlat.Text.ToString();
            string tempBicPlat = txtBicPlat.Text.ToString();
            string tempDeLa = txtDeLa.Text.ToString();
            string tempAngaj = txtAngajament.Text.ToString();
            string tempIndicator = txtIndicator.Text.ToString();
            string tempCodProgr = txtCodProgr.Text.ToString();

            string tempBenef = txtBenef.Text.ToString();
            string tempCodBenef = txtCodBenef.Text.ToString();
            string tempIbanBenef = txtIbanBenef.Text.ToString();
            string tempBicBenef = txtBicBenef.Text.ToString();
            string tempLa = txtLa.Text.ToString();
            string tempNrEvid = txtNrEvid.Text.ToString();
            string tempReprez = txtReprez.Text.ToString();
            string tempDataEmit = dtDataEmit.Text.ToString();

            btnNew.IsEnabled = false;
            btnEdit.IsEnabled = false;
            btnDelete.IsEnabled = false;

            btnSalvare.IsEnabled = true;
            btnCancel.IsEnabled = true;
            lstDate.IsEnabled = false;
            btnPrevious.IsEnabled = false;
            btnNext.IsEnabled = false;

            BindingOperations.ClearBinding(txtNr, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtPlatiti, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtNumarInCuvinte, TextBox.TextProperty);

            BindingOperations.ClearBinding(txtPlat, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtCodPlat, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtAdresaPlat, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtIbanPlat, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtBicPlat, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtDeLa, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtAngajament, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtIndicator, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtCodProgr, TextBox.TextProperty);

            BindingOperations.ClearBinding(txtBenef, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtCodBenef, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtIbanBenef, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtBicBenef, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtLa, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtNrEvid, TextBox.TextProperty);
            BindingOperations.ClearBinding(txtReprez, TextBox.TextProperty);
            BindingOperations.ClearBinding(dtDataEmit, TextBox.TextProperty);

            txtNr.Text = tempNr;
            txtPlatiti.Text = tempPlatiti;
            txtNumarInCuvinte.Text = tempNrInCuvinte;

            txtPlat.Text = tempPlat;
            txtCodPlat.Text = tempCodPlat;
            txtAdresaPlat.Text = tempAdPlat;
            txtIbanPlat.Text = tempIbanPlat;
            txtBicPlat.Text = tempBicPlat;
            txtDeLa.Text = tempDeLa;
            txtAngajament.Text = tempAngaj;
            txtIndicator.Text = tempIndicator;
            txtCodProgr.Text = tempCodProgr;

            txtBenef.Text = tempBenef;
            txtCodBenef.Text = tempCodBenef;
            txtIbanBenef.Text = tempIbanBenef;
            txtBicBenef.Text = tempBicBenef;
            txtLa.Text = tempLa;
            txtNrEvid.Text = tempNrEvid;
            txtReprez.Text = tempReprez;

            dtDataEmit.Text = tempDataEmit;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            action = ActionState.Nothing;
            btnNew.IsEnabled = true;
            btnEdit.IsEnabled = true;
            btnDelete.IsEnabled = true;

            btnSalvare.IsEnabled = false;
            btnCancel.IsEnabled = false;
            lstDate.IsEnabled = true;
            btnPrevious.IsEnabled = true;
            btnNext.IsEnabled = true;

            txtNr.IsEnabled = false;
            txtPlatiti.IsEnabled = false;
            txtNumarInCuvinte.IsEnabled = false;

            txtPlat.IsEnabled = false;
            txtCodPlat.IsEnabled = false;
            txtAdresaPlat.IsEnabled = false;
            txtIbanPlat.IsEnabled = false;
            txtBicPlat.IsEnabled = false;
            txtDeLa.IsEnabled = false;
            txtAngajament.IsEnabled = false;
            txtIndicator.IsEnabled = false;
            txtCodProgr.IsEnabled = false;

            txtBenef.IsEnabled = false;
            txtCodBenef.IsEnabled = false;
            txtIbanBenef.IsEnabled = false;
            txtBicBenef.IsEnabled = false;
            txtLa.IsEnabled = false;
            txtNrEvid.IsEnabled = false;
            txtReprez.IsEnabled = false;

            dtDataEmit.IsEnabled = false;

            txtNr.SetBinding(TextBox.TextProperty, txtNrBinding);
            txtPlatiti.SetBinding(TextBox.TextProperty, txtPlatitiBinding);
            txtNumarInCuvinte.SetBinding(TextBox.TextProperty, txtNumarInCuvinteBinding);
            txtPlat.SetBinding(TextBox.TextProperty, txtPlatBinding);
            txtCodPlat.SetBinding(TextBox.TextProperty, txtCodPlatBinding);
            txtAdresaPlat.SetBinding(TextBox.TextProperty, txtAdresaPlatBinding);
            txtIbanPlat.SetBinding(TextBox.TextProperty, txtIbanPlatBinding);
            txtBicPlat.SetBinding(TextBox.TextProperty, txtBicPlatBinding);
            txtDeLa.SetBinding(TextBox.TextProperty, txtDeLaBinding);
            txtAngajament.SetBinding(TextBox.TextProperty, txtAngajamentBinding);
            txtIndicator.SetBinding(TextBox.TextProperty, txtIndicatorBinding);
            txtCodProgr.SetBinding(TextBox.TextProperty, txtCodProgrBinding);

            txtBenef.SetBinding(TextBox.TextProperty, txtBenefBinding);
            txtCodBenef.SetBinding(TextBox.TextProperty, txtCodBenefBinding);
            txtIbanBenef.SetBinding(TextBox.TextProperty, txtIbanBenefBinding);
            txtBicBenef.SetBinding(TextBox.TextProperty, txtBicBenefBinding);
            txtLa.SetBinding(TextBox.TextProperty, txtLaBinding);
            txtNrEvid.SetBinding(TextBox.TextProperty, txtNrEvidBinding);
            txtReprez.SetBinding(TextBox.TextProperty, txtReprezBinding);
            dtDataEmit.SetBinding(TextBox.TextProperty, dtDataEmitBinding);

        }

        private void btnSalvare_Click(object sender, RoutedEventArgs e)
        {
            if (action == ActionState.New)
            {
                try
                {
                    DataRow newRow = bazaDeDateDataSet.DateFormIncarcare.NewRow();
                    newRow.BeginEdit();
                    newRow["nr"] = txtNr.Text.Trim();
                    newRow["platiti"] = txtPlatiti.Text.Trim();
                    newRow["numarInCuvinte"] = txtNumarInCuvinte.Text.Trim();
                    newRow["plat"] = txtPlat.Text.Trim();
                    newRow["codPlat"] = txtCodPlat.Text.Trim();
                    newRow["adresaPlat"] = txtAdresaPlat.Text.Trim();
                    newRow["ibanPlat"] = txtIbanPlat.Text.Trim();
                    newRow["bicPlat"] = txtBicPlat.Text.Trim();
                    newRow["deLa"] = txtDeLa.Text.Trim();
                    newRow["angajament"] = txtAngajament.Text.Trim();
                    newRow["indicator"] = txtIndicator.Text.Trim();
                    newRow["codProgr"] = txtCodProgr.Text.Trim();

                    newRow["benef"] = txtBenef.Text.Trim();
                    newRow["codBenef"] = txtCodBenef.Text.Trim();
                    newRow["ibanBenef"] = txtIbanBenef.Text.Trim();
                    newRow["bicBenef"] = txtBicBenef.Text.Trim();
                    newRow["la"] = txtLa.Text.Trim();
                    newRow["nrEvid"] = txtNrEvid.Text.Trim();
                    newRow["reprez"] = txtReprez.Text.Trim();
                    newRow["dataEmit"] = dtDataEmit.Text.Trim();

                    newRow.EndEdit();
                    bazaDeDateDataSet.DateFormIncarcare.Rows.Add(newRow);
                    tblDateFormAdapter.Update(bazaDeDateDataSet.DateFormIncarcare);
                    bazaDeDateDataSet.AcceptChanges();
                }
                catch (DataException ex)
                {
                    bazaDeDateDataSet.RejectChanges();
                    MessageBox.Show(ex.Message);
                }
                catch (Exception)
                {
                    MessageBox.Show("Tipul de date introdus este invalid");
                }

                btnNew.IsEnabled = true;
                btnEdit.IsEnabled = true;
                btnSalvare.IsEnabled = false;
                btnCancel.IsEnabled = false;
                lstDate.IsEnabled = true;
                btnPrevious.IsEnabled = true;
                btnNext.IsEnabled = true;

                txtNr.IsEnabled = false;
                txtPlatiti.IsEnabled = false;
                txtNumarInCuvinte.IsEnabled = false;

                txtPlat.IsEnabled = false;
                txtCodPlat.IsEnabled = false;
                txtAdresaPlat.IsEnabled = false;
                txtIbanPlat.IsEnabled = false;
                txtBicPlat.IsEnabled = false;
                txtDeLa.IsEnabled = false;
                txtAngajament.IsEnabled = false;
                txtIndicator.IsEnabled = false;
                txtCodProgr.IsEnabled = false;

                txtBenef.IsEnabled = false;
                txtCodBenef.IsEnabled = false;
                txtIbanBenef.IsEnabled = false;
                txtBicBenef.IsEnabled = false;
                txtLa.IsEnabled = false;
                txtNrEvid.IsEnabled = false;
                txtReprez.IsEnabled = false;

                dtDataEmit.IsEnabled = false;
            }
            else
            if (action == ActionState.Edit)
            {
                try
                {
                    DataRow editRow = bazaDeDateDataSet.DateFormIncarcare.Rows[lstDate.SelectedIndex];
                    editRow.BeginEdit();
                    editRow["nr"] = txtNr.Text.Trim();
                    editRow["platiti"] = txtPlatiti.Text.Trim();
                    editRow["numarInCuvinte"] = txtNumarInCuvinte.Text.Trim();
                    editRow["plat"] = txtPlat.Text.Trim();
                    editRow["codPlat"] = txtCodPlat.Text.Trim();
                    editRow["adresaPlat"] = txtAdresaPlat.Text.Trim();
                    editRow["ibanPlat"] = txtIbanPlat.Text.Trim();
                    editRow["bicPlat"] = txtBicPlat.Text.Trim();
                    editRow["deLa"] = txtDeLa.Text.Trim();
                    editRow["angajament"] = txtAngajament.Text.Trim();
                    editRow["indicator"] = txtIndicator.Text.Trim();
                    editRow["codProgr"] = txtCodProgr.Text.Trim();

                    editRow["benef"] = txtBenef.Text.Trim();
                    editRow["codBenef"] = txtCodBenef.Text.Trim();
                    editRow["ibanBenef"] = txtIbanBenef.Text.Trim();
                    editRow["bicBenef"] = txtBicBenef.Text.Trim();
                    editRow["la"] = txtLa.Text.Trim();
                    editRow["nrEvid"] = txtNrEvid.Text.Trim();
                    editRow["reprez"] = txtReprez.Text.Trim();
                    editRow["dataEmit"] = dtDataEmit.Text.Trim();

                    editRow.EndEdit();
                    tblDateFormAdapter.Update(bazaDeDateDataSet.DateFormIncarcare);
                    bazaDeDateDataSet.AcceptChanges();
                }
                catch (DataException ex)
                {
                    bazaDeDateDataSet.RejectChanges();
                    MessageBox.Show(ex.Message);
                }
                catch (Exception)
                {
                    MessageBox.Show("Tipul de date introdus este invalid");
                }

                btnNew.IsEnabled = true;
                btnEdit.IsEnabled = true;
                btnDelete.IsEnabled = true;
                btnSalvare.IsEnabled = false;
                btnCancel.IsEnabled = false;
                lstDate.IsEnabled = true;
                btnPrevious.IsEnabled = true;
                btnNext.IsEnabled = true;

                txtNr.IsEnabled = false;
                txtPlatiti.IsEnabled = false;
                txtNumarInCuvinte.IsEnabled = false;

                txtPlat.IsEnabled = false;
                txtCodPlat.IsEnabled = false;
                txtAdresaPlat.IsEnabled = false;
                txtIbanPlat.IsEnabled = false;
                txtBicPlat.IsEnabled = false;
                txtDeLa.IsEnabled = false;
                txtAngajament.IsEnabled = false;
                txtIndicator.IsEnabled = false;
                txtCodProgr.IsEnabled = false;

                txtBenef.IsEnabled = false;
                txtCodBenef.IsEnabled = false;
                txtIbanBenef.IsEnabled = false;
                txtBicBenef.IsEnabled = false;
                txtLa.IsEnabled = false;
                txtNrEvid.IsEnabled = false;
                txtReprez.IsEnabled = false;

                dtDataEmit.IsEnabled = false;

                txtNr.SetBinding(TextBox.TextProperty, txtNrBinding);
                txtPlatiti.SetBinding(TextBox.TextProperty, txtPlatitiBinding);
                txtNumarInCuvinte.SetBinding(TextBox.TextProperty, txtNumarInCuvinteBinding);
                txtPlat.SetBinding(TextBox.TextProperty, txtPlatBinding);
                txtCodPlat.SetBinding(TextBox.TextProperty, txtCodPlatBinding);
                txtAdresaPlat.SetBinding(TextBox.TextProperty, txtAdresaPlatBinding);
                txtIbanPlat.SetBinding(TextBox.TextProperty, txtIbanPlatBinding);
                txtBicPlat.SetBinding(TextBox.TextProperty, txtBicPlatBinding);
                txtDeLa.SetBinding(TextBox.TextProperty, txtDeLaBinding);
                txtAngajament.SetBinding(TextBox.TextProperty, txtAngajamentBinding);
                txtIndicator.SetBinding(TextBox.TextProperty, txtIndicatorBinding);
                txtCodProgr.SetBinding(TextBox.TextProperty, txtCodProgrBinding);

                txtBenef.SetBinding(TextBox.TextProperty, txtBenefBinding);
                txtCodBenef.SetBinding(TextBox.TextProperty, txtCodBenefBinding);
                txtIbanBenef.SetBinding(TextBox.TextProperty, txtIbanBenefBinding);
                txtBicBenef.SetBinding(TextBox.TextProperty, txtBicBenefBinding);
                txtLa.SetBinding(TextBox.TextProperty, txtLaBinding);
                txtNrEvid.SetBinding(TextBox.TextProperty, txtNrEvidBinding);
                txtReprez.SetBinding(TextBox.TextProperty, txtReprezBinding);
                dtDataEmit.SetBinding(TextBox.TextProperty, dtDataEmitBinding);
            }
            else
            if (action == ActionState.Delete)
            {
                try
                {
                    DataRow deleterow = bazaDeDateDataSet.DateFormIncarcare.Rows[lstDate.SelectedIndex];
                    deleterow.Delete();
                    tblDateFormAdapter.Update(bazaDeDateDataSet.DateFormIncarcare);
                    bazaDeDateDataSet.AcceptChanges();
                }
                catch (DataException ex)
                {
                    bazaDeDateDataSet.RejectChanges();
                    MessageBox.Show(ex.Message);
                }
                catch (Exception)
                {
                    MessageBox.Show("Tipul de date introdus este invalid");
                }

                btnNew.IsEnabled = true;
                btnEdit.IsEnabled = true;
                btnDelete.IsEnabled = true;
                btnSalvare.IsEnabled = false;
                btnCancel.IsEnabled = false;
                lstDate.IsEnabled = true;
                btnPrevious.IsEnabled = true;
                btnNext.IsEnabled = true;

                txtNr.IsEnabled = false;
                txtPlatiti.IsEnabled = false;
                txtNumarInCuvinte.IsEnabled = false;

                txtPlat.IsEnabled = false;
                txtCodPlat.IsEnabled = false;
                txtAdresaPlat.IsEnabled = false;
                txtIbanPlat.IsEnabled = false;
                txtBicPlat.IsEnabled = false;
                txtDeLa.IsEnabled = false;
                txtAngajament.IsEnabled = false;
                txtIndicator.IsEnabled = false;
                txtCodProgr.IsEnabled = false;

                txtBenef.IsEnabled = false;
                txtCodBenef.IsEnabled = false;
                txtIbanBenef.IsEnabled = false;
                txtBicBenef.IsEnabled = false;
                txtLa.IsEnabled = false;
                txtNrEvid.IsEnabled = false;
                txtReprez.IsEnabled = false;

                dtDataEmit.IsEnabled = false;

                txtNr.SetBinding(TextBox.TextProperty, txtNrBinding);
                txtPlatiti.SetBinding(TextBox.TextProperty, txtPlatitiBinding);
                txtNumarInCuvinte.SetBinding(TextBox.TextProperty, txtNumarInCuvinteBinding);
                txtPlat.SetBinding(TextBox.TextProperty, txtPlatBinding);
                txtCodPlat.SetBinding(TextBox.TextProperty, txtCodPlatBinding);
                txtAdresaPlat.SetBinding(TextBox.TextProperty, txtAdresaPlatBinding);
                txtIbanPlat.SetBinding(TextBox.TextProperty, txtIbanPlatBinding);
                txtBicPlat.SetBinding(TextBox.TextProperty, txtBicPlatBinding);
                txtDeLa.SetBinding(TextBox.TextProperty, txtDeLaBinding);
                txtAngajament.SetBinding(TextBox.TextProperty, txtAngajamentBinding);
                txtIndicator.SetBinding(TextBox.TextProperty, txtIndicatorBinding);
                txtCodProgr.SetBinding(TextBox.TextProperty, txtCodProgrBinding);

                txtBenef.SetBinding(TextBox.TextProperty, txtBenefBinding);
                txtCodBenef.SetBinding(TextBox.TextProperty, txtCodBenefBinding);
                txtIbanBenef.SetBinding(TextBox.TextProperty, txtIbanBenefBinding);
                txtBicBenef.SetBinding(TextBox.TextProperty, txtBicBenefBinding);
                txtLa.SetBinding(TextBox.TextProperty, txtLaBinding);
                txtNrEvid.SetBinding(TextBox.TextProperty, txtNrEvidBinding);
                txtReprez.SetBinding(TextBox.TextProperty, txtReprezBinding);
                dtDataEmit.SetBinding(TextBox.TextProperty, dtDataEmitBinding);
            }
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            ICollectionView navigationView =
             CollectionViewSource.GetDefaultView(bazaDeDateDataSet.DateFormIncarcare);

            if (!navigationView.MoveCurrentToPrevious())
            {
                navigationView.MoveCurrentToLast();
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            ICollectionView navigationView =
             CollectionViewSource.GetDefaultView(bazaDeDateDataSet.DateFormIncarcare);
            
            if (!navigationView.MoveCurrentToNext())
            {
                navigationView.MoveCurrentToFirst();
            }

        }

        private void txtNumarInCuvinte_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtPlatiti.Text != "")
            {
                try
                {
                    txtNumarInCuvinte.Text = ConversieNumarIntreg(Convert.ToInt32(txtPlatiti.Text));
                }
                catch (Exception) { MessageBox.Show("Introduceți doar numere în câmpul PLĂTIȚI"); }
            }
            txtNumarInCuvinte2.Text = txtNumarInCuvinte.Text;
        }

        private void txtNr_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtNr2.Text = txtNr.Text;
        }

        private void txtPlat_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtPlat2.Text = txtPlat.Text;
        }

        private void txtCodPlat_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtCodPlat2.Text = txtCodPlat.Text;
        }

        private void txtAdresaPlat_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtAdresaPlat2.Text = txtAdresaPlat.Text;
        }

        private void txtIbanPlat_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtIbanPlat2.Text = txtIbanPlat.Text;
        }

        private void txtBicPlat_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtBicPlat2.Text = txtBicPlat.Text;
        }

        private void txtDeLa_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtDeLa2.Text = txtDeLa.Text;
        }

        private void txtAngajament_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtAngajament2.Text = txtAngajament.Text;
        }

        private void txtIndicator_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtIndicator2.Text = txtIndicator.Text;
        }

        private void txtCodProgr_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtCodProgr2.Text = txtCodProgr.Text;
        }

        private void txtBenef_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtBenef2.Text = txtBenef.Text;
        }

        private void txtCodBenef_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtCodBenef2.Text = txtCodBenef.Text;
        }

        private void txtIbanBenef_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtIbanBenef2.Text = txtIbanBenef.Text;
        }

        private void txtBicBenef_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtBicBenef2.Text = txtBicBenef.Text;
        }

        private void txtLa_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtLa2.Text = txtLa.Text;
        }

        private void txtNrEvid_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtNrEvid2.Text = txtNrEvid.Text;
        }

        private void txtReprez_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtReprez2.Text = txtReprez.Text;
        }

        private void dtDataEmit_TextChanged(object sender, TextChangedEventArgs e)
        {
            dtDataEmit2.Text = dtDataEmit.Text;
        }
    }
}
