using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Collections;

namespace rmsDB
{
    class MainClass
    {
        private static string path;
        private static string connectionString()
        {
            path=Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\rms_connect";
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            else
            {
                return "";
            }
        }
        public static SqlConnection con = new SqlConnection(connectionString());

        public static void showWindow(Form openWin, Form clsWin, Form MDIWin)
        {
            clsWin.Close();
            openWin.MdiParent = MDIWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();

        }
        public static void showWindow(Form openWin, Form MDIWin)
        {

            openWin.MdiParent = MDIWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();

        }
        public static DialogResult showMessage(string msg, string heading, string type)
        {
            if (type == "Success")
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void disable_reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                    t.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                    //-1 is mean that combox will be blank
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                    cb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
                    dtp.Value = DateTime.Now;

                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = false;
                    cb.Value = 0;

                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = false;
                   

                }
            }
        }
        public static void disable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;

                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;

                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;

                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;

                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = false;

                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;


                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = false;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = false;
                }
            }
        }
        public static void enable_reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = "";
                    t.BackColor = Color.White;
                    
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    //-1 is mean that combox will be blank
                    cb.SelectedIndex = -1;
                    cb.BackColor = Color.White;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    rb.Checked = false;
                    rb.BackColor = Color.White;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                    cb.Checked = false;
                    cb.BackColor = Color.White;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                    dtp.BackColor = Color.White;

                }
                if(c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = true;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = true;
                    cb.Value = 0;
                }
            }
        }
        public static void enable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;

                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;

                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;

                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;

                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;


                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = true;

                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = true;
                }
            }
        }
        public static void enable_reset(GroupBox gp)
        {
            foreach (Control c in gp.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    //-1 is mean that combox will be blank
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                    cb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;

                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = true;
                    cb.Value = 0;

                }
            }
        }

    
        public static ArrayList checkControls(Panel p)
        {
            ArrayList arr = new ArrayList();
            foreach (Control c in p.Controls)
            {
                if(c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    if(tb.AllowDrop==true)
                    {

                    }
                    else
                    {
                        if (tb.Text == "")
                        {
                            arr.Add(tb);
                        }
                        else
                        {
                            if (!arr.Contains(tb))
                            {
                                arr.Remove(tb);
                            }

                        }

                        tb.BackColor = tb.Text == "" ? tb.BackColor = Color.Firebrick : tb.BackColor = Color.White;
                    }
                    
                    
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    if (cb.AllowDrop ==true)
                    {

                    }
                    else
                    {
                        if (cb.SelectedIndex == -1)
                        {
                            arr.Add(cb);
                        }
                        else
                        {
                            if (arr.Contains(cb))
                            {
                                arr.Remove(cb);
                            }

                        }

                        cb.BackColor = cb.SelectedIndex == -1 ? cb.BackColor = Color.Firebrick : cb.BackColor = Color.White;

                    }
                   

                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (!rb.Checked)
                    {
                        arr.Add(rb);
                    }
                    else
                    {
                        if (!arr.Contains(rb))
                        {
                            arr.Remove(rb);
                        }

                    }

                    rb.BackColor = !rb.Checked  ? rb.BackColor = Color.Firebrick : rb.BackColor = Color.White;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (!cb.Checked)
                    {
                        arr.Add(cb);
                    }
                    else
                    {
                        if (!arr.Contains(cb))
                        {
                            arr.Remove(cb);
                        }

                    }

                    cb.BackColor = !cb.Checked  ? cb.BackColor = Color.Firebrick : cb.BackColor = Color.White;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    if (cb.Value ==0)
                    {
                        arr.Add(cb);
                    }
                    else
                    {
                        if (!arr.Contains(cb))
                        {
                            arr.Remove(cb);
                        }

                    }

                    cb.BackColor = cb.Value==0 ? cb.BackColor = Color.Firebrick : cb.BackColor = Color.White;
                }
            }
            return arr;
        }

      public static void sno(DataGridView gv ,string srnoGV)
        {
            int count = 0;
            foreach(DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[srnoGV].Value = count;
            }
        }
        
    }
}
