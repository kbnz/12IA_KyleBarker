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
using System.Threading;
using System.Windows.Threading;

namespace _12IA_2._8_Kyle_Barker
{
    /// <summary>
    /// Interaction logic for frmGameScreen.xaml
    /// </summary>
    public partial class frmGameScreen : Window
    {
        public frmGameScreen()
        {
            InitializeComponent();
            int winHeight, winWidth;
        
          
        }

    

            private void Button_Click(object sender, RoutedEventArgs e)
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
          
             dispatcherTimer.Interval = TimeSpan.FromMilliseconds(1);
             dispatcherTimer.Tick += Timer_Tick;
             dispatcherTimer.Start();


            //for (int i = 0; i > -1; i++)
            //{
            //    Plane.LayoutTransform = new RotateTransform(i);
            //}
            //Plane.LayoutTransform = new RotateTransform(45);

        }

          void Timer_Tick(object sender, EventArgs e)
        { Random rand = new Random();
            int i;
            i = rand.Next();

            sprPlane.LayoutTransform = new RotateTransform(40*i);
           
        }
    }
}
