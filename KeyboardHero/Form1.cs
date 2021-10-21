using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardHero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        OleDbConnection connection = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        public static List<string> highscores = new List<string>();
        int lives = 5;
        int score;
        Random gen = new Random();
        frmMenu openMenu = new frmMenu();
        PictureBox[] tiles;
        int rr1; int rr2; int rr3; int rr4; int rr5;
        public static string k1, k2, k3, k4;
       

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\334327\Documents\KeyboardScores.accdb; Persist Security Info=True;";
            //open the dbase
            connection.Open();

            //load all data into the dgv
            string showAllData = "Select * from KHighScores";
            OleDbCommand ShowData = new OleDbCommand(showAllData, connection);
            OleDbDataAdapter da = new OleDbDataAdapter(ShowData);
            dt.Clear();
            da.Fill(dt);
            
            //close the database
            connection.Close();
            */

            //loading new tiles randomly
            LoadingTiles();

            //putting all pictureboxes in Tiles Array because why not
            tiles = this.Controls.OfType<PictureBox>().OrderBy(x => x.Name).ToArray();

            //bringing key labels to front
            lblKey1.BringToFront();lblKey2.BringToFront();lblKey3.BringToFront();lblKey4.BringToFront();

            //presetting the keys so the program doesn't break
            k1 = "Q"; k2 = "W"; k3 = "E"; k4 = "R";
        }

        private void LoadingTiles()
        {
            //Row 1
            int r1 = gen.Next(1, 5);
            if (r1 == 1) { pb1.BackColor = Color.DarkSlateBlue;rr1 = 1; }
            else if (r1 == 2) { pb6.BackColor = Color.DarkSlateBlue;rr1 = 6; }
            else if (r1 == 3) { pb11.BackColor = Color.DarkSlateBlue;rr1 = 11; }
            else if (r1 == 4) { pb16.BackColor = Color.DarkSlateBlue;rr1 = 16; }

            //Row 2
            int r2 = gen.Next(1, 5);
            if (r2==1) { pb2.BackColor = Color.DarkSlateBlue;rr2 = 2;  }
            else if (r2==2) { pb7.BackColor = Color.DarkSlateBlue;rr2 = 7;  }
            else if (r2 == 3) { pb12.BackColor = Color.DarkSlateBlue;rr2 = 12;  }
            else if (r2 == 4) { pb17.BackColor = Color.DarkSlateBlue;rr2 = 17;  }
            
            //Row3
            int r3 = gen.Next(1, 5);
            if (r3 == 1) { pb3.BackColor = Color.DarkSlateBlue;rr3 = 3; }
            else if (r3 == 2) { pb8.BackColor = Color.DarkSlateBlue;rr3 = 8;  }
            else if (r3 == 3) { pb13.BackColor = Color.DarkSlateBlue;rr3 = 13;  }
            else if (r3 == 4) { pb18.BackColor = Color.DarkSlateBlue;rr3 = 18; }

            //Row4
            int r4 = gen.Next(1, 5);
            if (r4 == 1) { pb4.BackColor = Color.DarkSlateBlue;rr4 = 4; }
            else if (r4 == 2) { pb9.BackColor = Color.DarkSlateBlue;rr4 = 9;  }
            else if (r4 == 3) { pb14.BackColor = Color.DarkSlateBlue;rr4 = 14;  }
            else if (r4 == 4) { pb19.BackColor = Color.DarkSlateBlue;rr4 = 19;  }

            //Row5
            int r5 = gen.Next(1, 5);
            if (r5 == 1) { pb5.BackColor = Color.DarkSlateBlue;rr5 = 5; }
            else if (r5 == 2) { pb10.BackColor = Color.DarkSlateBlue;rr5 = 10;  }
            else if (r5 == 3) { pb15.BackColor = Color.DarkSlateBlue;rr5 = 15;  }
            else if (r5 == 4) { pb20.BackColor = Color.DarkSlateBlue;rr5 = 20;  }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //(Keys)Enum.Parse(typeof(Keys), k1, true)) just sets the key to the string of k1, k1 is declaring keys1 from frmMenu
            if (e.KeyCode == (Keys)Enum.Parse(typeof(Keys), k1, true))
            {
                if (pb5.BackColor == Color.DarkSlateBlue)
                {
                    score += 1;
                    CheckingTiles();                    
                }
                else {; lives -= 1; lblLives.Text = lives.ToString(); if (lives == 0) { EndGame(); } }                               
            }
            if (e.KeyCode == (Keys)Enum.Parse(typeof(Keys), k2, true))
            {
                if (pb10.BackColor == Color.DarkSlateBlue)
                {
                    score += 1;
                    CheckingTiles();                   
                }
                else { ; lives -= 1; lblLives.Text = lives.ToString(); if (lives == 0) { EndGame(); } }
            }
            if (e.KeyCode == (Keys)Enum.Parse(typeof(Keys), k3, true))
            {
                if (pb15.BackColor == Color.DarkSlateBlue)
                {
                    score += 1;
                    CheckingTiles();                    
                }
                else {  lives -= 1; lblLives.Text = lives.ToString(); if (lives == 0) { EndGame(); } }
                
            }
            if (e.KeyCode == (Keys)Enum.Parse(typeof(Keys), k4, true))
            {
                if (pb20.BackColor == Color.DarkSlateBlue)
                {
                    score += 1;
                    CheckingTiles();                   
                }  
                else {; lives -= 1; lblLives.Text = lives.ToString(); if (lives == 0) { EndGame(); } }
            }
            if (e.KeyCode == Keys.Escape) { Application.Exit(); }
        }

        private void CheckingTiles()
        {   
           //Order matters a lot
            ((PictureBox)this.Controls["pb" + rr5.ToString()]).BackColor = Color.Transparent;
            rr5 = rr4 + 1;            
            ((PictureBox)this.Controls["pb" + rr4.ToString()]).BackColor = Color.Transparent;
            ((PictureBox)this.Controls["pb" + rr5.ToString()]).BackColor = Color.DarkSlateBlue;            
            rr4 = rr3 + 1;
            ((PictureBox)this.Controls["pb" + rr3.ToString()]).BackColor = Color.Transparent;
            ((PictureBox)this.Controls["pb" + rr4.ToString()]).BackColor = Color.DarkSlateBlue;
            rr3 = rr2 + 1;
            ((PictureBox)this.Controls["pb" + rr2.ToString()]).BackColor = Color.Transparent;
            ((PictureBox)this.Controls["pb" + rr3.ToString()]).BackColor = Color.DarkSlateBlue;
            rr2 = rr1 + 1;
            ((PictureBox)this.Controls["pb" + rr1.ToString()]).BackColor = Color.Transparent;
            ((PictureBox)this.Controls["pb" + rr2.ToString()]).BackColor = Color.DarkSlateBlue;
            //setting top row to transparent, rr1 still is same number currently
            ((PictureBox)this.Controls["pb" + rr1.ToString()]).BackColor = Color.Transparent;
            //this random calls one of the top panels to get filled, resetting rr1 integer, which therefore resets the next integer after
            Random gen = new Random();
            var values = new[] { 1, 6, 11, 16 }; //the 4 numbers correspond to the top row of picture boxes
            rr1 = values[gen.Next(values.Length)]; //thx Parker
            ((PictureBox)this.Controls["pb" + rr1.ToString()]).BackColor = Color.DarkSlateBlue;
            lblScore.Text = score.ToString();
            if (lives == 0)
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            DialogResult dialogResult = MessageBox.Show("You ran out of lives. Your score was " + score + ". " + '\n' + "Would you like to play again?", "Score", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            openMenu.ShowDialog();
            ChangeKeyz();
        }

        private void ChangeKeyz()
        {
            k1 = frmMenu.keys1;
            k2 = frmMenu.keys2;
            k3 = frmMenu.keys3;
            k4 = frmMenu.keys4;
            lblKey1.Text = k1;
            lblKey2.Text = k2;
            lblKey3.Text = k3;
            lblKey4.Text = k4;
        }
    }
}
