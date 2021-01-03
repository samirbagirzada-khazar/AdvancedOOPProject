using System;
namespace AdvancedOOPProject
{
    public class PharmacyItem
    {
        public int Id { get; set; }
        public int bUseMonths;
        public int bUseYears;


        public String Name { get; set; }
        public double Price { get; set; }
        public String Unit { get; set; }
        public String ItemType { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public double Quantity { get; set; }
        public PharmacyItem() { }
        public PharmacyItem ParseItem(string str)
        {
            str = str.Trim();
            if (str.StartsWith("<") && str.EndsWith(">"))
            {
                str = str.Remove(0, 1);
                str = str.Remove(str.Length - 1, 1);
                var xx = str.Split(';');
                try
                {
                    Id = Convert.ToInt32(xx[0]);
                    Name = xx[1];
                    Price = Convert.ToDouble(xx[2]);
                    Unit = xx[3];
                    var ret_type = xx[4];
                    Quantity = Convert.ToDouble(xx[5]);
                    if (xx[6].Trim().Equals("NULL") == false)
                    {
                        var ProductionDateMonth = Convert.ToInt32(xx[6].Split('-')[1].Trim());
                        var ProductionDateYear = Convert.ToInt32(xx[6].Split('-')[0].Trim());
                        ProductionDate = new DateTime(ProductionDateYear, ProductionDateMonth, 1);

                    }
                    if (xx[7].Trim().Equals("NULL") == false)
                    {
                        var ExpirationDateMonth = Convert.ToInt32(xx[7].Split('-')[1].Trim());
                        var ExpirationDateYear = Convert.ToInt32(xx[7].Split('-')[0].Trim());
                        ExpirationDate = new DateTime(ExpirationDateYear, ExpirationDateMonth, 1);
                    }
                    if (ret_type.Contains("Tablet"))
                    {
                        var retval = new Tablet(Id, Name, Price, Quantity);
                        retval.ProductionDate = this.ProductionDate;
                        retval.ExpirationDate = this.ExpirationDate;

                        return retval;
                    }
                    else if (ret_type.Contains("Liquid"))
                    {
                        var retval = new Liquid(Id, Name, Price, Quantity);
                        retval.ProductionDate = this.ProductionDate;
                        retval.ExpirationDate = this.ExpirationDate;

                        return retval;
                    }
                    else if (ret_type.Contains("Syringe"))
                    {
                        var retval = new Syringe(Id, Name, Price, Quantity);
                        retval.ProductionDate = this.ProductionDate;
                        retval.ExpirationDate = this.ExpirationDate;

                        return retval;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    throw;
                }

            }
            return new PharmacyItem();
        }
        public PharmacyItem(int _ID, String _Name, double _Price, double _Quantity)
        {
            Id = _ID;
            Name = _Name;
            Price = _Price;
            Quantity = _Quantity;
        }
        public virtual string AsString()
        {
            return String.Format("<{0};{1};{2};{3};{4};{5};{6}>",
                Id, Name, Price, "GenericPharmacyUnit", "GenericPharmacyItem", "NULL", "NULL");
        }
    };


    public class Tablet : PharmacyItem
    {

        public int PillsPerBottle { get; set; }
        public Tablet()
        {
            bUseMonths = 6;
            bUseYears = 1;
        }
        public Tablet(int _ID, String _Name, double _Price, double _Quantity) : base(_ID, _Name, _Price, _Quantity)
        {
            ItemType = "Tablet";
            Unit = "Bottle";
            bUseMonths = 6;
            bUseYears = 1;
        }
        public override string AsString()
        {
            return String.Format("<{0};{1};{2};{3};{4};{5};{6};{7}>",
                Id, Name, Price, Unit, ItemType, Quantity, ProductionDate.ToString("yyyy-MM"), ExpirationDate.ToString("yyyy-MM"));
        }

    }
    public class Liquid : PharmacyItem
    {
        public double VolumePerBottle { get; set; }
        public Liquid()
        {
            bUseMonths = 6;
            bUseYears = 0;
        }
        public Liquid(int _ID, String _Name, double _Price, double _Quantity) : base(_ID, _Name, _Price, _Quantity)
        {
            ItemType = "Liquid";
            Unit = "mL";
            bUseMonths = 6;
            bUseYears = 0;
        }
        public override string AsString()
        {
            return String.Format("<{0};{1};{2};{3};{4};{5};{6};{7}>",
                Id, Name, Price, Unit, ItemType, Quantity, ProductionDate.ToString("yyyy-MM"), ExpirationDate.ToString("yyyy-MM"));
        }
    }
    public class Syringe : PharmacyItem
    {
        public int SyringePerPack { get; set; }
        public Syringe()
        {
            bUseMonths = 6;
            bUseYears = 5;
        }
        public Syringe(int _ID, String _Name, double _Price, double _Quantity) : base(_ID, _Name, _Price, _Quantity)
        {
            ItemType = "Syringe";
            Unit = "pcs";
            bUseMonths = 6;
            bUseYears = 5;
        }
        public override string AsString()
        {
            return String.Format("<{0};{1};{2};{3};{4};{5};{6};{7}>",
                Id, Name, Price, Unit, ItemType, Quantity, ProductionDate.ToString("yyyy-MM"), ExpirationDate.ToString("yyyy-MM"));
        }
    }
}