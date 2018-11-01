namespace MEC
{
    partial class frmStart
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
            this.lsvGoals = new System.Windows.Forms.ListView();
            this.clmRep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReg = new System.Windows.Forms.Button();
            this.txtRepeatation = new System.Windows.Forms.TextBox();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.cmbTools.Location = new System.Drawing.Point(6, 24);
            this.cmbTools.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTools.Name = "cmbTools";
            this.cmbTools.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbTools.Size = new System.Drawing.Size(187, 24);
            this.cmbTools.TabIndex = 0;
            this.cmbTools.Text = "تلویزیون";
            this.cmbTools.SelectedIndexChanged += new System.EventHandler(this.cmbTools_SelectedIndexChanged);
            // 
            // gpxGoals
            // 
            this.gpxGoals.Controls.Add(this.lsvGoals);
            this.gpxGoals.Controls.Add(this.btnReg);
            this.gpxGoals.Controls.Add(this.txtRepeatation);
            this.gpxGoals.Controls.Add(this.txtBudget);
            this.gpxGoals.Controls.Add(this.cmbTools);
            this.gpxGoals.Location = new System.Drawing.Point(12, 13);
            this.gpxGoals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpxGoals.Name = "gpxGoals";
            this.gpxGoals.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpxGoals.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gpxGoals.Size = new System.Drawing.Size(201, 313);
            this.gpxGoals.TabIndex = 0;
            this.gpxGoals.TabStop = false;
            // 
            // lsvGoals
            // 
            this.lsvGoals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmRep,
            this.clmBud});
            this.lsvGoals.Location = new System.Drawing.Point(6, 86);
            this.lsvGoals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvGoals.Name = "lsvGoals";
            this.lsvGoals.RightToLeftLayout = true;
            this.lsvGoals.Size = new System.Drawing.Size(187, 185);
            this.lsvGoals.TabIndex = 4;
            this.lsvGoals.UseCompatibleStateImageBehavior = false;
            this.lsvGoals.View = System.Windows.Forms.View.Details;
            // 
            // clmRep
            // 
            this.clmRep.Text = "تکرار";
            this.clmRep.Width = 65;
            // 
            // clmBud
            // 
            this.clmBud.Text = "بودجه";
            this.clmBud.Width = 116;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(6, 277);
            this.btnReg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(187, 28);
            this.btnReg.TabIndex = 3;
            this.btnReg.Text = "ثبت";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // txtRepeatation
            // 
            this.txtRepeatation.Location = new System.Drawing.Point(133, 54);
            this.txtRepeatation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRepeatation.Name = "txtRepeatation";
            this.txtRepeatation.Size = new System.Drawing.Size(60, 23);
            this.txtRepeatation.TabIndex = 1;
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(6, 55);
            this.txtBudget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(121, 23);
            this.txtBudget.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 344);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(187, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 385);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gpxGoals);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStart";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.gpxGoals.ResumeLayout(false);
            this.gpxGoals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTools;
        private System.Windows.Forms.GroupBox gpxGoals;
        private System.Windows.Forms.ListView lsvGoals;
        private System.Windows.Forms.ColumnHeader clmRep;
        private System.Windows.Forms.ColumnHeader clmBud;
        private System.Windows.Forms.TextBox txtRepeatation;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReg;
    }
}

