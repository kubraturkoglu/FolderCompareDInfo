using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string FilePath1;
        string FilePath2;
        IEnumerable<FileInfo> list1;
        IEnumerable<FileInfo> list2;

        public bool IsCompleted { get; }
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            

        }

        public void Getfolder1()
        {
            if (string.IsNullOrEmpty(lbl_folder1.Text) || string.IsNullOrEmpty(lbl_folder2.Text))
            {
                MessageBox.Show("Select both folders before running compare");
                return;
            }
          
                DirectoryInfo dir1 = new DirectoryInfo(FilePath1);
              
                list1 = dir1.GetFiles("*.*", SearchOption.AllDirectories);
           

        }
        public void Getfolder2()
        {
            if (string.IsNullOrEmpty(lbl_folder1.Text) || string.IsNullOrEmpty(lbl_folder2.Text))
            {
                MessageBox.Show("Select both folders before running compare");
                return;
            }
            
                DirectoryInfo dir2 = new DirectoryInfo(FilePath2);
             
                list2 = dir2.GetFiles("*.*", SearchOption.AllDirectories);
            
        }
        private void difference1()
        {
            FileCompare myFileCompare1 = new FileCompare();
            bool areIdentical = list1.SequenceEqual(list2, myFileCompare1);

            if (areIdentical == true)
            {
                // listBox1.Show("the two folders are the same");
                label1.Text = String.Format("the two folders are the same");
            }
            else
            {
                label1.Text = String.Format("The two folders are not the same");
            }

            if (checkbox_dif.Checked == true)
            {
                listBox_folder1.Items.Clear();
                // Find the set difference between the two folders.  
                var queryList1Only = (from file in list1 select file).Except(list2, myFileCompare1);

                foreach (var v in queryList1Only)
                {
               
                    listBox_folder1.Items.Add(v.FullName);
                }
             

            }
            else
            {
                listBox_folder1.Items.Clear();
                listBox_folder2.Items.Clear();
                var queryCommonFiles = list1.Intersect(list2, myFileCompare1);

                if (queryCommonFiles.Any())
                {
                    //listBox1.Items.Add("The following files are in both folders:");
                    foreach (var v in queryCommonFiles)
                    {
                        listBox_folder1.Items.Add(v.FullName); //shows which items end up in result list  
                    }
                }
                else
                {
                    listBox_folder1.Items.Add("There are no common files in the two folders.");
                }
            }
        }
        private void difference2()
        {
            if (checkbox_dif.Checked == true)
            {

                FileCompare myFileCompare2 = new FileCompare();

                // Find the set difference between the two folders.  
                //listbox2 için
                listBox_folder2.Items.Clear();
                // Find the set difference between the two folders.  
                var queryList2Only = (from file in list2 select file).Except(list1, myFileCompare2);
                // Console.WriteLine("The following files are in list1 but not list2:");
                foreach (var v in queryList2Only)
                {
                    listBox_folder2.Items.Add(v.FullName);
                }
              
            }
        }
       
        private void GifStart(PictureBox gif)
        {
            gif.Visible = true;
        }
        private void GifStop(PictureBox gif)
        {
            gif.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            listBox_folder1.HorizontalScrollbar = true;
            listBox_folder2.HorizontalScrollbar = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog folder1 = new FolderBrowserDialog();
            if (folder1.ShowDialog() == DialogResult.OK)
            {
                FilePath1 = folder1.SelectedPath;
                lbl_folder1.ResetText();
                lbl_folder1.Text = (FilePath1);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog folder2 = new FolderBrowserDialog();
            if (folder2.ShowDialog() == DialogResult.OK)
            {
                FilePath2 = folder2.SelectedPath;
                lbl_folder2.ResetText();
                lbl_folder2.Text = (FilePath2);
            }
        }

        private async void compare_Click_1(object sender, EventArgs e)
        {
            //var files = Directory.EnumerateFiles("xx");
            //foreach (var file in files)
            //{

            //}
            GifStart(pictureBox2);
            GifStart(pictureBox1);
           // var watch = Stopwatch.StartNew();
            DateTime startingTime = DateTime.Now;
            
        

            try
            {
                List<Task> TaskList1 = new List<Task>();
                List<Task> TaskList2 = new List<Task>();


                TaskList1.Add(Task.Run(
                    () =>
                    {
                        Getfolder1();


                    }));
                TaskList1.Add(Task.Run(
                    () =>
                    {

                        Getfolder2();

                    }
                    ));
                Task.WaitAll(TaskList1.ToArray());
                TaskList2.Add(Task.Run(
                   () =>
                   {
                       difference1();


                   }));
                TaskList2.Add(Task.Run(
                    () =>
                    {


                        difference2();

                    }
                    ));
                Task.WaitAll(TaskList2.ToArray());
             
                GifStop(pictureBox2);
                GifStop(pictureBox1);
                TimeSpan endingTime = DateTime.Now- startingTime;
               // TimeSpan span = TimeSpan.FromHours(endingTime.Hour - startingTime.Hour);

                lbl_extime.Text = String.Format("{0}.{1}", endingTime.Seconds, endingTime.Milliseconds.ToString().PadLeft(3, '0'));
            //    lbl_extime.Text = span.TotalMilliseconds.ToString();
            } 
         
            catch (UnauthorizedAccessException ae)
            {
                MessageBox.Show("Caught unauthorized access exception-await behavior");
                FileAttributes attr = (new FileInfo(FilePath2)).Attributes;
                MessageBox.Show("UnAuthorizedAccessException: Unable to access file. ");
                if ((attr & FileAttributes.ReadOnly) > 0)
                    MessageBox.Show("The file is read-only.");
            }
           
            catch (AggregateException ae)
            {
                MessageBox.Show("Caught aggregate exception-Task.Wait behavior");
                ae.Handle((x) =>
                {
                    if (x is UnauthorizedAccessException) // This we know how to handle.
                    {
                        MessageBox.Show("You do not have permission to access all folders in this path.");
                        MessageBox.Show("See your network administrator or try another path.");
                        return true;
                    }
                    return false; // Let anything else stop the application.
                });
            }

          
           
        }
       
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        { 
            string fileName = listBox_folder1.SelectedItem.ToString();
            if (File.Exists(fileName))
            {
                Process.Start(fileName);
                return;
            }
          
                MessageBox.Show("File '" + fileName + "' does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string fileName = listBox_folder2.SelectedItem.ToString();
            if (File.Exists(fileName))
            {
                Process.Start(fileName);
                return;
            }
           
                MessageBox.Show("File '" + fileName + "' does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void listBox_folder2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

