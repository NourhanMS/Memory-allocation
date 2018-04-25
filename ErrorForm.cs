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
    public partial class ErrorForm : Form
    {
        public static string ID;
        public static char indicator = '0';
        public ErrorForm()
        {
            InitializeComponent();
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
            if (indicator == '0')
                txtError.Text = " Memory has no free space  to allocatee process " + ID + " , deallocate any process then try again";
            else if (indicator == '1')
                txtError.Text = " you have entered Holes larger than memory size , please Reset and re-enter your operations ";
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
