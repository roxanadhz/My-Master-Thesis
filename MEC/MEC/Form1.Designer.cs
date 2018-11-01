namespace MEC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTools = new System.Windows.Forms.ComboBox();
            this.gpxGoals = new System.Windows.Forms.GroupBox();
            this.cmbRoy = new System.Windows.Forms.ComboBox();
            this.cmbExc = new System.Windows.Forms.ComboBox();
            this.cmbExp = new System.Windows.Forms.ComboBox();
            this.cmbFav = new System.Windows.Forms.ComboBox();
            this.cmbKnd = new System.Windows.Forms.ComboBox();
            this.cmbUnderstanding = new System.Windows.Forms.ComboBox();
            this.lsvGoals = new System.Windows.Forms.ListView();
            this.clmRep = new System.Windows.Forms.ColumnHeader();
            this.clmBud = new System.Windows.Forms.ColumnHeader();
            this.clmUnd = new System.Windows.Forms.ColumnHeader();
            this.clmKnd = new System.Windows.Forms.ColumnHeader();
            this.clmFav = new System.Windows.Forms.ColumnHeader();
            this.clmExp = new System.Windows.Forms.ColumnHeader();
            this.clmExc = new System.Windows.Forms.ColumnHeader();
            this.clmRoy = new System.Windows.Forms.ColumnHeader();
            this.btnReg = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRepeatation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.تکرار = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.gpxGoals.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTools
            // 
            this.cmbTools.FormattingEnabled = true;
            this.cmbTools.Items.AddRange(new object[] {
            "تلویزیون",
            "رادیو",
            "جراید",
            "مجلات",
            "بیلبورد",
            "فضای مجازی",
            "سمینار",
            "حمایت های مادی معنوی",
            "اخبار",
            "گروه های مرجع",
            "مسئولیت های اجتماعی",
            "هدایا",
            "تسهیلات و تخفیفات",
            "نمایگاه",
            "فروشندگی شخصی",
            "پوستر بوشور و کاتالوگ",
            "رایانامه",
            "پیامک"});
            this.cmbTools.Location = new System.Drawing.Point(756, 9);
            this.cmbTools.Name = "cmbTools";
            this.cmbTools.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbTools.Size = new System.Drawing.Size(194, 21);
            this.cmbTools.TabIndex = 1;
            this.cmbTools.Text = "تلویزیون";
            this.cmbTools.SelectedIndexChanged += new System.EventHandler(this.cmbTools_SelectedIndexChanged);
            // 
            // gpxGoals
            // 
            this.gpxGoals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpxGoals.Controls.Add(this.cmbRoy);
            this.gpxGoals.Controls.Add(this.cmbExc);
            this.gpxGoals.Controls.Add(this.cmbExp);
            this.gpxGoals.Controls.Add(this.cmbFav);
            this.gpxGoals.Controls.Add(this.cmbKnd);
            this.gpxGoals.Controls.Add(this.cmbUnderstanding);
            this.gpxGoals.Controls.Add(this.lsvGoals);
            this.gpxGoals.Controls.Add(this.btnReg);
            this.gpxGoals.Controls.Add(this.label8);
            this.gpxGoals.Controls.Add(this.label6);
            this.gpxGoals.Controls.Add(this.txtRepeatation);
            this.gpxGoals.Controls.Add(this.label5);
            this.gpxGoals.Controls.Add(this.تکرار);
            this.gpxGoals.Controls.Add(this.label4);
            this.gpxGoals.Controls.Add(this.txtBudget);
            this.gpxGoals.Controls.Add(this.label3);
            this.gpxGoals.Controls.Add(this.label2);
            this.gpxGoals.Controls.Add(this.label1);
            this.gpxGoals.Location = new System.Drawing.Point(12, 36);
            this.gpxGoals.Name = "gpxGoals";
            this.gpxGoals.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gpxGoals.Size = new System.Drawing.Size(938, 176);
            this.gpxGoals.TabIndex = 2;
            this.gpxGoals.TabStop = false;
            this.gpxGoals.Text = "اهداف";
            // 
            // cmbRoy
            // 
            this.cmbRoy.FormattingEnabled = true;
            this.cmbRoy.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9"});
            this.cmbRoy.Location = new System.Drawing.Point(90, 43);
            this.cmbRoy.Name = "cmbRoy";
            this.cmbRoy.Size = new System.Drawing.Size(100, 21);
            this.cmbRoy.TabIndex = 9;
            this.cmbRoy.Text = "1";
            // 
            // cmbExc
            // 
            this.cmbExc.FormattingEnabled = true;
            this.cmbExc.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9"});
            this.cmbExc.Location = new System.Drawing.Point(195, 44);
            this.cmbExc.Name = "cmbExc";
            this.cmbExc.Size = new System.Drawing.Size(100, 21);
            this.cmbExc.TabIndex = 8;
            this.cmbExc.Text = "1";
            // 
            // cmbExp
            // 
            this.cmbExp.FormattingEnabled = true;
            this.cmbExp.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9"});
            this.cmbExp.Location = new System.Drawing.Point(301, 44);
            this.cmbExp.Name = "cmbExp";
            this.cmbExp.Size = new System.Drawing.Size(100, 21);
            this.cmbExp.TabIndex = 7;
            this.cmbExp.Text = "1";
            // 
            // cmbFav
            // 
            this.cmbFav.FormattingEnabled = true;
            this.cmbFav.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9"});
            this.cmbFav.Location = new System.Drawing.Point(407, 44);
            this.cmbFav.Name = "cmbFav";
            this.cmbFav.Size = new System.Drawing.Size(100, 21);
            this.cmbFav.TabIndex = 6;
            this.cmbFav.Text = "1";
            // 
            // cmbKnd
            // 
            this.cmbKnd.FormattingEnabled = true;
            this.cmbKnd.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9"});
            this.cmbKnd.Location = new System.Drawing.Point(513, 43);
            this.cmbKnd.Name = "cmbKnd";
            this.cmbKnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbKnd.Size = new System.Drawing.Size(100, 21);
            this.cmbKnd.TabIndex = 5;
            this.cmbKnd.Text = "1";
            // 
            // cmbUnderstanding
            // 
            this.cmbUnderstanding.FormattingEnabled = true;
            this.cmbUnderstanding.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9"});
            this.cmbUnderstanding.Location = new System.Drawing.Point(619, 43);
            this.cmbUnderstanding.Name = "cmbUnderstanding";
            this.cmbUnderstanding.Size = new System.Drawing.Size(100, 21);
            this.cmbUnderstanding.TabIndex = 4;
            this.cmbUnderstanding.Text = "1";
            // 
            // lsvGoals
            // 
            this.lsvGoals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvGoals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmRep,
            this.clmBud,
            this.clmUnd,
            this.clmKnd,
            this.clmFav,
            this.clmExp,
            this.clmExc,
            this.clmRoy});
            this.lsvGoals.Location = new System.Drawing.Point(90, 70);
            this.lsvGoals.Name = "lsvGoals";
            this.lsvGoals.RightToLeftLayout = true;
            this.lsvGoals.Size = new System.Drawing.Size(842, 100);
            this.lsvGoals.TabIndex = 17;
            this.lsvGoals.UseCompatibleStateImageBehavior = false;
            this.lsvGoals.View = System.Windows.Forms.View.Details;
            // 
            // clmRep
            // 
            this.clmRep.Text = "تکرار";
            this.clmRep.Width = 101;
            // 
            // clmBud
            // 
            this.clmBud.Text = "بودجه";
            this.clmBud.Width = 111;
            // 
            // clmUnd
            // 
            this.clmUnd.Text = "آگاهی";
            this.clmUnd.Width = 104;
            // 
            // clmKnd
            // 
            this.clmKnd.Text = "دانش";
            this.clmKnd.Width = 104;
            // 
            // clmFav
            // 
            this.clmFav.Text = "علاقه";
            this.clmFav.Width = 108;
            // 
            // clmExp
            // 
            this.clmExp.Text = "ترجیح";
            this.clmExp.Width = 108;
            // 
            // clmExc
            // 
            this.clmExc.Text = "آزمایش";
            this.clmExc.Width = 99;
            // 
            // clmRoy
            // 
            this.clmRoy.Text = "وفاداری";
            this.clmRoy.Width = 102;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(8, 41);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 10;
            this.btnReg.Text = "ثبت";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(779, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 27);
            this.label8.TabIndex = 16;
            this.label8.Text = "بودجه";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(126, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "وفاداری";
            // 
            // txtRepeatation
            // 
            this.txtRepeatation.Location = new System.Drawing.Point(831, 44);
            this.txtRepeatation.Name = "txtRepeatation";
            this.txtRepeatation.Size = new System.Drawing.Size(100, 20);
            this.txtRepeatation.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(240, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "آزمایش";
            // 
            // تکرار
            // 
            this.تکرار.AutoSize = true;
            this.تکرار.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.تکرار.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.تکرار.Location = new System.Drawing.Point(888, 15);
            this.تکرار.Name = "تکرار";
            this.تکرار.Size = new System.Drawing.Size(38, 27);
            this.تکرار.TabIndex = 15;
            this.تکرار.Text = "تکرار";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(349, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "ترجیح";
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(725, 44);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(100, 20);
            this.txtBudget.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(439, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "علاقه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(568, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "دانش";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(671, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "آگاهی";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(18, 7);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(101, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "بارگذاری فایل";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(125, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(425, 236);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(35, 13);
            this.lblCount.TabIndex = 8;
            this.lblCount.Text = "label7";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(517, 236);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(35, 13);
            this.lblS.TabIndex = 9;
            this.lblS.Text = "label7";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.gpxGoals);
            this.Controls.Add(this.cmbTools);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpxGoals.ResumeLayout(false);
            this.gpxGoals.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTools;
        private System.Windows.Forms.GroupBox gpxGoals;
        private System.Windows.Forms.ComboBox cmbRoy;
        private System.Windows.Forms.ComboBox cmbExc;
        private System.Windows.Forms.ComboBox cmbExp;
        private System.Windows.Forms.ComboBox cmbFav;
        private System.Windows.Forms.ComboBox cmbKnd;
        private System.Windows.Forms.ComboBox cmbUnderstanding;
        private System.Windows.Forms.ListView lsvGoals;
        private System.Windows.Forms.ColumnHeader clmRep;
        private System.Windows.Forms.ColumnHeader clmBud;
        private System.Windows.Forms.ColumnHeader clmUnd;
        private System.Windows.Forms.ColumnHeader clmKnd;
        private System.Windows.Forms.ColumnHeader clmFav;
        private System.Windows.Forms.ColumnHeader clmExp;
        private System.Windows.Forms.ColumnHeader clmExc;
        private System.Windows.Forms.ColumnHeader clmRoy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRepeatation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label تکرار;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Button button2;
    }
}

