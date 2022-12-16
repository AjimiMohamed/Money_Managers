using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Metrics;
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
using System.Xml.Linq;

namespace MoneyMoney
{
    /// <summary>
    /// Interaction logic for firstpage.xaml
    /// </summary>
  

    public partial class firstpage : Window
    {
        /// <summary>
        /// init all pages just one time 
        /// </summary>

        public ObservableCollection<transac> xd;
        public double balance = 8000;
        
        public firstpage()
        {
            InitializeComponent();


            
             xd = new ObservableCollection<transac>(TransacData.GetTransac());
            
             membersDataGrid.ItemsSource = xd;

            
            balancetext.Text = balance.ToString() + " €";



        
        

       

        }
        private void transaction_Button_Click(object sender, RoutedEventArgs e)
        {
            
            transac transaction = new transac
            {
                
            Name = txtUser.Text,
            Amount = int.Parse(txtAmount.Text),
            Category = txtCategory.Text
        };
            xd.Add(transaction);
            TransacData.AddTransaction(transaction);
            membersDataGrid.ItemsSource = xd;
            balancetext.Text = (balance - int.Parse(txtAmount.Text)).ToString() + " €";
            balance = balance - int.Parse(txtAmount.Text);
        }
        private void delete_Button_Click(object sender, RoutedEventArgs e)
        {
            }
            
           
        
        private void Border_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void textUser_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtUser.Focus();
        }
        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUser.Text) && txtUser.Text.Length > 0)
            {
                textUser.Visibility = Visibility.Collapsed;
            }
            else
            {
                textUser.Visibility = Visibility.Visible;

            }
        }
        private void textAmount_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtAmount.Focus();
        }
        private void txtAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAmount.Text) && txtAmount.Text.Length > 0)
            {
                textAmount.Visibility = Visibility.Collapsed;
            }
            else
            {
                textAmount.Visibility = Visibility.Visible;

            }
        }
        private void textCategory_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtCategory.Focus();
        }
        private void txtCategory_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCategory.Text) && txtCategory.Text.Length > 0)
            {
                textCategory.Visibility = Visibility.Collapsed;
            }
            else
            {
                textCategory.Visibility = Visibility.Visible;

            }
        }

        private void Logout_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            
            Close();
            main.Show();
        }

        
    }
    }

