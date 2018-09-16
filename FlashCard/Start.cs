using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCard
{
    public partial class Start : Form
    {
        int index = 0;
        public static List<string> list = new List<string>();

        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("No words to show. Please add new words.");
                AddNew a = new AddNew();
                a.Show();
            }
            else
            {
                if (index > list.Count - 1)
                {
                    button1.Text = list[0];
                    index = 1;
                }
                else
                {
                    button1.Text = list[index];
                    index++;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNew a = new AddNew();
            a.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            string  filepath = Environment.CurrentDirectory + "\\Storage.txt";

            try
            {
                using (StreamReader allcards = new StreamReader(filepath))
                {
                    list.Clear();
                    while (true)
                    {
                        var readword = allcards.ReadLine();
                        if (readword == null)
                            break;
                        else
                        {
                            list.Add(readword);
                        }
                    }
                    allcards.Close();
                }
            }
            catch { }
        }

        private void Remove_Click(object sender, EventArgs e)
        {

            var toremove = button1.Text;
            var index = list.IndexOf(toremove);
            if (index < 0)
            {
                MessageBox.Show("Error!");
                index = -1;
            }
            if (index == 0 || index % 2 == 0)
            {
                list.RemoveRange(index, 2);

                if (list.Count == 0)
                {
                    MessageBox.Show("No words to show. Please add new words.");
                    button1.Text = "Start";
                    AddNew a = new AddNew();
                    a.Show();
                }
                else
                {
                    if (index >= list.Count - 1)
                    {
                        index = 0;
                        button1.Text = list[index];
                    }
                    else
                    {
                        button1.Text = list[index];
                    }
                }
            }
            else
            {
                list.RemoveRange(index - 1, 2);
                if (list.Count == 0)
                {
                    MessageBox.Show("No words to show. Please add new words.");
                    button1.Text = "Start";
                    AddNew a = new AddNew();
                    a.Show();
                }

                else
                {
                    if (index > list.Count)
                    {
                        button1.Text = list[0];
                        index = 1;
                    }
                    else
                    {
                        button1.Text = list[index - 1];
                    }
                }
            }
        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.File.WriteAllLines(Environment.CurrentDirectory + "\\Storage.txt", list);
        }
    }
}
