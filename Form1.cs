using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contiguous_memory_allocation
{

    public partial class Form1 : Form
    {

        char index; //to check the algorith ( 1-> first fit )(2->best fit) (0-> deallocation)
        public static List<process> AllocatedProcesses;

        public static List<List<UInt32>> freeSpace;
        public static int numberOfHoles;
        int numOfProcesses;
        int MemorySize;
        public Form1()
        {
            InitializeComponent();
            AllocatedProcesses = new List<process>();        
            index = '0';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView2.Enabled = false;
            btnAllocate.Enabled = false;
            btnDeallocate.Enabled = false;
            btnReallocate.Enabled = false;
            txtProcess.Enabled = false;
            formState.Visible = false;
            chkBestFit.Enabled = false;
            chkFirstFit.Enabled = false;


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            formState.Visible = true;
            if (index == '1') //Allocation First fit
            {
                for (int i = 0; i < numberOfHoles - 1; i++) //sort free space according to locating address
                {
                    bool is_sorted = true;
                    for (int j = 0; j < numberOfHoles - i - 1; j++)
                    {
                        if (freeSpace[j][1] > freeSpace[j + 1][1])
                        {
                            is_sorted = false;
                            //swap                     
                            uint temp = freeSpace[j][0];
                            uint temp2 = freeSpace[j][1];
                            freeSpace[j][0] = freeSpace[j + 1][0];
                            freeSpace[j][1] = freeSpace[j + 1][1];
                            freeSpace[j + 1][0] = temp;
                            freeSpace[j + 1][1] = temp2;

                        }
                    }
                    if (is_sorted) break;

                }

                for (int i = 0; i < numOfProcesses; i++)
                {
                    string processID = dataGridView2.Rows[i].Cells[0].Value.ToString();
                    uint size = Convert.ToUInt32(dataGridView2.Rows[i].Cells[1].Value);
                    process A = new process(processID);
                    A.setSize(size); bool Allocated = false;
                    for (int j = 0; j < numberOfHoles; j++)
                    {
                        if (freeSpace[j][0] >= size)
                        {
                            Allocated = true;
                            A.setStartingAddress(freeSpace[j][1]);
                            freeSpace[j][0] = freeSpace[j][0] - size;
                            if (freeSpace[j][0] == 0)
                            {
                                freeSpace.Remove(freeSpace[j]);
                                numberOfHoles--;
                            }
                            else
                            {
                                freeSpace[j][1] = freeSpace[j][1] + size;
                            }

                            break;
                        }

                    }

                    if (Allocated)
                    {
                        AllocatedProcesses.Add(A);
                        dataGridView2.Rows[i].Cells[2].Value = "Allocated";
                    }
                    else
                    {
                        
                        ErrorForm Error = new ErrorForm();
                        dataGridView2.Rows[i].Cells[2].Value = "Not-Allocated";
                        ErrorForm.ID = processID;
                        Error.ShowDialog();
                    }


                }

                resultForm f = new resultForm();
                chkBestFit.Checked = false;
                chkFirstFit.Checked = false;
                f.ShowDialog();


            }
            else if (index == '2')  //Allocation best fit
            {
                bool Allocated = false;
                for (int i = 0; i < numOfProcesses; i++)
                {
                    for (int k = 0; k < numberOfHoles - 1; k++) //sort free space according to size
                    {
                        bool is_sorted = true;
                        for (int j = 0; j < numberOfHoles - i - 1; j++)
                        {
                            if (freeSpace[j][0] > freeSpace[j + 1][0])
                            {
                                is_sorted = false;
                                //swap
                                uint temp = freeSpace[j][0];
                                uint temp2 = freeSpace[j][1];
                                freeSpace[j][0] = freeSpace[j + 1][0];
                                freeSpace[j][1] = freeSpace[j + 1][1];
                                freeSpace[j + 1][0] = temp;
                                freeSpace[j + 1][1] = temp2;

                            }
                        }
                        if (is_sorted) break;

                    }




                    string processID = dataGridView2.Rows[i].Cells[0].Value.ToString();
                    uint size = Convert.ToUInt32(dataGridView2.Rows[i].Cells[1].Value);
                    process A = new process(processID);
                    A.setSize(size);
                    Allocated = false;
                    for (int j = 0; j < freeSpace.Count; j++)
                    {
                        if (freeSpace[j][0] >= size)
                        {
                            Allocated = true;
                            A.setStartingAddress(freeSpace[j][1]);
                            freeSpace[j][0] = freeSpace[j][0] - size;
                            if (freeSpace[j][0] == 0)
                            {
                                freeSpace.Remove(freeSpace[j]);
                                numberOfHoles--;
                            }
                            else
                            {
                                freeSpace[j][1] = freeSpace[j][1] + size;
                            }


                            break;

                        }

                    }
                    if (Allocated)
                    {
                        AllocatedProcesses.Add(A);
                        dataGridView2.Rows[i].Cells[2].Value = "Allocated";
                    }
                    else
                    {
                       
                        ErrorForm Error = new ErrorForm();
                        dataGridView2.Rows[i].Cells[2].Value = "Not-Allocated";
                        ErrorForm.ID = processID;
                        Error.ShowDialog();

                    }


                }


                resultForm f = new resultForm();
                chkBestFit.Checked = false;
                chkFirstFit.Checked = false;
                f.ShowDialog();



            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            freeSpace = new List<List<UInt32>>();
            uint sum = 0;
            for (int i = 0; i < numberOfHoles; i++)
            {
                freeSpace.Add(new List<UInt32>());
                freeSpace[i].Add(Convert.ToUInt32(dataGridView1.Rows[i].Cells[0].Value));
                freeSpace[i].Add(Convert.ToUInt32(dataGridView1.Rows[i].Cells[1].Value));
                sum += Convert.ToUInt32(dataGridView1.Rows[i].Cells[0].Value);
            }

            if (sum > MemorySize) //sum of holes > memory size 
            {
                ErrorForm Error = new ErrorForm();
                ErrorForm.indicator = '1';
                apply.Visible = false;
                txtMemorySize.Enabled = false;
                txtHoles.Enabled = false;
                dataGridView1.Enabled = false;
                Error.ShowDialog();

            }
            else
            {
                dataGridView1.Enabled = false;
                dataGridView2.Enabled = true;
                apply.Visible = false;
                btnAllocate.Enabled = true;
                btnReallocate.Enabled = true;
                btnDeallocate.Enabled = true;
                txtHoles.Enabled = false;
                txtProcess.Enabled = true;
                lblProcess.Enabled = true;
                txtMemorySize.Enabled = false;
                chkBestFit.Enabled = true;
                chkFirstFit.Enabled = true;
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtProcess.Text != "")
            {
                numOfProcesses = Convert.ToInt32(txtProcess.Text);
                for (int i = 0; i < numOfProcesses; i++)
                {
                    dataGridView2.Rows.Add();
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtHoles.Text != "")
            {
                numberOfHoles = Convert.ToInt32(txtHoles.Text);
                for (int i = 0; i < numberOfHoles; i++)
                {
                    dataGridView1.Rows.Add();
                }

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView1.Enabled = true;
            dataGridView2.Enabled = false;
            chkFirstFit.Checked = false;
            chkBestFit.Checked = false;
            txtMemorySize.Text = "";
            txtHoles.Text = "";
            btnAllocate.Enabled = false;
            apply.Visible = true;
            apply.Enabled = true;
            txtProcess.Text = "";
            AllocatedProcesses = new List<process>();

            txtHoles.Enabled = true;
            txtProcess.Enabled = false;
            lblProcess.Enabled = false;
            txtMemorySize.Enabled = true;
            chkBestFit.Visible = true;
            chkFirstFit.Visible = true;



        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if(txtMemorySize.Text !="")
            MemorySize = Convert.ToInt32(txtMemorySize.Text);
        }



        private void chkFirstFit_CheckedChanged(object sender, EventArgs e)
        {
            index = '1';

        }

        private void chkBestFit_CheckedChanged(object sender, EventArgs e)
        {
            index = '2';

        }






        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkDeallocate_CheckedChanged(object sender, EventArgs e)
        {
            index = '0';
            chkBestFit.Visible = false;
            chkFirstFit.Visible = false;
        }

        private void btnDeallocate_Click(object sender, EventArgs e)
        {
            //Deallocation
            index = '0';
            formState.Visible = true;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[3].Value))
                {
                    
                    for (int k = 0; k < AllocatedProcesses.Count; k++)
                    {
                        if( dataGridView2.Rows[i].Cells[0].Value.ToString() == AllocatedProcesses[k].getPID() )
                        {
                            freeSpace.Add(new List<UInt32>());
                            freeSpace[numberOfHoles].Add(AllocatedProcesses[k].getSize());
                            freeSpace[numberOfHoles].Add(AllocatedProcesses[k].getStartingAddress());
                            numberOfHoles++;
                            AllocatedProcesses.RemoveAt(k);
                            dataGridView2.Rows[i].Cells[2].Value = "Not-Allocated";
                            break;
                        }
                    }
                   

                }

            }


            resultForm f = new resultForm();
            f.ShowDialog();

        }

        private void btnReallocate_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
              
                if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[4].Value)) //re-allocate checked process is found 
                {
                    if (index == '1') //Allocation First fit
                    {

                        for (int k = 0; k < numberOfHoles - 1; k++) //sort free space according to locating address
                        {
                            bool is_sorted = true;
                            for (int j = 0; j < numberOfHoles - i - 1; j++)
                            {
                                if (freeSpace[j][1] > freeSpace[j + 1][1])
                                {
                                    is_sorted = false;
                                    //swap                     
                                    uint temp = freeSpace[j][0];
                                    uint temp2 = freeSpace[j][1];
                                    freeSpace[j][0] = freeSpace[j + 1][0];
                                    freeSpace[j][1] = freeSpace[j + 1][1];
                                    freeSpace[j + 1][0] = temp;
                                    freeSpace[j + 1][1] = temp2;

                                }
                            }
                            if (is_sorted) break;

                        }

                        string processID = dataGridView2.Rows[i].Cells[0].Value.ToString();
                        uint size = Convert.ToUInt32(dataGridView2.Rows[i].Cells[1].Value);
                        process A = new process(processID);
                        A.setSize(size); bool Allocated = false;
                        for (int j = 0; j < numberOfHoles; j++)
                        {
                            if (freeSpace[j][0] >= size)
                            {
                                Allocated = true;
                                A.setStartingAddress(freeSpace[j][1]);
                                freeSpace[j][0] = freeSpace[j][0] - size;
                                if (freeSpace[j][0] == 0)
                                {
                                    freeSpace.Remove(freeSpace[j]);
                                    numberOfHoles--;
                                }
                                else
                                {
                                    freeSpace[j][1] = freeSpace[j][1] + size;
                                }

                                break;
                            }

                        }

                        if (Allocated)
                        {
                            AllocatedProcesses.Add(A);
                            dataGridView2.Rows[i].Cells[2].Value = "Allocated";
                        }
                        else
                        {

                            ErrorForm Error = new ErrorForm();
                            dataGridView2.Rows[i].Cells[2].Value = "Not-Allocated";
                            ErrorForm.ID = processID;
                            Error.ShowDialog();
                        }

                    }
                    else if (index == '2')
                    {
                        for (int k = 0; k < numberOfHoles - 1; k++) //sort free space according to size
                        {
                            bool is_sorted = true;
                            for (int j = 0; j < numberOfHoles - i - 1; j++)
                            {
                                if (freeSpace[j][0] > freeSpace[j + 1][0])
                                {
                                    is_sorted = false;
                                    //swap
                                    uint temp = freeSpace[j][0];
                                    uint temp2 = freeSpace[j][1];
                                    freeSpace[j][0] = freeSpace[j + 1][0];
                                    freeSpace[j][1] = freeSpace[j + 1][1];
                                    freeSpace[j + 1][0] = temp;
                                    freeSpace[j + 1][1] = temp2;

                                }
                            }
                            if (is_sorted) break;

                        }
                        string processID = dataGridView2.Rows[i].Cells[0].Value.ToString();
                        uint size = Convert.ToUInt32(dataGridView2.Rows[i].Cells[1].Value);
                        process A = new process(processID);
                        A.setSize(size);
                        bool Allocated = false;
                        for (int j = 0; j < freeSpace.Count; j++)
                        {
                            if (freeSpace[j][0] >= size)
                            {
                                Allocated = true;
                                A.setStartingAddress(freeSpace[j][1]);
                                freeSpace[j][0] = freeSpace[j][0] - size;
                                if (freeSpace[j][0] == 0)
                                {
                                    freeSpace.Remove(freeSpace[j]);
                                    numberOfHoles--;
                                }
                                else
                                {
                                    freeSpace[j][1] = freeSpace[j][1] + size;
                                }


                                break;

                            }

                        }
                        if (Allocated)
                        {
                            AllocatedProcesses.Add(A);
                            dataGridView2.Rows[i].Cells[2].Value = "Allocated";
                        }
                        else
                        {
                            ErrorForm Error = new ErrorForm();
                            dataGridView2.Rows[i].Cells[2].Value = "Not-Allocated";
                            ErrorForm.ID = processID;
                            Error.ShowDialog();

                        }

                    }
                }
            }
            resultForm f = new resultForm();
            chkBestFit.Checked = false;
            chkFirstFit.Checked = false;
            f.ShowDialog();
        }

    }
   public  class process
    {
        private string PID;
        private uint size;
        private uint startingAddress;
        public process(string id) { PID = id; }
        public void setPID (string s) { PID=s;}
        public void setSize(uint s) { size = s; }
        public void setStartingAddress(uint s) { startingAddress = s; }
        public  string getPID() { return PID; }
        public uint getSize() { return size; }
        public uint getStartingAddress() {return startingAddress;}
        public uint getFinalAddress() { return startingAddress + size - 1; }

    };
}
