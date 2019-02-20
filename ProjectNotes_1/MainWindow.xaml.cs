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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using System.IO;

namespace ProjectNotes_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public List<ProjectClass> projectList = new List<ProjectClass>();
        //public List<ProjectClass_2> projectList = new List<ProjectClass_2>();
        public IList<basicProps> basicList = new List<basicProps>();

        public MainWindow()
        {
            InitializeComponent();
            //MessageBox.Show(Properties.Settings.Default.userName);
            if(Properties.Settings.Default.userName == "")
            {
                setUserName set = new setUserName();
                set.ShowDialog();
                while(!set.success)
                {
                    MessageBox.Show("You must enter a username.");
                    set.ShowDialog();
                }
            }
            userNameTextBlock.Text = Properties.Settings.Default.userName;


            Load();

            UpdateGrid();
        }

        public void UpdateGrid()
        {
            mainDataGrid.Items.Clear();
            basicList.Clear();

            for (int i = 0; i < _global.projects.Count; i++)
            {
                //mainDataGrid.Items.Add(_global.projects[i].basics);
                basicList.Add(_global.projects[i].basics);
            }
            mainDataGrid.Items.Add(basicList);


        }

        public void Load()
        {
            string[] subDirectories = System.IO.Directory.GetDirectories(System.IO.Directory.GetCurrentDirectory());

            for(int i = 0; i < subDirectories.Length; i++)
            {
                _global.projects.Add(new ProjectClass_2());

                XmlSerializer serBasic = new XmlSerializer(typeof(basicProps));
                FileStream fs = new FileStream(subDirectories[i] + "/" + "basic.xml", FileMode.Open);
                _global.projects.Last().basics = (basicProps)serBasic.Deserialize(fs);

                XmlSerializer serLinks = new XmlSerializer(typeof(Links));
                fs = new FileStream(subDirectories[i] + "/" + "links.xml", FileMode.Open);
                _global.projects.Last().log.links = (Links)serLinks.Deserialize(fs);

                XmlSerializer serEntries = new XmlSerializer(typeof(EntryList));
                fs = new FileStream(subDirectories[i] + "/" + "entries.xml", FileMode.Open);
                EntryList el = (EntryList)serEntries.Deserialize(fs);
                _global.projects.Last().log.entries = el.ls;
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            projectViewWindow newProjWindow = new projectViewWindow();
            newProjWindow.ShowDialog();
            //Grid g = new Grid();
        }

        private void changeUserButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mainDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            projectViewWindow projWindow = new projectViewWindow(mainDataGrid.SelectedIndex);
            projWindow.ShowDialog();

            UpdateGrid();
        }

        private void mainDataGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            projectViewWindow projWindow = new projectViewWindow(mainDataGrid.SelectedIndex);
            projWindow.ShowDialog();

            UpdateGrid();
        }

        private void mainDataGrid_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
