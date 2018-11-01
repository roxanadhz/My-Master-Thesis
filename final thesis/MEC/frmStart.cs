using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace MEC
{
    public partial class frmStart : Form
    {
        class count_bud
        {
            public string name { set; get; }
            public int count { set; get; }
            public ulong bud { set; get; }
        }
        private static List<count_bud> dinamicTools = new List<count_bud>();
        public frmStart()
        {
            InitializeComponent();
        }
        
        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtRepeatation.Text.Length > 0 & txtBudget.Text.Length > 0)
            {
                count_bud item = new count_bud()
                {
                    name = cmbTools.Text,
                    count = Convert.ToInt16(txtRepeatation.Text),
                    bud = Convert.ToUInt32(txtBudget.Text)
                };
                dinamicTools.Add(item);
                showlist(cmbTools.Text);
            }
            txtRepeatation.Clear();
            txtBudget.Clear();
            txtRepeatation.Select();
        }

        public void showlist (string name)//نمایش رکوردهای آرایه در listviw
        {
            lsvGoals.Items.Clear();
            foreach (count_bud item in dinamicTools)
            {
                if (item.name == name)
                {
                    ListViewItem row = new ListViewItem(Convert.ToString(item.count));
                    row.SubItems.Add(Convert.ToString(item.bud));
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
                    foreach (count_bud i in dinamicTools)//find tool in array
                    {
                        if (i.name == text)
                            flag = true;
                    }
                    if (flag == true)
                    {
                        writer.WriteStartElement("tool");
                        writer.WriteAttributeString("name", text);
                        foreach (count_bud item in dinamicTools)
                        {
                            if (item.name == text)
                            {
                                writer.WriteStartElement("repeat");
                                writer.WriteAttributeString("count", Convert.ToString(item.count));
                                writer.WriteElementString("bud", Convert.ToString(item.bud));
                                writer.WriteElementString("und", "1");
                                writer.WriteElementString("knd", "1");
                                writer.WriteElementString("fav", "1");
                                writer.WriteElementString("exp", "1");
                                writer.WriteElementString("exc", "1");
                                writer.WriteElementString("roy", "1");
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
    }
}
