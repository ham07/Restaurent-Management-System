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
    public partial class HomeScreen2 : Sample
    {
        public HomeScreen2()
        {
            InitializeComponent();
        }

        private void rolesBtn_Click(object sender, EventArgs e)
        {
            ChefOrders cw = new ChefOrders();
            MainClass.showWindow(cw, this, MDI.ActiveForm);
        }
    }
}
