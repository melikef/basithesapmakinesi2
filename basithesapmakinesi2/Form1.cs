namespace basithesapmakinesi2
{
    public partial class Form1 : Form
    {
        // Global de�i�kenler
        private double number1 = 0; // �lk say�
        private double number2 = 0; // �kinci say� (gerekirse)
        private string operation = ""; // Se�ilen i�lem (+, -, *, /)

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Mevcut MaskedTextBox'a "5" ekle
            maskedTextBox1.Text += "5";

            // �mleci sona ta��mak i�in
            maskedTextBox1.SelectionStart = maskedTextBox1.Text.Length;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "0";

            maskedTextBox1.SelectionStart = maskedTextBox1.Text.Length;
        }

        private void button8_Click(object sender, EventArgs e)
        {           
            maskedTextBox1.Text += "8";
            
            maskedTextBox1.SelectionStart = maskedTextBox1.Text.Length;
        }


        private void button1_Click(object sender, EventArgs e)
        {            
            maskedTextBox1.Text += "1";
           
            maskedTextBox1.SelectionStart = maskedTextBox1.Text.Length;
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            maskedTextBox1.Text += "2";
           
            maskedTextBox1.SelectionStart = maskedTextBox1.Text.Length;
        }

        private void button3_Click(object sender, EventArgs e)
        {           
            maskedTextBox1.Text += "3";
           
            maskedTextBox1.SelectionStart = maskedTextBox1.Text.Length;
        }

        private void button4_Click(object sender, EventArgs e)
        {            
            maskedTextBox1.Text += "4";
            
            maskedTextBox1.SelectionStart = maskedTextBox1.Text.Length;
        }

        private void button6_Click(object sender, EventArgs e)
        {            
            maskedTextBox1.Text += "6";
            
            maskedTextBox1.SelectionStart = maskedTextBox1.Text.Length;
        }

        private void button7_Click(object sender, EventArgs e)
        {           
            maskedTextBox1.Text += "7";
            
            maskedTextBox1.SelectionStart = maskedTextBox1.Text.Length;
        }

        private void button9_Click(object sender, EventArgs e)
        {            
            maskedTextBox1.Text += "8";
            
            maskedTextBox1.SelectionStart = maskedTextBox1.Text.Length;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            // �lk say�y� sakla
            if (double.TryParse(maskedTextBox1.Text, out number1))
            {
                operation = "*"; // ��lemi belirle
                maskedTextBox1.Clear(); // Girdi alan�n� temizle
            }
            else
            {
                MessageBox.Show("L�tfen ge�erli bir say� girin.");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (double.TryParse(maskedTextBox1.Text, out number1))
            {
                operation = "/"; 
                maskedTextBox1.Clear(); 
            }
            else
            {
                MessageBox.Show("L�tfen ge�erli bir say� girin.");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (double.TryParse(maskedTextBox1.Text, out number1))
            {
                operation = "-"; 
                maskedTextBox1.Clear(); 
            }
            else
            {
                MessageBox.Show("L�tfen ge�erli bir say� girin.");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (double.TryParse(maskedTextBox1.Text, out number1))
            {
                operation = "+"; 
                maskedTextBox1.Clear(); 
            }
            else
            {
                MessageBox.Show("L�tfen ge�erli bir say� girin.");
            }
        }


        private void button16_Click(object sender, EventArgs e)
        {
            if (double.TryParse(maskedTextBox1.Text, out number2))
            {
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        if (number2 != 0)
                        {
                            result = number1 / number2;
                        }
                        else
                        {
                            MessageBox.Show("S�f�ra b�lme hatas�!");
                            return; // Hata mesaj�ndan sonra i�lemi sonland�r
                        }
                        break;
                }

                maskedTextBox1.Text = result.ToString(); // Sonucu g�ster
            }
            else
            {
                MessageBox.Show("L�tfen ge�erli bir say� girin.");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // MaskedTextBox'� temizle
            maskedTextBox1.Clear();

            // Global de�i�kenleri s�f�rla
            number1 = 0;
            number2 = 0;
            operation = "";

            // Kullan�c�ya bir i�lem durumu belirtmek i�in iste�e ba�l� olarak bir mesaj yazabilirsiniz
            MessageBox.Show("Hesap makinesi s�f�rland�.");
        }
    }
}



