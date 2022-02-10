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
                    RAM = 2
                }
            };

            _laptops.Add(laptop);            

            for (int i = 0; i < _laptops.Count; i++)
            {
                dataGridViewLaptops.Rows.Add();
                dataGridViewLaptops["CostName", i].Value = _laptops[i].CostPrice.Name;
                dataGridViewLaptops["CostProcessor", i].Value = _laptops[i].CostPrice.Processor;
                dataGridViewLaptops["CostRAM", i].Value = _laptops[i].CostPrice.RAM;
                dataGridViewLaptops["CostHDD", i].Value = _laptops[i].CostPrice.HDD;
            }

        }
    }
}
