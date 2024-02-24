namespace SíkidomForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a, b, c, k, s, t;
        private void Calculate()
        { try  {
                textBoxA.Text = textBoxA.Text.Replace('.', ',');
                textBoxB.Text = textBoxB.Text.Replace('.', ',');
                textBoxC.Text = textBoxC.Text.Replace('.', ',');
                textBoxA.SelectionStart = textBoxA.Text.Length;
                textBoxA.SelectionLength = 0;
                textBoxB.SelectionStart = textBoxB.Text.Length;
                textBoxB.SelectionLength = 0;
                textBoxC.SelectionStart = textBoxC.Text.Length;
                textBoxC.SelectionLength = 0;

                // Oldalak ellenőrzése és beolvasása
                if (textBoxA.Text != string.Empty && textBoxB.Text != string.Empty)   {
                    a = Convert.ToDouble(textBoxA.Text);
                    b = Convert.ToDouble(textBoxB.Text);
                    c = Convert.ToDouble(textBoxC.Text);

                    if ((a + b) > c && (a + c) > b && (b + c) > a)
                    {
                        // Kerület kiszámolása
                         k = a + b + c;

                        // Terület kiszámolása
                         s = k / 2;
                         t = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                        // Eredmények megjelenítése a Label vezérlőkben
                        labelErr.Text = string.Empty;
                        labelK.Text = $"k = {k:F4} ";
                        labelT.Text = $"t = {t:F4}";
                    }  else  {
                        labelErr.Text = "A háromszög nem szerkeszthető.";
                    }  } }
            catch (Exception ex)
            {   labelErr.Text = $"Hiba történt: {ex.Message}";    }
        }
        private void textBoxA_TextChanged(object sender, EventArgs e)
        {  Calculate();  }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        { Calculate();  }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {  Calculate();  }
    }
}
