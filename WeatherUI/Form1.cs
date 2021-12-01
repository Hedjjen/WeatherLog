using WeatherLibrary;

namespace WeatherUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textClear(object sender, EventArgs e)
        {
            textBoxCity.Text = string.Empty;
        }

        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            textBoxShowWeather.Text = Controller.ShowWeather(textBoxCity.Text);
        }
    }
}