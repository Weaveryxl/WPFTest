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

namespace WPFTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format("Hi, {0}", this.txtName.Text));
            txtName.Focus(); // 让文本框获得焦点
        }

        private void txtName_MouseEnter(object sender, MouseEventArgs e)
        {
            txtName.Text = "大爷来玩啊~~";
        }

        private void txtName_MouseLeave(object sender, MouseEventArgs e)
        {
            txtName.Text = "大爷常来啊~~";
        }
    }
}
