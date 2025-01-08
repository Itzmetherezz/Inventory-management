namespace Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ClearForm();
            OpenMainForm();








           
        }

        private void ClearForm()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                   ((TextBox)c).Clear();
                }
            }
        }
        private void OpenMainForm()
        {
            main mainform = new main();
            mainform.Show();
            this.Hide();

        }


    }
}
