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
    public partial class Form2 : Form
    {
        private Form1 f1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            f1 = form1;
        }

        public string ForTooltip()
        {
            string finStr = null;
            finStr = "Полный вес: " + int.Parse(Weight.Text) * int.Parse(Amount.Text);
            if (Armor.Text != "0")
                finStr += "\nПулестойкость: +" + Armor.Text;
            if (Endurance.Text != "0")
                finStr += "\nВыносливость: +" + Endurance.Text;
            if (ElectroResist.Text != "0")
                finStr += "\nЭлектрозащита: +" + ElectroResist.Text;
            if (ChemicalResist.Text != "0")
                finStr += "\nХимзащита: +" + ChemicalResist.Text;
            if (PsiResist.Text != "0")
                finStr += "\nПсизащита: +" + PsiResist.Text;
            if (FireResist.Text != "0")
                finStr += "\nТермозащита: +" + FireResist.Text;
            if (HitResist.Text != "0")
                finStr += "\nГашение удара: +" + HitResist.Text;
            if (RadioResist.Text != "0")
                finStr += "\nРадиозащита: +" + RadioResist.Text;
            return finStr;
        }

        private void Item_Click(object sender, EventArgs e)
        {
            if (f1.del == true)
                f1.flowLayoutPanel1.Controls.Remove((Button)sender);
        }

        public void CreateItem()
        {
            Item item = new Item(int.Parse(Weight.Text), int.Parse(Amount.Text) , int.Parse(Armor.Text), int.Parse(Endurance.Text), int.Parse(ElectroResist.Text),
                int.Parse(ChemicalResist.Text), int.Parse(PsiResist.Text), int.Parse(FireResist.Text), int.Parse(HitResist.Text), int.Parse(RadioResist.Text),
                int.Parse(CarriedWeight.Text));
            item.Name = Name1.Text;
            item.Text = Name1.Text + " x" + Amount.Text;
            item.AutoSize = true;
            f1.flowLayoutPanel1.Controls.Add(item);
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(item, ForTooltip());
            item.Click += new EventHandler(Item_Click); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateItem();
        }
    }
}
