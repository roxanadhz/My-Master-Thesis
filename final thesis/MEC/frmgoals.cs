using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;

namespace MEC
{
    public partial class frmgoals : Form
    {
        public frmgoals()
        {
            InitializeComponent();
        }
        class goals
        {
            public string name { get; set; }
            public byte und { get; set; }
            public byte knd { get; set; }
            public byte fav { get; set; }
            public byte exp { get; set; }
            public byte exc { get; set; }
            public byte roy { get; set; }
        }
        List<goals> listGoals = new List<goals>();
        goals newItem = new goals();
        goals oldItem = new goals();
        double a1, a2, a3, a4, a5, a6;
        private void frmgoals_Load(object sender, EventArgs e)
        {
            listGoals.Clear();
            XDocument Goals = XDocument.Load("Goals.xml");
            IEnumerable<XElement> Goal = Goals.Element("Goals").Elements("Goal");
            foreach (XElement G in Goal)
            {
                goals Item = new goals();
                Item.name = G.Element("name").Value;
                Item.und = Convert.ToByte(G.Element("und").Value);
                Item.knd = Convert.ToByte(G.Element("knd").Value);
                Item.fav = Convert.ToByte(G.Element("fav").Value);
                Item.exp = Convert.ToByte(G.Element("exp").Value);
                Item.exc = Convert.ToByte(G.Element("exc").Value);
                Item.roy = Convert.ToByte(G.Element("roy").Value);
                listGoals.Add(Item);
            }
            fillLSV();
            clear();
        }

        private void fillLSV()
        {
            goals Total = new goals { name = "درصد" };
            int total;
            lsvGoals.Items.Clear();
            foreach (goals item in listGoals)
            {
                Total.und += item.und;
                Total.knd += item.knd;
                Total.fav += item.fav;
                Total.exp += item.exc;
                Total.exc += item.exc;
                Total.roy += item.roy;
            }
            total = Total.und + Total.knd + Total.fav + Total.exp + Total.exc + Total.roy;

            foreach (goals item in listGoals)
            {
                ListViewItem row = new ListViewItem(item.name);
                row.SubItems.Add(Convert.ToString(item.und));
                row.SubItems.Add(Convert.ToString(item.knd));
                row.SubItems.Add(Convert.ToString(item.fav));
                row.SubItems.Add(Convert.ToString(item.exp));
                row.SubItems.Add(Convert.ToString(item.exc));
                row.SubItems.Add(Convert.ToString(item.roy));
                lsvGoals.Items.Add(row);
            }
            a1 = Math.Round((double)Total.und / total, 2);
            a2 = Math.Round((double)Total.knd / total, 2);
            a3 = Math.Round((double)Total.fav / total, 2);
            a4 = Math.Round((double)Total.exp / total, 2);
            a5 = Math.Round((double)Total.exc / total, 2);
            a6 = 1 - (a1 + a2 + a3 + a4 + a5);
            ListViewItem r = new ListViewItem(Total.name);
            r.SubItems.Add(Convert.ToString(a1));
            r.SubItems.Add(Convert.ToString(a2));
            r.SubItems.Add(Convert.ToString(a3));
            r.SubItems.Add(Convert.ToString(a4));
            r.SubItems.Add(Convert.ToString(a5));
            r.SubItems.Add(Convert.ToString(a6));
            lsvGoals.Items.Add(r);
        }

        private void lsvGoals_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = lsvGoals.FocusedItem.Index;
            if (!lsvGoals.Items[a].Text.Equals("درصد"))
            {
                txtName.Text = Convert.ToString(listGoals[a].name);
                cmbUnd.Text = Convert.ToString(listGoals[a].und);
                cmbKnd.Text = Convert.ToString(listGoals[a].knd);
                cmbFav.Text = Convert.ToString(listGoals[a].fav);
                cmbExp.Text = Convert.ToString(listGoals[a].exp);
                cmbExc.Text = Convert.ToString(listGoals[a].exc);
                cmbRoy.Text = Convert.ToString(listGoals[a].roy);
                oldItem = listGoals[a];
                newItem = oldItem;
                enable();
            };

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            newItem.und = Convert.ToByte(cmbUnd.Text);
            newItem.knd = Convert.ToByte(cmbKnd.Text);
            newItem.fav = Convert.ToByte(cmbFav.Text);
            newItem.exp = Convert.ToByte(cmbExp.Text);
            newItem.exc = Convert.ToByte(cmbExc.Text);
            newItem.roy = Convert.ToByte(cmbRoy.Text);
            if (!oldItem.Equals(newItem))
                listGoals[listGoals.IndexOf(oldItem)] = newItem;
            
            fillLSV();
            clear();
        }
        private void clear()
        {
            txtName.Clear();
            cmbUnd.Text = "";
            cmbKnd.Text = "";
            cmbFav.Text = "";
            cmbExp.Text = "";
            cmbExc.Text = "";
            cmbRoy.Text = "";
            cmbUnd.Enabled = false;
            cmbKnd.Enabled = false;
            cmbFav.Enabled = false;
            cmbExp.Enabled = false;
            cmbExc.Enabled = false;
            cmbRoy.Enabled = false;
            btnReg.Enabled = false;
        }
        private void enable()
        {
            cmbUnd.Enabled = true;
            cmbKnd.Enabled = true;
            cmbFav.Enabled = true;
            cmbExp.Enabled = true;
            cmbExc.Enabled = true;
            cmbRoy.Enabled = true;
            btnReg.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.Encoding = Encoding.UTF8;
            XmlWriter writer = XmlWriter.Create("Goals.xml", settings);

            writer.WriteStartDocument();
            writer.WriteStartElement("Goals");
            foreach (goals item in listGoals)
            {
                writer.WriteStartElement("Goal");
                writer.WriteElementString("name", Convert.ToString(item.name));
                writer.WriteElementString("und", Convert.ToString(item.und));
                writer.WriteElementString("knd", Convert.ToString(item.knd));
                writer.WriteElementString("fav", Convert.ToString(item.fav));
                writer.WriteElementString("exp", Convert.ToString(item.exp));
                writer.WriteElementString("exc", Convert.ToString(item.exc));
                writer.WriteElementString("roy", Convert.ToString(item.roy));
                writer.WriteEndElement();
            }
            writer.WriteStartElement("Total");
            writer.WriteElementString("und", Convert.ToString(a1));
            writer.WriteElementString("knd", Convert.ToString(a2));
            writer.WriteElementString("fav", Convert.ToString(a3));
            writer.WriteElementString("exp", Convert.ToString(a4));
            writer.WriteElementString("exc", Convert.ToString(a5));
            writer.WriteElementString("roy", Convert.ToString(a6));
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
            MessageBox.Show("فایل ذخیره شد", "ذخیره");
        }
    }
}
