using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ролка_Сталкер
{
    public partial class Form1 : Form
    {
        public bool del = false;

        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (del == false)
                del = true;
            textBox1.Text = del.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (del == true)
                del = false;
            textBox1.Text = del.ToString();
        }
    }

    

    public class Item : Button
    {
        public int Weight, Amount, Armor, Endurance, ElectroResist, ChemicalResist, PsiResist, FireResist, HitResist, RadioResist, CarriedWeight;
        public Item(int Weight, int Amount, int Armor, int Endurance, int ElectroResist, int ChemicalResist, int PsiResist,
            int FireResist, int HitResist, int RadioResist, int CarriedWeight)
        {
            this.Weight = Weight;
            this.Amount = Amount;
            this.Armor = Armor;
            this.Endurance = Endurance;
            this.ElectroResist = ElectroResist;
            this.ChemicalResist = ChemicalResist;
            this.PsiResist = PsiResist;
            this.FireResist = FireResist;
            this.HitResist = HitResist;
            this.RadioResist = RadioResist;
            this.CarriedWeight = CarriedWeight;
        }
    }
}
