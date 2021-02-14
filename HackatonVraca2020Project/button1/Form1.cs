using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button1
{
    public partial class Form1 : Form
    {
        int index = 0;

        int x = 0;
        int buttonChange = 0;
        List<String> mylist = new List<String> { "Пиеш ли алкохол?", "Ядеш ли вредна храна?", "Спазваш ли елементарна хигиена?", "Физически активен ли си?", "Имаш ли кашлица или болки в гърлото?", "Имаш ли болки в гърдите?", "Чувстваш ли се отпаднал?", "Правилен ли е ражимът ти на сън?", "Пиеш ли много вода на ден?" };
        public Form1()
        {
            InitializeComponent();
        }

    
      
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void button9_Click(object sender, EventArgs e)
        {
            if (index == 3 || index == 4 || index == 8 || index == 9)
            {
                x--;
                ChangeQ();
                lblX.Text = "" + x;
                return;
            }
            
            buttonChange++;
            x = x + 1;
            lblX.Text = "" + x;
            ChangeQ();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblX_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (index == 3 || index == 4 || index == 8 || index == 9)
            {
                x++;
                ChangeQ();
                lblX.Text = "" + x;
                return;
            }
            ChangeQ();

        }
        private void ChangeQ()
        {
            if (index == mylist.Count)
            {
                

                textBox1.Text = "Поздравления тестът приключи и имаш " + x + " точки";
                buuton.Enabled = false;
                button2.Enabled = false;
                return;
            }

            textBox1.Text = mylist.ElementAt(index);
            index++;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            lblPoints.Text = "Добре си, но бъди бдителен и ако имаш дори един от тези симптоми посъветвай се с лекар!";
            if (super.Checked == true)
            {
                biva.Enabled = false;
                zle.Enabled = false;
            }
            else if (biva.Checked == true)
            {
                super.Enabled = false;
                zle.Enabled = false;
            }
            else if (zle.Checked == true)
            {
                super.Enabled = false;
                biva.Enabled = false;
            }
            
            else if (super.Checked == false)
            {
                lblPoints.Text = " ";
                biva.Enabled = true;
                zle.Enabled = true;
            }
            else if (biva.Checked == false)
            {
                lblPoints.Text = " ";
                super.Enabled = true;
                zle.Enabled = true;
            }
            else if (zle.Checked == false)
            {
                lblPoints.Text = " ";
                super.Enabled = true;
                biva.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            lblPoints.Text = "Пази се повече, бъди внимателен и се храни по-здравословно! И ако имаш дори един от тези симптоми посъветвай се с лекар!";
            if (super.Checked == true)
            {
                biva.Enabled = false;
                zle.Enabled = false;
            }
            else if (biva.Checked == true)
            {
                super.Enabled = false;
                zle.Enabled = false;
            }
            else if (zle.Checked == true)
            {
                super.Enabled = false;
                biva.Enabled = false;
            }

            else if (super.Checked == false)
            {
                lblPoints.Text = " ";
                super.Enabled = true;
                biva.Enabled = true;
                zle.Enabled = true;
            }
            else if (biva.Checked == false)
            {
                lblPoints.Text = " ";
                super.Enabled = true;
                zle.Enabled = true;
            }
            else if (zle.Checked == false)
            {
                lblPoints.Text = " ";
                super.Enabled = true;
                biva.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            lblPoints.Text = "Въобще не е добре! Потърси лекарска помощ ВЕДНАГА!";
            if (super.Checked == true)
            {
                biva.Enabled = false;
                zle.Enabled = false;
            }
            else if (biva.Checked == true)
            {
                super.Enabled = false;
                zle.Enabled = false;
            }
            else if (zle.Checked == true)
            {
                super.Enabled = false;
                biva.Enabled = false;

            }
            
           else if (super.Checked == false)
            {
                lblPoints.Text = " ";
                super.Enabled = true;
                biva.Enabled = true;
                zle.Enabled = true;
            }
            else if (biva.Checked == false)
            {
                lblPoints.Text = " ";
                super.Enabled = true;
                zle.Enabled = true;
            }
            else if (zle.Checked == false)
            {
                lblPoints.Text = " ";
                super.Enabled = true;
                biva.Enabled = true;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
