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
        List<string> Callsign = new List<string>();
        List<int> Heading = new List<int>();
        List<int> Speed = new List<int>()   ;
        List<double> positionX = new List<double>();
        List<double> positionY = new List<double>();

        int nPlane = 10;
        Image[] Plane_callsigns = new Image[10];
        Random rand = new Random();

        int heading, speed; 

        public frmGameScreen()
        {
            InitializeComponent();
            CallSign_Creator(nPlane);
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);


            
            List<string> Callsign = new List<string>();
            for (int i = 0; i < nPlane+1; i++)
            {
              Heading.Add(rand.Next(1,360));
                positionY.Add(i);
                positionX.Add(i);
            }



            dispatcherTimer.Start();
        }


        double X_Length, Y_Length;
        int distance = 0;
        double tempHeading;

        public Point planeCurr { get; private set; }

        // TranslateTransform translateTransform1 = new TranslateTransform();
        public void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            distance += 1;
            //Limits movement of plane
            //   if (distance > 50) { distance = 50; }
            double pX;
            double pY;
            Point planeCurrent = new Point();
            for (int i = 0; i < Plane_callsigns.Length; i++)
            {

             
                //double myvar2;
                //tempHeading = Plane_callsigns[i].ActualHeight;
                planeCurrent = Plane_callsigns[i].PointFromScreen( planeCurrent);
                pX = planeCurrent.X;
                pY = planeCurrent.Y;

                positionX[i] = pX;
                positionY[i] = pY;

                //for (int k = 0; k < Plane_callsigns.Length; k++)
                //{
                //    foreach (var item in collection)
                //    {

                //    }

                //}

                tempHeading = ((Heading[i] % 90) * (Math.PI*180));

            

                    X_Length = positionX[i]*(Math.PI/180) + (Math.Sin((Heading[i] * (Math.PI / 180))) * distance);
                    Y_Length = (positionY[i]* (Math.PI/180))-(Math.Cos(Heading[i] * (Math.PI / 180)) * distance);

                

                //else if (Heading[i] > 90 && 180 > Heading[i])
                //{

                //    X_Length = (Math.Sin((Heading[i] * (Math.PI / 180))) * distance);
                //    Y_Length = -(Math.Cos(Heading[i] * (Math.PI / 180)) * distance);
                //}
                //else if (Heading[i] > 180 && 270 > Heading[i])
                //{
                //    X_Length = (Math.Sin((Heading[i] * (Math.PI / 180))) * distance);
                //    Y_Length = -(Math.Cos(Heading[i] * (Math.PI / 180)) * distance);
                //}
                //else if  (Heading[i] > 270 && 360 > Heading[i])
                //{
                //    X_Length = (Math.Sin((Heading[i] * (Math.PI / 180))) * distance);
                //    Y_Length = -(Math.Cos(Heading[i] * (Math.PI / 180)) * distance);
                //}

                Plane_callsigns[i].RenderTransform = new TranslateTransform(X_Length, Y_Length);
                Plane_callsigns[i].LayoutTransform = new RotateTransform(Heading[i]);

               

            }

            
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            Heading[cmb_PlaneSelector.SelectedIndex] = Convert.ToInt32(txtHeading.Text);

            cmb_PlaneSelector.Items.Clear();
           //heading = Convert.ToInt32(txtHeading);
            //speed = Convert.ToInt32(txtSpeed);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
         
            
           

        }

        public void CallSign_Creator(int length)
        {
            string code;
            int number;
            string Completed_callsign = "";

            String[] IATAcallsign = {"AA","2G",
"CO",
"DL",
"NW",
"AC",
"UA",
"CP",
"LH",
"FX",
"AS",
"US",
"RG",
"KA",
"LA",
"TP",
"CY",
"OA",
"EI",
"AZ",
"AF",
"IC",
"HM",
"OK",
"SV",
"RB",
"ET",
"GF",
"KL",
"IB",
"ME",
"MS",
"PR",
"AF",
"LO",
"QF",
"SN",
"SA",
"NZ",
"IT",
"KD",
"IR",
"AI",
"AY",
"BW",
"FI",
"CK",
"LY",
"JU",
"SK",
"DT",
"LM",
"AH",
"BA",
"GA",
"MP",
"JL",
"LR",
"AM",
"LI",
"AT",
"LN",
"QR",
"CX",
"3V",
"JP",
"CV",
"EK",
"KE",
"MA",
"RG",
"JI",
"JM",
"TA",
"NH",
"PK",
"TG",
"KU",
"CM",
"NG",
"MH",
"MH",
"MH",
"JD",
"TK",
"BD",
"MK",
"OS",
"MD",
"EF",
"LT",
"TL",
"K4",
"LD",
"CI",
"5S",
"OO",
"WE",
"SC",
"RF",
"NC",
"C8",
"5Y",
"KX",
"A3",
"PO",
"JW",
"5X",
"N8",
"S7",
"ER",
"KC",
"ZH",
"SU",
"RJ",
"WN",
"A2",
"M3",
"M2",
"XQ",
"PS",
"9U",
"7C",
"RU",
"9W",
"UL",
"UL",
"UY",
"EY",
"QY",
"SQ",
"FB",
"GL",
"IY",
"KM",
"PX",
"BT",
"BI",
"NX",
"BR",
"5C",
"KQ",
"MB",
"LX",
"QT",
"MF",
"SP",
"VN",
"SM",
"J2",
"FM",
"MU",
"CZ",
"GD",
"AE",
"M6",
"S6",
"F4",
"OU",
"N8",
"FK",
"EV",
"MY",
"VV",
"Y8",
"6R",
"3U",
"HU",
"DE",
"OH",
"B1",
"QN",
"UZ",
"VS",
"KZ",
"JJ",
"7I",
"OV",
"QO",
"OZ",
"IJ",
"UX",
"BG",
 };
           
           
            for (int p = 0; p < length; p++)
            {
                Completed_callsign = null;
                while (!Callsign.Contains(Completed_callsign)) {
                    code = IATAcallsign[rand.Next(0, IATAcallsign.Length)];
                    number = rand.Next(100, 999);
                    Completed_callsign = $"{code}{number}";

                    Callsign.Add($"{Completed_callsign}");
                    {
                        Plane_callsigns[p] = new Image();
                        Plane_callsigns[p].Source = new BitmapImage(new Uri(@"imgPlaneSprite.png", UriKind.Relative));
                        Plane_callsigns[p].Width = 50;
                        Plane_callsigns[p].Height = 50;
                        Plane_callsigns[p].Stretch = Stretch.Fill;

                        LayoutRoot.Children.Add(Plane_callsigns[p]);
                        

                    }
                }
            };

            foreach (string item in Callsign)
            {
                cmb_PlaneSelector.Items.Add(item);
            }
        }

    }
}
