using static System.Windows.Forms.AxHost;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private DateTime date;
        private int h;
        private int m;
        private int s;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!int.TryParse(textBox1.Text, out h))
            {
                MessageBox.Show($"Error: {label1.Text}");
                return;
            }
            if (!int.TryParse(textBox2.Text, out h))
            {
                MessageBox.Show($"Error: {label2.Text}");
                return;
            }
            if (!int.TryParse(textBox3.Text, out h))
            {
                MessageBox.Show($"Error: {label3.Text}");
                return;
            }
            date = dateTimePicker1.Value;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (date.Date != now.Date)
                return;
            if (now.TimeOfDay.Hours == h && now.TimeOfDay.Minutes == m && now.TimeOfDay.Seconds == s)
            {
                ((System.Windows.Forms.Timer)sender).Stop();
                MessageBox.Show("TIMER!", "Timers!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}