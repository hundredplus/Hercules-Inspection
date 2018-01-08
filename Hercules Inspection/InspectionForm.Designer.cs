namespace Hercules_Inspection
{
    partial class HerculesInspection
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
            this.passBtn = new System.Windows.Forms.Button();
            this.failBtn = new System.Windows.Forms.Button();
            this.productBox = new System.Windows.Forms.ComboBox();
            this.projectBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productInfoTxt = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passBtn
            // 
            this.passBtn.Enabled = false;
            this.passBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBtn.Location = new System.Drawing.Point(386, 520);
            this.passBtn.Name = "passBtn";
            this.passBtn.Size = new System.Drawing.Size(117, 41);
            this.passBtn.TabIndex = 0;
            this.passBtn.Text = "PASS";
            this.passBtn.UseVisualStyleBackColor = true;
            this.passBtn.Click += new System.EventHandler(this.passBtn_Click);
            // 
            // failBtn
            // 
            this.failBtn.Enabled = false;
            this.failBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failBtn.Location = new System.Drawing.Point(541, 520);
            this.failBtn.Name = "failBtn";
            this.failBtn.Size = new System.Drawing.Size(109, 41);
            this.failBtn.TabIndex = 1;
            this.failBtn.Text = "FAIL";
            this.failBtn.UseVisualStyleBackColor = true;
            this.failBtn.Click += new System.EventHandler(this.failBtn_Click);
            // 
            // productBox
            // 
            this.productBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productBox.FormattingEnabled = true;
            this.productBox.Location = new System.Drawing.Point(22, 115);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(288, 21);
            this.productBox.TabIndex = 2;
            this.productBox.SelectedIndexChanged += new System.EventHandler(this.productBox_SelectedIndexChanged);
            // 
            // projectBox
            // 
            this.projectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectBox.FormattingEnabled = true;
            this.projectBox.Location = new System.Drawing.Point(22, 60);
            this.projectBox.Name = "projectBox";
            this.projectBox.Size = new System.Drawing.Size(288, 21);
            this.projectBox.TabIndex = 3;
            this.projectBox.SelectedIndexChanged += new System.EventHandler(this.projectBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a project:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select a PBU to inspect:";
            // 
            // productInfoTxt
            // 
            this.productInfoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInfoTxt.Location = new System.Drawing.Point(22, 156);
            this.productInfoTxt.Multiline = true;
            this.productInfoTxt.Name = "productInfoTxt";
            this.productInfoTxt.ReadOnly = true;
            this.productInfoTxt.Size = new System.Drawing.Size(288, 178);
            this.productInfoTxt.TabIndex = 5;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4",
            "Item 5"});
            this.checkedListBox1.Location = new System.Drawing.Point(348, 30);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(302, 304);
            this.checkedListBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 385);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(628, 107);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comments:";
            // 
            // HerculesInspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 583);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.productInfoTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectBox);
            this.Controls.Add(this.productBox);
            this.Controls.Add(this.failBtn);
            this.Controls.Add(this.passBtn);
            this.Name = "HerculesInspection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hercules Inspection";
            this.Load += new System.EventHandler(this.HerculesInspection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button passBtn;
        private System.Windows.Forms.Button failBtn;
        private System.Windows.Forms.ComboBox productBox;
        private System.Windows.Forms.ComboBox projectBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productInfoTxt;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}

