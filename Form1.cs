using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, sonuc;
            s1 = 0;
            s2 = 0;
            try
            {
                s1 = int.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            try
            {
                s2 = int.Parse(textBox2.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ikinci textbox a doğru bir değer giriniz"+ex.ToString());
            }          

            sonuc = s1 + s2;

            MessageBox.Show(sonuc.ToString());
        }
    }
}
