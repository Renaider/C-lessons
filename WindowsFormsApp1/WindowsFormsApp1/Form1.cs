using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser.Url = new Uri("http://google.com");
            searchButton.Click += searchButton_Click;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void forwardButon_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(textBox1.Text);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://yandex.ru/");
        }

        private void form2Button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}