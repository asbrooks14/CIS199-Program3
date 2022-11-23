
namespace Program_3
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
            this.farmLabel = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.initialCostLabel = new System.Windows.Forms.Label();
            this.discountedCostLabel = new System.Windows.Forms.Label();
            this.shipmentCostLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.itemInputTextBox = new System.Windows.Forms.TextBox();
            this.quantityInputTextBox = new System.Windows.Forms.TextBox();
            this.farmComboBox = new System.Windows.Forms.ComboBox();
            this.initialCostOutputLabel = new System.Windows.Forms.Label();
            this.discountedCostOutputLabel = new System.Windows.Forms.Label();
            this.shipmentCostOutputLabel = new System.Windows.Forms.Label();
            this.totalPriceOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // farmLabel
            // 
            this.farmLabel.AutoSize = true;
            this.farmLabel.Location = new System.Drawing.Point(88, 61);
            this.farmLabel.Name = "farmLabel";
            this.farmLabel.Size = new System.Drawing.Size(44, 17);
            this.farmLabel.TabIndex = 0;
            this.farmLabel.Text = "Farm:";
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(94, 90);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(38, 17);
            this.itemLabel.TabIndex = 1;
            this.itemLabel.Text = "Item:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(35, 121);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(97, 17);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Quantity (lbs):";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(119, 176);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(97, 27);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // initialCostLabel
            // 
            this.initialCostLabel.AutoSize = true;
            this.initialCostLabel.Location = new System.Drawing.Point(56, 236);
            this.initialCostLabel.Name = "initialCostLabel";
            this.initialCostLabel.Size = new System.Drawing.Size(76, 17);
            this.initialCostLabel.TabIndex = 4;
            this.initialCostLabel.Text = "Initial Cost:";
            // 
            // discountedCostLabel
            // 
            this.discountedCostLabel.AutoSize = true;
            this.discountedCostLabel.Location = new System.Drawing.Point(17, 270);
            this.discountedCostLabel.Name = "discountedCostLabel";
            this.discountedCostLabel.Size = new System.Drawing.Size(115, 17);
            this.discountedCostLabel.TabIndex = 5;
            this.discountedCostLabel.Text = "Discounted Cost:";
            // 
            // shipmentCostLabel
            // 
            this.shipmentCostLabel.AutoSize = true;
            this.shipmentCostLabel.Location = new System.Drawing.Point(29, 306);
            this.shipmentCostLabel.Name = "shipmentCostLabel";
            this.shipmentCostLabel.Size = new System.Drawing.Size(103, 17);
            this.shipmentCostLabel.TabIndex = 6;
            this.shipmentCostLabel.Text = "Shipment Cost:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(52, 347);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(80, 17);
            this.totalPriceLabel.TabIndex = 7;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // itemInputTextBox
            // 
            this.itemInputTextBox.Location = new System.Drawing.Point(137, 88);
            this.itemInputTextBox.Name = "itemInputTextBox";
            this.itemInputTextBox.Size = new System.Drawing.Size(121, 22);
            this.itemInputTextBox.TabIndex = 8;
            // 
            // quantityInputTextBox
            // 
            this.quantityInputTextBox.Location = new System.Drawing.Point(137, 118);
            this.quantityInputTextBox.Name = "quantityInputTextBox";
            this.quantityInputTextBox.Size = new System.Drawing.Size(121, 22);
            this.quantityInputTextBox.TabIndex = 9;
            // 
            // farmComboBox
            // 
            this.farmComboBox.FormattingEnabled = true;
            this.farmComboBox.Items.AddRange(new object[] {
            "NE",
            "NW",
            "SE",
            "SW"});
            this.farmComboBox.Location = new System.Drawing.Point(137, 58);
            this.farmComboBox.Name = "farmComboBox";
            this.farmComboBox.Size = new System.Drawing.Size(121, 24);
            this.farmComboBox.TabIndex = 10;
            // 
            // initialCostOutputLabel
            // 
            this.initialCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.initialCostOutputLabel.Location = new System.Drawing.Point(137, 235);
            this.initialCostOutputLabel.Name = "initialCostOutputLabel";
            this.initialCostOutputLabel.Size = new System.Drawing.Size(121, 23);
            this.initialCostOutputLabel.TabIndex = 11;
            // 
            // discountedCostOutputLabel
            // 
            this.discountedCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountedCostOutputLabel.Location = new System.Drawing.Point(137, 269);
            this.discountedCostOutputLabel.Name = "discountedCostOutputLabel";
            this.discountedCostOutputLabel.Size = new System.Drawing.Size(121, 23);
            this.discountedCostOutputLabel.TabIndex = 12;
            // 
            // shipmentCostOutputLabel
            // 
            this.shipmentCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shipmentCostOutputLabel.Location = new System.Drawing.Point(137, 305);
            this.shipmentCostOutputLabel.Name = "shipmentCostOutputLabel";
            this.shipmentCostOutputLabel.Size = new System.Drawing.Size(121, 23);
            this.shipmentCostOutputLabel.TabIndex = 13;
            // 
            // totalPriceOutputLabel
            // 
            this.totalPriceOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceOutputLabel.Location = new System.Drawing.Point(138, 346);
            this.totalPriceOutputLabel.Name = "totalPriceOutputLabel";
            this.totalPriceOutputLabel.Size = new System.Drawing.Size(121, 23);
            this.totalPriceOutputLabel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.totalPriceOutputLabel);
            this.Controls.Add(this.shipmentCostOutputLabel);
            this.Controls.Add(this.discountedCostOutputLabel);
            this.Controls.Add(this.initialCostOutputLabel);
            this.Controls.Add(this.farmComboBox);
            this.Controls.Add(this.quantityInputTextBox);
            this.Controls.Add(this.itemInputTextBox);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.shipmentCostLabel);
            this.Controls.Add(this.discountedCostLabel);
            this.Controls.Add(this.initialCostLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.farmLabel);
            this.Name = "Form1";
            this.Text = "uPickItGrocery Cost Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label farmLabel;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label initialCostLabel;
        private System.Windows.Forms.Label discountedCostLabel;
        private System.Windows.Forms.Label shipmentCostLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.TextBox itemInputTextBox;
        private System.Windows.Forms.TextBox quantityInputTextBox;
        private System.Windows.Forms.ComboBox farmComboBox;
        private System.Windows.Forms.Label initialCostOutputLabel;
        private System.Windows.Forms.Label discountedCostOutputLabel;
        private System.Windows.Forms.Label shipmentCostOutputLabel;
        private System.Windows.Forms.Label totalPriceOutputLabel;
    }
}

