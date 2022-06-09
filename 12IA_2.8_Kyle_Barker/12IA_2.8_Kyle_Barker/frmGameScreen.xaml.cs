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
        List<int> Speed = new List<int>();

        int heading, speed;
        public frmGameScreen()
        {
            InitializeComponent();
            CallSign_Creator(10);
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            dispatcherTimer.Start();


            List<string> Callsign = new List<string>();
     

           

            for (int i = 0; i < 360; i++)
            {
                Heading.Add(i);
            }

            

        
        }

  

        int inputVector = 95;


        double X_Location_Start;
        double Y_Location_Start;

        double X_Location_Current = 0;
        double Y_Location_Current = 0;

        double Y_Point;
        double X_Point = 100;
        double X_Length, Y_Length;


       public void dispatcherTimer_Tick(object sender, EventArgs e)
        {


            //THIS WORKS

            foreach (string item in Callsign)
            {
                Plane_Movement(item);
            }

         
        }

         void Plane_Movement(string planeID) {
            X_Length = (2 * (Math.Sin((Math.PI / 180) * inputVector)));
            Y_Length = (X_Length * Math.Tan((90 - inputVector) * (Math.PI / 180)));
            X_Point = X_Location_Current + X_Length;
            Y_Point = Y_Location_Current - Y_Length;




            TranslateTransform translateTransform1 = new TranslateTransform(X_Point, Y_Point);

          sprPlane.RenderTransform = translateTransform1;
            X_Location_Current = translateTransform1.X;
            Y_Location_Current = translateTransform1.Y;
            sprPlane.LayoutTransform = new RotateTransform(inputVector);



        }
        public object IATAcallsign { get; private set; }


        //private void ObservableCollection<T>()
        //{

        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            cmb_PlaneSelector.Items.Clear();
            heading = Convert.ToInt32(txtHeading);
            speed = Convert.ToInt32(txtSpeed);

            Heading[1] = heading;


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

            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {

                Completed_callsign = null;
                while (!Callsign.Contains(Completed_callsign)) {
                    code = IATAcallsign[rand.Next(0, IATAcallsign.Length)];
                    number = rand.Next(100, 999);
                    Completed_callsign = $"{code}{number}";

                    Callsign.Add($"{Completed_callsign}");
                    {
                        ImageBrush SpriteCreator = new ImageBrush();


                        //set value works just need to find prevoius name
                        SpriteCreator.SetValue(NameProperty, "hi");



                        SpriteCreator.ImageSource = new BitmapImage(new Uri(@"imgPlaneSprite.png", UriKind.Relative));
                       
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
