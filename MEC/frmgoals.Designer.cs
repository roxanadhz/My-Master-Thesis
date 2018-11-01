namespace MEC
{
    partial class frmgoals
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
            this.lsvGoals = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmKnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFav = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmExp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmExc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRoy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbRoy = new System.Windows.Forms.ComboBox();
            this.cmbExc = new System.Windows.Forms.ComboBox();
            this.cmbExp = new System.Windows.Forms.ComboBox();
            this.cmbFav = new System.Windows.Forms.ComboBox();
            this.cmbKnd = new System.Windows.Forms.ComboBox();
            this.cmbUnd = new System.Windows.Forms.ComboBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvGoals
            // 
            this.lsvGoals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvGoals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmUnd,
            this.clmKnd,
            this.clmFav,
            this.clmExp,
            this.clmExc,
            this.clmRoy});
            this.lsvGoals.Location = new System.Drawing.Point(26, 82);
            this.lsvGoals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvGoals.Name = "lsvGoals";
            this.lsvGoals.RightToLeftLayout = true;
            this.lsvGoals.Size = new System.Drawing.Size(726, 389);
            this.lsvGoals.TabIndex = 18;
            this.lsvGoals.UseCompatibleStateImageBehavior = false;
            this.lsvGoals.View = System.Windows.Forms.View.Details;
            this.lsvGoals.SelectedIndexChanged += new System.EventHandler(this.lsvGoals_SelectedIndexChanged);
            // 
            // clmName
            // 
            this.clmName.Text = "متغیرهای محیطی/درون سازمانی";
            this.clmName.Width = 420;
            // 
            // clmUnd
            // 
            this.clmUnd.Text = "آگاهی";
            this.clmUnd.Width = 50;
            // 
            // clmKnd
            // 
            this.clmKnd.Text = "دانش";
            this.clmKnd.Width = 50;
            // 
            // clmFav
            // 
            this.clmFav.Text = "علاقه";
            this.clmFav.Width = 50;
            // 
            // clmExp
            // 
            this.clmExp.Text = "ترجیح";
            this.clmExp.Width = 50;
            // 
            // clmExc
            // 
            this.clmExc.Text = "آزمایش";
            this.clmExc.Width = 50;
            // 
            // clmRoy
            // 
            this.clmRoy.Text = "وفاداری";
            this.clmRoy.Width = 50;
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
            this.cmbRoy.Location = new System.Drawing.Point(354, 45);
            this.cmbRoy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRoy.Name = "cmbRoy";
            this.cmbRoy.Size = new System.Drawing.Size(60, 22);
            this.cmbRoy.TabIndex = 27;
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
            this.cmbExc.Location = new System.Drawing.Point(354, 15);
            this.cmbExc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbExc.Name = "cmbExc";
            this.cmbExc.Size = new System.Drawing.Size(60, 22);
            this.cmbExc.TabIndex = 26;
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
            this.cmbExp.Location = new System.Drawing.Point(209, 45);
            this.cmbExp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbExp.Name = "cmbExp";
            this.cmbExp.Size = new System.Drawing.Size(60, 22);
            this.cmbExp.TabIndex = 25;
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
            this.cmbFav.Location = new System.Drawing.Point(209, 15);
            this.cmbFav.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFav.Name = "cmbFav";
            this.cmbFav.Size = new System.Drawing.Size(60, 22);
            this.cmbFav.TabIndex = 24;
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
            this.cmbKnd.Location = new System.Drawing.Point(74, 45);
            this.cmbKnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbKnd.Name = "cmbKnd";
            this.cmbKnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbKnd.Size = new System.Drawing.Size(60, 22);
            this.cmbKnd.TabIndex = 23;
            this.cmbKnd.Text = "1";
            // 
            // cmbUnd
            // 
            this.cmbUnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUnd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbUnd.FormattingEnabled = true;
            this.cmbUnd.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9"});
            this.cmbUnd.Location = new System.Drawing.Point(74, 15);
            this.cmbUnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUnd.Name = "cmbUnd";
            this.cmbUnd.Size = new System.Drawing.Size(60, 22);
            this.cmbUnd.TabIndex = 22;
            this.cmbUnd.Text = "1";
            // 
            // btnReg
            // 
            this.btnReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReg.Enabled = false;
            this.btnReg.Location = new System.Drawing.Point(467, 45);
            this.btnReg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(185, 28);
            this.btnReg.TabIndex = 28;
            this.btnReg.Text = "ثبت";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(304, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 14);
            this.label6.TabIndex = 33;
            this.label6.Text = "وفاداری";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtName.Location = new System.Drawing.Point(467, 15);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 22);
            this.txtName.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(304, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 32;
            this.label5.Text = "آزمایش";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(168, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 31;
            this.label4.Text = "ترجیح";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(168, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 30;
            this.label3.Text = "علاقه";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 29;
            this.label2.Text = "دانش";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "آگاهی";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(681, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 52);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmgoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 502);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbRoy);
            this.Controls.Add(this.cmbExc);
            this.Controls.Add(this.cmbExp);
            this.Controls.Add(this.cmbFav);
            this.Controls.Add(this.cmbKnd);
            this.Controls.Add(this.cmbUnd);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvGoals);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MinimizeBox = false;
            this.Name = "frmgoals";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmgoals";
            this.Load += new System.EventHandler(this.frmgoals_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvGoals;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmUnd;
        private System.Windows.Forms.ColumnHeader clmKnd;
        private System.Windows.Forms.ColumnHeader clmFav;
        private System.Windows.Forms.ColumnHeader clmExp;
        private System.Windows.Forms.ColumnHeader clmExc;
        private System.Windows.Forms.ColumnHeader clmRoy;
        private System.Windows.Forms.ComboBox cmbRoy;
        private System.Windows.Forms.ComboBox cmbExc;
        private System.Windows.Forms.ComboBox cmbExp;
        private System.Windows.Forms.ComboBox cmbFav;
        private System.Windows.Forms.ComboBox cmbKnd;
        private System.Windows.Forms.ComboBox cmbUnd;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
    }
}