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

namespace ucaklar02
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        bool ates = false;
        bool ates1 = false;
        bool ates2 = false;
      
        int mermiHiz = 20;
        int mermiHiz1 = 15;
        int mermiHiz2 = 15;
    
        int ucakHiz = 8;
        int ucakHiz2 = 8;


        int can = 10;
        int sure = 0;
        int puan = 0;
        public Form1()
        {
            InitializeComponent();
            baslama();

        }

        private void baslama()
        {
            ucak1.Top = -(random.Next(1, 200));
            ucak1.Left=random.Next(1, 600);
            mermi1.Top = ucak1.Top + 40;
            mermi1.Left = ucak1.Left + 25;
            ucak2.Top = -(random.Next(1, 200));
            ucak2.Left = random.Next(1, 600);
            mermi2.Top = ucak2.Top + 40;
            mermi2.Left = ucak2.Left + 25;
            sure = 0;
            puan = 0;
            can = 10;

        }
        
        private void OyunSonu()
        {
            timer1.Enabled = false;
            MessageBox.Show(puan + " Puan Kazandınız.", "OYUN SONU", MessageBoxButtons.OK, MessageBoxIcon.Stop);
           
           
            baslama();
        }

        private void atesleme1()
        {
            if (ates1 == false)
            {
                mermi1.Visible = true;
                mermiHiz1 = 12;
                mermi1.Left = ucak1.Left + 25;
                mermi1.Top = ucak1.Top + 40; 
            }
        }
        private void atesleme2()
        {
            if (ates2 == false)
            {
                mermi2.Visible = true;
                mermiHiz2 = 12;
                mermi2.Left = ucak2.Left + 25;
                mermi2.Top = ucak2.Top + 40;
            }
        }

        private void vurma()
        {
            if (mermi.Bounds.IntersectsWith(ucak1.Bounds))
            {
                puan += 1;
                lbPuan.Text = puan.ToString();
                ucak1.Top = -50;
                int ranP = random.Next(1, 300);
                ucak1.Left = ranP;
                ates = false;
                mermiHiz = 0;
                mermi.Top = ucak.Top+40;
                mermi.Left = ucak.Left+25;
            }
            if (mermi.Bounds.IntersectsWith(ucak2.Bounds))
            {
                puan += 1;
                lbPuan.Text = puan.ToString();
                ucak2.Top = -50;
                int ranP = random.Next(1, 300);
                ucak2.Left = ranP;
                ates = false;
                mermiHiz = 0;
                mermi.Top = ucak.Top + 40;
                mermi.Left = ucak.Left + 25;
            }
        }
        private void vurulma()
        {
            if (mermi1.Bounds.IntersectsWith(ucak.Bounds))
            {
                can -= 1;
                lbCan.Text = can.ToString();
                if (can == 0) { OyunSonu(); }
                ucak.Left = random.Next(1, 500);          
            }
            else if (mermi2.Bounds.IntersectsWith(ucak.Bounds))
            {
                can -= 1;
                lbCan.Text = can.ToString();
                if (can == 0) { OyunSonu(); }
                ucak.Left = random.Next(1, 500);       
            }
            else if (ucak1.Bounds.IntersectsWith(ucak.Bounds))
            {
                can -= 1;
                lbCan.Text = can.ToString();
                puan += 1;
                lbPuan.Text = puan.ToString();
                if (can == 0) { OyunSonu(); }
                ucak.Left = random.Next(1, 500);
                ucak1.Top = -50;
                int ranP = random.Next(1, 300);
                ucak1.Left = ranP;
            }
            else if (ucak2.Bounds.IntersectsWith(ucak.Bounds))
            {
                can -= 1;
                lbCan.Text = can.ToString();
                puan += 1;
                lbPuan.Text = puan.ToString();
                if (can == 0) { OyunSonu(); }
                ucak.Left = random.Next(1, 500);
                ucak2.Top = -50;
                int ranP = random.Next(1, 300);
                ucak2.Left = ranP;
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) { timer1.Start(); }
            int x=ucak.Location.X;
            int y=ucak.Location.Y;
            if (e.KeyCode==Keys.Left && x > 0) { x=x-20;}//sol ok a basıldığında sola doğru 20 piksel git
            if (e.KeyCode == Keys.Right && x <600) { x = x + 20; }//sağ ok a basıldığında sağa doğru 20 piksel git
            ucak.Location=new Point(x, y); // uçak yeni lokasyonu tanımlanıyor
            if (e.KeyCode == Keys.Space) //ana uçak ateş olayları
            {
                if (ates == false)
                {
                    mermi.Visible = true;
                    mermiHiz = 12;
                    mermi.Left = ucak.Left + 25;
                    mermi.Top = ucak.Top-40;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Width = 700;//formun genişliği
            this.Height = 700; //formun yüksekliği
            mermi.Visible = false;
            puan = 0;
            lbPuan.Text = puan.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure += 1;
            lbSure.Text=sure.ToString();

            //ana uçak ateş 
            mermi.Top -= mermiHiz;
           
            if (ates && mermi.Top < 0)
            {
                ates = false;
                mermiHiz = 0;
                mermi.Top = ucak.Left + 25;
                mermi.Left = ucak.Top + 40;

            }
            
            //ucaklar hareket
            ucak1.Top += ucakHiz;
            if (ucak1.Top >= 600)
            {
                ucakHiz = 0;
                can -= 1;
                lbCan.Text = can.ToString();
                if (can == 0) { OyunSonu(); }
                //uçak1 yeniden baştan konumlandırılıyor
                ucak1.Top = -(random.Next(1, 500));
                ucak1.Left = random.Next(1, 600);
                ucakHiz = 8;
            }
            ucak2.Top += ucakHiz;
            if (ucak2.Top >= 600)
            {
                ucakHiz2 = 0;
                can -= 1;
                lbCan.Text = can.ToString();
                if (can == 0) { OyunSonu(); }
                //uçak2 yeniden baştan konumlandırılıyor
                ucak2.Top = -(random.Next(1, 500));
                ucak2.Left = random.Next(1, 600);
                ucakHiz2 = 8;
            }

            //ucak1ardan ateş
            int atesSure1=
            mermi1.Top += mermiHiz1;
            if (sure % random.Next(80, 200) == 0) { atesleme1(); vurulma(); }
            mermi2.Top += mermiHiz2;
            if (sure % random.Next(60, 200) == 0) { atesleme2(); vurulma(); }

            vurma();
            vurulma();
        }
    }
}
