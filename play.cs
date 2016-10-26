using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Quiz
{

    public partial class play : Form
    {
        

        Wronganswer objform = new Wronganswer();
        int islide = 0;
        
       

        public play()
        {
            InitializeComponent();
        }
        

        private void A_Click(object sender, EventArgs e)
        {
        }

        private void play_Load(object sender, EventArgs e)
        {
            button1.Text = "START";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
        private void Question1()
        {
            label5.Text = "A quale anno risale il primo triumvirato?";
            radioButton1.Text = "43 a.C.";
            radioButton2.Text = "nessuna delle precedenti";
            radioButton3.Text = "57 a.C.";
            radioButton4.Text = "60 a.c";
        }

        private void Question2()
        {
            label5.Text = " In che anno Cesare fu eletto console per la prima volta?";
            radioButton1.Text = "49 a.C.";
            radioButton2.Text = "59 a.C.";
            radioButton3.Text = "69 a.C.";
            radioButton4.Text = "nessuna delle precedenti";

        }

        private void Question3()
        {
            label5.Text = "Oltre al consolato, Cesare, durante l'anno, si assicurò il proconsolato in:";
            radioButton1.Text = "Siria";
            radioButton2.Text = "Sicilia";
            radioButton3.Text = "Africa";
            radioButton4.Text = "Gallia";
        }

        private void Question4()
        {
            label5.Text = "I primi triumviri furono Cesare, Pompeo e:";
            radioButton1.Text = "Catilina";
            radioButton2.Text = "Crasso";
            radioButton3.Text = "Cicerone";
            radioButton4.Text = "Catone";
        }

        private void Question5()
        {
            label5.Text = "Sconfitto Pompeo, Cesare divenne il padrone di Roma. Egli si fece nominare dittatore a vita e:";
            radioButton1.Text = " augusto";
            radioButton2.Text = "imperator";
            radioButton3.Text = "dux";
            radioButton4.Text = "dominus";
        }

        private void Question6()
        {
            label5.Text = "uno dei libri scritti da cesare si chiamava";
            radioButton1.Text = "De agricoltura";
            radioButton2.Text = "De fato";
            radioButton3.Text = "Ortensio";
            radioButton4.Text = "De Bello Gallico";
        }

        private void Question7()
        {
            label5.Text = "Quale carica non ottenne mai Cesare?";
            radioButton1.Text = "Edile";
            radioButton2.Text = "Questore";
            radioButton3.Text = "Censore";
            radioButton4.Text = "Dux";
        }

        private void Question8()
        {
            label5.Text = "In che occasione pronunciò la famosa frase \"alea iacta est\"?";
            radioButton1.Text = "quando dichiarò guerra a Pompeo";
            radioButton2.Text = "quando attraversò il fiume Rubicone";
            radioButton3.Text = "non è Giulio Cesare ad averla pronunciata";
            radioButton4.Text = "poco prima di essere ucciso";
        }

        private void Question9()
        {
            label5.Text = "Quale fu il carattere del primo Triumvirato?";
            radioButton1.Text = "Fu un accordo scritto e siglato dal Pontefice Massimo.";
            radioButton2.Text = "Il carattere di questo accordo fu soltanto privato, non istituzionale.";
            radioButton3.Text = "fu un accordo sancito formalmente davanti al senato";
            radioButton4.Text = "fu un accordo stipulato per spartirisi Roma";
        }

        private void Question10()
        {
            label5.Text = "Quale fu l'operato di Cesare dopo la vittoria su Pompeo?";
            radioButton1.Text = "Thailand";
            radioButton2.Text = "Si dedicò a una serie di riforme economiche e sociali.";
            radioButton3.Text = "Concesse ampi poteri al Senato e alle magistrature.";
            radioButton4.Text = "Nessuna delle precedenti";
        }


        
        

        private void label2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All progres will be lost, Continue?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                Form1 objmainmenu = new Form1();
                objmainmenu.Show();

            }
            else
            {

            }

        }

        private void C_Click(object sender, EventArgs e)
        {


        }




        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            if (button1.Text == "7" && radioButton3.Checked == true)
            {
                radioButton3.BackColor = Color.Green;
                button1.Enabled = true;
            }

            if (button1.Text == "9" && radioButton3.Checked == true)
            {
                radioButton3.BackColor = Color.Green;
                button1.Enabled = true;
            }

            if (button1.Text == "13" && radioButton3.Checked == true)
            {
                radioButton3.BackColor = Color.Green;
                button1.Enabled = true;
            }
            if ((button1.Text == "1" || button1.Text == "2" || button1.Text == "3" || button1.Text == "4" || button1.Text == "5" || button1.Text == "6" || button1.Text == "11" || button1.Text == "8" || button1.Text == "15" || button1.Text == "10" || button1.Text == "12" || button1.Text == "15" && (radioButton3.Checked == true)))
            { 
                //radioButton3.BackColor = Color.Red;
               
                
                objform.Show();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            if (button1.Text == "1" && radioButton4.Checked == true)
            {
                radioButton4.BackColor = Color.Green;
                button1.Enabled = true;
            }
            if (button1.Text == "3" && radioButton4.Checked == true)
            {
                radioButton4.BackColor = Color.Green;
                button1.Enabled = true;
            }
            if (button1.Text == "6" && radioButton4.Checked == true)
            {
                radioButton4.BackColor = Color.Green;
                button1.Enabled = true;
            }
            if ((button1.Text == "2" || button1.Text == "4" || button1.Text == "5" || button1.Text == "7" || button1.Text == "8" || button1.Text == "9" || button1.Text == "10" || button1.Text == "11" || button1.Text == "12" || button1.Text == "13" || button1.Text == "15" || button1.Text == "14" && (radioButton4.Checked == true)))
            {
                //radioButton4.BackColor = Color.Red;
              
               
                objform.Show();
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (button1.Text == "11" && radioButton1.Checked == true)
            {
                radioButton1.BackColor = Color.Green;
                button1.Enabled = true;
            }
            if (button1.Text == "15" && radioButton1.Checked == true)
            {
                radioButton1.BackColor = Color.Green;
                button1.Enabled = true;
                MessageBox.Show("WELL DONE!!!");
            }
             if ((button1.Text == "1"||button1.Text == "2"||button1.Text == "3" ||button1.Text == "4"||button1.Text == "5"||button1.Text == "6"||button1.Text == "7"||button1.Text == "8"||button1.Text == "9"||button1.Text == "10"||button1.Text == "12"||button1.Text == "13" && (radioButton1.Checked == true)))
             {
                 radioButton1.BackColor = Color.Red;
              
               
                 objform.Show();
                 

             }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (button1.Text == "2" && radioButton2.Checked == true)
            {
                radioButton2.BackColor = Color.Green;
                button1.Enabled = true;
            }
            if (button1.Text == "5" && radioButton2.Checked == true)
            {
                radioButton2.BackColor = Color.Green;
                button1.Enabled = true;
            }
            if (button1.Text == "8" && radioButton2.Checked == true)
            {
                radioButton2.BackColor = Color.Green;
                button1.Enabled = true;
            }
            if (button1.Text == "10" && radioButton2.Checked == true)
            {
                radioButton2.BackColor = Color.Green;
                button1.Enabled = true;
            }
            if (button1.Text == "12" && radioButton2.Checked == true)
            {
                radioButton2.BackColor = Color.Green;
                button1.Enabled = true;
            }
            if (button1.Text == "14" && radioButton2.Checked == true)
            {
                radioButton2.BackColor = Color.Green;
                button1.Enabled = true;
            }
            if (button1.Text == "4" && radioButton2.Checked == true)
            {
                radioButton2.BackColor = Color.Green;
                button1.Enabled = true;
            }
            if ((button1.Text == "1" || button1.Text == "3" || button1.Text == "6" || button1.Text == "7"|| button1.Text == "11" ||  button1.Text == "9" || button1.Text == "13" || button1.Text == "15" && (radioButton2.Checked == true)))
            {
                radioButton2.BackColor = Color.Red;
              

                objform.Show();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Text = "0";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;

            
            islide = islide + 1;
            
            {
                switch (islide)
                {

                    case 1:
                        
                        Question1();
                        
                       
                        button1.Enabled = false;
                        button1.Text = Convert.ToString(islide);


                        button1.ForeColor = Color.Black;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        radioButton1.BackColor = Color.RoyalBlue;
                        radioButton2.BackColor = Color.RoyalBlue;
                        radioButton3.BackColor = Color.RoyalBlue;
                        radioButton4.BackColor = Color.RoyalBlue;
                        break;
                    case 2:
                        Question2();
                        label3.Text = "1";
                      
                        button1.Text = Convert.ToString(islide);
                       
                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        radioButton1.BackColor = Color.RoyalBlue;
                        radioButton2.BackColor = Color.RoyalBlue;
                        radioButton3.BackColor = Color.RoyalBlue;
                        radioButton4.BackColor = Color.RoyalBlue;
                        break;
                    case 3:
                        Question3();
                        label3.Text = "2";
                        button1.Text = Convert.ToString(islide);
                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                         radioButton1.BackColor = Color.RoyalBlue;
                        radioButton2.BackColor = Color.RoyalBlue;
                        radioButton3.BackColor = Color.RoyalBlue;
                        radioButton4.BackColor = Color.RoyalBlue;
                        break;
                    case 4:
                        label3.Text = "3";
                        Question4();
                        button1.Text = Convert.ToString(islide);
                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        radioButton1.BackColor = Color.RoyalBlue;
                        radioButton2.BackColor = Color.RoyalBlue;
                        radioButton3.BackColor = Color.RoyalBlue;
                        radioButton4.BackColor = Color.RoyalBlue;
                        break;
                    case 5:
                        Question5();
                        label3.Text = "4";

                        button1.Text = Convert.ToString(islide);
                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                         radioButton1.BackColor = Color.RoyalBlue;
                        radioButton2.BackColor = Color.RoyalBlue;
                        radioButton3.BackColor = Color.RoyalBlue;
                        radioButton4.BackColor = Color.RoyalBlue;
                        break;

                    case 6:
                        label3.Text = "5";
                        Question6();
                        button1.Text = Convert.ToString(islide);

                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        radioButton1.BackColor = Color.RoyalBlue;
                        radioButton2.BackColor = Color.RoyalBlue;
                        radioButton3.BackColor = Color.RoyalBlue;
                        radioButton4.BackColor = Color.RoyalBlue;
                        break;
                    case 7:
                        label3.Text = "6";
                        Question7();
                        button1.Text = Convert.ToString(islide);
                       
                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                         radioButton1.BackColor = Color.RoyalBlue;
                        radioButton2.BackColor = Color.RoyalBlue;
                        radioButton3.BackColor = Color.RoyalBlue;
                        radioButton4.BackColor = Color.RoyalBlue;
                        break;
                    case 8:
                        label3.Text = "7";
                        Question8();
                        button1.Text = Convert.ToString(islide);
                      
                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                       radioButton1.BackColor = Color.RoyalBlue;
                        radioButton2.BackColor = Color.RoyalBlue;
                        radioButton3.BackColor = Color.RoyalBlue;
                        radioButton4.BackColor = Color.RoyalBlue;
                        break;
                    case 9:
                        label3.Text = "8";
                        Question9();
                        button1.Text = Convert.ToString(islide);
                       
                        button1.Enabled = true;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                         radioButton1.BackColor = Color.RoyalBlue;
                        radioButton2.BackColor = Color.RoyalBlue;
                        radioButton3.BackColor = Color.RoyalBlue;
                        radioButton4.BackColor = Color.RoyalBlue;

                        if (button1.Enabled==true)
                        {
                            this.Close();
                        }

                        break;
        


              
               
                }

              


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}




    



