using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void metot1()
        {
            label1.Text = "18 Ağustos 2021";
            label2.Text = "Sıcak Bir Yaz Günü";
            label3.Text = "Peynir,Karpuz,Su";
            label4.Text = "Beşiktaş-Etiler";

        }
        void metot2()
        {
            label1.BackColor = Color.OrangeRed;
            label2.BackColor = Color.BlueViolet;
            label3.BackColor = Color.Yellow;
            label4.BackColor = Color.Red;
            
        }
        void metot3()
        {
            label1.ForeColor = Color.Navy;
            label2.ForeColor = Color.Red;
            label3.ForeColor = Color.Green;
            label4.ForeColor = Color.Beige;
            MessageBox.Show("HELLO THERE");
        }
            
        private void button1_Click(object sender, EventArgs e)


        {
            metot1();
            metot2();
            metot3();
        }
    }
}
