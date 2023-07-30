namespace Delegate_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //btnClick.Click += delegate(Object sender, EventArgs e)
            btnClick.Click += delegate{
                MessageBox.Show("Olá, fui clicado!");
            };
        }
    }
}