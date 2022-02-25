using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<Student> students = new List<Student>();
        Color[] colors = { Color.Red, Color.Green, Color.Yellow, Color.Blue, Color.Black, Color.White };
        int counter = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 500;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            ParseStudents();
            dataGridView1.Rows.Add(students.Count - 1);
            for (int i = 0; i < students.Count; i++)
            {
                if (treeView1.Nodes[0].Name.Equals(students[i].group))
                {
                    treeView1.Nodes[0].Nodes.Add($"{students[i].name} {students[i].surname}");
                    dataGridView1.Rows[i].SetValues(students[i].surname, students[i].name, "Какой-то тип");
                }
                else if (treeView1.Nodes[1].Name.Equals(students[i].group))
                {
                    treeView1.Nodes[1].Nodes.Add($"{students[i].name} {students[i].surname}");
                    dataGridView1.Rows[i].SetValues(students[i].surname, students[i].name, "Какой-то тип");
                }
            }
        }
        private void ParseStudents()
        {
            string path = $@"{Directory.GetCurrentDirectory()}\students.txt";
            using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    students.Add(new Student(line.Split(' ')[0], line.Split(' ')[1], line.Split(' ')[2]));
                }
            }
        }
        void timer_Tick(object sender, EventArgs e)
        {
            splitContainer2.Panel2.BackColor = colors[counter++];
            if (counter == colors.Length) counter = 0;
        }
    }
}
