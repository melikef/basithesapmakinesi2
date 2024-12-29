namespace basithesapmakinesi2
{
    public partial class Form1 : Form
    {
        // Global deðiþkenler
        private double number1 = 0; // Ýlk sayý
        private double number2 = 0; // Ýkinci sayý (gerekirse)
        private string operation = ""; // Seçilen iþlem (+, -, *, /)

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Mevcut MaskedTextBox'a "5" ekle
            maskedTextBox1.Text += "5";

            // Ýmleci sona taþýmak için
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
            // Ýlk sayýyý sakla
            if (double.TryParse(maskedTextBox1.Text, out number1))
            {
                operation = "*"; // Ýþlemi belirle
                maskedTextBox1.Clear(); // Girdi alanýný temizle
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayý girin.");
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
                MessageBox.Show("Lütfen geçerli bir sayý girin.");
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
                MessageBox.Show("Lütfen geçerli bir sayý girin.");
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
                MessageBox.Show("Lütfen geçerli bir sayý girin.");
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
                            MessageBox.Show("Sýfýra bölme hatasý!");
                            return; // Hata mesajýndan sonra iþlemi sonlandýr
                        }
                        break;
                }

                maskedTextBox1.Text = result.ToString(); // Sonucu göster
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayý girin.");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // MaskedTextBox'ý temizle
            maskedTextBox1.Clear();

            // Global deðiþkenleri sýfýrla
            number1 = 0;
            number2 = 0;
            operation = "";

            // Kullanýcýya bir iþlem durumu belirtmek için isteðe baðlý olarak bir mesaj yazabilirsiniz
            MessageBox.Show("Hesap makinesi sýfýrlandý.");
        }
    }
}



