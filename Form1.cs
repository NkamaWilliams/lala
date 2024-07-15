using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Faculty
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> faculty = new Dictionary<string, List<string>>();
        private System.Drawing.Printing.PrintDocument docToPrint;
        private string stringToPrint;
        public Form1()
        {
            InitializeComponent();
            docToPrint = new System.Drawing.Printing.PrintDocument();
        }

        private void newdoc_Click(object sender, EventArgs e)
        {
            page1.Visible = true;
            page2.Visible = false;
            page3.Visible = false;
            page4.Visible = false;
        }

        private void create_Click(object sender, EventArgs e)
        {
            bool success = FacultyFunc.create(name.Text);
            name.Text = string.Empty;
            if (success)
            {
                faculty.Clear();
                MessageBox.Show(name.Text + " created successfully!");
            }
            else
            {
                MessageBox.Show("Error creating " + name);
            }
        }

        private void newdept_Click(object sender, EventArgs e)
        {
            page1.Visible = false;
            page2.Visible = true;
            page3.Visible = false;
            page4.Visible = false;
        }

        private void newlec_Click(object sender, EventArgs e)
        {
            page1.Visible = false;
            page2.Visible = false;
            page3.Visible = false;
            page4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Departments.Items.Contains(dept.Text))
            {
                Departments.Items.Add(dept.Text);
                dropdown.Items.Add(dept.Text);
                faculty.Add(dept.Text, new List<string>());
            }
            dept.Text = string.Empty;
        }

        private void addlec_Click(object sender, EventArgs e)
        {
            if (dropdown.SelectedIndex == null)
            {
                MessageBox.Show("Select Department to add to!");
            }
            if (!dropdown.Items.Contains(lectname.Text))
            {
                faculty[dropdown.SelectedItem.ToString()].Add(lectname.Text);
                MessageBox.Show("Lecturer added successfully!");
                lectname.Text = string.Empty;
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Contains(".txt"))
            {
                FacultyFunc.Load(openFileDialog1.FileName, faculty);
                MessageBox.Show(FacultyFunc.path + " Loaded");
                foreach (string dept in faculty.Keys)
                {
                    Departments.Items.Add(dept);
                    dropdown.Items.Add(dept);
                }
            }
            else
            {
                MessageBox.Show("Invalid file. Must be a txt file");
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            FacultyFunc.Save(faculty);
            
        }

        private void print_Click(object sender, EventArgs e)
        {
            if (FacultyFunc.path == null)
            {
                MessageBox.Show("No file currently selected or available to print! Have you saved or loaded one?");
            }

            stringToPrint = File.ReadAllText(FacultyFunc.path);
            string docName = FacultyFunc.path.Split('\\')[5];
            string docPath = FacultyFunc.BasePath;

            printDocument1.DocumentName = docName;
            printPreviewDialog1.ShowDialog();
        }

        private void finalPrint_Click(object sender, EventArgs e)
        {
            if (FacultyFunc.path == null)
            {
                MessageBox.Show("No file currently selected or available to print! Have you saved or loaded one?");
            }

            stringToPrint = File.ReadAllText(FacultyFunc.path);
            string docName = FacultyFunc.path.Split('\\')[5];
            string docPath = FacultyFunc.BasePath;

            printDocument1.DocumentName = docName;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;

            // Sets the value of charactersOnPage to the number of characters
            // of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(stringToPrint, this.Font,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out linesPerPage);

            // Draws the string within the bounds of the page
            e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black,
                e.MarginBounds, StringFormat.GenericTypographic);

            // Remove the portion of the string that has been printed.
            stringToPrint = stringToPrint.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (stringToPrint.Length > 0);
        }
    }

    class FacultyFunc
    {
        const string basepath = @"C:\Users\USER\Documents\Files\";
        public static string path { get; private set; }
        public static readonly string BasePath = basepath;
        public static Boolean create(string name)
        {
            path = basepath + name + ".txt";
            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Dispose();
            }

            if (File.Exists(path))
            {
                return true;
            }
            return false;
        }

        public static void Load(string name, Dictionary<string, List<string>> faculty)
        {
            path = name;
            string line;
            string dept = "";

            FileStream fs = File.OpenRead(path);
            StreamReader file = new StreamReader(fs);

            while (!file.EndOfStream)
            {
                line = file.ReadLine();
                if (line.Contains("Department of"))
                {
                    dept = line.Trim().Substring(14);
                    faculty[dept] = new List<string>();
                }

                else if (!line.Contains("Faculty of") && line.Trim() != "")
                {
                    faculty[dept].Add(line.Trim());
                }
            }

            file.Dispose();
        }

        public static void Save(Dictionary<string, List<string>> faculty)
        {
            FileStream fs = File.OpenWrite(path);
            StreamWriter writer = new StreamWriter(fs);

            writer.WriteLine("Faculty of Science");
            writer.WriteLine("\n");
            foreach (string dept in faculty.Keys)
            {
                writer.WriteLine("Department of " + dept);
                foreach (string name in faculty[dept])
                {
                    writer.WriteLine(name);
                }
                writer.WriteLine("\n");
            }

            writer.Dispose();
            MessageBox.Show("Saved Successfully");
        }
    }
}
