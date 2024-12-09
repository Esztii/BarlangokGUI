using System.Text;

namespace BarlangokGUI
{
    public partial class Form1 : Form
    {
        List<Barlangok> barlanglista = new List<Barlangok>();
        public void betoltes()
        {
            StreamReader sr = new("barlangok.txt", Encoding.UTF8);
            sr.ReadLine();
            while (!sr.EndOfStream) barlanglista.Add(new(sr.ReadLine()));


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            betoltes();
        }
        public Form1()
        {

            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt_barlang_keres_Click(object sender, EventArgs e)
        {
            if (tx_azon.Text.Length != 0)
            {
                int azonosito = Convert.ToInt32(tx_azon.Text);
                for (int i = 0; barlanglista.Count > 0; i++) 
                {
                    if (azonosito == barlanglista[i].Azon)
                    {
                        
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
