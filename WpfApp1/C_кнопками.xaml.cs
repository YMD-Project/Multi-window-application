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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для C_кнопками.xaml
    /// </summary>
    public partial class C_кнопками : Window
    {
        public C_кнопками()
        {
            InitializeComponent();
        }

        private void btnDA_Click(object sender, RoutedEventArgs e)
        {
            ДА da = new ДА();
            da.ShowDialog();
        }

        private void btnNEt_Click(object sender, RoutedEventArgs e)
        {
            НЕТ net = new НЕТ();
            net.ShowDialog();
        }

        private void btnOtmena_Click(object sender, RoutedEventArgs e)
        {
            Отмена otmena = new Отмена();
            otmena.ShowDialog();
        }
    }
}
