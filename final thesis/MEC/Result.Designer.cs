namespace MEC
{
    partial class Result
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
            this.lsvArray = new System.Windows.Forms.ListView();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lsvValue = new System.Windows.Forms.ListView();
            this.clmValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMaxBud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRepeat = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lsvArray
            // 
            this.lsvArray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvArray.Location = new System.Drawing.Point(12, 34);
            this.lsvArray.Name = "lsvArray";
            this.lsvArray.Size = new System.Drawing.Size(779, 430);
            this.lsvArray.TabIndex = 3;
            this.lsvArray.UseCompatibleStateImageBehavior = false;
            this.lsvArray.View = System.Windows.Forms.View.Details;
            this.lsvArray.SelectedIndexChanged += new System.EventHandler(this.lsvArray_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(742, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "اجرا";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(1135, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(40, 361);
            this.listBox1.TabIndex = 5;
            // 
            // lsvValue
            // 
            this.lsvValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvValue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmValue,
            this.clmBud});
            this.lsvValue.Location = new System.Drawing.Point(797, 41);
            this.lsvValue.Name = "lsvValue";
            this.lsvValue.Size = new System.Drawing.Size(332, 430);
            this.lsvValue.TabIndex = 4;
            this.lsvValue.UseCompatibleStateImageBehavior = false;
            this.lsvValue.View = System.Windows.Forms.View.Details;
            this.lsvValue.SelectedIndexChanged += new System.EventHandler(this.lsvValue_SelectedIndexChanged);
            // 
            // clmValue
            // 
            this.clmValue.Text = "ارزش";
            this.clmValue.Width = 114;
            // 
            // clmBud
            // 
            this.clmBud.Text = "بودجه";
            this.clmBud.Width = 150;
            // 
            // txtMaxBud
            // 
            this.txtMaxBud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaxBud.Location = new System.Drawing.Point(606, 7);
            this.txtMaxBud.Name = "txtMaxBud";
            this.txtMaxBud.Size = new System.Drawing.Size(130, 24);
            this.txtMaxBud.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "محدودیت بوجه";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 14);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "تعداد تکرار:";
            // 
            // txtRepeat
            // 
            this.txtRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepeat.Location = new System.Drawing.Point(440, 7);
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.Size = new System.Drawing.Size(60, 24);
            this.txtRepeat.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(12, 477);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(1163, 24);
            this.txtResult.TabIndex = 6;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 513);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRepeat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaxBud);
            this.Controls.Add(this.lsvValue);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lsvArray);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "Result";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvArray;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView lsvValue;
        private System.Windows.Forms.ColumnHeader clmValue;
        private System.Windows.Forms.ColumnHeader clmBud;
        private System.Windows.Forms.TextBox txtMaxBud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRepeat;
        private System.Windows.Forms.TextBox txtResult;
    }
}