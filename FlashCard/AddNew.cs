using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCard
{
    public partial class AddNew : Form
    {
        public AddNew()
        {
            InitializeComponent();
        }

        private void AddNew_Load(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (frontword.Text == "Front Word" || backword.Text == "Back Word" || frontword.Text == "" || backword.Text == "")
            {
                MessageBox.Show("Please fill the words to add.");
                return;
            }
            Start.list.Add(frontword.Text);
            Start.list.Add(backword.Text);
            backword.Text = "Front Word";
            frontword.Text = "Back Word";
        }

        private void frontword_MouseClick(object sender, MouseEventArgs e)
        {
            frontword.Text = "";
            backword.Text = "";
        }
    }
}
