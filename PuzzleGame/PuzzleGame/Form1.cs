using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class GameScreen : Form
    {
        Random r = new Random();
        
        int k=0,aa,bb;
      
        public int t1()
        {
           return  aa = r.Next(0, 650);
           
 
        }
        public int t2()
        {
           
            return bb = r.Next(0, 440);

        }
        public void hd()
        {
            if (a1 == true)
            {
                button1.Image = null;
                a1 = false;
            }
            if (a2 == true)
            {
                button2.Image = null;
                a2 = false;
            }
            if (a3 == true)
            {
                button3.Image = null;
                a3= false;
            }
            if (a4 == true)
            {
                button4.Image = null;
                a4 = false;
            }
            if (a5 == true)
            {
                button5.Image = null;
                 a5 = false;
            }
            if (a6 == true)
            {
                button6.Image = null;
                a6 = false;
            }
            if (a7 == true)
            {
                button7.Image = null;
                a7 = false;
            }
            if (a8 == true)
            {
                button8.Image = null;
                a8 = false;
            }
            if (a9 == true)
            {
                button9.Image = null;
                a9 = false;
            }
            if (a10 == true)
            {
                button10.Image = null;
                a10 = false;
            }
        }
        bool a1 = false,a2=false, a3 = false,a4 = false,a5=false,a6=false,a7=false,a8=false,a9=false,a10=false;
        public void clo()
        {
            if(k==5)
         {
            StartScreen s=new  StartScreen ();
            this.Hide();
            s.Show();
          
         }
     
        }
        public void resa()
        {

            button1.Location = new Point( t1(), t2());
            button2.Location = new Point(t1(), t2());
            button3.Location = new Point(t1(), t2());
            button4.Location = new Point(t1(), t2());
            button5.Location = new Point(t1(), t2());
            button6.Location = new Point(t1(), t2());
            button7.Location = new Point(t1(), t2());
            button8.Location = new Point(t1(), t2());
            button9.Location = new Point(t1(), t2());
            button10.Location = new Point(t1(), t2());
        }
        
        
        public GameScreen()
        {
            InitializeComponent();
            resa();
                       
          }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (a1 == false && a3 == false)
            
            {
               
                    button1.Image = Properties.Resources.Bat;
                    a1 = true;
               
               

                
            }
            if(a3==true && a1==false)
            { 
                button1.Image = button3.Image;
                MessageBox.Show("MATCHED !!!");
                button3.Hide();
                button1.Hide();
               
                k++;
                a3 = false;
                a1 = false;
                clo();
            }
            if (a10 == true || a4 == true || a6 == true || a8 == true  || a7 == true || a9 == true||a2==true||a5==true)
            {
                button1.Image = null;
                hd();
                a1 = false;
              
            }
                       
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (a3 == false && a1 == false)
            {
                
                    button3.Image = Properties.Resources.Bat;
                    a3 = true;                                             
               
            }
            if (a1 == true && a3 == false)
            {
                button3.Image = button1.Image;
               
                button3.Hide();
                button1.Hide();
                MessageBox.Show("MATCHED !!!");
                k++;
                a3 = false;
                a1 = false;
                clo();
                
            }
            if (a10 == true || a4 == true || a6 == true || a8 == true || a7 == true || a9 == true || a2 == true || a5 == true)
            {
                button3.Image = null;
                hd();
                a3 = false;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (a2 == false && a5 == false)
            {
               
                    button2.Image = Properties.Resources.Creed;
                    a2 = true;               
            }
            if (a5 == true && a2 == false)
            {

                button2.Image = button5.Image;
                MessageBox.Show("MATCHED !!!");
                button2.Hide();
                button5.Hide();
                a5 = false;
                a2 = false;

                k++;
                clo();
            }
            if (a10 == true || a3 == true || a4 == true || a6 == true || a8 == true || a1 == true || a7 == true || a9 == true)
            {
                button2.Image = null;
                hd();
                a2 = false;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (a9 == false && a7 == false)
            {
               
                    button9.Image = Properties.Resources.Gebon;
                    a9 = true;              
            }
            if (a7 == true && a9 == false)
            {

                button9.Image = button7.Image;
                MessageBox.Show("MATCHED !!!");
                button9.Hide();
                button7.Hide();
                a9 = false;
                a7 = false;
                k++;
                clo();
            }
            if (a10 == true || a3 == true || a4 == true || a6 == true || a8 == true || a1 == true || a2==true||a3==true||a5==true)
            {
                button9.Image = null;
                hd();
                a9 = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (a2 == false && a5 == false)
            {
                
                    button5.Image = Properties.Resources.Creed;
                    a5 = true;              
            }
            if (a2 == true && a5 == false)
            {

                button5.Image = button2.Image;
                MessageBox.Show("MATCHED !!!");
                button2.Hide();
                button5.Hide();
                a2 = false;
                a5 = false;
                k++;
                clo();
            }
             if(a10==true||a3==true||a4==true||a6==true||a8==true||a1==true||a7==true||a9==true)
            {
                button5.Image = null;
                hd();
                a5 = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (a9 == false && a7 == false)
            {
               
                    button7.Image = Properties.Resources.Gebon;
                    a7 = true;
               
            }
            if (a7 == false && a9 == true)
            {

                button7.Image = button9.Image;
                MessageBox.Show("MATCHED !!!");
                button9.Hide();
                button7.Hide();
                a9 = false;
                a7 = false;
                k++;
                clo();
            }
            if(a1==true||a2==true||a3==true||a4==true||a5==true||a6==true||a8==true||a10==true)
            {
                button7.Image=null;
                hd();
                a7 = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (a4 == false && a8 == false)
            {
                
                    button4.Image = Properties.Resources.Fma;
                    a4 = true;
            }
            if (a4 == false && a8 == true)
            {

                button4.Image = button8.Image;
                MessageBox.Show("MATCHED !!!");
                button4.Hide();
                button8.Hide();
                a4 = false;
                a8 = false;
                k++;
                clo();
            }
            if (a1 == true || a2 == true || a3 == true ||  a5 == true || a6 == true ||a7==true ||a9==true|| a10 == true)
            {
                button4.Image = null;
                hd();
                a4 = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (a4 == false && a8 == false)
            {         
                    button8.Image = Properties.Resources.Fma;
                    a8 = true;

            }
            if (a8 == false && a4 == true)
            {

                button8.Image = button4.Image;
                MessageBox.Show("MATCHED !!!");
                button4.Hide();
                button8.Hide();
                a4 = false;
                a8 = false;
                k++;
                clo();
            }
            if (a1 == true || a2 == true || a3 == true || a5 == true || a6 == true || a7 == true || a9 == true || a10 == true)
            {
                button8.Image = null;
                hd();
                a8 = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (a6 == false && a10 == false)
            {

                    button6.Image = Properties.Resources.Iron;
                    a6 = true;

            }
            if (a6 == false && a10 == true)
            {

                button6.Image = button10.Image;
                MessageBox.Show("MATCHED !!!");
                button6.Hide();
                button10.Hide();
                k++;
            }
            if (a1 == true || a2 == true || a3 == true || a5 == true ||  a7 == true ||a8==true|| a9 == true ||a4==true)
            {
                button6.Image = null;
                hd();
                a6 = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (a6 == false && a10 == false)
            {

                    button10.Image = Properties.Resources.Iron;
                    a10 = true;

            }
            if (a10 == false && a6 == true)
            {

                button10.Image = button6.Image;
                MessageBox.Show("MATCHED !!!");
                button6.Hide();
                button10.Hide();
                a10 = false;
                a6 = false;
                k++;
                clo();
            }
            if (a1 == true || a2 == true || a3 == true || a5 == true || a7 == true || a8 == true || a9 == true || a4 == true)
            {
                button10.Image = null;
                hd();
                a10 = false;
            }
        }         
    }
}
