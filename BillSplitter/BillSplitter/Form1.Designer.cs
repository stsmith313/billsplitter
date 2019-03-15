namespace BillSplitter
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
            this.label1 = new System.Windows.Forms.Label();
            this.totalTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.peopleTxt = new System.Windows.Forms.TextBox();
            this.tipTxt = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.outputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the total of the bill:";
            // 
            // totalTxt
            // 
            this.totalTxt.Location = new System.Drawing.Point(397, 33);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.Size = new System.Drawing.Size(119, 22);
            this.totalTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the number of people on the bill:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter the tip for the bill:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // peopleTxt
            // 
            this.peopleTxt.Location = new System.Drawing.Point(397, 80);
            this.peopleTxt.Name = "peopleTxt";
            this.peopleTxt.Size = new System.Drawing.Size(119, 22);
            this.peopleTxt.TabIndex = 4;
            // 
            // tipTxt
            // 
            this.tipTxt.Location = new System.Drawing.Point(397, 133);
            this.tipTxt.Name = "tipTxt";
            this.tipTxt.Size = new System.Drawing.Size(119, 22);
            this.tipTxt.TabIndex = 5;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(584, 32);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(102, 50);
            this.calcBtn.TabIndex = 6;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(584, 105);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(102, 50);
            this.resetBtn.TabIndex = 7;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // outputLbl
            // 
            this.outputLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLbl.Location = new System.Drawing.Point(162, 252);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(354, 106);
            this.outputLbl.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.tipTxt);
            this.Controls.Add(this.peopleTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bill Splitter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox peopleTxt;
        private System.Windows.Forms.TextBox tipTxt;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label outputLbl;
    }
}

