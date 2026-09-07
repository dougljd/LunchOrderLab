using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
namespace LunchOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gbxMainCourse_Enter(object sender, EventArgs e)
        {

        }

        //Jonathan Douglas
        private void radHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (radHamburger.Checked)
            {
                grpAddOns.Text = "Add-on items ($.75/each)";
                checkBox1.Text = "Lettuce, tomato, and onions";
                checkBox2.Text = "Ketchup, mustard, and mayo";
                checkBox3.Text = "French fries";
                ClearAddOns();
                ClearTotals();
            }
        }
        private void ClearTotals()
        {
            txtSubtotal.Text = "";
            txtSalesTax.Text = "";
            txtOrderTotal.Text = "";
        }

        private void ClearAddOns()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void AddOn_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }

        //Jonathan Douglas
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0m;
            decimal addOnCost = 0m;

            if (radHamburger.Checked)
            {
                subtotal += 6.95m;
                addOnCost = 0.75m;
            }
            else if (radPizza.Checked)
            {
                subtotal += 5.95m;
                addOnCost = 0.50m;
            }
            else if (radSalad.Checked)
            {
                subtotal += 4.95m;
                addOnCost = 0.25m;
            }

            if (checkBox1.Checked) subtotal += addOnCost;
            if (checkBox2.Checked) subtotal += addOnCost;
            if (checkBox3.Checked) subtotal += addOnCost;

            decimal tax = subtotal * 0.0775m;
            decimal total = subtotal + tax;

            txtSubtotal.Text = subtotal.ToString("c");
            txtSalesTax.Text = tax.ToString("c");
            txtOrderTotal.Text = total.ToString("c");
        }

        //Jonathan Douglas
        private void radSalad_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radSalad.Checked)
            {
                grpAddOns.Text = "Add-on items ($.25/each)";
                checkBox1.Text = "Croutons";
                checkBox2.Text = "Bacon bits";
                checkBox3.Text = "Bread sticks";
                ClearAddOns();
                ClearTotals();
            }
        }
        //Jonathan Douglas
        private void radPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (radPizza.Checked)
            {
                grpAddOns.Text = "Add-on items ($.50/each)";
                checkBox1.Text = "Pepperoni";
                checkBox2.Text = "Sausage";
                checkBox3.Text = "Olives";
                ClearAddOns();
                ClearTotals();
            }
        }
    }
}