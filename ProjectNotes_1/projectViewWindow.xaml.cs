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
    }
}
