using System.Diagnostics;
namespace Converter

{
    /*
     TODO:
          Poprawić wygląd
          
     
    */
    public partial class Form1 : Form
    {
        private bool isHidden = false;

        public string ustawienia = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Documents\temperatura\ustawienia.txt");

        

        public Form1()
        {

            InitializeComponent();
            if (ustawienia.Contains("Schowany: false"))
            {
                checkBoxhide.Checked = false;
                this.label3.Visible = true;
               

            }
            else
            {
                checkBoxhide.Checked = true;
                this.label3.Visible = false;
            }
            var tekst = File.ReadAllText(@"C:\Users\"+ Environment.UserName+@"\Documents\temperatura\temeperatura.txt");
            if (new FileInfo(fileName: @"C:\Users\"+Environment.UserName+@"\Documents\temperatura\temeperatura.txt").Length == 0)
            {
                return;
            }
            this.label3.Text = "Ostatnie konwercje:" + "\n" + tekst;
           





        }

        private void convertbutton_Click(object sender, EventArgs e)
        {
            File.ReadAllText(@"C:\Users\"+ Environment.UserName+@"\Documents\temperatura\temeperatura.txt");
            var textboxcelc = textBoxCelc.Text;
            var textboxfahre = textBoxFahre.Text;
            var historia = label3.Text;
            

            try
            {
                if (this.textBoxCelc.ReadOnly == false)
                {
                    var converter = Convert.ToDouble(textboxcelc) *1.8 + 32;
                    var wiadomosc = textBoxFahre.Text = converter.ToString() + "F";
                    this.label3.Text += wiadomosc + " " + DateTime.Now.ToString("HH:mm:ss tt") + "\n";
                    Creator(wiadomosc, historia);
                }
                else
                {
                    var converter = (Convert.ToDouble(textboxfahre)- 32) * 5/9;
                    var wiadomosc = textBoxCelc.Text = converter.ToString() + "C";
                    this.label3.Text += wiadomosc + " " + DateTime.Now.ToString("HH:mm:ss tt") + "\n";
                    Creator(wiadomosc, historia);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd", "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var f1 = new FileStream(@"C:\Users\"+Environment.UserName+@"\Documents\temperatura\bledy.txt", FileMode.Append);
                using (StreamWriter sw = new StreamWriter(f1))
                {
                    sw.Write(ex + "\n");
                    sw.Close();
                }
            }








        }

        private void Creator(string wiadomosc, string historia)
        {
            try
            {
                var f1 = new FileStream(@"C:\Users\"+ Environment.UserName+@"\Documents\temperatura\temeperatura.txt", FileMode.Append);
                using (StreamWriter sw = new StreamWriter(f1))
                {
                    sw.Write(wiadomosc + " " + DateTime.Now.ToString("HH:mm:ss tt") +  "\n");
                    sw.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd", "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var f1 = new FileStream(@"C:\Users\"+ Environment.UserName+@"\Documents\temperatura\bledy.txt", FileMode.Append);
                using (StreamWriter sw = new StreamWriter(f1))
                {
                    sw.Write(ex + "\n");
                    sw.Close();
                }
            }

        }


        private void checkBoxhide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxhide.Checked)
            {
                this.label3.Visible = false;
                var zmianaReplace = ustawienia.Replace("Schowany: false", "Schowany: true");
                File.WriteAllText(@"C:\Users\"+ Environment.UserName+@"\Documents\temperatura\ustawienia.txt", zmianaReplace);




            }
            else
            {
                this.label3.Visible = true;
                var zmianaReplace = ustawienia.Replace("Schowany: true", "Schowany: false");
                File.WriteAllText(@"C:\Users\"+ Environment.UserName+@"\Documents\temperatura\ustawienia.txt", zmianaReplace);
                
            }
        }

        private void buttonzmiana_click(object sender, EventArgs e)
        {
            this.textBoxCelc.Text = "";
            this.textBoxFahre.Text = "";
            if (this.textBoxCelc.ReadOnly == false)
            {
               
                this.textBoxCelc.ReadOnly = true;
                this.textBoxFahre.ReadOnly = false;
                
            }
            else
            {
                this.textBoxCelc.ReadOnly = false;
                this.textBoxFahre.ReadOnly = true;
            }
        }

        private void textBoxFahre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", @"C:\Users\" + Environment.UserName + @"\Documents\temperatura\bledy.txt");
        }
    }
}