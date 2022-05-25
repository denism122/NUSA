using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NUSA.Models;

namespace NUSA
{
    public partial class FormCreateLaptop : Form
    {
        public FormCreateLaptop()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Laptop laptop = new Laptop()
            {
                CostPrice = new CostPrice()
                {
                    Name = textBoxModelName.Text,
                    Processor = textBoxProcessorName.Text,
                    RAM = Convert.ToByte( textBoxRAMName.Text),
                    HDD = Convert.ToInt32( textBoxHDDName.Text),
                    Battery = true,
                    AC = checkBoxACAvailable.Checked,
                    Comment = "white spot",
                    PurchaseDate = DateTime.Parse("01-01-2022"),
                    LotNumber = textBoxLotNumberName.Text,
                    TrackNumber = "849566",
                    BodyPrice = 350,
                    ACPrice = 12,
                    RAMPrice = 10,
                    HDDPrice = 40,
                    BatteryPrice = Convert.ToDouble(textBox1PriceBattery.Text),
                    CaddyPrice = Convert.ToDouble(textBoxPriceCaddy.Text),
                    CustomPrice = Convert.ToDouble(textBoxPriceCustoms.Text),
                    ShippingPrice = 9.99,
                    UnlockPrice = Convert.ToDouble(textBoxPriceRepair.Text),
                    BuyPrice = 5000,
                    SellPrice = 5500,
                    CoursePrice = 27
                    
                    
                }
            };
            SomeMethod = laptop;

            
            
            //AddNewLaptop(laptop);
        }
        public Laptop SomeMethod
        {
            get;
            set;
        }
    }
}
