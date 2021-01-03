using System;
using System.Windows.Forms;
using System.Collections.Generic;
namespace AdvancedOOPProject
{
    public partial class MainWindow : Form
    {
        public int LastId = 1000;
        AddNewForm AddNew = new AddNewForm();
        List<PharmacyItem> PharmacyItems = new List<PharmacyItem>();
        public MainWindow()
        {
            InitializeComponent();

        }


        private void MainWindow_Load(object sender, EventArgs e)
        {
            sizelabel.Text = PharmacyItems.Count.ToString();
        }
        private void CancelNewBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void AddRowBtn_Click(object sender, EventArgs e)
        {


            AddNew.ShowDialog();

        }
        public void RefreshGrid()
        {
            ShopDataGrid.Rows.Clear();
            foreach (PharmacyItem pItem in PharmacyItems)
            {

                ShopDataGrid.Rows.Add(pItem.Id, pItem.Name, pItem.Price, pItem.Unit, pItem.ItemType, pItem.ProductionDate.ToString("yyyy-MM"), pItem.ExpirationDate.ToString("yyyy-MM"));
            }
            // setSizeLabel(PharmacyItems.Count);
        }

        public int AddItem(PharmacyItem pItem)
        {

            PharmacyItems.Add(pItem);
            sizelabel.Text = PharmacyItems.Count.ToString();
            RefreshGrid();
            return 0;

        }

        public int RemoveItem(PharmacyItem pItem)
        {
    
                    PharmacyItems.Remove(pItem);
                    sizelabel.Text = PharmacyItems.Count.ToString();
                    RefreshGrid();
               
            return 0;
        }
        public int RemoveItem(int index)
        {


            PharmacyItems.RemoveAt(index);
            sizelabel.Text = PharmacyItems.Count.ToString();
            RefreshGrid();

            return 0;
        }

        public void setSizeLabel(int sz)
        {

            sizelabel.Text = Convert.ToString(sz);
        }

        private void ClearFiltersBtn_Click(object sender, EventArgs e)
        {
            IdFilterCBox.Checked = false; IdFilterTBox.Text = "";
            NameFilterCBox.Checked = false; NameFilterTBox.Text = "";
            PriceFilterCBox.Checked = false; PriceFilterTBox.Text = "";
            UnitFilterCBox.Checked = false; UnitFilterTBox.Text = "";
            TypeFilterCBox.Checked = false; TypeFilterCmBox.Text = "";
            PDateFilterCBox.Checked = false; ExpDateFilterCBox.Checked = false;
        }

        private void DeleteRowsBtn_Click(object sender, EventArgs e)
        {
            if (PharmacyItems.Count > 0)
            {
                if (ShopDataGrid.SelectedRows.Count > 0)
                {

                    RemoveItem(ShopDataGrid.CurrentCell.RowIndex);

                }
                else MessageBox.Show("No row selected!");
                }
                else MessageBox.Show("No data!");
            }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter file =
           new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines2.txt", false))
            {
                foreach(PharmacyItem pItem in PharmacyItems) { file.WriteLine(String.Format("{0}",pItem.AsString())); }
      
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line;
            List<PharmacyItem> TempPharmacyItems = new List<PharmacyItem>();
            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\Public\TestFolder\WriteLines2.txt");
            while ((line = file.ReadLine()) != null)
            {
                try
                {
                    if (line.Trim().StartsWith("<")&&line.Trim().EndsWith(">")){ 
                    PharmacyItem pItem = new PharmacyItem().ParseItem(line.Trim());
                    TempPharmacyItems.Add(pItem);
                }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                    throw;
                }
      
            }
            PharmacyItems = TempPharmacyItems;
            file.Close();
            RefreshGrid();
        }
    }
    }

