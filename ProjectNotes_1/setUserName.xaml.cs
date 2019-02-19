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
    /// Interaction logic for setUserName.xaml
    /// </summary>
    public partial class setUserName : Window
    {
        public bool success = false;
        public setUserName()
        {
            InitializeComponent();
        }

        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            if(initialField.Text != null)
            {
                Properties.Settings.Default.userName = initialField.Text;
                Properties.Settings.Default.Save();
                success = true;
                this.Close();
            }
        }
    }
}
