using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class Calculator : System.Web.UI.Page
    {
        public int FirstNumber;
        public int SecondNumber;
        public int Solution;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            Solution = Convert.ToInt32(TxtNumberOne.Text) - Convert.ToInt32(TxtNumberTwo.Text);
            TxtNumberOne.Text = "";
            TxtNumberTwo.Text = "";
            LblSolution.Text = Solution.ToString();
        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
         
        }

        protected void Btn2_Click(object sender, EventArgs e)
        {
          
        }

        protected void Btn3_Click(object sender, EventArgs e)
        {
         
        }

        protected void Btn4_Click(object sender, EventArgs e)
        {
           
        }

        protected void Btn5_Click(object sender, EventArgs e)
        {
     
        }

        protected void Btn6_Click(object sender, EventArgs e)
        {
       
        }

        protected void Btn0_Click(object sender, EventArgs e)
        {
           
        }

        protected void Btn7_Click(object sender, EventArgs e)
        {
       
        }

        protected void Btn8_Click(object sender, EventArgs e)
        {
        }

        protected void Btn9_Click(object sender, EventArgs e)
        {
         
        }

        protected void BtnAdd2_Click(object sender, EventArgs e)
        {
            Solution = Convert.ToInt32(TxtNumberOne.Text) + Convert.ToInt32(TxtNumberTwo.Text);
            TxtNumberOne.Text = "";
            TxtNumberTwo.Text = "";
            LblSolution.Text = Solution.ToString();
        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            TxtNumberOne.Text = "";
            TxtNumberTwo.Text = "";
            LblSolution.Text = "";
          
        }

        protected void TxtOutput0_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnDivision_Click(object sender, EventArgs e)
        {
            Solution= Convert.ToInt32(TxtNumberOne.Text) / Convert.ToInt32(TxtNumberTwo.Text);
            TxtNumberOne.Text = "";
            TxtNumberTwo.Text = "";
            LblSolution.Text = Solution.ToString();
               
        }

        protected void BtnMultiply_Click(object sender, EventArgs e)
        {
            Solution = Convert.ToInt32(TxtNumberOne.Text) * Convert.ToInt32(TxtNumberTwo.Text);
            TxtNumberOne.Text = "";
            TxtNumberTwo.Text = "";
            LblSolution.Text = Solution.ToString();
        }
    }
}