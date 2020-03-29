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
    public partial class FoodMenu : Sample2
    {
        public FoodMenu()
        {
            InitializeComponent();
        }

        insertions i = new insertions();
        retrival r = new retrival();
        updation u = new updation();
        int menuID;

        private void FoodMenu_Load(object sender, EventArgs e)
        {
            retrival.loadItems("st_getCategory", categoryCB,  "Category", "ID");
            categoryCB.SelectedIndex = -1;


        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftpanel).Count == 0)
            {
                short status = statusCB.SelectedItem.ToString() == "Avalible" ? Convert.ToInt16(1) : Convert.ToInt16(0);
                if (edit == 0)//save code
                {
                   
                    // i.insertUsers(nameTxt.Text,userTxt.Text,phoneTxt.Text,addressTxt.Text,passTxt.Text,Convert.ToInt16(roleCB.SelectedValue.ToString()));
                    i.insertMenu(menuTxt.Text, Convert.ToSingle(priceTxt.Text), Convert.ToInt32(categoryCB.SelectedValue.ToString()), status,pictureBox1.Image);
                    MainClass.disable_reset(leftpanel);
                    r.showMenu(dataGridView1, menuIDgv, MenuItemGV, priceGV, statusGV, catIDGV, CatnameGV);
                }
                else if (edit == 1)// update code
                {
                    u.updateMenu(menuID, menuTxt.Text, Convert.ToSingle(priceTxt.Text), Convert.ToInt32(categoryCB.SelectedValue.ToString()), status,pictureBox1.Image);
                    MainClass.disable_reset(leftpanel);
                    r.showMenu(dataGridView1, menuIDgv, MenuItemGV, priceGV, statusGV, catIDGV, CatnameGV);
                }

            }
            else
            {
                MessageBox.Show("Please Enter all require Feilds");
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (delStatus == 1)
            {

                DialogResult dr = MessageBox.Show("are you sure you want to delete this record", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    deletions d = new deletions();
                    d.deleteData("st_deleteMenu", "@mid", menuID);
                    MainClass.disable_reset(leftpanel);
                    r.showMenu(dataGridView1, menuIDgv, MenuItemGV, priceGV, statusGV, catIDGV, CatnameGV);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showMenu(dataGridView1, menuIDgv, MenuItemGV, priceGV, statusGV, catIDGV, CatnameGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.disable(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                menuID = Convert.ToInt32(row.Cells["menuIDgv"].Value.ToString());
                categoryCB.SelectedValue = row.Cells["catIDGV"].Value.ToString();
                menuTxt.Text = row.Cells["MenuItemGV"].Value.ToString();
                priceTxt.Text = row.Cells["priceGV"].Value.ToString();
                statusCB.SelectedItem = row.Cells["statusGV"].Value.ToString();
              //  pictureBox1.Image = Image.FromFile(row.Cells["imageGV"].Value.ToString());


            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if(dr== DialogResult.OK)
            {
                Image im = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = im;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
