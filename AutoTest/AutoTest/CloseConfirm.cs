using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTest
{
    public partial class CloseConfirm_form : Form
    {
        public AutoTestMain OwningWindowSettings { get; set; }

        public CloseConfirm_form()
        {
            InitializeComponent();
        }

        private void Yes_button_Click(object sender, EventArgs e)
        {
            this.Close();
            if (OwningWindowSettings != null)
                OwningWindowSettings.Close();
        }

        void CloseConfirm_form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Y)
            {
                this.Close();
                if (OwningWindowSettings != null)
                    OwningWindowSettings.Close();
            } else if (e.KeyCode == Keys.N)
            {
                this.Close();
            }
        }

        private void No_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
