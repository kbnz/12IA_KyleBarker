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
            CallSign(4);
            CallSign(10);
            

        }
        List<string> callsign = new List<string>();


        //private void ObservableCollection<T>()
        //{
      
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
          
             dispatcherTimer.Interval = TimeSpan.FromMilliseconds(1);
             dispatcherTimer.Tick += Timer_Tick;
             dispatcherTimer.Start();
            cmb_PlaneSelector.Items.Clear();

            //for (int i = 0; i > -1; i++)
            //{
            //    Plane.LayoutTransform = new RotateTransform(i);
            //}
            //Plane.LayoutTransform = new RotateTransform(45);

        }

          void Timer_Tick(object sender, EventArgs e)
        { 

            sprPlane.LayoutTransform = new RotateTransform(40);
           
        }

        public void CallSign(int length)
        {
            
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {

                callsign.Add(Convert.ToString(rand.Next(1000, 9999)));
            }
            foreach (string item in callsign)
            {
                cmb_PlaneSelector.Items.Add(item);
            }
        }

    }
}
