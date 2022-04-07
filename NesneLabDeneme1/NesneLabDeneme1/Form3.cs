﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace NesneLabDeneme1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument xdosya = XDocument.Load("kayıtlar.xml");
            XElement rootelement = xdosya.Root;

            XElement element = new XElement("uye");

            XElement username = new XElement("username", textBox1.Text);
            XElement password = new XElement("password", textBox2.Text);
            XElement phone = new XElement("phone", textBox3.Text);
            XElement city = new XElement("city", textBox4.Text);
            XElement adress = new XElement("adress", textBox5.Text);
            XElement e_mail = new XElement("e-mail", textBox6.Text);
            XElement country = new XElement("country", textBox7.Text);
            XElement name_surname = new XElement("name-surname", textBox7.Text);

            element.Add(username, password, phone, city, adress, e_mail, country, name_surname);
            rootelement.Add(element);

            xdosya.Save("kayıtlar.xml");

            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
