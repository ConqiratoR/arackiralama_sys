namespace ArabaKiralama
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAra�Listele listele = new frmAra�Listele();
            listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAra�Kay�t kay�t = new frmAra�Kay�t();
            kay�t.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmM��teriEkle ekle = new frmM��teriEkle();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmM��teriListele listele = new frmM��teriListele();
            listele.ShowDialog();
        }
    }
}