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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string bilgi;
        public static string bilgi2;

        private void Form2_Load(object sender, EventArgs e)
        {
            //Form1 form = new Form1();
            //textBox1.Text = Form1.bilgi;
            //label1.Text = Form1.bilgi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 form = new Form1();
            //if (textBox1.Text==Form1.bilgi)
            //{
            //    MessageBox.Show("oldu atıyoruz");
            //    Form3 form3 = new Form3();
            //    form3.Show();
            //}

            if (textBox3.Text==""&&textBox4.Text=="")
            {
                MessageBox.Show("istenen bilgileri girin");
            }
            else
            {
                MessageBox.Show("Kayit Olusturuldu");
                bilgi=textBox3.Text;
                bilgi2=textBox4.Text;
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }
    }
}
