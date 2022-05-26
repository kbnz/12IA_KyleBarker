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
            cmb_PlaneSelector.Items.Clear();
            callsign.Clear();
            CallSign(10);
            
            

        }
        List<string> callsign = new List<string>();

        public object IATAcallsign { get; private set; }


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
            

            callsign.Add(Convert.ToString(rand.Next(100, 999)));
            
            foreach (string item in callsign)
            {
                cmb_PlaneSelector.Items.Add(item);
            }
        }

    }
}
