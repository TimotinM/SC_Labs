
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Helpers;
using System.Windows.Forms;

namespace Lab2CS
{
    public partial class Lab2 : Form
    {
        List<JToken> list = new List<JToken>();
        public Lab2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                textBox1.Text = openFileDialog1.FileName;
            }

            
            string file = textBox1.Text;
            using (StreamReader r = new StreamReader(file))
            {
                string json = r.ReadToEnd();
                var ja = (JArray)JsonConvert.DeserializeObject(json);
                foreach (var jo in ja)
                {
                    list.Add(jo);
                }
            }

            foreach (var obj in list)
            {
                checkedListBox1.Items.Add(obj["  info        "]);

            }
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string savePath = textBox3.Text + "\\";
            string newfileName = textBox4.Text + ".json";
            string fileName = savePath + newfileName;
            

            List<JToken> listChecked = new List<JToken>();
            List<JObject> listObjects = new List<JObject>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                {
                    listChecked.Add(list[i]);
                }
            }
            foreach (var item in listChecked)
            {
                listObjects.Add(item.ToObject<JObject>());
            }

            File.AppendAllText(fileName, "[");
            foreach (var obj in listObjects)
            {
                File.AppendAllText(fileName, obj.ToString());
                File.AppendAllText(fileName, "," + Environment.NewLine);
            }
            File.AppendAllText(fileName, "]");

            this.Hide();
            Done done = new Done();
            done.StartPosition = FormStartPosition.Manual;
            done.Location = this.Location;
            done.ShowDialog();
            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemCheckState(i) != CheckState.Checked)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }

        private void Lab2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string filter = textBox2.Text;
            checkedListBox1.Items.Clear();
            foreach (var obj in list)
            {
                if(obj["  info        "].ToString().Contains(filter))
                {
                    checkedListBox1.Items.Add(obj["  info        "]);
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }

}
