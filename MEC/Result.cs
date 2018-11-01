using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MEC
{
    public partial class Result : Form
    {
        public List<cell> BaseForResult = new List<cell>();
        private cell[,] aCells;
        private List<List<cell>> Matrix = new List<List<cell>>();
        public byte kind;
        public float undValue, kndValue, favValue, expValue, excValue, royValue;
        private Random random = new Random();// عدد تصادفی برای تقاطع
        public Result()
        {
            InitializeComponent();
        }

        private void TolidMesl()
        {
            int maxMatrix = Matrix.Count;
            int maxTemp = Matrix[0].Count;//بدست آوردن بازه سلولها
            int minTemp = random.Next(Matrix[0].Count);//محل تقاطع
            listBox1.Items.Add(Convert.ToString(minTemp));
            for (int i = 0; i < maxMatrix / 2; i++)
            {
                List<cell> temp1 = new List<cell>();
                List<cell> temp2 = new List<cell>();
                temp1.AddRange(Matrix[i]);
                temp2.AddRange(Matrix[maxMatrix - i - 1]);
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
       private Color ListPrint(Color randomColor)
       {
           for (int i = 0; i < Matrix.Count; i++)
           {
               List<cell> tr = new List<cell>();
               tr.AddRange(Matrix[i]);
               ListViewItem row = new ListViewItem(i.ToString());
               foreach (cell c in tr)
               {
                   row.SubItems.Add(Convert.ToString(c.bol));
                   row.SubItems.Add(Convert.ToString(c.bud));
               }
               row.BackColor = randomColor;
               lsvArray.Items.Add(row);
           }
           return randomColor;
       }

        private void button4_Click(object sender, EventArgs e)
        {
            float lastvalue;
            ulong lastbud;
            for (int intRepeat = 1; intRepeat <= Convert.ToInt16(txtRepeat.Text); intRepeat++)
            {
                //رنگ رندوم
                Random randomGen = new Random();
                KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
                KnownColor randomColorName = names[randomGen.Next(names.Length)];
                Color randomColor = Color.FromKnownColor(randomColorName);
                //----------------------------------------------------------
                List<value> lstValue = new List<value>();
                calcValue(lstValue);// محاسبه مقدار هر كرموزوم
                List<value> o = (from l in lstValue
                                 where l.bud <= Convert.ToUInt32(txtMaxBud.Text)
                                 orderby l.vl descending, l.bud
                                 select l).ToList();
                List<value> order = o.Take(200).ToList(); // پيدا كردن بهترين ها

                List<List<cell>> tempList = new List<List<cell>>();
                foreach (value i in order)
                    tempList.Add(Matrix[i.index]);

                Matrix.Clear();
                Matrix = tempList;
                //------------------------
                TolidMesl();
                randomColor = ListPrint(randomColor);
                // محاسبه مقدار هر كرموزوم
                lstValue.Clear();
                calcValue(lstValue);
                foreach (value a1 in lstValue)
                {
                    ListViewItem row = new ListViewItem(a1.vl.ToString());
                    row.SubItems.Add(a1.bud.ToString());
                    lsvValue.Items.Add(row);
                }
            }
            List<cell> tr = new List<cell>();
            tr.AddRange(Matrix[0]);
            lastvalue = 0;
            lastbud = 0;
            foreach (cell c in tr)
               {
                   if (c.bol == 1)
                   {
                       txtResult.Text += c.toolname + " (" + c.bud + ") ,";
                       lastvalue += c.value;
                       lastbud += c.bud;
                   }
               }
            txtResult.Text += " = ارزش " + lastvalue + "و بودجه " + lastbud;
        }

        private void calcValue(List<value> lstValue)
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                List<cell> t = new List<cell>();
                t.AddRange(Matrix[i]);
                float vsum = 0;
                ulong vbud = 0;
                foreach (cell a in t)
                {
                    vbud += (ulong)a.bol * a.bud;
                    vsum += a.bol * a.value;
                }
                value v = new value() { index = i, vl = vsum, bud = vbud };
                lstValue.Add(v);
            }
        }

        private void lsvArray_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = lsvArray.FocusedItem.Index;
            lsvValue.Items[a].Focused = true;
            lsvValue.Items[a].Selected = true;
        }

        private void lsvValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Result_Load(object sender, EventArgs e)
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
                X.value = undValue * i.und + kndValue * i.knd + favValue * i.fav + expValue * i.exp + excValue * i.exc + royValue * i.roy;
                X.bud = i.bud;
                BaseForResult.Add(X);
            }
            lsvArray.Clear();
            lsvArray.Columns.Add("ردیف");
            List<int> max = new List<int>();//به دست آوردن بيشترين تكرار يك ابزار براي تشكيل ايندكس آرايه
            foreach (string str in ToolName)
            {
                lsvArray.Columns.Add(str + " بود/نبود");
                lsvArray.Columns.Add(str + " بودجه");
                //میتونیم از linq استفاده کنیم
                max.Add((from p in BaseForResult where p.toolname == str select p).Count());
            }

            aCells = new cell[max.Max(), ToolName.Count];//فضا سازي براي آرايه

            cell = BaseForResult.ElementAt(0);
            string t = cell.toolname;
            BaseForResult.RemoveAt(0);
            int iIndex = 0, jIndex = 0;
            aCells[iIndex, jIndex] = cell;
            foreach (cell c in BaseForResult)
            {
                if (c.toolname == t)
                    iIndex++;
                else
                {
                    jIndex++;
                    iIndex = 0;
                    t = c.toolname;
                }
                aCells[iIndex, jIndex] = c;
            }

            //تا اينجا آرايه پر شد
            for (int counteri = 0; counteri < max.Max(); counteri++)
            {
                List<cell> track = new List<cell>();
                for (int counterj = 0; counterj < ToolName.Count; counterj++)
                {
                    if (aCells[counteri, counterj].toolname == null)//اگه سلول خالي باشه پرش ميكنه
                    {
                        aCells[counteri, counterj] = aCells[counteri - 1, counterj];
                    }
                    track.Add(aCells[counteri, counterj]);//اضافه كردن 
                }
                Matrix.Add(track);
            }

            //-------------------------------------------------------------------------
            //مرحله دوم
            //-------------------------------------------------------------------------
            int max2 = Matrix.Count;

            //رنگ رندوم
            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            Color randomColor = Color.FromKnownColor(randomColorName);
            //----------------------------------
            //اضافه كردن ابزارها با مقداردهي صفر
            for (int i = 0; i < max2; i++)
            {
                List<cell> track = new List<cell>();
                track.AddRange(Matrix[i]);
                for (int j = 0; j < track.Count; j++)
                {
                    cell temp2 = track[j];
                    temp2.bol = 0;//****!!!!
                    track[j] = temp2;
                }
                Matrix.Add(track);
            }
            //نمايش در ليست
            ListPrint(randomColor);
            // محاسبه مقدار هر كرموزوم
            List<value> lstValue = new List<value>();
            calcValue(lstValue);
            foreach (value a1 in lstValue)
            {
                ListViewItem row = new ListViewItem(a1.vl.ToString());
                row.SubItems.Add(a1.bud.ToString());
                lsvValue.Items.Add(row);
            }

            //-------------------------------------------------------------------------
            //مرحله سوم
            //-------------------------------------------------------------------------
            while (Matrix.Count < 200)
                TolidMesl();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }          
    }
}
class value
{
    public float vl { get; set; }
    public int index { get; set; }
    public ulong bud { get; set; }
}