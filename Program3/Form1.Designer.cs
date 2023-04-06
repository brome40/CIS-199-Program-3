namespace Program3
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
            this.stateLbl = new System.Windows.Forms.Label();
            this.productLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.stateListBox = new System.Windows.Forms.ComboBox();
            this.productTxt = new System.Windows.Forms.TextBox();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.intCostLbl = new System.Windows.Forms.Label();
            this.discCostLbl = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.intCostOutput = new System.Windows.Forms.Label();
            this.discCostOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOuput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stateLbl
            // 
            this.stateLbl.AutoSize = true;
            this.stateLbl.Location = new System.Drawing.Point(63, 48);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(35, 13);
            this.stateLbl.TabIndex = 0;
            this.stateLbl.Text = "State:";
            // 
            // productLbl
            // 
            this.productLbl.AutoSize = true;
            this.productLbl.Location = new System.Drawing.Point(51, 85);
            this.productLbl.Name = "productLbl";
            this.productLbl.Size = new System.Drawing.Size(47, 13);
            this.productLbl.TabIndex = 1;
            this.productLbl.Text = "Product:";
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Location = new System.Drawing.Point(51, 117);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(49, 13);
            this.quantityLbl.TabIndex = 2;
            this.quantityLbl.Text = "Quantity:";
            // 
            // stateListBox
            // 
            this.stateListBox.FormattingEnabled = true;
            this.stateListBox.Items.AddRange(new object[] {
            "KY",
            "OH",
            "IN",
            "IL"});
            this.stateListBox.Location = new System.Drawing.Point(126, 40);
            this.stateListBox.Name = "stateListBox";
            this.stateListBox.Size = new System.Drawing.Size(121, 21);
            this.stateListBox.TabIndex = 3;
            // 
            // productTxt
            // 
            this.productTxt.Location = new System.Drawing.Point(126, 78);
            this.productTxt.Name = "productTxt";
            this.productTxt.Size = new System.Drawing.Size(121, 20);
            this.productTxt.TabIndex = 4;
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(126, 117);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(121, 20);
            this.quantityTxt.TabIndex = 5;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(147, 171);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 6;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // intCostLbl
            // 
            this.intCostLbl.AutoSize = true;
            this.intCostLbl.Location = new System.Drawing.Point(42, 227);
            this.intCostLbl.Name = "intCostLbl";
            this.intCostLbl.Size = new System.Drawing.Size(58, 13);
            this.intCostLbl.TabIndex = 7;
            this.intCostLbl.Text = "Initial Cost:";
            // 
            // discCostLbl
            // 
            this.discCostLbl.AutoSize = true;
            this.discCostLbl.Location = new System.Drawing.Point(12, 263);
            this.discCostLbl.Name = "discCostLbl";
            this.discCostLbl.Size = new System.Drawing.Size(88, 13);
            this.discCostLbl.TabIndex = 8;
            this.discCostLbl.Text = "Discounted Cost:";
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Location = new System.Drawing.Point(70, 298);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(28, 13);
            this.taxLbl.TabIndex = 9;
            this.taxLbl.Text = "Tax:";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(37, 331);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(61, 13);
            this.totalLbl.TabIndex = 10;
            this.totalLbl.Text = "Total Price:";
            // 
            // intCostOutput
            // 
            this.intCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.intCostOutput.Location = new System.Drawing.Point(126, 226);
            this.intCostOutput.Name = "intCostOutput";
            this.intCostOutput.Size = new System.Drawing.Size(121, 23);
            this.intCostOutput.TabIndex = 11;
            // 
            // discCostOutput
            // 
            this.discCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discCostOutput.Location = new System.Drawing.Point(126, 262);
            this.discCostOutput.Name = "discCostOutput";
            this.discCostOutput.Size = new System.Drawing.Size(121, 23);
            this.discCostOutput.TabIndex = 12;
            // 
            // taxOutput
            // 
            this.taxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxOutput.Location = new System.Drawing.Point(126, 297);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(121, 23);
            this.taxOutput.TabIndex = 13;
            // 
            // totalOuput
            // 
            this.totalOuput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOuput.Location = new System.Drawing.Point(126, 330);
            this.totalOuput.Name = "totalOuput";
            this.totalOuput.Size = new System.Drawing.Size(121, 23);
            this.totalOuput.TabIndex = 14;
            // 
            // Form1
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 430);
            this.Controls.Add(this.totalOuput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.discCostOutput);
            this.Controls.Add(this.intCostOutput);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.taxLbl);
            this.Controls.Add(this.discCostLbl);
            this.Controls.Add(this.intCostLbl);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.productTxt);
            this.Controls.Add(this.stateListBox);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.productLbl);
            this.Controls.Add(this.stateLbl);
            this.Name = "Form1";
            this.Text = "Sales Co Cost Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stateLbl;
        private System.Windows.Forms.Label productLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.ComboBox stateListBox;
        private System.Windows.Forms.TextBox productTxt;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label intCostLbl;
        private System.Windows.Forms.Label discCostLbl;
        private System.Windows.Forms.Label taxLbl;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label intCostOutput;
        private System.Windows.Forms.Label discCostOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOuput;
    }
}

