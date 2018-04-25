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
    public partial class resultForm : Form
    {
        public resultForm()
        {
            InitializeComponent();
        }

        private void resultForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
          
            //re-order the free space to gather near holes together
           for (int i = 0; i < Form1.numberOfHoles - 1; i++) //sort free space according to locating address
           {
               bool is_sorted = true;
               for (int j = 0; j < Form1.numberOfHoles - i - 1; j++)
               {
                   if (Form1.freeSpace[j][1] >Form1. freeSpace[j + 1][1])
                   {
                       is_sorted = false;
                       //swap                     
                       uint temp = Form1.freeSpace[j][0];
                       uint temp2 = Form1.freeSpace[j][1];
                       Form1.freeSpace[j][0] = Form1.freeSpace[j + 1][0];
                       Form1.freeSpace[j][1] =Form1. freeSpace[j + 1][1];
                       Form1. freeSpace[j + 1][0] = temp;
                       Form1.freeSpace[j + 1][1] = temp2;

                   }
               }
               if (is_sorted) break;

           }
           for (int i = 0; i < Form1.freeSpace.Count-1; i++)
           {
               for (int j = i+1; j < Form1.freeSpace.Count; j++)
               {
                   if (Form1.freeSpace[i][1]+Form1.freeSpace[i][0]  == Form1.freeSpace[j][1])
                   {
                       Form1.freeSpace[i][0] += Form1.freeSpace[j][0]; //add the size to the hole
                       Form1.freeSpace.RemoveAt(j);
                       Form1.numberOfHoles--;
                   }

               }
           }

            for (int i = 0; i <Form1. freeSpace.Count; i++)
            {
                dataGridView1.Rows.Add();
                uint first =Form1. freeSpace[i][1];
                uint last = Form1.freeSpace[i][1] +Form1. freeSpace[i][0] - 1;
                dataGridView1.Rows[i].Cells[0].Value = Form1.freeSpace[i][0].ToString();
                dataGridView1.Rows[i].Cells[1].Value = first.ToString();
                this.chart1.Series["Holes"].Points.AddXY("Hole" + i, first, last);
            }

            for (int i = 0; i < Form1.AllocatedProcesses.Count; i++)
            {
                dataGridView2.Rows.Add();
                string name = Form1.AllocatedProcesses[i].getPID();
                uint first = Form1.AllocatedProcesses[i].getStartingAddress();
                uint last = Form1.AllocatedProcesses[i].getFinalAddress();
                dataGridView2.Rows[i].Cells[0].Value = name;
                dataGridView2.Rows[i].Cells[1].Value = Form1.AllocatedProcesses[i].getSize().ToString();
                dataGridView2.Rows[i].Cells[2].Value = first.ToString();
                this.chart1.Series["allocated_processes"].Points.AddXY(name, first, last);
            }
            chart1.Visible = true;

        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
