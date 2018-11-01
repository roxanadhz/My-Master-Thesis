using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

public struct cell
{
    public string toolname;
    public int bol;
    public float value;
    public ulong bud;

    public cell(string toolname, int bol,float value, ulong bud)
    {
        this.toolname = toolname;
        this.bol = bol;
        this.value = value;
        this.bud = bud;
    }
}
public struct tool
{
    public string name;
    public int count;
    public ulong bud;
    public byte und, knd, fav, exp, exc, roy;

    public tool(string name, int count, ulong bud, byte und, byte knd, byte fav, byte exp, byte exc, byte roy)
    {
        this.name = name;
        this.count = count;
        this.bud = bud;
        this.und = und;
        this.knd = knd;
        this.fav = fav;
        this.exp = exp;
        this.exc = exc;
        this.roy = roy;
    }
}

namespace MEC
{
    public partial class Form1 : Form
    {
        public static List<tool> dinamicTools = new List<tool>();
        public Form1()
        {
            InitializeComponent();
        }
        tool oldItem, newItem;
        string a1, a2, a3, a4, a5, a6;
        private void btnReg_Click(object sender, EventArgs e)
        {
            newItem.und = Convert.ToByte(cmbUnderstanding.Text);
            newItem.knd = Convert.ToByte(cmbKnd.Text);
            newItem.fav = Convert.ToByte(cmbFav.Text);
            newItem.exp = Convert.ToByte(cmbExp.Text);
            newItem.exc = Convert.ToByte(cmbExc.Text);
            newItem.roy = Convert.ToByte(cmbRoy.Text);
            if (!oldItem.Equals(newItem))
                dinamicTools[dinamicTools.IndexOf(oldItem)] = newItem;
                
            showlist(cmbTools.Text);
            clear();
        }
        public void showlist (string name)//نمایش رکوردهای آرایه در listviw
        {
            lsvGoals.Items.Clear();
            foreach (tool item in dinamicTools)
            {
                if (item.name == name)
                {
                    ListViewItem row = new ListViewItem(Convert.ToString(item.count));
                    row.SubItems.Add(Convert.ToString(item.bud));
                    row.SubItems.Add(Convert.ToString(item.und));
                    row.SubItems.Add(Convert.ToString(item.knd));
                    row.SubItems.Add(Convert.ToString(item.fav));
                    row.SubItems.Add(Convert.ToString(item.exp));
                    row.SubItems.Add(Convert.ToString(item.exc));
                    row.SubItems.Add(Convert.ToString(item.roy));
                    lsvGoals.Items.Add(row);
                }
            }

        }

