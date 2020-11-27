namespace StoreReciept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.item1Input = new System.Windows.Forms.TextBox();
            this.item2Input = new System.Windows.Forms.TextBox();
            this.item3Input = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.calculatedTotals = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tenderedIntput = new System.Windows.Forms.TextBox();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.receiptOutput = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.receiptOutputRight = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Force Performance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turbo Charger";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fuel Injecter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cold Air Intake";
            // 
            // item1Input
            // 
            this.item1Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item1Input.Location = new System.Drawing.Point(242, 55);
            this.item1Input.Name = "item1Input";
            this.item1Input.Size = new System.Drawing.Size(55, 29);
            this.item1Input.TabIndex = 4;
            // 
            // item2Input
            // 
            this.item2Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item2Input.Location = new System.Drawing.Point(242, 92);
            this.item2Input.Name = "item2Input";
            this.item2Input.Size = new System.Drawing.Size(55, 29);
            this.item2Input.TabIndex = 5;
            // 
            // item3Input
            // 
            this.item3Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item3Input.Location = new System.Drawing.Point(242, 128);
            this.item3Input.Name = "item3Input";
            this.item3Input.Size = new System.Drawing.Size(55, 29);
            this.item3Input.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(70, 173);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(226, 34);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(70, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 101);
            this.label5.TabIndex = 8;
            this.label5.Text = "Subtotal\r\n\r\nTax\r\n\r\nTotal";
            // 
            // calculatedTotals
            // 
            this.calculatedTotals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calculatedTotals.BackColor = System.Drawing.Color.White;
            this.calculatedTotals.Location = new System.Drawing.Point(223, 236);
            this.calculatedTotals.Name = "calculatedTotals";
            this.calculatedTotals.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.calculatedTotals.Size = new System.Drawing.Size(76, 101);
            this.calculatedTotals.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tendered";
            // 
            // tenderedIntput
            // 
            this.tenderedIntput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedIntput.Location = new System.Drawing.Point(178, 337);
            this.tenderedIntput.Name = "tenderedIntput";
            this.tenderedIntput.Size = new System.Drawing.Size(100, 29);
            this.tenderedIntput.TabIndex = 11;
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateChangeButton.Location = new System.Drawing.Point(70, 372);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(226, 30);
            this.calculateChangeButton.TabIndex = 12;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = true;
            this.calculateChangeButton.Click += new System.EventHandler(this.CalculateChangeButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Change";
            // 
            // changeOutput
            // 
            this.changeOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeOutput.BackColor = System.Drawing.Color.Transparent;
            this.changeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(172, 405);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.changeOutput.Size = new System.Drawing.Size(110, 35);
            this.changeOutput.TabIndex = 14;
            // 
            // receiptOutput
            // 
            this.receiptOutput.BackColor = System.Drawing.Color.White;
            this.receiptOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptOutput.Location = new System.Drawing.Point(399, 53);
            this.receiptOutput.Name = "receiptOutput";
            this.receiptOutput.Size = new System.Drawing.Size(316, 304);
            this.receiptOutput.TabIndex = 15;
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(433, 2);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(226, 30);
            this.printButton.TabIndex = 16;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(465, 375);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(194, 35);
            this.newOrderButton.TabIndex = 17;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // receiptOutputRight
            // 
            this.receiptOutputRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.receiptOutputRight.BackColor = System.Drawing.Color.White;
            this.receiptOutputRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.receiptOutputRight.Location = new System.Drawing.Point(588, 53);
            this.receiptOutputRight.Name = "receiptOutputRight";
            this.receiptOutputRight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.receiptOutputRight.Size = new System.Drawing.Size(130, 304);
            this.receiptOutputRight.TabIndex = 18;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(288, 417);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(293, 24);
            this.warningLabel.TabIndex = 19;
            this.warningLabel.Text = "MUST USE VALID INTEGERS!";
            this.warningLabel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Performance car parts store";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.receiptOutputRight);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.receiptOutput);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.tenderedIntput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.calculatedTotals);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.item3Input);
            this.Controls.Add(this.item2Input);
            this.Controls.Add(this.item1Input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Force Performance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox item1Input;
        private System.Windows.Forms.TextBox item2Input;
        private System.Windows.Forms.TextBox item3Input;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label calculatedTotals;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tenderedIntput;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label receiptOutput;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label receiptOutputRight;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label label8;
    }
}

