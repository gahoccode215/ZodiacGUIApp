using Services;

namespace Zodiac
{
    public partial class ZodiacManager : Form
    {
        public ZodiacManager()
        {
            InitializeComponent();
        }

        private void btnShowImage_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile("signs\\MyGirl.jpg");
            picImage.Image = img;
        }

        private void picImage_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckZodiac_Click(object sender, EventArgs e)
        {
            int day = int.Parse(txtDay.Text);
            int month = int.Parse(txtMonth.Text);
            string zodiacEN = ZodiacCalculator.GetZodiacEnglish(month, day);
            string zodiacVN = ZodiacCalculator.GetZodiacVietnamese(zodiacEN);
            string zodiacImage = @"signs\" + zodiacEN + ".jpg";
            Image img = Image.FromFile(zodiacImage);
            picImage.Image = img;
            lblResult.Text = " Your zodiac sign is - Cung hoàng đạo của bạn là: " + zodiacEN + " | " + zodiacVN;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
