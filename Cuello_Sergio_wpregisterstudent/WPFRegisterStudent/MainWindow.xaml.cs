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

namespace WPFRegisterStudent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Course choice;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Course course1 = new Course("IT 145");
            Course course2 = new Course("IT 200");
            Course course3 = new Course("IT 201");
            Course course4 = new Course("IT 270");
            Course course5 = new Course("IT 315");
            Course course6 = new Course("IT 328");
            Course course7 = new Course("IT 330");


            this.comboBox.Items.Add(course1);
            this.comboBox.Items.Add(course2);
            this.comboBox.Items.Add(course3);
            this.comboBox.Items.Add(course4);
            this.comboBox.Items.Add(course5);
            this.comboBox.Items.Add(course6);
            this.comboBox.Items.Add(course7);

            this.textBox.Text = "Cuello";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            choice = (Course)(this.comboBox.SelectedItem);
            if (choice != null)
            {
                if (listBox.Items.Count > 0)
                {
                    if (listBox.Items.Count < 3)
                    {

                        foreach (var item in listBox.Items)
                        {
                            if (choice == item)
                            {
                                this.label3.Content = "You're already registered for that course";
                                break;
                            }
                            else
                            {
                                listBox.Items.Add(choice);
                                this.textBox.Text = (listBox.Items.Count*3).ToString();
                                this.label3.Content = "Registration confirmed";

                                break;
                            }


                        }
                    }
                    else
                    {
                        this.label3.Content = "You can not register for more than 9 credit hours";
                    }
                }
                else
                {
                    listBox.Items.Add(choice);
                    this.label3.Content = "Registration confirmed";
                    this.textBox.Text = (listBox.Items.Count * 3).ToString();
                }
            }
            else
            {
                this.label3.Content = "Please Choose an option";
            }
        }

    }
}
