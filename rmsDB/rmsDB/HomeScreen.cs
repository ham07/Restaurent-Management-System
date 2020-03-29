using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rmsDB
{
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void rolesBtn_Click(object sender, EventArgs e)
        {
            Roless obj = new Roless();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tables obj = new Tables();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Floors obj = new Floors();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Category obj = new Category();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FoodMenu obj = new FoodMenu();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Orders obj = new Orders();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OrderCompletion obj = new OrderCompletion();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Tax obj = new Tax();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OrderModification obj = new OrderModification();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }
    }
}
