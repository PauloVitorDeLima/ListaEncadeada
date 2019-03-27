using MusicPlayer.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List list = new List();

        private void BtAddLast_Click(object sender, EventArgs e)
        {
            string Name = TxtBxName.Text;
            int Age = (int)NumericUpDownIdade.Value;
            list.InsertLast(Name, Age);
            RichTxtBxName.Clear();
            RichTxtBxName.AppendText("LISTA: \n");
            Node timer = list.Begin;
            while (timer != null)
            {
                RichTxtBxName.AppendText(timer.Name.ToString() +" ---------- "+ timer.Age.ToString() +" \n");
                timer = timer.Next;
            }
        }
        
        private void BtAddFirst_Click(object sender, EventArgs e)
        {
            
            string Name = TxtBxName.Text;
            int Age = (int)NumericUpDownIdade.Value;
            list.InsertFirst(Name, Age);
            RichTxtBxName.Clear();
            RichTxtBxName.AppendText("LISTA: \n");
            Node timer = list.Begin;
            while(timer != null)
            {
                RichTxtBxName.AppendText(timer.Name.ToString() + " ---------- " + timer.Age.ToString() + " \n");
                timer = timer.Next;
            }
        }

        private void BtRemoveFirst_Click(object sender, EventArgs e)
        {
            list.RemoveFirst();
            RichTxtBxName.Clear();
            RichTxtBxName.AppendText("LISTA: \n");
            Node timer = list.Begin;
            while (timer != null)
            {
                RichTxtBxName.AppendText(timer.Name.ToString() + " --------- " + timer.Age.ToString() + " \n");
                timer = timer.Next;
            }
        }

        private void BtRemoveLast_Click(object sender, EventArgs e)
        {
            list.RemoveLast();
            RichTxtBxName.Clear();
            RichTxtBxName.AppendText("LISTA: \n");
            Node timer = list.Begin;
            while (timer != null)
            {
                RichTxtBxName.AppendText(timer.Name.ToString() + " --------- " + timer.Age.ToString() + " \n");
                timer = timer.Next;
            }
        }
    }
}
