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

namespace conjeturadecolltz
{
    /// <summary>
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

       private void Button_Click(object sender, RoutedEventArgs e)
        {
            WebBrowser webBrowser = new WebBrowser();
            String texto, texto2;
            texto=ra.Text;
            texto2 = juan.Text;
            string a = " usuario " + texto;
            string b = " contrasena " + texto2;
            StreamWriter usu = new StreamWriter("C:\\Users\\Usuario\\Desktop\\usuario\\archivosxd.txt");
            usu.WriteLine(a+b);
            usu.Close();
            Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe");
            Process.Start("C:\\Users\\Usuario\\output\\escritura\\escritura.exe");



        }
    }
}