        private void cmbTools_SelectedIndexChanged(object sender, EventArgs e)
        {
            showlist(cmbTools.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean flag;
            XmlWriterSettings settings = new XmlWriterSettings();

            settings.Indent = true;
            settings.Encoding = Encoding.UTF8;

            if (dinamicTools.Count > 1)
            {
                XmlWriter writer = XmlWriter.Create("Data.xml", settings);

                writer.WriteStartDocument();
                writer.WriteStartElement("tools");
                foreach (string text in cmbTools.Items)
                {
                    flag = false;
                    foreach (tool i in dinamicTools)//find tool in array
                    {
                        if (i.name == text)
                            flag = true;
                    }
                    if (flag == true)
                    {
                        writer.WriteStartElement("tool");
                        writer.WriteAttributeString("name", text);
                        foreach (tool item in dinamicTools)
                        {
                            if (item.name == text)
                            {
                                writer.WriteStartElement("repeat");
                                writer.WriteAttributeString("count", Convert.ToString(item.count));
                                writer.WriteElementString("bud", Convert.ToString(item.bud));
                                writer.WriteElementString("und", Convert.ToString(item.und));
                                writer.WriteElementString("knd", Convert.ToString(item.knd));
                                writer.WriteElementString("fav", Convert.ToString(item.fav));
                                writer.WriteElementString("exp", Convert.ToString(item.exp));
                                writer.WriteElementString("exc", Convert.ToString(item.exc));
                                writer.WriteElementString("roy", Convert.ToString(item.roy));
                                writer.WriteEndElement();
                            }
                        }
                        writer.WriteEndElement();
                    }
                }

                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();
                MessageBox.Show("فایل ذخیره شد", "ذخیره");
            }
            else
            {
                MessageBox.Show("لطفا لیست را پر کنید", "ذخیره");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (chkUnd.Checked || chkKnd.Checked || chkFav.Checked || chkExp.Checked || chkExc.Checked || chkRoy.Checked)
            {
                float v1,v2,v3,v4,v5,v6;
                v1 = v2 = v3 = v4 = v5 = v6 = 0;
                if (chkUnd.Checked)
                    v1 = Convert.ToSingle(chkUnd.Tag);
                if (chkKnd.Checked)
                    v2 = Convert.ToSingle(chkKnd.Tag);
                if (chkFav.Checked)
                    v3 = Convert.ToSingle(chkFav.Tag);
                if (chkExp.Checked)
                    v4 = Convert.ToSingle(chkExp.Tag);
                if (chkExc.Checked)
                    v5 = Convert.ToSingle(chkExc.Tag);
                if (chkRoy.Checked)
                    v6 = Convert.ToSingle(chkRoy.Tag);
                Result r = new Result() { undValue=v1,kndValue=v2,favValue=v3,expValue=v4,excValue=v5,royValue=v6 };
                r.ShowDialog();
            }
            else
            {
                MessageBox.Show("لطفا گزینه ای را انتخاب کنید", "اخطار");
            }
        }

        private void lsvGoals_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = lsvGoals.FocusedItem.Index;
            txtRepeatation.Text = lsvGoals.Items[a].Text;
            txtBudget.Text = lsvGoals.Items[a].SubItems[1].Text;
            cmbUnderstanding.Text = lsvGoals.Items[a].SubItems[2].Text;
            cmbKnd.Text = lsvGoals.Items[a].SubItems[3].Text;
            cmbFav.Text = lsvGoals.Items[a].SubItems[4].Text;
            cmbExp.Text = lsvGoals.Items[a].SubItems[5].Text;
            cmbExc.Text = lsvGoals.Items[a].SubItems[6].Text;
            cmbRoy.Text = lsvGoals.Items[a].SubItems[7].Text;
            oldItem = (from item in dinamicTools
                       where item.name == cmbTools.Text &
                       item.count == Convert.ToInt32(lsvGoals.Items[a].Text)
                       select item).FirstOrDefault();
            newItem = oldItem;
            enable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dinamicTools.Clear();
            loadData();
            showlist(cmbTools.Text);
            loadTotal();
            chkUnd.Text = label1.Text += " (" + a1 + ")";
            chkKnd.Text = label2.Text += " (" + a2 + ")";
            chkFav.Text = label3.Text += " (" + a3 + ")";
            chkExp.Text = label4.Text += " (" + a4 + ")";
            chkExc.Text = label5.Text += " (" + a5 + ")";
            chkRoy.Text = label6.Text += " (" + a6 + ")";
            chkUnd.Tag = a1;
            chkKnd.Tag = a2;
            chkFav.Tag = a3;
            chkExp.Tag = a4;
            chkExc.Tag = a5;
            chkRoy.Tag = a6;
            clear();
        }

        private void loadData()
        {
            XDocument Data = XDocument.Load("Data.xml");
            XElement Tools = Data.Element("tools");
            IEnumerable<XElement> Tool = Tools.Elements("tool");
            foreach (XElement t in Tool)
            {
                tool Item =new tool();
                Item.name = t.Attribute("name").Value;
                IEnumerable<XElement> repeat = t.Elements("repeat");
                foreach (XElement re in repeat)
                {
                    Item.count = Convert.ToInt32(re.Attribute("count").Value);
                    Item.bud = Convert.ToUInt32(re.Element("bud").Value);
                    Item.und = Convert.ToByte(re.Element("und").Value);
                    Item.knd = Convert.ToByte(re.Element("knd").Value);
                    Item.fav = Convert.ToByte(re.Element("fav").Value);
                    Item.exp = Convert.ToByte(re.Element("exp").Value);
                    Item.exc = Convert.ToByte(re.Element("exc").Value);
                    Item.roy = Convert.ToByte(re.Element("roy").Value);
                    dinamicTools.Add(Item);
                }
            }
        }
        private void loadTotal()
        {
            XDocument goals = XDocument.Load("Goals.xml");
            XElement total = goals.Element("Goals").Element("Total");
            a1 = total.Element("und").Value;
            a2 = total.Element("knd").Value;
            a3 = total.Element("fav").Value;
            a4 = total.Element("exp").Value;
            a5 = total.Element("exc").Value;
            a6 = total.Element("roy").Value;
        }
        private void enable()
        {
            cmbUnderstanding.Enabled = true;
            cmbKnd.Enabled = true;
            cmbFav.Enabled = true;
            cmbExp.Enabled = true;
            cmbExc.Enabled = true;
            cmbRoy.Enabled = true;
            btnReg.Enabled = true;
        }
        private void clear()
        {
            txtRepeatation.Clear();
            txtBudget.Clear();
            cmbUnderstanding.Text = "";
            cmbKnd.Text = "";
            cmbFav.Text = "";
            cmbExp.Text = "";
            cmbExc.Text = "";
            cmbRoy.Text = "";
            cmbUnderstanding.Enabled = false;
            cmbKnd.Enabled = false;
            cmbFav.Enabled = false;
            cmbExp.Enabled = false;
            cmbExc.Enabled = false;
            cmbRoy.Enabled = false;
            btnReg.Enabled = false;
        }
    }
}
