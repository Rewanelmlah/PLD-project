using com.calitha.goldparser;
namespace Rewan_elmalah__Project_
{
    public partial class Form1 : Form
    {
        MyParser p;
        public Form1()
        {
            InitializeComponent();
            p = new MyParser("pld project.cgt",listBox1,listBox2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            
            p.Parse(textBox1.Text);
        }
    }
}
