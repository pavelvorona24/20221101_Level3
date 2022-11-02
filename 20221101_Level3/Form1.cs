using System.Net.Security;

namespace _20221101_Level3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //define variables
            int number1, number2, sum, newnumber1;
            
            //convert text to integer from form variables
            number1 = Convert.ToInt32(n1.Text);
            number2 = Convert.ToInt32(n2.Text);

            // assign variables to reduce loop iterations by 1
            sum = 0;
            newnumber1 = number1;
            // check if number is even to add 1 if true 
            if ( number1 % 2 == 0 )
            {
                newnumber1 = newnumber1 + 1;
            }
            // begin loop comparing increased newnumber1 with number2 from the form
            while (newnumber1 < number2)
            {
                //calculate sum through addition of newnumber in every iteration
                sum = sum + newnumber1 ;
                // skip to next odd number every iteration
                newnumber1 = newnumber1 + 2;

            }
           
            
            // output sum
            
            lblOutput.Text = sum.ToString();
        }
    }
}
 