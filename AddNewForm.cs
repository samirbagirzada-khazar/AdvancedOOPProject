using System.Windows.Forms;
using System;
namespace AdvancedOOPProject
{
    
    public partial class AddNewForm : Form
    {

        public enum ClassesEnum
        {
            Tablet,
            Liquid,
            Syringe

        }
        PharmacyItem TempTablet = new Tablet();
        PharmacyItem TempSyringe = new Syringe();
        PharmacyItem TempLiquid = new Liquid();
       
        public AddNewForm()
        {
            InitializeComponent();
            string[] availableClasses = { "Tablet", "Liquid", "Syringe" };
            this.NewTypeCBox.Focus();
            foreach (string str in availableClasses)
            {
                this.NewTypeCBox.Items.Add(str);
            }
            this.NewTypeCBox.SelectedIndex = 0;
            NewPDateDBox.Value = DateTime.Now;


        }


        private void CancelNewBtn_Click(object sender, System.EventArgs e)
        {
            this.reset();
            this.Close();
        }

        private void AddNewBtn_Click(object sender, System.EventArgs e)
        {
            int selectedClass = this.NewTypeCBox.SelectedIndex;
            PharmacyItem pItem;
            switch (selectedClass)
            {
                case (int)ClassesEnum.Tablet: 
                    pItem = new Tablet(Program.MWindow.LastId++,NewNameTBox.Text,Convert.ToDouble(NewPriceTBox.Text), Convert.ToDouble(NewQuantityTBox.Text));
                    pItem.ExpirationDate = this.NewExpDateDBox.Value;
                    pItem.ProductionDate = this.NewPDateDBox.Value;    
                    Program.MWindow.AddItem(pItem);

                    this.reset();
                    break;
                case (int)ClassesEnum.Liquid: pItem = new Liquid();
                    pItem = new Liquid(Program.MWindow.LastId++, NewNameTBox.Text, Convert.ToDouble(NewPriceTBox.Text), Convert.ToDouble(NewQuantityTBox.Text));
                    pItem.ExpirationDate = this.NewExpDateDBox.Value;
                    pItem.ProductionDate = this.NewPDateDBox.Value;
                    Program.MWindow.AddItem(pItem);
    
                    this.reset();
                    break;
                case (int)ClassesEnum.Syringe:
                    pItem = new Syringe(Program.MWindow.LastId++, NewNameTBox.Text, Convert.ToDouble(NewPriceTBox.Text), Convert.ToDouble(NewQuantityTBox.Text));
                    pItem.ExpirationDate = this.NewExpDateDBox.Value;
                    pItem.ProductionDate = this.NewPDateDBox.Value;
                    Program.MWindow.AddItem(pItem);
    
                    this.reset();
                    break;
            }
         
        
        }
        public void reset()
        {

            this.NewTypeCBox.Focus();
            NewNameTBox.Text = "";
            NewPriceTBox.Text = "";
            NewQuantityTBox.Text = "";
        }
        private void AddNewForm_Load(object sender, System.EventArgs e)
        {
            this.NewTypeCBox.SelectedIndex = 0;
            this.NewTypeCBox.Focus();

            NewNameTBox.Text = "";
            NewPriceTBox.Text = "";
            NewQuantityTBox.Text = "";

        }

        private void NewTypeCBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (this.NewTypeCBox.SelectedIndex)
            {
                case (int)ClassesEnum.Tablet:
                    this.NewExpDateDBox.Value = NewPDateDBox.Value.AddYears(TempTablet.bUseYears).AddMonths(TempTablet.bUseYears);
                    break;
                case (int)ClassesEnum.Liquid:
                    this.NewExpDateDBox.Value = NewPDateDBox.Value.AddYears(TempLiquid.bUseYears).AddMonths(TempLiquid.bUseYears);
                    break;
                case (int)ClassesEnum.Syringe:
                    this.NewExpDateDBox.Value = NewPDateDBox.Value.AddYears(TempSyringe.bUseYears).AddMonths(TempSyringe.bUseYears); 
                    break;

            }
        }
    }
}
