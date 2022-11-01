using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginUygulaması2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public static string bilgi;

        private void button1_Click(object sender, EventArgs e)
        {
            //bilgi = textBox1.Text;
            Form2 form = new Form2();
            //form.Show();
            
            if (textBox1.Text==""&&textBox2.Text=="")
            {
                MessageBox.Show("istenen bilgileri girin");
            }
            if (Form2.bilgi == textBox1.Text && Form2.bilgi2==textBox2.Text) 
            {
                MessageBox.Show("ACCES");
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("yanlıs bılgı girdiniz...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
