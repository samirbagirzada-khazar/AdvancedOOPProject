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
            string[] available_classes = new string[] { "Tablet", "Syringe", "Liquid" };
            TypeFilterCmBox.Items.AddRange(available_classes);
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
                if (IdFilterCBox.Checked == true && !pItem.Id.ToString().StartsWith(IdFilterTBox.Text) && IdFilterTBox.Text.Length > 0)
                {
                    ShopDataGrid.Rows.RemoveAt(ShopDataGrid.Rows.Count - 1);
                }
                else if (NameFilterCBox.Checked == true && !pItem.Name.StartsWith(NameFilterTBox.Text) && NameFilterTBox.Text.Length > 0)
                    {
                        ShopDataGrid.Rows.RemoveAt(ShopDataGrid.Rows.Count - 1);
                    }
                else if (PriceFilterCBox.Checked == true && !pItem.Price.ToString().StartsWith(PriceFilterTBox.Text) && PriceFilterTBox.Text.Length > 0)
                {
                    ShopDataGrid.Rows.RemoveAt(ShopDataGrid.Rows.Count - 1);
                }
                else if (UnitFilterCBox.Checked == true && !pItem.Unit.ToString().StartsWith(UnitFilterTBox.Text) && UnitFilterTBox.Text.Length > 0)
                {
                    ShopDataGrid.Rows.RemoveAt(ShopDataGrid.Rows.Count - 1);
                }
                else if (TypeFilterCBox.Checked == true && !pItem.ItemType.StartsWith(TypeFilterCmBox.Text) && TypeFilterCmBox.Text.Length > 0)
                {
                    ShopDataGrid.Rows.RemoveAt(ShopDataGrid.Rows.Count - 1);
                }
                else if (PDateFilterCBox.Checked == true && 
                    (pItem.ProductionDate.Month!=PDateDBox.Value.Month|| pItem.ProductionDate.Year != PDateDBox.Value.Year) && TypeFilterCmBox.Text.Length > 0)
                {
                    ShopDataGrid.Rows.RemoveAt(ShopDataGrid.Rows.Count - 1);
                }
                else if (ExpDateFilterCBox.Checked == true &&
    (pItem.ExpirationDate.Month != ExpDateDBox.Value.Month || pItem.ExpirationDate.Year != ExpDateDBox.Value.Year))
                {
                    ShopDataGrid.Rows.RemoveAt(ShopDataGrid.Rows.Count - 1);
                }
            }
            sizelabel.Text = PharmacyItems.Count.ToString();
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
            RefreshGrid();
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
          
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter file =
           new System.IO.StreamWriter(saveFileDialog1.FileName, false))
                {
                    foreach (PharmacyItem pItem in PharmacyItems) { file.WriteLine(String.Format("{0}", pItem.AsString())); }

                }
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string line;
            List<PharmacyItem> TempPharmacyItems = new List<PharmacyItem>();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader file =
                new System.IO.StreamReader(openFileDialog1.FileName);
                while ((line = file.ReadLine()) != null)
                {
                    try
                    {
                        if (line.Trim().StartsWith("<") && line.Trim().EndsWith(">"))
                        {
                            PharmacyItem pItem = new PharmacyItem().ParseItem(line.Trim());
                            TempPharmacyItems.Add(pItem);
                            PharmacyItems = TempPharmacyItems;
                            LastId = PharmacyItems[PharmacyItems.Count - 1].Id + 1;
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.ToString());
                        throw;
                    }

                }

                file.Close();
                RefreshGrid();
            }
        }
    }
}

