using System.Xml.Linq;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {

        Color DefaultColor
        {
            get { return Color.White; }
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //получаем значение текстового пол€ + отрезаем пробелы по кра€м:
            string userName = textBox1.Text.Trim();
            if (userName.Length < 3) //если длина имени пользовател€ слишком коротка€, ошибка!
            {
                MessageBox.Show("¬ведите им€ пользовател€!");
            }
            else
            {
                MessageBox.Show("ѕривет " + userName);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
