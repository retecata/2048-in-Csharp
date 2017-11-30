using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace _2048
{
    public partial class Form1 : Form
    {
        int n = 3;
        int rez;
        Boolean mutare = false;
        Button[,] buttonMatrix = new Button[4, 4];

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sus = 30, jos = 100;
            gata.Hide();
            int i, j;
            for (i = 0; i <= n; i++)
            {
                for (j = 0; j <= n; j++)
                {


                    buttonMatrix[i, j] = new Button();

                    buttonMatrix[i, j].Height = 80;
                    buttonMatrix[i, j].Width = 80;
                    buttonMatrix[i, j].Text = "";
                    buttonMatrix[i, j].FlatStyle = FlatStyle.Flat;
                    buttonMatrix[i, j].FlatAppearance.BorderColor = Color.Black;
                    buttonMatrix[i, j].FlatAppearance.BorderSize = 1;
                    buttonMatrix[i, j].Location = new Point(sus, jos);
                    buttonMatrix[i, j].Font = new Font("Georgia", 16);
                    ;

                    sus += 80;



                    this.Controls.Add(buttonMatrix[i, j]);

                }
                jos += 80;
                sus = 30;

            }
            Random rnd = new Random();
            int x = rnd.Next(0, 3);
            int y = rnd.Next(0, 3);
            buttonMatrix[x, y].Text = "2";
            changecolor();
            Highscore.Text = File.ReadAllText(Path.GetFullPath("Highscore.txt"));



        }
        private void gameover()
        {
            int ok = 0;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (buttonMatrix[i,j].Text == "")
                    {
                        ok = 1;
                    }
                }
            }
            if (ok == 0)
            {
                Boolean gameover = true;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (buttonMatrix[i, j].Text == buttonMatrix[i + 1, j].Text ||
                            buttonMatrix[i, j].Text == buttonMatrix[i, j + 1].Text)
                            gameover = false;
                    }
                }
                if (buttonMatrix[3, 3].Text == buttonMatrix[3, 2].Text || buttonMatrix[3, 3].Text == buttonMatrix[2, 3].Text)
                {
                    gameover = false;
                }

                if (gameover == true)
                {


                    gata.Show();
                    int s = Convert.ToInt32(Scor.Text);
                    string value1 = File.ReadAllText(Path.GetFullPath("Highscore.txt"));
                    if (s > Convert.ToInt32(value1))
                    {
                        File.WriteAllText(Path.GetFullPath("Highscore.txt"), String.Empty);
                        File.WriteAllText(Path.GetFullPath("Highscore.txt"), s.ToString());
                        Highscore.Text = s.ToString();
                    }
                    Scor.Text = "0";


                }
            }
        }
        public void nrnou()
        {
           
            Random rnd = new Random();
            int x, y;
            if (mutare == true)
            {
                do
                {
                    x = rnd.Next(0, 4);
                    y = rnd.Next(0, 4);
                } while (buttonMatrix[x, y].Text != "");
                int greu;
                greu = rnd.Next(0, 5);
                if (greu % 2 == 0)
                {
                    buttonMatrix[x, y].Text = "2";

                }
                else
                {
                    buttonMatrix[x, y].Text = "4";

                }
            }
            changecolor();
        }
        private void jos()
        {
           
            for (int i = n - 1; i >= 0; i--)
            {
                int urm = i;


                for (int j = 0; j <= n; j++)
                {

                    
                    
                        for (urm = i; urm < n; urm++)
                        {
                             if (buttonMatrix[urm + 1,j].Text == ""&& buttonMatrix[urm, j].Text != "")
                   
                            {
                                buttonMatrix[urm + 1, j].Text = buttonMatrix[urm, j].Text;
                                buttonMatrix[urm, j].Text = "";
                                changecolor();
                                mutare = true;
                            }

                        
                    }

                }
            }
        }
        private void sus()
        {
            
            for (int i = 1; i < n; i++)
            {

                for (int j = 0; j <= n; j++)
                {
                    for (int urm = n; urm > 0; urm--)
                    {
                        
                            if (buttonMatrix[urm - 1, j].Text == ""&& buttonMatrix[urm, j].Text != "")
                            {
                                buttonMatrix[urm - 1, j].Text = buttonMatrix[urm, j].Text;
                                buttonMatrix[urm, j].Text = "";
                                mutare = true;
                                changecolor();
                            }
                        
                    }

                }

            }
        }
        private void dreapta()
        {
           
            for (int i = 0; i <= n; i++)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    
                        for (int urm = j; urm < n; urm++)
                        {
                            if (buttonMatrix[i, urm + 1].Text == ""&& buttonMatrix[i, urm].Text != "")
                            {
                                buttonMatrix[i, urm + 1].Text = buttonMatrix[i, urm].Text;
                                buttonMatrix[i, urm].Text = "";
                                changecolor();
                                mutare = true;

                            }
                        }
                    
                }
            }
        }
        private void stanga()
        {
           
            for (int i = 0; i <= n; i++)
            {

                for (int j = 1; j <= n; j++)
                {
                    
                    for (int urm = j; urm > 0; urm--)
                    {
                        if (buttonMatrix[i, urm - 1].Text == "" && buttonMatrix[i, urm].Text != "")
                        {
                            buttonMatrix[i, urm - 1].Text = buttonMatrix[i, urm].Text;
                            buttonMatrix[i, urm].Text = "";
                            changecolor();
                            mutare = true;
                        }
                    }

                }
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                   
                case Keys.Down:
                    mutare = false;
                    jos();
                    gameover();
                    for (int i = n - 1; i >= 0; i--)
                    {
                        int urm = i;

                        for (int j = 0; j <= n; j++)
                        {

                            if (buttonMatrix[i + 1, j].Text == buttonMatrix[i, j].Text)
                            {


                                if (buttonMatrix[i, j].Text != "")
                                {
                                    int s = Convert.ToInt32(buttonMatrix[i + 1, j].Text);
                                    int m = Convert.ToInt32(buttonMatrix[i, j].Text);


                                    s = s + m;
                                    buttonMatrix[i + 1, j].Text = s.ToString();
                                    buttonMatrix[i, j].Text = "";
                                    changecolor();
                                     rez = Convert.ToInt32(Scor.Text) + Convert.ToInt32(buttonMatrix[i+1, j].Text);
                                    Scor.Text = rez.ToString();
                                    mutare = true;
                                }

                            }

                        }
                    }
                    jos();
                    if(mutare==true)
                    nrnou();
                    

                    break;
                case Keys.Up:
                    mutare = false;
                    sus();
                    gameover();
                    for (int i = 1; i <= n; i++)
                    {

                        for (int j = 0; j <= n; j++)
                        {


                            if (buttonMatrix[i - 1, j].Text == buttonMatrix[i, j].Text)
                            {


                                if (buttonMatrix[i, j].Text != "")
                                {
                                    int s = Convert.ToInt32(buttonMatrix[i - 1, j].Text);
                                    int m = Convert.ToInt32(buttonMatrix[i, j].Text);


                                    s = s + m;
                                    buttonMatrix[i - 1, j].Text = s.ToString();
                                    buttonMatrix[i, j].Text = "";
                                    rez= Convert.ToInt32(Scor.Text) + Convert.ToInt32(buttonMatrix[i - 1, j].Text);
                                    Scor.Text = rez.ToString();
                                    mutare = true;
                                }

                            }
                        }

                    }
                    sus();

                    if(mutare==true)
                    nrnou();
                    break;
                case Keys.Right:
                    mutare = false;
                    dreapta();
                    gameover();
                    for (int i = 0; i <= n; i++)
                    {
                        for (int j = n - 1; j >= 0; j--)
                        {
                            if (buttonMatrix[i, j + 1].Text == buttonMatrix[i, j].Text)
                            {


                                if (buttonMatrix[i, j].Text != "")
                                {
                                    int s = Convert.ToInt32(buttonMatrix[i, j + 1].Text);
                                    int m = Convert.ToInt32(buttonMatrix[i, j].Text);


                                    s = s + m;
                                    buttonMatrix[i, j + 1].Text = s.ToString();
                                    buttonMatrix[i, j].Text = "";
                                    changecolor();
                                     rez = Convert.ToInt32(Scor.Text) + Convert.ToInt32(buttonMatrix[i , j+1].Text);
                                    Scor.Text = rez.ToString();
                                    mutare = true;
                                }

                            }
                        }
                    }
                    dreapta();
                    nrnou();
                    break;
                case Keys.Left:
                    mutare = false;
                    stanga();
                    gameover();
                    for (int i = 0; i <= n; i++)
                    {
                        for (int j = 1; j <= n; j++)
                        {


                            if (buttonMatrix[i, j - 1].Text == buttonMatrix[i, j].Text)
                            {
                                if (buttonMatrix[i, j].Text != "")
                                {
                                    int s = Convert.ToInt32(buttonMatrix[i, j - 1].Text);
                                    int m = Convert.ToInt32(buttonMatrix[i, j].Text);


                                    s = s + m;
                                    buttonMatrix[i, j - 1].Text = s.ToString();
                                    buttonMatrix[i, j].Text = "";
                                    changecolor();
                                     rez = Convert.ToInt32(Scor.Text) + Convert.ToInt32(buttonMatrix[i , j-1].Text);
                                    Scor.Text = rez.ToString();
                                    mutare = true;
                                }

                            }
                        }
                    }

                    stanga();
                    if(mutare==true)
                    nrnou();
                    
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void changecolor()
        {

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (buttonMatrix[i, j].Text == "")
                    {
                        buttonMatrix[i, j].BackColor = Color.White;
                    }
                    if (buttonMatrix[i, j].Text == "2")
                    {
                        buttonMatrix[i, j].BackColor = Color.LightYellow;
                    }
                    if (buttonMatrix[i, j].Text == "4")
                    {
                        buttonMatrix[i, j].BackColor = Color.PeachPuff;
                    }
                    if (buttonMatrix[i, j].Text == "8")
                    {
                        buttonMatrix[i, j].BackColor = Color.Bisque;
                    }
                    if (buttonMatrix[i, j].Text == "16")
                    {
                        buttonMatrix[i, j].BackColor = Color.BurlyWood;
                    }
                    if (buttonMatrix[i, j].Text == "32")
                    {
                        buttonMatrix[i, j].BackColor = Color.LightPink;
                    }
                    if (buttonMatrix[i, j].Text == "64")
                    {
                        buttonMatrix[i, j].BackColor = Color.RosyBrown;
                    }
                    if (buttonMatrix[i, j].Text == "128")
                    {
                        buttonMatrix[i, j].BackColor = Color.IndianRed;
                    }
                    if (buttonMatrix[i, j].Text == "256")
                    {
                        buttonMatrix[i, j].BackColor = Color.Plum;
                    }
                    if (buttonMatrix[i, j].Text == "512")
                    {
                        buttonMatrix[i, j].BackColor = Color.SandyBrown;
                    }
                }
            }

        }

     
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    buttonMatrix[i, j].Text = "";
                    buttonMatrix[i, j].BackColor = Color.White;
                }
            }
            gata.Hide();
            int s = Convert.ToInt32(Scor.Text);
            string value1 = File.ReadAllText(Path.GetFullPath("Highscore.txt"));
            if(s>Convert.ToInt32(value1))
            {
                File.WriteAllText(Path.GetFullPath("Highscore.txt"), String.Empty);
                File.WriteAllText(Path.GetFullPath("Highscore.txt"), s.ToString());
                Highscore.Text = s.ToString();
            }
            Scor.Text = "0";


            Random rnd = new Random();
            int x = rnd.Next(0, 3);
            int y = rnd.Next(0, 3);
            buttonMatrix[x, y].Text = "2";
            changecolor();
        }

        private void gata_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}