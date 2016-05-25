using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPokémonWannabe
{
    public partial class Form1 : Form
    {
        Pokemon1 Pikaboo;
        Pokemon1 Enemy;
        Boolean p1atk = false;
        Boolean p1pry = false;
        Boolean p1grb = false;
        Boolean p2atk = false;
        Boolean p2pry = false;
        Boolean p2grb = false;
        Boolean won = false;




        public Form1()
        {
            InitializeComponent();
            
            }

        private void Form1_Load(object sender, EventArgs e)
        {

            listBox1.Items.Add("Pikaboo");
            listBox1.Items.Add("Panmander");
            listBox1.Items.Add("Sugarfree");
            Victory.Visible = false;



            Pikaboo = new Pokemon1();
            Pikaboo.namn = "Pikaboo";
            Pikaboo.hitPoints = 10;
            Pikaboo.level = 1;
            Pikaboo.styrka = 1;
            Pikaboo.speed = 50;


            label2.Text = "" + Pikaboo.hitPoints;
            name.Text = "" + Pikaboo.namn;
            lvl.Text = "" + Pikaboo.level;
            speed.Text = "" + Pikaboo.speed;
            styrka.Text = "" + Pikaboo.styrka;

            Enemy = new Pokemon1();
            Enemy.namn = "Enemy name";
            Enemy.hitPoints = 10;
            Enemy.level = 1;
            Enemy.speed = 45;
            Enemy.styrka = 1;



            label6.Text = "" + Enemy.namn;
            label7.Text = "" + Enemy.hitPoints;

        }
        
        private void Endenable()
        {
            if (checkBox1.Checked == true & checkBox2.Checked == true)
            {
                endturn.Enabled = true;
            }
            else if(checkBox1.Checked == false || checkBox2.Checked == false)
            {
                endturn.Enabled = false;
            }
        }
        private void Win()
        {
            
            if (Enemy.hitPoints == 0 || Enemy.hitPoints < 0)
            {
                Victory.Text = "Player 1 wins,";
                Restartlbl.Text = "press End turn to restart the game";
                Victory.Visible = true;
                Restartlbl.Visible = true;

                button1.Enabled = false;
                grabp1.Enabled = false;
                Parryp1.Enabled = false;

                attack2.Enabled = false;
                parryp2.Enabled = false;
                grabp2.Enabled = false;
                won = true;
                endturn.Enabled = true;

            }

            else if (Pikaboo.hitPoints == 0 || Pikaboo.hitPoints < 0)
            {
                Victory.Text = "player 2 wins,";
                Restartlbl.Text = "press End turn to restart the game";
                Victory.Visible = true;
                Restartlbl.Visible = true;
                endturn.Enabled = true;
                button1.Enabled = false;
            }
        }



private void button1_Click(object sender, EventArgs e)
        {
            if (p1atk == true)
            {
                p1atk = false;
                checkBox1.Checked = false;
            }
            else
            {
                p1atk = true;
                checkBox1.Checked = true;
                
            }
            Endenable();
        }

        private void attack2_Click(object sender, EventArgs e)
        {
            if (p2atk == true)
            {
                p2atk = false;
                checkBox2.Checked = false;

            }
            else
            {
                p2atk = true;
                p2pry = false;
                p2grb = false;
                checkBox2.Checked = true;
                
            }
            Endenable();
        }

        private void endturn_Click(object sender, EventArgs e)
        {
            if (won == true)
            {
                button1.Enabled = true;
                grabp1.Enabled = true;
                Parryp1.Enabled = true;

                attack2.Enabled = true;
                parryp2.Enabled = true;
                grabp2.Enabled = true;
                endturn.Enabled = false;
                won = false;
                Enemy.hitPoints = 10;
                Pikaboo.hitPoints = 10;
                label7.Text = "" + Enemy.hitPoints;
                label2.Text = "" + Pikaboo.hitPoints;
                Victory.Visible = false;
                Restartlbl.Visible = false;
            }
            if (p1atk == true &p2pry !=true)
            {
                int enemydmg = Enemy.styrka;
                int enemyhp = Enemy.hitPoints;
                int pikaboohp = Pikaboo.hitPoints;
                int pikaboodmg = Pikaboo.styrka;
            
                Enemy.hitPoints = enemyhp - pikaboodmg;
                label7.Text = "" + Enemy.hitPoints;
            }



            
            if (p1pry == true & p2grb != true)
            {
                int enemydmg = Enemy.styrka;
                int enemyhp = Enemy.hitPoints;
                int pikaboohp = Pikaboo.hitPoints;
                int pikaboodmg = Pikaboo.styrka;

                Enemy.hitPoints = enemyhp - pikaboodmg;
                label7.Text = "" + Enemy.hitPoints;
            }
            if(p1grb==true & p2atk != true)
            {
                int enemydmg = Enemy.styrka;
                int enemyhp = Enemy.hitPoints;
                int pikaboohp = Pikaboo.hitPoints;
                int pikaboodmg = Pikaboo.styrka;

                Enemy.hitPoints = enemyhp - pikaboodmg;
                label7.Text = "" + Enemy.hitPoints;
            }
            //p2
            if (p2atk == true & p1pry != true)
            {
                
                int enemydmg = Enemy.styrka;
                int enemyhp = Enemy.hitPoints;
                int pikaboohp = Pikaboo.hitPoints;
                int pikaboodmg = Pikaboo.styrka;

                Pikaboo.hitPoints = pikaboohp - enemydmg;
                label2.Text = "" + Pikaboo.hitPoints;
            }
            if (p2grb == true & p1atk != true)
            {

                int enemydmg = Enemy.styrka;
                int enemyhp = Enemy.hitPoints;
                int pikaboohp = Pikaboo.hitPoints;
                int pikaboodmg = Pikaboo.styrka;

                Pikaboo.hitPoints = pikaboohp - enemydmg;
                label2.Text = "" + Pikaboo.hitPoints;
            }
            if (p2pry == true & p1grb != true)
            {

                int enemydmg = Enemy.styrka;
                int enemyhp = Enemy.hitPoints;
                int pikaboohp = Pikaboo.hitPoints;
                int pikaboodmg = Pikaboo.styrka;

                Pikaboo.hitPoints = pikaboohp - enemydmg;
                label2.Text = "" + Pikaboo.hitPoints;
            }
            //reset
            p1atk = false;
            p1pry = false;
            p1grb = false;
            p2atk=false;
            p2grb = false;
            p2pry = false;
            endturn.Enabled = false;

            checkBox1.Checked = false;
            checkBox2.Checked = false;

            Win();
        }

        private void Parryp1_Click(object sender, EventArgs e)
        {
            if (p1pry == true)
            {
                p1pry = false;
                checkBox1.Checked = false;
            }
            else
            {
                p1pry = true;
                p1atk = false;
                p1grb = false;
                checkBox1.Checked = true;
                
            }
            Endenable();
        }

        private void grabp1_Click(object sender, EventArgs e)
        {
            if (p1grb == true)
            {
                p1grb = false;
                checkBox1.Checked = false;
            }
            else 
            {
                p1pry = false;
                p1atk = false;
                p1grb = true;
                checkBox1.Checked = true;
                
            }
            Endenable();
        }

        private void grabp2_Click(object sender, EventArgs e)
        {
            if (p2grb == true)
            {
                p2grb = false;
                checkBox2.Checked = false;
            }
            else
            {
                p2pry = false;
                p2atk = false;
                p2grb = true;
                checkBox2.Checked = true;
                
            }
            Endenable();
        }

        private void parryp2_Click(object sender, EventArgs e)
        {
            if (p2pry == true)
            {
                p2pry = false;
                checkBox2.Checked = false;
            }
            else
            {
                p2pry = true;
                p2atk = false;
                p2grb = false;
                checkBox2.Checked = true;
              
            }
            Endenable();
        }
    }
}
