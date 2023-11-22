namespace CoffeeShop
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudColdDrink = new System.Windows.Forms.NumericUpDown();
            this.nudGreenTea = new System.Windows.Forms.NumericUpDown();
            this.nudTea = new System.Windows.Forms.NumericUpDown();
            this.nudCoffee = new System.Windows.Forms.NumericUpDown();
            this.chkColdDrink = new System.Windows.Forms.CheckBox();
            this.chkGreenTea = new System.Windows.Forms.CheckBox();
            this.chkTea = new System.Windows.Forms.CheckBox();
            this.chkCoffee = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudChicken = new System.Windows.Forms.NumericUpDown();
            this.nudBeef = new System.Windows.Forms.NumericUpDown();
            this.nudFish = new System.Windows.Forms.NumericUpDown();
            this.nudBiryani = new System.Windows.Forms.NumericUpDown();
            this.chkChicken = new System.Windows.Forms.CheckBox();
            this.chkBeef = new System.Windows.Forms.CheckBox();
            this.chkFish = new System.Windows.Forms.CheckBox();
            this.chkBiryani = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvOrderData = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColdDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreenTea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoffee)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChicken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBeef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBiryani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 54);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coffee Shop POS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 502);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 31);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudColdDrink);
            this.groupBox1.Controls.Add(this.nudGreenTea);
            this.groupBox1.Controls.Add(this.nudTea);
            this.groupBox1.Controls.Add(this.nudCoffee);
            this.groupBox1.Controls.Add(this.chkColdDrink);
            this.groupBox1.Controls.Add(this.chkGreenTea);
            this.groupBox1.Controls.Add(this.chkTea);
            this.groupBox1.Controls.Add(this.chkCoffee);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            // 
            // nudColdDrink
            // 
            this.nudColdDrink.Location = new System.Drawing.Point(119, 153);
            this.nudColdDrink.Name = "nudColdDrink";
            this.nudColdDrink.Size = new System.Drawing.Size(120, 20);
            this.nudColdDrink.TabIndex = 7;
            // 
            // nudGreenTea
            // 
            this.nudGreenTea.Location = new System.Drawing.Point(119, 118);
            this.nudGreenTea.Name = "nudGreenTea";
            this.nudGreenTea.Size = new System.Drawing.Size(120, 20);
            this.nudGreenTea.TabIndex = 6;
            // 
            // nudTea
            // 
            this.nudTea.Location = new System.Drawing.Point(119, 76);
            this.nudTea.Name = "nudTea";
            this.nudTea.Size = new System.Drawing.Size(120, 20);
            this.nudTea.TabIndex = 5;
            // 
            // nudCoffee
            // 
            this.nudCoffee.Location = new System.Drawing.Point(119, 35);
            this.nudCoffee.Name = "nudCoffee";
            this.nudCoffee.Size = new System.Drawing.Size(120, 20);
            this.nudCoffee.TabIndex = 4;
            // 
            // chkColdDrink
            // 
            this.chkColdDrink.AutoSize = true;
            this.chkColdDrink.Location = new System.Drawing.Point(16, 153);
            this.chkColdDrink.Name = "chkColdDrink";
            this.chkColdDrink.Size = new System.Drawing.Size(75, 17);
            this.chkColdDrink.TabIndex = 3;
            this.chkColdDrink.Text = "Cold Drink";
            this.chkColdDrink.UseVisualStyleBackColor = true;
            // 
            // chkGreenTea
            // 
            this.chkGreenTea.AutoSize = true;
            this.chkGreenTea.Location = new System.Drawing.Point(16, 118);
            this.chkGreenTea.Name = "chkGreenTea";
            this.chkGreenTea.Size = new System.Drawing.Size(77, 17);
            this.chkGreenTea.TabIndex = 2;
            this.chkGreenTea.Text = "Green Tea";
            this.chkGreenTea.UseVisualStyleBackColor = true;
            // 
            // chkTea
            // 
            this.chkTea.AutoSize = true;
            this.chkTea.Location = new System.Drawing.Point(16, 76);
            this.chkTea.Name = "chkTea";
            this.chkTea.Size = new System.Drawing.Size(45, 17);
            this.chkTea.TabIndex = 1;
            this.chkTea.Text = "Tea";
            this.chkTea.UseVisualStyleBackColor = true;
            // 
            // chkCoffee
            // 
            this.chkCoffee.AutoSize = true;
            this.chkCoffee.Location = new System.Drawing.Point(16, 38);
            this.chkCoffee.Name = "chkCoffee";
            this.chkCoffee.Size = new System.Drawing.Size(57, 17);
            this.chkCoffee.TabIndex = 0;
            this.chkCoffee.Text = "Coffee";
            this.chkCoffee.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudChicken);
            this.groupBox2.Controls.Add(this.nudBeef);
            this.groupBox2.Controls.Add(this.nudFish);
            this.groupBox2.Controls.Add(this.nudBiryani);
            this.groupBox2.Controls.Add(this.chkChicken);
            this.groupBox2.Controls.Add(this.chkBeef);
            this.groupBox2.Controls.Add(this.chkFish);
            this.groupBox2.Controls.Add(this.chkBiryani);
            this.groupBox2.Location = new System.Drawing.Point(313, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 195);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items";
            // 
            // nudChicken
            // 
            this.nudChicken.Location = new System.Drawing.Point(119, 153);
            this.nudChicken.Name = "nudChicken";
            this.nudChicken.Size = new System.Drawing.Size(120, 20);
            this.nudChicken.TabIndex = 7;
            // 
            // nudBeef
            // 
            this.nudBeef.Location = new System.Drawing.Point(119, 117);
            this.nudBeef.Name = "nudBeef";
            this.nudBeef.Size = new System.Drawing.Size(120, 20);
            this.nudBeef.TabIndex = 6;
            // 
            // nudFish
            // 
            this.nudFish.Location = new System.Drawing.Point(119, 76);
            this.nudFish.Name = "nudFish";
            this.nudFish.Size = new System.Drawing.Size(120, 20);
            this.nudFish.TabIndex = 5;
            // 
            // nudBiryani
            // 
            this.nudBiryani.Location = new System.Drawing.Point(119, 35);
            this.nudBiryani.Name = "nudBiryani";
            this.nudBiryani.Size = new System.Drawing.Size(120, 20);
            this.nudBiryani.TabIndex = 4;
            // 
            // chkChicken
            // 
            this.chkChicken.AutoSize = true;
            this.chkChicken.Location = new System.Drawing.Point(16, 153);
            this.chkChicken.Name = "chkChicken";
            this.chkChicken.Size = new System.Drawing.Size(65, 17);
            this.chkChicken.TabIndex = 3;
            this.chkChicken.Text = "Chicken";
            this.chkChicken.UseVisualStyleBackColor = true;
            // 
            // chkBeef
            // 
            this.chkBeef.AutoSize = true;
            this.chkBeef.Location = new System.Drawing.Point(16, 118);
            this.chkBeef.Name = "chkBeef";
            this.chkBeef.Size = new System.Drawing.Size(48, 17);
            this.chkBeef.TabIndex = 2;
            this.chkBeef.Text = "Beef";
            this.chkBeef.UseVisualStyleBackColor = true;
            // 
            // chkFish
            // 
            this.chkFish.AutoSize = true;
            this.chkFish.Location = new System.Drawing.Point(16, 76);
            this.chkFish.Name = "chkFish";
            this.chkFish.Size = new System.Drawing.Size(45, 17);
            this.chkFish.TabIndex = 1;
            this.chkFish.Text = "Fish";
            this.chkFish.UseVisualStyleBackColor = true;
            // 
            // chkBiryani
            // 
            this.chkBiryani.AutoSize = true;
            this.chkBiryani.Location = new System.Drawing.Point(16, 38);
            this.chkBiryani.Name = "chkBiryani";
            this.chkBiryani.Size = new System.Drawing.Size(57, 17);
            this.chkBiryani.TabIndex = 0;
            this.chkBiryani.Text = "Biryani";
            this.chkBiryani.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(600, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 42);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvOrderData
            // 
            this.dgvOrderData.AllowUserToAddRows = false;
            this.dgvOrderData.AllowUserToDeleteRows = false;
            this.dgvOrderData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderData.Location = new System.Drawing.Point(12, 303);
            this.dgvOrderData.Name = "dgvOrderData";
            this.dgvOrderData.ReadOnly = true;
            this.dgvOrderData.Size = new System.Drawing.Size(740, 183);
            this.dgvOrderData.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(621, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Bill";
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.AutoSize = true;
            this.lblTotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBill.Location = new System.Drawing.Point(637, 157);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(50, 16);
            this.lblTotalBill.TabIndex = 8;
            this.lblTotalBill.Text = "label3";
            this.lblTotalBill.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 533);
            this.Controls.Add(this.lblTotalBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvOrderData);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColdDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreenTea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoffee)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChicken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBeef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBiryani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkColdDrink;
        private System.Windows.Forms.CheckBox chkGreenTea;
        private System.Windows.Forms.CheckBox chkTea;
        private System.Windows.Forms.CheckBox chkCoffee;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkChicken;
        private System.Windows.Forms.CheckBox chkBeef;
        private System.Windows.Forms.CheckBox chkFish;
        private System.Windows.Forms.CheckBox chkBiryani;
        private System.Windows.Forms.NumericUpDown nudColdDrink;
        private System.Windows.Forms.NumericUpDown nudGreenTea;
        private System.Windows.Forms.NumericUpDown nudTea;
        private System.Windows.Forms.NumericUpDown nudCoffee;
        private System.Windows.Forms.NumericUpDown nudChicken;
        private System.Windows.Forms.NumericUpDown nudBeef;
        private System.Windows.Forms.NumericUpDown nudFish;
        private System.Windows.Forms.NumericUpDown nudBiryani;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvOrderData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalBill;
    }
}

