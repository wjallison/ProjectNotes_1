﻿using System;
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

namespace ProjectNotes_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public List<ProjectClass> projectList = new List<ProjectClass>();
        public List<ProjectClass_2> projectList = new List<ProjectClass_2>();

        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            projectViewWindow newProjWindow = new projectViewWindow();
            newProjWindow.ShowDialog();
            //Grid g = new Grid();
        }
    }
}
