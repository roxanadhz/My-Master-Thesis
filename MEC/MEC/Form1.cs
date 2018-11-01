using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

public struct cell
{
    public string toolname;
    public int value,bol;
    public ulong bud;

    public cell(string toolname, int bol,int value, ulong bud)
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
        
        private void btnReg_Click(object sender, EventArgs e)
        {
           // cell[] celul = new cell[18];
            if (txtRepeatation.Text.Length > 0 & txtBudget.Text.Length > 0)
            {
            tool item;
            item.name=cmbTools.Text ;
            item.count=Convert.ToInt16(txtRepeatation.Text);
            item.bud=Convert.ToUInt32(txtBudget.Text);
            item.und=Convert.ToByte(cmbUnderstanding.Text);
            item.knd=Convert.ToByte(cmbKnd.Text);
            item.fav=Convert.ToByte(cmbFav.Text);
            item.exp=Convert.ToByte(cmbExp.Text);
            item.exc=Convert.ToByte(cmbExc.Text);
            item.roy=Convert.ToByte(cmbRoy.Text);
            dinamicTools.Add(item);
            showlist(cmbTools.Text);
            }
            txtRepeatation.Clear();
            txtBudget.Clear();
            txtRepeatation.Select();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader("Data.xml");
            dinamicTools.Clear();
            
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "tool")
                {
                    tool Item = new tool();
                    Item.name = reader.GetAttribute(0);
                    while (reader.NodeType != XmlNodeType.EndElement)
                    {
                        reader.Read();
                        if (reader.Name == "repeat")
                        {
                            Item.count = Convert.ToInt16(reader.GetAttribute(0));
                            while (reader.NodeType != XmlNodeType.EndElement)
                            {
                                reader.Read();
                                if (reader.Name == "bud")
                                {
                                    while (reader.NodeType != XmlNodeType.EndElement)
                                    {
                                        reader.Read();
                                        if (reader.NodeType == XmlNodeType.Text)
                                            Item.bud=Convert.ToUInt32(reader.Value);
                                    }
                                    reader.Read();
                                } //end if bud
                                if (reader.Name == "und")
                                {
                                    while (reader.NodeType != XmlNodeType.EndElement)
                                    {
                                        reader.Read();
                                        if (reader.NodeType == XmlNodeType.Text)
                                            Item.und = Convert.ToByte(reader.Value);
                                    }
                                    reader.Read();
                                } //end if und
                                if (reader.Name == "knd")
                                {
                                    while (reader.NodeType != XmlNodeType.EndElement)
                                    {
                                        reader.Read();
                                        if (reader.NodeType == XmlNodeType.Text)
                                            Item.knd = Convert.ToByte(reader.Value);
                                    }
                                    reader.Read();
                                } //end if knd
                                if (reader.Name == "fav")
                                {
                                    while (reader.NodeType != XmlNodeType.EndElement)
                                    {
                                        reader.Read();
                                        if (reader.NodeType == XmlNodeType.Text)
                                            Item.fav = Convert.ToByte(reader.Value);
                                    }
                                    reader.Read();
                                } //end if fav
                                if (reader.Name == "exp")
                                {
                                    while (reader.NodeType != XmlNodeType.EndElement)
                                    {
                                        reader.Read();
                                        if (reader.NodeType == XmlNodeType.Text)
                                            Item.exp = Convert.ToByte(reader.Value);
                                    }
                                    reader.Read();
                                } //end if exp
                                if (reader.Name == "exc")
                                {
                                    while (reader.NodeType != XmlNodeType.EndElement)
                                    {
                                        reader.Read();
                                        if (reader.NodeType == XmlNodeType.Text)
                                            Item.exc = Convert.ToByte(reader.Value);
                                    }
                                    reader.Read();
                                } //end if exc
                                if (reader.Name == "roy")
                                {
                                    while (reader.NodeType != XmlNodeType.EndElement)
                                    {
                                        reader.Read();
                                        if (reader.NodeType == XmlNodeType.Text)
                                            Item.roy = Convert.ToByte(reader.Value);
                                    }
                                    reader.Read();
                                } //end if roy
                            }
                            reader.Read();
                            dinamicTools.Add(Item);
                        }
                    }
                }
            }
            reader.Close();
            MessageBox.Show("فایل بارگذاری شد", "بارگذاری");
            showlist(cmbTools.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> toolname = new List<string>();
            foreach (tool item in dinamicTools)
            {
                toolname.Add(item.name);
            }
                
            lblCount.Text = toolname.Distinct().Count().ToString();
            //lblS.Text = dinamicTools.OrderBy<
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result r = new Result();
            r.ShowDialog();
        }

    }
}
