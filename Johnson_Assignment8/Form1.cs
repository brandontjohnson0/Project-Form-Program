using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Johnson_Assignment8
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void hourBox1A_MouseClick(object sender, MouseEventArgs e)
        {
            string clientA = clientNameA.Text;
            string contract1 = contractA.Text;
            string project1 = projectA.Text;
            if (string.IsNullOrEmpty(clientA))
            {
                MessageBox.Show("You must enter a client name", "Client Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clientNameA.Focus();
            }
            else if (string.IsNullOrEmpty(contract1))
            {
                MessageBox.Show("You must enter a contract name", "Contract Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractA.Focus();
            }
            else if (string.IsNullOrEmpty(project1))
            {
                MessageBox.Show("You must enter a project name", "Project Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractA.Focus();
            }

        }

        private void hourBox1B_MouseClick(object sender, MouseEventArgs e)
        {
            string clientB = clientNameB.Text;
            string contract2 = contractB.Text;
            string project2 = projectB.Text;
            if (string.IsNullOrEmpty(clientB))
            {
                MessageBox.Show("You must enter a client name", "Client Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clientNameB.Focus();
            }
            else if (string.IsNullOrEmpty(contract2))
            {
                MessageBox.Show("You must enter a contract name", "Contract Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractB.Focus();
            }
            else if (string.IsNullOrEmpty(project2))
            {
                MessageBox.Show("You must enter a project name", "Project Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractB.Focus();
            }

        }
        //*********************************************************************************************************************************************************************
        private void hourBox2A_MouseClick(object sender, MouseEventArgs e)
        {
            string clientA = clientNameA.Text;
            string contract1 = contractA.Text;
            string project1 = projectA.Text;
            if (string.IsNullOrEmpty(clientA))
            {
                MessageBox.Show("You must enter a client name", "Client Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clientNameA.Focus();
            }
            else if (string.IsNullOrEmpty(contract1))
            {
                MessageBox.Show("You must enter a contract name", "Contract Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractA.Focus();
            }
            else if (string.IsNullOrEmpty(project1))
            {
                MessageBox.Show("You must enter a project name", "Project Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractA.Focus();
            }
        }

        private void hourBox2B_MouseClick(object sender, MouseEventArgs e)
        {
            string clientB = clientNameB.Text;
            string contract2 = contractB.Text;
            string project2 = projectB.Text;
            if (string.IsNullOrEmpty(clientB))
            {
                MessageBox.Show("You must enter a client name", "Client Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clientNameB.Focus();
            }
            else if (string.IsNullOrEmpty(contract2))
            {
                MessageBox.Show("You must enter a contract name", "Contract Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractB.Focus();
            }
            else if (string.IsNullOrEmpty(project2))
            {
                MessageBox.Show("You must enter a project name", "Project Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractB.Focus();
            }
        }
        //*********************************************************************************************************************************************************************
        private void hourBox3A_MouseClick(object sender, MouseEventArgs e)
        {
            string clientA = clientNameA.Text;
            string contract1 = contractA.Text;
            string project1 = projectA.Text;
            if (string.IsNullOrEmpty(clientA))
            {
                MessageBox.Show("You must enter a client name", "Client Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clientNameA.Focus();
            }
            else if (string.IsNullOrEmpty(contract1))
            {
                MessageBox.Show("You must enter a contract name", "Contract Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractA.Focus();
            }
            else if (string.IsNullOrEmpty(project1))
            {
                MessageBox.Show("You must enter a project name", "Project Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractA.Focus();
            }
        }

        private void hourBox3B_MouseClick(object sender, MouseEventArgs e)
        {
            string clientB = clientNameB.Text;
            string contract2 = contractB.Text;
            string project2 = projectB.Text;
            if (string.IsNullOrEmpty(clientB))
            {
                MessageBox.Show("You must enter a client name", "Client Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clientNameB.Focus();
            }
            else if (string.IsNullOrEmpty(contract2))
            {
                MessageBox.Show("You must enter a contract name", "Contract Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractB.Focus();
            }
            else if (string.IsNullOrEmpty(project2))
            {
                MessageBox.Show("You must enter a project name", "Project Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractB.Focus();
            }
        }
        //*********************************************************************************************************************************************************************
        private void hourBox4A_MouseClick(object sender, MouseEventArgs e)
        {
            string clientA = clientNameA.Text;
            string contract1 = contractA.Text;
            string project1 = projectA.Text;
            if (string.IsNullOrEmpty(clientA))
            {
                MessageBox.Show("You must enter a client name", "Client Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clientNameA.Focus();
            }
            else if (string.IsNullOrEmpty(contract1))
            {
                MessageBox.Show("You must enter a contract name", "Contract Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractA.Focus();
            }
            else if (string.IsNullOrEmpty(project1))
            {
                MessageBox.Show("You must enter a project name", "Project Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractA.Focus();
            }
        }

        private void hourBox4B_MouseClick(object sender, MouseEventArgs e)
        {
            string clientB = clientNameB.Text;
            string contract2 = contractB.Text;
            string project2 = projectB.Text;
            if (string.IsNullOrEmpty(clientB))
            {
                MessageBox.Show("You must enter a client name", "Client Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clientNameB.Focus();
            }
            else if (string.IsNullOrEmpty(contract2))
            {
                MessageBox.Show("You must enter a contract name", "Contract Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractB.Focus();
            }
            else if (string.IsNullOrEmpty(project2))
            {
                MessageBox.Show("You must enter a project name", "Project Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractB.Focus();
            }
        }
        //*********************************************************************************************************************************************************************
        private void hourBox5A_MouseClick(object sender, MouseEventArgs e)
        {
            string clientA = clientNameA.Text;
            string contract1 = contractA.Text;
            string project1 = projectA.Text;
            if (string.IsNullOrEmpty(clientA))
            {
                MessageBox.Show("You must enter a client name", "Client Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clientNameA.Focus();
            }
            else if (string.IsNullOrEmpty(contract1))
            {
                MessageBox.Show("You must enter a contract name", "Contract Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractA.Focus();
            }
            else if (string.IsNullOrEmpty(project1))
            {
                MessageBox.Show("You must enter a project name", "Project Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractA.Focus();
            }
        }

        private void hourBox5B_MouseClick(object sender, MouseEventArgs e)
        {
            string clientB = clientNameB.Text;
            string contract2 = contractB.Text;
            string project2 = projectB.Text;
            if (string.IsNullOrEmpty(clientB))
            {
                MessageBox.Show("You must enter a client name", "Client Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clientNameB.Focus();
            }
            else if (string.IsNullOrEmpty(contract2))
            {
                MessageBox.Show("You must enter a contract name", "Contract Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractB.Focus();
            }
            else if (string.IsNullOrEmpty(project2))
            {
                MessageBox.Show("You must enter a project name", "Project Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractB.Focus();
            }
        }
        //*********************************************************************************************************************************************************************
        private void hourBox6A_MouseClick(object sender, MouseEventArgs e)
        {
            string clientA = clientNameA.Text;
            string contract1 = contractA.Text;
            string project1 = projectA.Text;
            if (string.IsNullOrEmpty(clientA))
            {
                MessageBox.Show("You must enter a client name", "Client Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clientNameA.Focus();
            }
            else if (string.IsNullOrEmpty(contract1))
            {
                MessageBox.Show("You must enter a contract name", "Contract Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractA.Focus();
            }
            else if (string.IsNullOrEmpty(project1))
            {
                MessageBox.Show("You must enter a project name", "Project Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractA.Focus();
            }
        }

        private void hourBox6B_MouseClick(object sender, MouseEventArgs e)
        {
            string clientB = clientNameB.Text;
            string contract2 = contractB.Text;
            string project2 = projectB.Text;
            if (string.IsNullOrEmpty(clientB))
            {
                MessageBox.Show("You must enter a client name", "Client Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clientNameB.Focus();
            }
            else if (string.IsNullOrEmpty(contract2))
            {
                MessageBox.Show("You must enter a contract name", "Contract Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractB.Focus();
            }
            else if (string.IsNullOrEmpty(project2))
            {
                MessageBox.Show("You must enter a project name", "Project Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractB.Focus();
            }
        }
        //*********************************************************************************************************************************************************************
        private void hourBox7A_MouseClick(object sender, MouseEventArgs e)
        {
            string clientA = clientNameA.Text;
            string contract1 = contractA.Text;
            string project1 = projectA.Text;
            if (string.IsNullOrEmpty(clientA))
            {
                MessageBox.Show("You must enter a client name", "Client Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clientNameA.Focus();
            }
            else if (string.IsNullOrEmpty(contract1))
            {
                MessageBox.Show("You must enter a contract name", "Contract Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractA.Focus();
            }
            else if (string.IsNullOrEmpty(project1))
            {
                MessageBox.Show("You must enter a project name", "Project Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractA.Focus();
            }
        }

        private void hourBox7B_MouseClick(object sender, MouseEventArgs e)
        {
            string clientB = clientNameB.Text;
            string contract2 = contractB.Text;
            string project2 = projectB.Text;
            if (string.IsNullOrEmpty(clientB))
            {
                MessageBox.Show("You must enter a client name", "Client Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clientNameB.Focus();
            }
            else if (string.IsNullOrEmpty(contract2))
            {
                MessageBox.Show("You must enter a contract name", "Contract Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractB.Focus();
            }
            else if (string.IsNullOrEmpty(project2))
            {
                MessageBox.Show("You must enter a project name", "Project Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contractB.Focus();
            }
        }

        private void numericReportWeek_ValueChanged(object sender, EventArgs e)
        {
            if (numericReportWeek.Value >= 52)
            {
                MessageBox.Show("You can only enter in a number from 1 to 52", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericReportWeek.Focus();
            }
        }
        //*********************************************************************************************************************************************************************

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* Primary function of this section is to tie certain rules to clicking submit.
         * Within this includes constraints for empty boxes and check boxes*/
        private void buttonSubmit_Click(object sender, EventArgs e) 
        {
            string userName = nameBox.Text;
            string report = numericReportWeek.Text;

            string monBoxA = hourBox1A.Text; //monday boxes and check
            string monBoxB = hourBox1B.Text;
            bool monCheck = mondayCheck.Checked;
            int monBoxAmountA;
            int monBoxAmountB;

            string tuesBoxA = hourBox2A.Text; //tuesday boxes and check
            string tuesBoxB = hourBox2B.Text;
            bool tuesCheck = tuesdayCheck.Checked;
            int tuesBoxAmountA;
            int tuesBoxAmountB;

            string wedBoxA = hourBox3A.Text; //wednesday boxes and check
            string wedBoxB = hourBox3B.Text;
            bool wedCheck = wednesdayCheck.Checked;
            int wedBoxAmountA;
            int wedBoxAmountB;

            string thursBoxA = hourBox4A.Text; //thursday boxes and check
            string thursBoxB = hourBox4B.Text;
            bool thursCheck = thursdayCheck.Checked;
            int thursBoxAmountA;
            int thursBoxAmountB;

            string friBoxA = hourBox5A.Text; //friday boxes and check
            string friBoxB = hourBox5B.Text;
            bool friCheck = fridayCheck.Checked;
            int friBoxAmountA;
            int friBoxAmountB;

            string satBoxA = hourBox6A.Text; //saturday boxes and check
            string satBoxB = hourBox6B.Text;
            bool satCheck = saturdayCheck.Checked;
            int satBoxAmountA;
            int satBoxAmountB;

            string sunBoxA = hourBox7A.Text; //sunday boxes and check
            string sunBoxB = hourBox7B.Text;
            bool sunCheck = sundayCheck.Checked;
            int sunBoxAmountA;
            int sunBoxAmountB;

            double sumA;
            double sumB;
            double totalHours;
            double overtime;
            double rate;

            monBoxAmountA = (Convert.ToInt32(hourBox1A.Text));
            monBoxAmountB = (Convert.ToInt32(hourBox1B.Text));
            tuesBoxAmountA = (Convert.ToInt32(hourBox2A.Text));
            tuesBoxAmountB = (Convert.ToInt32(hourBox2B.Text));
            wedBoxAmountA = (Convert.ToInt32(hourBox3A.Text));
            wedBoxAmountB = (Convert.ToInt32(hourBox3B.Text));
            thursBoxAmountA = (Convert.ToInt32(hourBox4A.Text));
            thursBoxAmountB = (Convert.ToInt32(hourBox4B.Text));
            friBoxAmountA = (Convert.ToInt32(hourBox5A.Text));
            friBoxAmountB = (Convert.ToInt32(hourBox5B.Text));
            satBoxAmountA = (Convert.ToInt32(hourBox6A.Text));
            satBoxAmountB = (Convert.ToInt32(hourBox6B.Text));
            sunBoxAmountA = (Convert.ToInt32(hourBox7A.Text));
            sunBoxAmountB = (Convert.ToInt32(hourBox7B.Text));

            sumA = (monBoxAmountA + tuesBoxAmountA + wedBoxAmountA + thursBoxAmountA + friBoxAmountA + satBoxAmountA + sunBoxAmountA);
            sumB = (monBoxAmountB + tuesBoxAmountB + wedBoxAmountB + thursBoxAmountB + friBoxAmountB + satBoxAmountB + sunBoxAmountB);

            totalHours = (sumA + sumB);
            if (totalHours > 40)
            {
                overtime = (totalHours - 40);
            }

            else
            {
                overtime = 0;
            }
            rate = (totalHours * 15) + (overtime * (1.5 * 15));
            string Response = string.Format($"Hello, {userName}, your rate is {rate} ");
            MessageBox.Show(Response, "Hello Message");


            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please provide a name", "Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameBox.Focus();
            }

            if (string.IsNullOrEmpty(report)) 
            {
                MessageBox.Show("Please provide a week number", "Missing Week Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //*********************************************************************************************************************************************************************
            if (string.IsNullOrEmpty(monBoxA)) //Each of these checks if the text box is empty, and if the check box coinciding with the box is checked or not. Gives error if no.
            {
                if (mondayCheck.Checked == false)
                {
                    MessageBox.Show("Missing Entry - Please specify a Weekend/Vacation/Holiday", "Blank Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                

            }
            

            if (string.IsNullOrEmpty(monBoxB))
            {
                if (mondayCheck.Checked == false)
                {
                    MessageBox.Show("Missing Entry - Did you forget a 0 or to specify a Weekend/Vacation/Holiday?", "Blank Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            
            //*******************************************************************************************************************************************************************
            if (string.IsNullOrEmpty(tuesBoxA))
            {
                if (tuesdayCheck.Checked == false)
                {
                    MessageBox.Show("Missing Entry - Did you forget a 0 or to specify a Weekend/Vacation/Holiday?", "Blank Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            
            if (string.IsNullOrEmpty(tuesBoxB))
            {
                if (tuesdayCheck.Checked == false)
                {
                    MessageBox.Show("Missing Entry - Did you forget a 0 or to specify a Weekend/Vacation/Holiday?", "Blank Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            
            //*******************************************************************************************************************************************************************
            if (string.IsNullOrEmpty(wedBoxA))
            {
                if (wednesdayCheck.Checked == false)
                {
                    MessageBox.Show("Missing Entry - Did you forget a 0 or to specify a Weekend/Vacation/Holiday?", "Blank Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            
            if (string.IsNullOrEmpty(wedBoxB))
            {
                if (wednesdayCheck.Checked == false)
                {
                    MessageBox.Show("Missing Entry - Did you forget a 0 or to specify a Weekend/Vacation/Holiday?", "Blank Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            
            //*******************************************************************************************************************************************************************
            if (string.IsNullOrEmpty(thursBoxA))
            {
                if (thursdayCheck.Checked == false)
                {
                    MessageBox.Show("Missing Entry - Did you forget a 0 or to specify a Weekend/Vacation/Holiday?", "Blank Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            
            if (string.IsNullOrEmpty(thursBoxB))
            {
                if (thursdayCheck.Checked == false)
                {
                    MessageBox.Show("Missing Entry - Did you forget a 0 or to specify a Weekend/Vacation/Holiday?", "Blank Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            
            //*******************************************************************************************************************************************************************
            if (string.IsNullOrEmpty(friBoxA))
            {
                if (fridayCheck.Checked == false)
                {
                    MessageBox.Show("Missing Entry - Did you forget a 0 or to specify a Weekend/Vacation/Holiday?", "Blank Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                

               
            }
            
            if (string.IsNullOrEmpty(friBoxB))
            {
                if (fridayCheck.Checked == false)
                {
                    MessageBox.Show("Missing Entry - Did you forget a 0 or to specify a Weekend/Vacation/Holiday?", "Blank Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            
            //*******************************************************************************************************************************************************************
            if (string.IsNullOrEmpty(satBoxA))
            {
                if (saturdayCheck.Checked == false)
                {
                    MessageBox.Show("Missing Entry - Did you forget a 0 or to specify a Weekend/Vacation/Holiday?", "Blank Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                

            }
            
            if (string.IsNullOrEmpty(satBoxB))
            {
                if (saturdayCheck.Checked == false)
                {
                    MessageBox.Show("Missing Entry - Did you forget a 0 or to specify a Weekend/Vacation/Holiday?", "Blank Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                

            }
            
            //*********************************************************************************************************************************************************************
            if (string.IsNullOrEmpty(sunBoxA))
            {
                if (sundayCheck.Checked == false)
                {
                    MessageBox.Show("Missing Entry - Did you forget a 0 or to specify a Weekend/Vacation/Holiday?", "Blank Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                

            }
            
            if (string.IsNullOrEmpty(sunBoxB))
            {
                if (sundayCheck.Checked == false)
                {
                    MessageBox.Show("Missing Entry - Did you forget a 0 or to specify a Weekend/Vacation/Holiday?", "Blank Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                

            }
            
            //*********************************************************************************************************************************************************************

        }



            
            
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //ignore
        {
            string monBoxA = hourBox1A.Text; 
            

        }

        private void textBox11_TextChanged(object sender, EventArgs e) //ignore
        {
            string monBoxB = hourBox1B.Text;

        }

        private void reportWeek_TextChanged(object sender, EventArgs e) //checks if user enters in number under 1 and over 52. CURRENT PROBLEM: if user clears box, exception is thrown and kicks user out of program.
        {

        }

        private void clientNameA_MouseClick(object sender, MouseEventArgs e) //ignore
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }
        /*This set of code makes sure the user cannot edit 
* the hours until they fill out relevant information*/


    }

}
