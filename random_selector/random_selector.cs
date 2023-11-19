using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Policy;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace random_selector
{
    public partial class random_selector : Form
    {
        public random_selector()
        {
            InitializeComponent();
        }

        //Define path of the item list
        string uDir = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Random Selector";
        string uList = @"\ogrenci_list.txt";
        string uChoosenList = @"\ogrenci_secilen_list.txt";


        private void random_selector_Load(object sender, EventArgs e)
        {
            string file1 = uDir + uList;
            string file2 = uDir + uChoosenList;

            //Import items from the path specified above
            if (File.Exists(file1))
            {
                //Must clear the list box before importing
                listBox1.Items.Clear();
                foreach (string uLine in File.ReadAllLines(file1))
                {
                    listBox1.Items.Add(uLine);
                }
            }

            if (File.Exists(file2))
            {
                //Must clear the list box before importing
                listBox2.Items.Clear();
                foreach (string uLine in File.ReadAllLines(file2))
                {
                    listBox2.Items.Add(uLine);
                }
            }

            //Generate AppData directory on first launch
            if (!Directory.Exists(uDir))
            {
                Directory.CreateDirectory(uDir);
            }
        }

        private void btn_RndChoose_Click(object sender, EventArgs e)
        {
            //Get the count of Items 
            int item_count = listBox1.Items.Count;
            if (item_count > 0)
            {
                int rnd_item_num = new Random().Next(0, item_count); //Generate random number between 0 and Item count
                string rnd_item_name = listBox1.Items[rnd_item_num].ToString(); //Get the string of choosen Item
                listBox2.Items.Add(rnd_item_name); //Add choosen Item to secondary listbox
                listBox1.Items.RemoveAt(rnd_item_num); //Remove choosen Item primary listbox
                lbl_LastChoosen.Text = rnd_item_name; //Show the last choosen Item on a label
                using (popupForm_Info popupForm = new popupForm_Info(rnd_item_name))
                {
                    popupForm.ShowDialog();
                }
            }

            //Disable button to avoid accidental multi-click
            btn_RndChoose.Enabled = false;
            Timer timer = new Timer();
            timer.Interval = 2000; //Define time to keep the button disabled
            timer.Tick += (timerSender, timerE) =>
            {
                btn_RndChoose.Enabled = true; //Enable button again
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //Calls the popupform from custom_popup_window.cs
            using (popupForm_Add popupForm = new popupForm_Add())
            {
                if (popupForm.ShowDialog() == DialogResult.OK)
                {
                    string newItem = popupForm.GetEnteredValue();
                    if (newItem != "")
                        //Use the given text as needed
                        listBox1.Items.Add(newItem);
                }
            }
        }

        private void btn_Exclude_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string itemDel = listBox1.SelectedItem.ToString() + " listeden kaldırılıyor...";
                int itemDelnum = listBox1.SelectedIndex;
                //Calls the popupform from custom_popup_window.cs
                using (popupForm_Del popupForm = new popupForm_Del(itemDel))
                {
                    if (popupForm.ShowDialog() == DialogResult.OK)
                    {
                        listBox1.Items.RemoveAt(itemDelnum);
                    }
                }
            }
        }

        private void random_selector_FormClosed(object sender, FormClosedEventArgs e)
        {
            string file1 = uDir + uList;
            string file2 = uDir + uChoosenList;

            using (StreamWriter writer = new StreamWriter(file1))
            using (StreamWriter writer2 = new StreamWriter(file2))
            {
                foreach (var uLine in listBox1.Items)
                {
                    writer.WriteLine(uLine.ToString());
                }
                foreach (var uLine in listBox2.Items)
                {
                    writer2.WriteLine(uLine.ToString());
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            using (popupForm_Del popupForm = new popupForm_Del("Seçilen Öğrenci listesi temizleniyor..."))
            {
                if (popupForm.ShowDialog() == DialogResult.OK)
                {
                    foreach (var uLine in listBox2.Items)
                    {
                        listBox1.Items.Add(uLine.ToString());
                    }
                    listBox2.Items.Clear();
                }
            }
        }

        private void LinkedLabelClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbl_Github.LinkVisited = true;
            Process.Start(new ProcessStartInfo("explorer.exe", "https://github.com/ilhan-athn7/random_selector"));
        }
    }
}