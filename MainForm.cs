using NUSA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NUSA
{
    public partial class NUSAForm : Form
    {
        private List<Laptop> _laptops = new List<Laptop>();


        public NUSAForm()
        {
            InitializeComponent();
        }



        private void NUSAForm_Load(object sender, EventArgs e)
        {
            var laptop = new Laptop
            {
               CostPrice = new CostPrice
                {
                    Name = "Lenovo T530",
                    Processor = "Core i7 2,9GHz",
                    RAM = 2,
                    HDD = 500,
                    Battery = true,
                    AC = true,
                    Comment = "Bad AC port",
                    PurchaseDate = DateTime.Parse("01-01-2022"),
                    LotNumber = "0231564022",
                    TrackNumber = "9562318",
                    BodyPrice = 100,
                    ACPrice = 5,
                    RAMPrice = 8,
                    HDDPrice = 15,
                    BatteryPrice = 0,
                    CaddyPrice = 0,
                    CustomPrice = 0,
                    ShippingPrice = 13.89,
                    UnlockPrice = 0,
                    BuyPrice = 2500,
                    SellPrice = 3500,
                    CoursePrice = 28

                }
            };

            var laptop2 = new Laptop
            {
                CostPrice = new CostPrice
                {
                    Name = "Dell E5570",
                    Processor = "Core i5 2,6GHz",
                    RAM = 16,
                    HDD = 250,
                    Battery = true,
                    AC = false,
                    Comment = "white spot",
                    PurchaseDate = DateTime.Parse("01-01-2022"),
                    LotNumber = "056654652",
                    TrackNumber = "849566",
                    BodyPrice = 350,
                    ACPrice = 12,
                    RAMPrice = 10,
                    HDDPrice = 40,
                    BatteryPrice = 15,
                    CaddyPrice = 0,
                    CustomPrice = 33,
                    ShippingPrice = 9.99,
                    UnlockPrice = 0,
                    BuyPrice = 5000,
                    SellPrice = 5500,
                    CoursePrice = 27

                }
            };



            _laptops.Add(laptop);
            _laptops.Add(laptop2);
            
            CreateLaptop(_laptops);
            void CreateLaptop(List<Laptop> _laptops)
            {
                for (int i = 0; i < _laptops.Count; i++)
                {
                    dataGridViewLaptops.Rows.Add();
                    dataGridViewLaptops["CostName", i].Value = _laptops[i].CostPrice.Name;
                    dataGridViewLaptops["CostProcessor", i].Value = _laptops[i].CostPrice.Processor;
                    dataGridViewLaptops["CostRAM", i].Value = _laptops[i].CostPrice.RAM;
                    dataGridViewLaptops["CostHDD", i].Value = _laptops[i].CostPrice.HDD;
                    dataGridViewLaptops["CostBattery", i].Value = _laptops[i].CostPrice.Battery;
                    dataGridViewLaptops["CostAC", i].Value = _laptops[i].CostPrice.AC;
                    dataGridViewLaptops["CostComment", i].Value = _laptops[i].CostPrice.Comment;
                    dataGridViewLaptops["CostLotNumber", i].Value = _laptops[i].CostPrice.LotNumber;
                    dataGridViewLaptops["CostTrackNumber", i].Value = _laptops[i].CostPrice.TrackNumber;
                    dataGridViewLaptops["CostBodyPrice", i].Value = _laptops[i].CostPrice.BodyPrice;
                    dataGridViewLaptops["CostACPrice", i].Value = _laptops[i].CostPrice.ACPrice;
                    dataGridViewLaptops["CostRAMPrice", i].Value = _laptops[i].CostPrice.RAMPrice;
                    dataGridViewLaptops["CostHDDPrice", i].Value = _laptops[i].CostPrice.HDDPrice;
                    dataGridViewLaptops["CostBatteryPrice", i].Value = _laptops[i].CostPrice.BatteryPrice;
                    dataGridViewLaptops["CostCaddyPrice", i].Value = _laptops[i].CostPrice.CaddyPrice;
                    dataGridViewLaptops["CostCustomPrice", i].Value = _laptops[i].CostPrice.CustomPrice;
                    dataGridViewLaptops["CostShippingPrice", i].Value = _laptops[i].CostPrice.ShippingPrice;
                    dataGridViewLaptops["CostUnlockPrice", i].Value = _laptops[i].CostPrice.UnlockPrice;
                    dataGridViewLaptops["CostBuyPrice", i].Value = _laptops[i].CostPrice.BuyPrice;
                    dataGridViewLaptops["CostSellPrice", i].Value = _laptops[i].CostPrice.SellPrice;
                    dataGridViewLaptops["CostCoursePrice", i].Value = _laptops[i].CostPrice.CoursePrice;
                }
            }
            
        }

        private void CreateLaptop2(List<Laptop> _laptops)
        {
            dataGridViewLaptops.Rows.Clear();
            for (int i = 0; i < _laptops.Count; i++)
            {
                dataGridViewLaptops.Rows.Add();
                dataGridViewLaptops["CostName", i].Value = _laptops[i].CostPrice.Name;
                dataGridViewLaptops["CostProcessor", i].Value = _laptops[i].CostPrice.Processor;
                dataGridViewLaptops["CostRAM", i].Value = _laptops[i].CostPrice.RAM;
                dataGridViewLaptops["CostHDD", i].Value = _laptops[i].CostPrice.HDD;
                dataGridViewLaptops["CostBattery", i].Value = _laptops[i].CostPrice.Battery;
                dataGridViewLaptops["CostAC", i].Value = _laptops[i].CostPrice.AC;
                dataGridViewLaptops["CostComment", i].Value = _laptops[i].CostPrice.Comment;
                dataGridViewLaptops["CostLotNumber", i].Value = _laptops[i].CostPrice.LotNumber;
                dataGridViewLaptops["CostTrackNumber", i].Value = _laptops[i].CostPrice.TrackNumber;
                dataGridViewLaptops["CostBodyPrice", i].Value = _laptops[i].CostPrice.BodyPrice;
                dataGridViewLaptops["CostACPrice", i].Value = _laptops[i].CostPrice.ACPrice;
                dataGridViewLaptops["CostRAMPrice", i].Value = _laptops[i].CostPrice.RAMPrice;
                dataGridViewLaptops["CostHDDPrice", i].Value = _laptops[i].CostPrice.HDDPrice;
                dataGridViewLaptops["CostBatteryPrice", i].Value = _laptops[i].CostPrice.BatteryPrice;
                dataGridViewLaptops["CostCaddyPrice", i].Value = _laptops[i].CostPrice.CaddyPrice;
                dataGridViewLaptops["CostCustomPrice", i].Value = _laptops[i].CostPrice.CustomPrice;
                dataGridViewLaptops["CostShippingPrice", i].Value = _laptops[i].CostPrice.ShippingPrice;
                dataGridViewLaptops["CostUnlockPrice", i].Value = _laptops[i].CostPrice.UnlockPrice;
                dataGridViewLaptops["CostBuyPrice", i].Value = _laptops[i].CostPrice.BuyPrice;
                dataGridViewLaptops["CostSellPrice", i].Value = _laptops[i].CostPrice.SellPrice;
                dataGridViewLaptops["CostCoursePrice", i].Value = _laptops[i].CostPrice.CoursePrice;
            }
        }

        private void deleteLaptopMenuItem_Click(object sender, EventArgs e)
        {
            var laptopName = dataGridViewLaptops.SelectedRows[0].Cells["CostName"].Value.ToString();

            var laptop = _laptops.Find(x => x.CostPrice.Name == laptopName);
            _laptops.Remove(laptop);
            CreateLaptop2(_laptops);
        }

        private void createLaptopMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            FormCreateLaptop Form = new FormCreateLaptop();
            var dialogResult = Form.ShowDialog();

            if (dialogResult == DialogResult.OK)            
            {
                AddNewLaptop(Form.SomeMethod);
            }
        }

        public void  AddNewLaptop(Laptop L)
        {
            _laptops.Add(L);
            CreateLaptop2(_laptops);

            
            
        }
    }
}
