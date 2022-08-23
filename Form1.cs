namespace CreditCardSampleProject_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuBankamatik_Click(object sender, EventArgs e)
        {
            BankamatikKarti bankamatik = new BankamatikKarti();
            bankamatik.Bakiye = 9000;
        }

        private void mnuKKPlatin_Click(object sender, EventArgs e)
        {
            KKPlatin platin = new KKPlatin();
        }

        private void mnuKKAltin_Click(object sender, EventArgs e)
        {
            KKAltin altin = new KKAltin();
        }

        private void mnuKKGumus_Click(object sender, EventArgs e)
        {
            KKGumus gumus = new KKGumus();
        }
    }
}