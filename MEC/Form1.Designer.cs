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
            this.clmRep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmKnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFav = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmExp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmExc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRoy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chkUnd = new System.Windows.Forms.CheckBox();
            this.chkKnd = new System.Windows.Forms.CheckBox();
            this.chkFav = new System.Windows.Forms.CheckBox();
            this.chkExp = new System.Windows.Forms.CheckBox();
            this.chkExc = new System.Windows.Forms.CheckBox();
            this.chkRoy = new System.Windows.Forms.CheckBox();
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
            "نمایشگاه",
            "فروشندگی شخصی",
            "پوستر بروشور و کاتالوگ",
            "رایانامه",
            "پیامک"});
            this.cmbTools.Location = new System.Drawing.Point(25, 13);
            this.cmbTools.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTools.Name = "cmbTools";
            this.cmbTools.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbTools.Size = new System.Drawing.Size(154, 27);
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
            this.gpxGoals.Location = new System.Drawing.Point(25, 50);
            this.gpxGoals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpxGoals.Name = "gpxGoals";
            this.gpxGoals.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpxGoals.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gpxGoals.Size = new System.Drawing.Size(779, 329);
            this.gpxGoals.TabIndex = 2;
            this.gpxGoals.TabStop = false;
            this.gpxGoals.Text = "اهداف";
            // 
            // cmbRoy
            // 
            this.cmbRoy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRoy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbRoy.FormattingEnabled = true;
            this.cmbRoy.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9"});
            this.cmbRoy.Location = new System.Drawing.Point(139, 55);
            this.cmbRoy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRoy.Name = "cmbRoy";
            this.cmbRoy.Size = new System.Drawing.Size(60, 26);
            this.cmbRoy.TabIndex = 9;
            this.cmbRoy.Text = "1";
            // 
            // cmbExc
            // 
            this.cmbExc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbExc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbExc.FormattingEnabled = true;
            this.cmbExc.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9"});
            this.cmbExc.Location = new System.Drawing.Point(227, 56);
            this.cmbExc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbExc.Name = "cmbExc";
            this.cmbExc.Size = new System.Drawing.Size(60, 26);
            this.cmbExc.TabIndex = 8;
            this.cmbExc.Text = "1";
            // 
            // cmbExp
            // 
            this.cmbExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbExp.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbExp.FormattingEnabled = true;
            this.cmbExp.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9"});
            this.cmbExp.Location = new System.Drawing.Point(310, 56);
            this.cmbExp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbExp.Name = "cmbExp";
            this.cmbExp.Size = new System.Drawing.Size(60, 26);
            this.cmbExp.TabIndex = 7;
            this.cmbExp.Text = "1";
            // 
            // cmbFav
            // 
            this.cmbFav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFav.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbFav.FormattingEnabled = true;
            this.cmbFav.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9"});
            this.cmbFav.Location = new System.Drawing.Point(389, 55);
            this.cmbFav.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFav.Name = "cmbFav";
            this.cmbFav.Size = new System.Drawing.Size(60, 26);
            this.cmbFav.TabIndex = 6;
            this.cmbFav.Text = "1";
            // 
            // cmbKnd
            // 
            this.cmbKnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbKnd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbKnd.FormattingEnabled = true;
            this.cmbKnd.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9"});
            this.cmbKnd.Location = new System.Drawing.Point(465, 56);
            this.cmbKnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbKnd.Name = "cmbKnd";
            this.cmbKnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbKnd.Size = new System.Drawing.Size(60, 26);
            this.cmbKnd.TabIndex = 5;
            this.cmbKnd.Text = "1";
            // 
            // cmbUnderstanding
            // 
            this.cmbUnderstanding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUnderstanding.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbUnderstanding.FormattingEnabled = true;
            this.cmbUnderstanding.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9"});
            this.cmbUnderstanding.Location = new System.Drawing.Point(544, 56);
            this.cmbUnderstanding.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUnderstanding.Name = "cmbUnderstanding";
            this.cmbUnderstanding.Size = new System.Drawing.Size(60, 26);
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
            this.lsvGoals.Location = new System.Drawing.Point(6, 86);
            this.lsvGoals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvGoals.Name = "lsvGoals";
            this.lsvGoals.RightToLeftLayout = true;
            this.lsvGoals.Size = new System.Drawing.Size(760, 235);
            this.lsvGoals.TabIndex = 17;
            this.lsvGoals.UseCompatibleStateImageBehavior = false;
            this.lsvGoals.View = System.Windows.Forms.View.Details;
            this.lsvGoals.SelectedIndexChanged += new System.EventHandler(this.lsvGoals_SelectedIndexChanged);
            // 
            // clmRep
            // 
            this.clmRep.Text = "تکرار";
            this.clmRep.Width = 62;
            // 
            // clmBud
            // 
            this.clmBud.Text = "بودجه";
            this.clmBud.Width = 96;
            // 
            // clmUnd
            // 
            this.clmUnd.Text = "آگاهی";
            this.clmUnd.Width = 75;
            // 
            // clmKnd
            // 
            this.clmKnd.Text = "دانش";
            this.clmKnd.Width = 75;
            // 
            // clmFav
            // 
            this.clmFav.Text = "علاقه";
            this.clmFav.Width = 80;
            // 
            // clmExp
            // 
            this.clmExp.Text = "ترجیح";
            this.clmExp.Width = 80;
            // 
            // clmExc
            // 
            this.clmExc.Text = "آزمایش";
            this.clmExc.Width = 80;
            // 
            // clmRoy
            // 
            this.clmRoy.Text = "وفاداری";
            this.clmRoy.Width = 75;
            // 
            // btnReg
            // 
            this.btnReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReg.Enabled = false;
            this.btnReg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReg.Location = new System.Drawing.Point(38, 51);
            this.btnReg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(79, 28);
            this.btnReg.TabIndex = 10;
            this.btnReg.Text = "ثبت";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(661, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "بودجه";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(110, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "وفاداری";
            // 
            // txtRepeatation
            // 
            this.txtRepeatation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepeatation.Enabled = false;
            this.txtRepeatation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtRepeatation.Location = new System.Drawing.Point(704, 56);
            this.txtRepeatation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRepeatation.Name = "txtRepeatation";
            this.txtRepeatation.Size = new System.Drawing.Size(60, 26);
            this.txtRepeatation.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(202, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "آزمایش";
            // 
            // تکرار
            // 
            this.تکرار.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.تکرار.AutoSize = true;
            this.تکرار.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.تکرار.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.تکرار.Location = new System.Drawing.Point(731, 25);
            this.تکرار.Name = "تکرار";
            this.تکرار.Size = new System.Drawing.Size(35, 18);
            this.تکرار.TabIndex = 15;
            this.تکرار.Text = "تکرار";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(290, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "ترجیح";
            // 
            // txtBudget
            // 
            this.txtBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBudget.Enabled = false;
            this.txtBudget.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtBudget.Location = new System.Drawing.Point(609, 55);
            this.txtBudget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(89, 26);
            this.txtBudget.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(373, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "علاقه";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(452, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "دانش";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(528, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "آگاهی";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(580, 14);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(451, 404);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "فرم محاسبه";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkUnd
            // 
            this.chkUnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkUnd.AutoSize = true;
            this.chkUnd.Location = new System.Drawing.Point(37, 381);
            this.chkUnd.Name = "chkUnd";
            this.chkUnd.Size = new System.Drawing.Size(77, 25);
            this.chkUnd.TabIndex = 12;
            this.chkUnd.Text = "آگاهی";
            this.chkUnd.UseVisualStyleBackColor = true;
            // 
            // chkKnd
            // 
            this.chkKnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkKnd.AutoSize = true;
            this.chkKnd.Location = new System.Drawing.Point(37, 407);
            this.chkKnd.Name = "chkKnd";
            this.chkKnd.Size = new System.Drawing.Size(71, 25);
            this.chkKnd.TabIndex = 13;
            this.chkKnd.Text = "دانش";
            this.chkKnd.UseVisualStyleBackColor = true;
            // 
            // chkFav
            // 
            this.chkFav.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkFav.AutoSize = true;
            this.chkFav.Location = new System.Drawing.Point(172, 381);
            this.chkFav.Name = "chkFav";
            this.chkFav.Size = new System.Drawing.Size(71, 25);
            this.chkFav.TabIndex = 14;
            this.chkFav.Text = "علاقه";
            this.chkFav.UseVisualStyleBackColor = true;
            // 
            // chkExp
            // 
            this.chkExp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkExp.AutoSize = true;
            this.chkExp.Location = new System.Drawing.Point(170, 407);
            this.chkExp.Name = "chkExp";
            this.chkExp.Size = new System.Drawing.Size(73, 25);
            this.chkExp.TabIndex = 15;
            this.chkExp.Text = "ترجیح";
            this.chkExp.UseVisualStyleBackColor = true;
            // 
            // chkExc
            // 
            this.chkExc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkExc.AutoSize = true;
            this.chkExc.Location = new System.Drawing.Point(294, 381);
            this.chkExc.Name = "chkExc";
            this.chkExc.Size = new System.Drawing.Size(83, 25);
            this.chkExc.TabIndex = 16;
            this.chkExc.Text = "آزمایش";
            this.chkExc.UseVisualStyleBackColor = true;
            // 
            // chkRoy
            // 
            this.chkRoy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkRoy.AutoSize = true;
            this.chkRoy.Location = new System.Drawing.Point(293, 407);
            this.chkRoy.Name = "chkRoy";
            this.chkRoy.Size = new System.Drawing.Size(84, 25);
            this.chkRoy.TabIndex = 17;
            this.chkRoy.Text = "وفاداری";
            this.chkRoy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 444);
            this.Controls.Add(this.chkRoy);
            this.Controls.Add(this.chkExc);
            this.Controls.Add(this.chkExp);
            this.Controls.Add(this.chkFav);
            this.Controls.Add(this.chkKnd);
            this.Controls.Add(this.chkUnd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gpxGoals);
            this.Controls.Add(this.cmbTools);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView lsvGoals;
        private System.Windows.Forms.ColumnHeader clmRep;
        private System.Windows.Forms.ColumnHeader clmBud;
        private System.Windows.Forms.ColumnHeader clmUnd;
        private System.Windows.Forms.ColumnHeader clmKnd;
        private System.Windows.Forms.ColumnHeader clmFav;
        private System.Windows.Forms.ColumnHeader clmExp;
        private System.Windows.Forms.ColumnHeader clmExc;
        private System.Windows.Forms.ColumnHeader clmRoy;
        private System.Windows.Forms.CheckBox chkUnd;
        private System.Windows.Forms.CheckBox chkKnd;
        private System.Windows.Forms.CheckBox chkFav;
        private System.Windows.Forms.CheckBox chkExp;
        private System.Windows.Forms.CheckBox chkExc;
        private System.Windows.Forms.CheckBox chkRoy;
    }
}

