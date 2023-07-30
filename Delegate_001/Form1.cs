namespace Delegate_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btn.Click += Metodo1;
            btn.Click += Metodo2;
        }

        private void Metodo1(Object sender, EventArgs e)
        {
            MessageBox.Show("Método 1 executado!");
        }
        private void Metodo2(Object sender, EventArgs e)
        {
            MessageBox.Show("Método 2 executado!");
        }

    }
}