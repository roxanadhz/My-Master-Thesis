using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public struct value
{
    public int vl, index;
    public ulong bud;

    public value(int index,int vl, ulong bud)
    {
        this.index = index;
        this.vl = vl;
        this.bud = bud;
    }
}
namespace MEC
{
    public partial class Result : Form
    {
        public List<cell> BaseForResult = new List<cell>();
        private cell[,] aCells;
        private List<List<cell>> Matrix = new List<List<cell>>();
        public Result()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            List<string> temp = new List<string>();
            cell cell;
            
            foreach (tool i in Form1.dinamicTools)
            {
                temp.Add(i.name); // بدست آوردن نام ابزارهاي پر شده
            }
            List<string> ToolName = new List<string>(temp.Distinct().ToList());
            
            foreach (tool i in Form1.dinamicTools)//پر كردن سلول ها
            {
                cell X;
                X.toolname = i.name;
                X.bol = 1;
                X.value = i.und;
                X.bud = i.bud;
                BaseForResult.Add(X);
            }
            lsvArray.Clear();
            lsvArray.Columns.Add("ردیف");
            List<int> max = new List<int>();
            foreach (string str in ToolName)
            {
                lsvArray.Columns.Add(str + " 0");
                lsvArray.Columns.Add(str + " 1");
                lsvArray.Columns.Add(str + " 2");
                lsvArray.Columns.Add(str + " 3");
                //میتونیم از linq استفاده کنیم
                max.Add((from p in BaseForResult where p.toolname == str select p).Count());

            }

            aCells = new cell[max.Max(), ToolName.Count];
           
            cell = BaseForResult.ElementAt(0);
            string t = cell.toolname;
            BaseForResult.RemoveAt(0);
            int iIndex = 0, jIndex = 0;
            aCells[iIndex, jIndex] = cell;
            foreach (cell c in BaseForResult)
            {
                //MessageBox.Show(c.toolname.ToString(), "ss");
             if (c.toolname==t)
                {
                    iIndex++;
                }
                else
                {
                    jIndex++;
                    iIndex = 0;
                    t = c.toolname;
                }
                aCells[iIndex, jIndex] = c;
            }
            
            for (int counteri = 0; counteri < max.Max();counteri++ )
            {
                ListViewItem row = new ListViewItem(counteri.ToString());
                List<cell> track = new List<cell>();
                for (int counterj = 0; counterj < ToolName.Count ;counterj++ )
                {
                    if ( aCells[counteri, counterj].toolname ==null)//اگه سلول خالي باشه پرش ميكنه
                    {
                        aCells[counteri, counterj] = aCells[counteri-1, counterj];
                    }
                    track.Add(aCells[counteri, counterj]);//اضافه كردن 
                    row.SubItems.Add(aCells[counteri, counterj].toolname);
                    row.SubItems.Add(Convert.ToString(aCells[counteri, counterj].bol));
                    row.SubItems.Add(Convert.ToString(aCells[counteri, counterj].value));
                    row.SubItems.Add(Convert.ToString(aCells[counteri, counterj].bud));
                }
                Matrix.Add(track);
                lsvArray.Items.Add(row);
            }


                // ايجاد كروموزومهاي اوليه
            lsvCell.Clear();
            lsvCell.Columns.Add("نام");
            lsvCell.Columns.Add( "تعداد");
            lsvCell.Columns.Add("بودجه");
            
            foreach (cell c in BaseForResult)
            {
                ListViewItem row = new ListViewItem(c.toolname);
                row.SubItems.Add(Convert.ToString(c.value));
                row.SubItems.Add(Convert.ToString(c.bud));
                row.BackColor = Color.Chartreuse;
                lsvCell.Items.Add(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaseForResult.RemoveAt(Convert.ToInt32(textBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int max = Matrix.Count;
            
            //رنگ رندوم
            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            Color randomColor = Color.FromKnownColor(randomColorName);
            //----------------------------------
            for (int i = 0; i < max; i++)
            {
                List<cell> track = new List<cell>();
                track.AddRange(Matrix[i]);

                for (int j = 0; j < track.Count; j++)
                {
                    cell temp = track[j];
                    temp.bol = 0;
                    track[j]=temp;
                }
                Matrix.Add(track);
            }

            //-------چاپ
            for (int i=0; i < Matrix.Count; i++)
            {
                List<cell> tr = new List<cell>();
                tr.AddRange(Matrix[i]);
                ListViewItem row = new ListViewItem(i.ToString());
                
                foreach(cell c in tr)
                {
                    row.SubItems.Add(c.toolname);
                    row.SubItems.Add(Convert.ToString(c.bol));
                    row.SubItems.Add(Convert.ToString(c.value));
                    row.SubItems.Add(Convert.ToString(c.bud));
                }

                row.BackColor = randomColor;
                lsvArray.Items.Add(row);
 
            }
                                                        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<value> lstValue = new List<value>();
            for (int i = 0; i < Matrix.Count; i++)
            {
                List<cell> t = new List<cell>();
                t.AddRange(Matrix[i]);
                int vsum = 0;
                ulong vbud = 0;
                foreach (cell a in t)
                {
                    vbud += (ulong)a.bol * a.bud;
                    vsum += a.bol * a.value;
                }
                value v = new value(i, vsum, vbud);
                lstValue.Add(v);
            }
            
            List<value> order = (from l in lstValue
                                 //orderby l.vl descending, l.bud
                                 select l).ToList();
            foreach (value c in order)
            {
                ListViewItem row = new ListViewItem(Convert.ToString(c.index));
                row.SubItems.Add(Convert.ToString(c.vl));
                row.SubItems.Add(Convert.ToString(c.bud));                
                lsvCell.Items.Add(row);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            while (Matrix.Count < 100)
            {
                int maxMatrix = Matrix.Count;
                int maxTemp = Matrix[0].Count;//بدست آوردن بازه سلولها
                int minTemp = random.Next(Matrix[0].Count);//محل تقاطع
                for(int i=0;i<maxMatrix/2;i++)
                {
                    List<cell> temp1 = new List<cell>();
                    List<cell> temp2 = new List<cell>();
                    temp1.AddRange(Matrix[i]);
                    temp2.AddRange(Matrix[maxMatrix-i-1]);
                    for (int j = minTemp; j < maxTemp; j++)
                    {
                        cell t1 = temp1[j];//تقاطع
                        cell t2 = temp2[j];
                        temp1[j] = t2;
                        temp2[j] = t1;
                    }
                    Matrix.Add(temp1);
                    Matrix.Add(temp2);
                }
            }
        }
           
    }
}
