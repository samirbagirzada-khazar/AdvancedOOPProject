using System;
using System.Windows.Forms;

namespace AdvancedOOPProject
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
            
        }


        private void MainWindow_Load(object sender, EventArgs e)
        {
  

        }

        private void AddRowBtn_Click(object sender, EventArgs e)
        {
            AddNewForm AddNew = new AddNewForm();
            AddNew.ShowDialog();
        }
    }
}
