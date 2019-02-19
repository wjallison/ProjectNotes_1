using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjectNotes_1
{
    /// <summary>
    /// Interaction logic for projectViewWindow.xaml
    /// </summary>
    public partial class projectViewWindow : Window
    {
        //public ProjectClass thisProject;
        public ProjectClass_2 proj;
        public bool fromScratch = true;
        public int index;

        public List<Image> figList = new List<Image>();

        public projectViewWindow()
        {
            InitializeComponent();
            //thisProject = new ProjectClass();
            proj = new ProjectClass_2();

            textFieldsDataGrid.Items.Add(proj.log.entries[0]);
            //textFieldsDataGrid.Items = proj.log.entries

            //thisProject.addNoteLine();
            //thisProject.notes.updateContent[0] = "test";
            //textFieldsDataGrid.Items.Add(thisProject.notes);

        }

        public projectViewWindow(int ind)
        {
            fromScratch = false;
            index = ind;
            proj = _global.projects[index];

            if(proj.log.entries.Count > 0)
            {
                for(int i = 0; i < proj.log.entries.Count; i++)
                {
                    textFieldsDataGrid.Items.Add(proj.log.entries[i]);
                }
            }


        }

        public void Save()
        {
            if (System.IO.Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "/" + proj.basics.designation))
            {

            }
            else
            {
                System.IO.Directory.CreateDirectory(
                    System.IO.Directory.GetCurrentDirectory() + "/" + proj.basics.designation);
            }



        }

        //public projectViewWindow(ProjectClass p)
        //{
        //    InitializeComponent();
        //    thisProject = p;

        //    textFieldsDataGrid.Items.Add(thisProject);
        //}

        private void linkButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addFigButton_Click(object sender, RoutedEventArgs e)
        {
            /*
             * There's a lot that needs to happen here.
             * 
             * CHECK
             * First, OpenFileDialog to select the image.
             * CHECK
             * Second, open / create a folder for the project
             * CHECK
             * Third, copy the image into that folder
             * CHECK
             * Fourth, create a copy of the image scaled to 50 pixels maximum and add to figListBox
             * 
             */

            //proj.basics.designation = "test";

            Microsoft.Win32.OpenFileDialog openFile = new Microsoft.Win32.OpenFileDialog();
            if(openFile.ShowDialog() == true)
            {
                if(System.IO.Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "/" + proj.basics.designation))
                {

                }
                else
                {
                    System.IO.Directory.CreateDirectory(
                        System.IO.Directory.GetCurrentDirectory() + "/" + proj.basics.designation);
                }
                System.IO.File.Copy(openFile.FileName,
                    System.IO.Directory.GetCurrentDirectory() + "/" + proj.basics.designation
                    + "/" + System.IO.Path.GetFileName(openFile.FileName), true);

                proj.log.links.imgLocList.Add(System.IO.Path.GetFileName(openFile.FileName));

                
                //im.Source = new BitmapImage(new Uri())
                for(int i = 0; i < proj.log.links.imgLocList.Count; i++)
                {
                    Image im = new Image();
                    im.Source = new BitmapImage(new Uri(
                        System.IO.Directory.GetCurrentDirectory() + "/" + proj.basics.designation
                    + "/" + proj.log.links.imgLocList[i]));
                    double x, y;
                    x = im.Width;
                    y = im.Height;

                    im.Width = 50;
                    im.Height = im.Height * 50 / x;

                    figListBox.Items.Add(im);
                }

            }
        }

        private void addUpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //thisProject.addNoteLine();
            //textFieldsDataGrid.Items.Clear();
            ////textFieldsDataGrid.Items.Add(thisProject);
            ////for(int i = 0; i < thisProject.)
            //textFieldsDataGrid.Items.Add(thisProject.notes);
            proj.log.entries.Add(new Entry());
            textFieldsDataGrid.Items.Add(proj.log.entries[-1]);
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(sender.GetType().ToString());
            //UpdateSourceTrigger
            //TextBox test = (TextBox)sender;
            //test.Parent.GetType().ToString();
            //MessageBox.Show(test.Parent.GetType().ToString());
            //MessageBox.Show(textFieldsDataGrid.Items[0].GetType().ToString());
            //thisProject = (ProjectClass)textFieldsDataGrid.Items[0];
            //thisProject.notes = (RecordClass)textFieldsDataGrid.Items[0];
            //RecordClass test = (RecordClass)textFieldsDataGrid.Items[0];
            //MessageBox.Show(test.updateContent[0]);
            //MessageBox.Show("ljkh");

            //Entry test = (Entry)textFieldsDataGrid.Items[0];

            //if(sender is TextBox)
            //{
            //    TextBox t = (TextBox)sender;

            //    var parent = ItemsControl.ItemsControlFromItemContainer(t);
            //    var entry = parent?.ItemContainerGenerator?.ItemFromContainer(t);

            //    Entry test = (Entry)entry;

            //    MessageBox.Show(test.rev);
            //}
            
            //Entry test = (Entry)textFieldsDataGrid.Items[0];
            //MessageBox.Show(test.content);
            //MessageBox.Show(test.content);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (fromScratch)
            {
                _global.projects.Add(proj);
            }

            else
            {
                _global.projects[index] = proj;
            }
        }

        private void desigTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void figListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Image img = new Image();
            img.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "/" + proj.basics.designation
                    + "/" + proj.log.links.imgLocList[figListBox.SelectedIndex]));

            activeFigImage = img;
        }
    }
}
