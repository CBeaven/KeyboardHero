using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardHero
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();           
        }
        int clicks = 0;
        public static string keys1;
        public static string keys2;
        public static string keys3;
        public static string keys4;

       

        private void frmMenu_Load(object sender, EventArgs e)
        {
            
        }

        #region BoardClick
        private void pbQ_Click(object sender, EventArgs e)
        {

            if (clicks == 0) { keys1 = "Q"; lblKey1.Text = keys1 + ", "; }
            if (clicks == 1) { keys2 = "Q"; lblKey2.Text = keys2 + ", "; }
            if (clicks == 2) { keys3 = "Q"; lblKey3.Text = keys3 + ", "; }
            if (clicks == 3) { keys4 = "Q"; lblKey4.Text = keys4 + " "; }
            Clicks();
                        
        }
        private void pbW_Click(object sender, EventArgs e)
        {
            if (clicks == 0) { keys1 = "W"; lblKey1.Text = keys1 + ", ";  }
            if (clicks == 1) { keys2 = "W"; lblKey2.Text = keys2 + ", ";  }
            if (clicks == 2) { keys3 = "W"; lblKey3.Text = keys3 + ", ";  }
            if (clicks == 3) { keys4 = "W"; lblKey4.Text = keys4 + " ";  }
            Clicks();
        }

        private void pbE_Click(object sender, EventArgs e)
        {
            if (clicks == 0) { keys1 = "E"; lblKey1.Text = keys1 + ", ";  }
            if (clicks == 1) { keys2 = "E"; lblKey2.Text = keys2 + ", ";  }
            if (clicks == 2) { keys3 = "E"; lblKey3.Text = keys3 + ", ";  }
            if (clicks == 3) { keys4 = "E"; lblKey4.Text = keys4 + " ";  }
            Clicks();
        }

        private void pbR_Click(object sender, EventArgs e)
        {
            if (clicks == 0) { keys1 = "R"; lblKey1.Text = keys1 + ", ";  }
            if (clicks == 1) { keys2 = "R"; lblKey2.Text = keys2 + ", ";  }
            if (clicks == 2) { keys3 = "R"; lblKey3.Text = keys3 + ", ";  }
            if (clicks == 3) { keys4 = "R"; lblKey4.Text = keys4 + " ";  }
            Clicks();
        }

        private void pbT_Click(object sender, EventArgs e)
        {
            if (clicks == 0) { keys1 = "T"; lblKey1.Text = keys1 + ", ";  }
            if (clicks == 1) { keys2 = "T"; lblKey2.Text = keys2 + ", ";  }
            if (clicks == 2) { keys3 = "T"; lblKey3.Text = keys3 + ", ";  }
            if (clicks == 3) { keys4 = "T"; lblKey4.Text = keys4 + " ";  }
            Clicks();
        }

        private void pbY_Click(object sender, EventArgs e)
        {
            if (clicks == 0) { keys1 = "Y"; lblKey1.Text = keys1 + ", ";  }
            if (clicks == 1) { keys2 = "Y"; lblKey2.Text = keys2 + ", ";  }
            if (clicks == 2) { keys3 = "Y"; lblKey3.Text = keys3 + ", ";  }
            if (clicks == 3) { keys4 = "Y"; lblKey4.Text = keys4 + " ";  }
            Clicks();
        }

        private void pbU_Click(object sender, EventArgs e)
        {
            if (clicks == 0) { keys1 = "U"; lblKey1.Text = keys1 + ", ";  }
            if (clicks == 1) { keys2 = "U"; lblKey2.Text = keys2 + ", ";  }
            if (clicks == 2) { keys3 = "U"; lblKey3.Text = keys3 + ", ";  }
            if (clicks == 3) { keys4 = "U"; lblKey4.Text = keys4 + " ";  }
            Clicks();
        }

        private void pbI_Click(object sender, EventArgs e)
        {
            if (clicks == 0) { keys1 = "I"; lblKey1.Text = keys1 + ", ";  }
            if (clicks == 1) { keys2 = "I"; lblKey2.Text = keys2 + ", ";  }
            if (clicks == 2) { keys3 = "I"; lblKey3.Text = keys3 + ", ";  }
            if (clicks == 3) { keys4 = "I"; lblKey4.Text = keys4 + " ";  }
            Clicks();
        }

        private void pbO_Click(object sender, EventArgs e)
        {
            if (clicks == 0) { keys1 = "O"; lblKey1.Text = keys1 + ", ";  }
            if (clicks == 1) { keys2 = "O"; lblKey2.Text = keys2 + ", ";  }
            if (clicks == 2) { keys3 = "O"; lblKey3.Text = keys3 + ", ";  }
            if (clicks == 3) { keys4 = "O"; lblKey4.Text = keys4 + " ";  }
            Clicks();
        }

        private void pbP_Click(object sender, EventArgs e)
        {
            if (clicks == 0) { keys1 = "P"; lblKey1.Text = keys1 + ", ";  }
            if (clicks == 1) { keys2 = "P"; lblKey2.Text = keys2 + ", ";  }
            if (clicks == 2) { keys3 = "P"; lblKey3.Text = keys3 + ", ";  }
            if (clicks == 3) { keys4 = "P"; lblKey4.Text = keys4 + " "; }
            Clicks();
        }
        #endregion

        private void Clicks()
        {
            if (clicks == 0 || clicks == 1 || clicks == 2) { clicks += 1; }
            if (clicks == 3) { clicks = 3; }
            
        }

        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { if (clicks == 3) { this.Close(); }; }
            if (e.KeyCode == Keys.Back) { ClicksBACK(); }           
            if (e.KeyCode == Keys.Escape) { this.Close(); keys1 = "Q"; keys2 = "W"; keys3 = "E"; keys4 = "R"; }
        }

        private void ClicksBACK()
        {
            if (clicks == 3) { keys4 = ""; lblKey4.Text = keys4 + " "; }
            if (clicks == 2) { keys3 = ""; lblKey3.Text = keys3 + ", "; }
            if (clicks == 1) { keys2 = ""; lblKey2.Text = keys2 + ", "; }
            if (clicks == 0) { keys1 = ""; lblKey1.Text = keys1 + ", "; }
            if (clicks == 3 || clicks == 2 || clicks == 1) { clicks -= 1; }
            if (clicks == 0) { clicks = 0; }
            
        }

        #region Useless
        private void Backspace_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        private void Backspace_MouseClick(object sender, MouseEventArgs e)
        {
            ClicksBACK();
        }
    }
}
