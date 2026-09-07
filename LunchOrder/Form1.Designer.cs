namespace LunchOrder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbxMainCourse = new GroupBox();
            radPizza = new RadioButton();
            radSalad = new RadioButton();
            radHamburger = new RadioButton();
            groupBox2 = new GroupBox();
            txtOrderTotal = new TextBox();
            label3 = new Label();
            txtSalesTax = new TextBox();
            label2 = new Label();
            txtSubtotal = new TextBox();
            label1 = new Label();
            btnPlaceOrder = new Button();
            btnExit = new Button();
            grpAddOns = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            gbxMainCourse.SuspendLayout();
            groupBox2.SuspendLayout();
            grpAddOns.SuspendLayout();
            SuspendLayout();
            // 
            // gbxMainCourse
            // 
            gbxMainCourse.Controls.Add(radPizza);
            gbxMainCourse.Controls.Add(radSalad);
            gbxMainCourse.Controls.Add(radHamburger);
            gbxMainCourse.Location = new Point(49, 28);
            gbxMainCourse.Name = "gbxMainCourse";
            gbxMainCourse.Size = new Size(227, 163);
            gbxMainCourse.TabIndex = 0;
            gbxMainCourse.TabStop = false;
            gbxMainCourse.Text = "Main Course";
            gbxMainCourse.Enter += gbxMainCourse_Enter;
            // 
            // radPizza
            // 
            radPizza.AutoSize = true;
            radPizza.Location = new Point(6, 119);
            radPizza.Name = "radPizza";
            radPizza.Size = new Size(76, 29);
            radPizza.TabIndex = 2;
            radPizza.Text = "Pizza";
            radPizza.UseVisualStyleBackColor = true;
            radPizza.CheckedChanged += radPizza_CheckedChanged;
            // 
            // radSalad
            // 
            radSalad.AutoSize = true;
            radSalad.Location = new Point(6, 84);
            radSalad.Name = "radSalad";
            radSalad.Size = new Size(80, 29);
            radSalad.TabIndex = 1;
            radSalad.Text = "Salad";
            radSalad.UseVisualStyleBackColor = true;
            radSalad.CheckedChanged += radSalad_CheckedChanged;
            // 
            // radHamburger
            // 
            radHamburger.AutoSize = true;
            radHamburger.Checked = true;
            radHamburger.Location = new Point(6, 49);
            radHamburger.Name = "radHamburger";
            radHamburger.Size = new Size(128, 29);
            radHamburger.TabIndex = 0;
            radHamburger.TabStop = true;
            radHamburger.Text = "Hamburger";
            radHamburger.UseVisualStyleBackColor = true;
            radHamburger.CheckedChanged += radHamburger_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtOrderTotal);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtSalesTax);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtSubtotal);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(49, 222);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(371, 192);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new Point(160, 127);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new Size(150, 31);
            txtOrderTotal.TabIndex = 5;
            txtOrderTotal.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 132);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 4;
            label3.Text = "Order Total:";
            // 
            // txtSalesTax
            // 
            txtSalesTax.Location = new Point(160, 83);
            txtSalesTax.Name = "txtSalesTax";
            txtSalesTax.ReadOnly = true;
            txtSalesTax.Size = new Size(150, 31);
            txtSalesTax.TabIndex = 3;
            txtSalesTax.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 88);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 2;
            label2.Text = "Tax (7.75%):";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(160, 38);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(150, 31);
            txtSubtotal.TabIndex = 1;
            txtSubtotal.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 43);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(457, 238);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(111, 42);
            btnPlaceOrder.TabIndex = 2;
            btnPlaceOrder.Text = "Place &Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(457, 370);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(111, 42);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // grpAddOns
            // 
            grpAddOns.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            grpAddOns.Controls.Add(checkBox3);
            grpAddOns.Controls.Add(checkBox2);
            grpAddOns.Controls.Add(checkBox1);
            grpAddOns.Location = new Point(310, 42);
            grpAddOns.Name = "grpAddOns";
            grpAddOns.Size = new Size(282, 149);
            grpAddOns.TabIndex = 4;
            grpAddOns.TabStop = false;
            grpAddOns.Text = "Add-on items ($.75/each)";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 105);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(128, 29);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "French fries";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 71);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(266, 29);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Ketchup, mustard, and mayo";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 36);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(260, 29);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Lettuce, tomato, and onions";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = btnPlaceOrder;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(619, 457);
            Controls.Add(grpAddOns);
            Controls.Add(btnExit);
            Controls.Add(btnPlaceOrder);
            Controls.Add(groupBox2);
            Controls.Add(gbxMainCourse);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jonathan Douglas' Lunch Order Application";
            gbxMainCourse.ResumeLayout(false);
            gbxMainCourse.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grpAddOns.ResumeLayout(false);
            grpAddOns.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox gbxMainCourse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private RadioButton radPizza;
        private RadioButton radSalad;
        private RadioButton radHamburger;
        private GroupBox grpAddOns;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}
