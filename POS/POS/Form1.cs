using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace POS
{
    public partial class Form1 : Form
    {
        string Write = "============================================"+Environment.NewLine+"No.\tMenu\t\t\tPrice"+Environment.NewLine+"============================================"+Environment.NewLine;
        int i = 0, j=0;
        string billname,word_total;
        float total_price;
        string[] s_item_no = new string[50] ;
        string[] s_item_name = new string[50];
        string[] s_item_price = new string[50];
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_m_es_Click(object sender, EventArgs e)
        {
            Write += (i+1).ToString()+"\tEsspresso\t\t45฿" + Environment.NewLine;
            total_price += 45;
            tb_total.Text = total_price.ToString()+ ".00 ฿";
            s_item_no[i] = (i + 1).ToString(); 
            s_item_name[i] = "Esspresso";
            s_item_price[i] = "45";
            Addlist();
            i++;
        }

        private void bt_m_am_Click(object sender, EventArgs e)
        {
            Write += (i + 1).ToString() + "\tAmericano\t\t45฿" + Environment.NewLine;
            total_price += 45;
            tb_total.Text = total_price.ToString() + ".00 ฿";
            s_item_no[i] = (i + 1).ToString();
            s_item_name[i] = "Americano";
            s_item_price[i] = "45";
            Addlist();
            i++;
        }

        private void bt_m_la_Click(object sender, EventArgs e)
        {
            Write += (i + 1).ToString() + "\tLatte\t\t\t45฿" + Environment.NewLine;
            total_price += 45;
            tb_total.Text = total_price.ToString() + ".00 ฿";
            s_item_no[i] = (i + 1).ToString();
            s_item_name[i] = "Latte";
            s_item_price[i] = "45";
            Addlist();
            i++;
        }

        private void bt_m_mo_Click(object sender, EventArgs e)
        {
            Write += (i + 1).ToString() + "\tMocha\t\t\t45฿" + Environment.NewLine;
            total_price += 45;
            tb_total.Text = total_price.ToString() + ".00 ฿";
            s_item_no[i] = (i + 1).ToString();
            s_item_name[i] = "Mocha";
            s_item_price[i] = "45";
            Addlist();
            i++;
        }

        private void bt_m_ca_Click(object sender, EventArgs e)
        {
            Write += (i + 1).ToString() + "\tCappuccino\t\t45฿" + Environment.NewLine;
            total_price += 45;
            tb_total.Text = total_price.ToString() + ".00 ฿";
            s_item_no[i] = (i + 1).ToString();
            s_item_name[i] = "Cappuccino";
            s_item_price[i] = "45";
            Addlist();
            i++;
        }

        private void bt_m_gr_Click(object sender, EventArgs e)
        {
            Write += (i + 1).ToString() + "\tGreenTea\t\t45฿" + Environment.NewLine;
            total_price += 25;
            tb_total.Text = total_price.ToString() + ".00 ฿";
            s_item_no[i] = (i + 1).ToString();
            s_item_name[i] = "GreenTea";
            s_item_price[i] = "25";
            Addlist();
            i++;
        }

        private void bt_m_th_Click(object sender, EventArgs e)
        {
            Write += (i + 1).ToString() + "\tThaiTea\t\t\t45฿" + Environment.NewLine;
            total_price += 25;
            tb_total.Text = total_price.ToString() + ".00 ฿";
            s_item_no[i] = (i + 1).ToString();
            s_item_name[i] = "ThaiTea";
            s_item_price[i] = "25";
            Addlist();
            i++;
        }

        private void bt_m_mt_Click(object sender, EventArgs e)
        {
            Write += (i + 1).ToString() + "\tMilkTea\t\t\t45฿" + Environment.NewLine;
            total_price += 25;
            tb_total.Text = total_price.ToString() + ".00 ฿";
            s_item_no[i] = (i + 1).ToString();
            s_item_name[i] = "MilkTea";
            s_item_price[i] = "25";
            Addlist();
            i++;
        }

        private void bt_m_lt_Click(object sender, EventArgs e)
        {
            Write += (i + 1).ToString() + "\tLemonTea\t\t45฿" + Environment.NewLine;
            total_price += 25;
            tb_total.Text = total_price.ToString() + ".00 ฿";
            s_item_no[i] = (i + 1).ToString();
            s_item_name[i] = "LemonTea";
            s_item_price[i] = "25";
            Addlist();
            i++;
        }

        private void bt_m_mi_Click(object sender, EventArgs e)
        {
            Write += (i + 1).ToString() + "\tMilk\t\t\t45฿" + Environment.NewLine;
            total_price += 25;
            tb_total.Text = total_price.ToString() + ".00 ฿";
            s_item_no[i] = (i + 1).ToString();
            s_item_name[i] = "Milk";
            s_item_price[i] = "25";
            Addlist();
            i++;
        }

        private void bt_m_co_Click(object sender, EventArgs e)
        {
            Write += (i + 1).ToString() + "\tCocoa\t\t\t45฿" + Environment.NewLine;
            total_price += 25;
            tb_total.Text = total_price.ToString() + ".00 ฿";
            s_item_no[i] = (i + 1).ToString();
            s_item_name[i] = "Cocoa";
            s_item_price[i] = "25";
            Addlist();
            i++;
        }

        private void bt_m_mil_Click(object sender, EventArgs e)
        {
            Write += (i + 1).ToString() + "\tMilo\t\t\t45฿" + Environment.NewLine;
            total_price += 25;
            tb_total.Text = total_price.ToString() + ".00 ฿";
            s_item_no[i] = (i + 1).ToString();
            s_item_name[i] = "Milo";
            s_item_price[i] = "25";
            Addlist();
            i++;
        }

        private void bt_m_nc_Click(object sender, EventArgs e)
        {
            Write += (i + 1).ToString() + "\tNescafe\t\t\t45฿" + Environment.NewLine;
            total_price += 25;
            tb_total.Text = total_price.ToString() + ".00 ฿";
            s_item_no[i] = (i + 1).ToString();
            s_item_name[i] = "Nescafe";
            s_item_price[i] = "25";
            Addlist();
            i++;
        }

        private void bt_m_nt_Click(object sender, EventArgs e)
        {
            Write += (i + 1).ToString() + "\tNestea\t\t\t45฿" + Environment.NewLine;
            total_price += 25;
            tb_total.Text = total_price.ToString() + ".00 ฿";
            s_item_no[i] = (i + 1).ToString();
            s_item_name[i] = "Nestea";
            s_item_price[i] = "25";
            Addlist();
            i++;
        }

        private void bt_m_is_Click(object sender, EventArgs e)
        {
            Write += (i + 1).ToString() + "\tItalian Soda\t\t45฿" + Environment.NewLine;
            total_price += 25;
            tb_total.Text = total_price.ToString() + ".00 ฿";
            s_item_no[i] = (i + 1).ToString();
            s_item_name[i] = "Italian Soda";
            s_item_price[i] = "25";
            Addlist();
            i++;
        }

        private void bt_m_rls_Click(object sender, EventArgs e)
        {
            Write += (i + 1).ToString() + "\tRed lime Soda\t\t45฿" + Environment.NewLine;
            total_price += 25;
            tb_total.Text = total_price.ToString() + ".00 ฿";
            s_item_no[i] = (i + 1).ToString();
            s_item_name[i] = "Red lime Soda";
            s_item_price[i] = "25";
            Addlist();
            i++;
        }

        private void bt_m_hls_Click(object sender, EventArgs e)
        {
            Write += (i + 1).ToString() + "\tHoney lime Soda\t\t45฿" + Environment.NewLine;
            total_price += 25;
            tb_total.Text = total_price.ToString() + ".00 ฿";
            s_item_no[i] = (i + 1).ToString();
            s_item_name[i] = "Honey lime Soda";
            s_item_price[i] = "25";
            Addlist();
            i++;
        }

        private void bt_clr_Click(object sender, EventArgs e)
        {
            i = 0;
            total_price=0;
            tb_total.Text = string.Empty;
            listview_detail.Items.Clear();
            Write = "============================================" + Environment.NewLine + "No.\tMenu\t\t\tPrice" + Environment.NewLine + "============================================" + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Addlist()
        {
            ListViewItem es = new ListViewItem();
            es.Text = ""+s_item_no[i];
            es.SubItems.Add(s_item_name[i]);
            es.SubItems.Add(s_item_price[i]);
            listview_detail.Items.Add(es);
            
        }

        private void bt_pay_Click(object sender, EventArgs e)
        {
            billname = "Bill/Bill" + (j)+".txt";
            word_total = Environment.NewLine+ "Total\t\t\t\t" + total_price.ToString()+" ฿";
            File.WriteAllText(billname, "Date/Time : "+DateTime.Now+Environment.NewLine + Write + word_total);
            j++;
            MessageBox.Show("ชำระเงินสำเร็จ!!"+Environment.NewLine+"บันทึกข้อมูลไว้ที่"+billname +" เรียบร้อย","ชำระเงินสำเร็จ");
            i = 0;
            total_price = 0;
            tb_total.Text = string.Empty;
            listview_detail.Items.Clear();
            Write = "============================================" + Environment.NewLine + "No.\tMenu\t\t\tPrice" + Environment.NewLine + "============================================" + Environment.NewLine;
        }
    }
}
