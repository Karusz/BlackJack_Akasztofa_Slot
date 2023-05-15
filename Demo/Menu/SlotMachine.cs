using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class SlotMachine : Form
    {
        Form opener;
        public SlotMachine(Form parentForm)
        {
            InitializeComponent();
            this.opener = parentForm;
        }

        private void SlotMachine_Load(object sender, EventArgs e)
        {

        }
    }
}
