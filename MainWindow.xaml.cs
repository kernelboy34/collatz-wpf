using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using System.IO;
using LiveCharts.Wpf;
using conjeturadecolltz;
using LiveCharts;
using System.Security.Policy;
using System.Reflection.Emit;
using System.Windows.Controls.Ribbon;
using conjeturadecolltz.Pages;
namespace conjeturadecolltz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        Pg r =new Pg();
        public MainWindow()
        {

            InitializeComponent();
            this.DataContext = this;
            this.Cartesian();
            a.NavigationService.Navigate(r);


        }
        public void Cartesian()
        {
  
            double h = 122;
            SeriesCollection = new SeriesCollection {
             new LineSeries
                {
                    Title = "collatz numbers",
                    Values = new ChartValues<double> {346,173,520,260,130,65,196,98,49,148,74,37,112,56,28,14,7,22,11,34,17,52,26,13,40,20,10,5,16,8,4,2,1},
                    PointForeground=Brushes.Cyan,
                    //secuencia de numeros en base a la conjetura de collatz numero 346
                   
                },
            new LineSeries
            {
             
                Title = "paramentros",
                Values = new ChartValues<double> { 1, 56, 63, 78,4 },
                PointGeometry = null
            },

            new LineSeries
            {
                Title = "tema",
                Values = new ChartValues<double> {23,2,4,h,6,7},
                PointGeometry = DefaultGeometries.Square,
                PointGeometrySize = 15
                //secuencia de numeros referencia
            },
               
                };
            Labels = new[] { "tablas", "char", "valores" };
            yFormatter = value => value.ToString("c");
            SeriesCollection.Add(new LineSeries { Title = "comprobacion", Values = new ChartValues<double> { 442, 453, 444 }, LineSmoothness = 0, PointGeometry = Geometry.Parse("m.26 70 56555 94 38 -3 -7 -3"), PointForeground = Brushes.Red });
            SeriesCollection[3].Values.Add(5d);
            DataContext = this;
            //nombres de los graficos brownianos

        }

        public Func<double, string> yFormatter { get; set; }
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd= new Random();
            double j=Convert.ToDouble(rnd.Next(0, 100));
            secuencia rito = new secuencia();
            rito.collatz_sec(346);
            escritura lito=new escritura();
            lito.es();
            rito.derivadas(346);
            lito.derivadas(346);
            //transferimos la parte matematica a la clase secuencia

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            a.NavigationService.Navigate(r);
        }
    }
}
//programa hecho por kernelboy34 o Bernardo Pedrazas