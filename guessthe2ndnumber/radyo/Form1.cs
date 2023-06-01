namespace radyo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            MessageBox.Show("Yapýlan Ýþleme ve Sonuca Göre 2. Sayýyý Tahmin Edin!");

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label6.Text = "Toplama";
            double sonuc;

            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            sonuc = a + b;
            label4.Text = Convert.ToString(sonuc);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label6.Text = "Çarpma";
            double sonuc;
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            sonuc = a * b;
            label4.Text = Convert.ToString(sonuc);
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label6.Text = "Çýkarma";
            double sonuc;
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            sonuc = a - b;
            label4.Text = Convert.ToString(sonuc);
                  
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label6.Text = "Bölme";
            double sonuc;
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            sonuc = a / b;
            label4.Text = Convert.ToString(sonuc);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (label6.Text == "Toplama")
            {
                double a = Convert.ToDouble(textBox1.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double sonuc = Convert.ToDouble(label4.Text);
                if (sonuc - a == c)
                {
                    MessageBox.Show("Doðru");

                }
                else
                {
                    MessageBox.Show("Yanlýþ");
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else if (label6.Text == "Çýkarma")
            {
                double a = Convert.ToDouble(textBox1.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double sonuc = Convert.ToDouble(label4.Text);
                if (sonuc - a == c || sonuc - a == -c)
                {
                    MessageBox.Show("Doðru");

                }
                else
                {
                    MessageBox.Show("Yanlýþ");
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else if (label6.Text == "Bölme")
            {
                double a = Convert.ToDouble(textBox1.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double sonuc = Convert.ToDouble(label4.Text);
                if (sonuc *c == a)
                {
                    MessageBox.Show("Doðru");

                }
                else
                {
                    MessageBox.Show("Yanlýþ");
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else if (label6.Text == "Çarpma")
            {
                double a = Convert.ToDouble(textBox1.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double sonuc = Convert.ToDouble(label4.Text);
                if (sonuc / c == a)
                {
                    MessageBox.Show("Doðru");

                }
                else
                {
                    MessageBox.Show("Yanlýþ");
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }
    }
}
