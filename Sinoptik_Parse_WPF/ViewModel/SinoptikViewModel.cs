using Sinoptik_Parse_WPF.Helpers;
using Sinoptik_Parse_WPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Sinoptik_Parse_WPF.ViewModel
{
    public class SinoptikViewModel : ObservableObjectBase
    {
        private ObservableCollection<BitmapImage> _images;
        private ObservableCollection<string> _weatherDataTabe;
        private SinoptikModel _sinoptik;

        #region Properties
        public BitmapImage Night0
        {
            get => _images[0];
            set
            {
                _images[0] = value;
                OnPropertyChanged("Night0");
            }
        }
        public BitmapImage Night3
        {
            get => _images[1];
            set
            {
                _images[1] = value;
                OnPropertyChanged("Night3");
            }
        }
        public BitmapImage Morning6
        {
            get => _images[2];
            set
            {
                _images[2] = value;
                OnPropertyChanged("Morning6");
            }
        }
        public BitmapImage Morning9
        {
            get => _images[3];
            set
            {
                _images[3] = value;
                OnPropertyChanged("Morning9");
            }
        }
        public BitmapImage Day12
        {
            get => _images[4];
            set
            {
                _images[4] = value;
                OnPropertyChanged("Day12");
            }
        }
        public BitmapImage Day15
        {
            get => _images[5];
            set
            {
                _images[5] = value;
                OnPropertyChanged("Day15");
            }
        }
        public BitmapImage Evening18
        {
            get => _images[6];
            set
            {
                _images[6] = value;
                OnPropertyChanged("Evening18");
            }
        }
        public BitmapImage Evening21
        {
            get => _images[7];
            set
            {
                _images[7] = value;
                OnPropertyChanged("Evening21");
            }
        }
        public BitmapImage WeatherLogo
        {
            get => _sinoptik.WeathrLogo;
            set
            {
                _sinoptik.WeathrLogo = value;
                OnPropertyChanged("WeatherLogo");
            }
        }
        public string TodayWeather
        {
            get => _sinoptik.TodayWeather;
            set
            {
                _sinoptik.TodayWeather = value;
                OnPropertyChanged("TodayWeather");
            }
        }
        public string TodayTime
        {
            get => _sinoptik.TodayTime;
            set
            {
                _sinoptik.TodayTime = value;
                OnPropertyChanged("TodayTime");
            }
        }
        public string DuskDown
        {
            get => _sinoptik.DuskDown;
            set
            {
                _sinoptik.DuskDown = value;
                OnPropertyChanged("DuskDown");
            }
        }
        public string Temperature
        {
            get => _sinoptik.Temperature;
            set
            {
                _sinoptik.Temperature = value;
                OnPropertyChanged("Temperature");
            }
        }
        public int TermometerValue
        {
            get => _sinoptik.TermometerValue;
            set
            {
                _sinoptik.TermometerValue = value;
                OnPropertyChanged("TermometerValue");
            }
        }

        #region Weather data Properties

        public string Temperature1
        {
            get => _weatherDataTabe[0];
            set
            {
                _weatherDataTabe[0] = value;
                OnPropertyChanged("Temperature1");
            }
        }
        public string Temperature2
        {
            get => _weatherDataTabe[1];
            set
            {
                _weatherDataTabe[1] = value;
                OnPropertyChanged("Temperature2");
            }
        }
        public string Temperature3
        {
            get => _weatherDataTabe[2];
            set
            {
                _weatherDataTabe[2] = value;
                OnPropertyChanged("Temperature3");
            }
        }
        public string Temperature4
        {
            get => _weatherDataTabe[3];
            set
            {
                _weatherDataTabe[3] = value;
                OnPropertyChanged("Temperature4");
            }
        }
        public string Temperature5
        {
            get => _weatherDataTabe[4];
            set
            {
                _weatherDataTabe[4] = value;
                OnPropertyChanged("Temperature5");
            }
        }
        public string Temperature6
        {
            get => _weatherDataTabe[5];
            set
            {
                _weatherDataTabe[5] = value;
                OnPropertyChanged("Temperature4");
            }
        }
        public string Temperature7
        {
            get => _weatherDataTabe[6];
            set
            {
                _weatherDataTabe[6] = value;
                OnPropertyChanged("Temperature7");
            }
        }
        public string Temperature8
        {
            get => _weatherDataTabe[7];
            set
            {
                _weatherDataTabe[7] = value;
                OnPropertyChanged("Temperature8");
            }
        }
        public string Fells
        {
            get => _weatherDataTabe[8];
            set
            {
                _weatherDataTabe[8] = value;
                OnPropertyChanged("Fells");
            }
        }
        public string Fells2
        {
            get => _weatherDataTabe[9];
            set
            {
                _weatherDataTabe[9] = value;
                OnPropertyChanged("Fells2");
            }
        }
        public string Fells3
        {
            get => _weatherDataTabe[10];
            set
            {
                _weatherDataTabe[10] = value;
                OnPropertyChanged("Fells3");
            }
        }
        public string Fells4
        {
            get => _weatherDataTabe[11];
            set
            {
                _weatherDataTabe[11] = value;
                OnPropertyChanged("Fells4");
            }
        }
        public string Fells5
        {
            get => _weatherDataTabe[12];
            set
            {
                _weatherDataTabe[12] = value;
                OnPropertyChanged("Fells5");
            }
        }
        public string Fells6
        {
            get => _weatherDataTabe[13];
            set
            {
                _weatherDataTabe[13] = value;
                OnPropertyChanged("Fells6");
            }
        }
        public string Fells7
        {
            get => _weatherDataTabe[14];
            set
            {
                _weatherDataTabe[14] = value;
                OnPropertyChanged("Fells7");
            }
        }
        public string Fells8
        {
            get => _weatherDataTabe[15];
            set
            {
                _weatherDataTabe[15] = value;
                OnPropertyChanged("Fells8");
            }
        }
        public string Presuare
        {
            get => _weatherDataTabe[16];
            set
            {
                _weatherDataTabe[16] = value;
                OnPropertyChanged("Presuare");
            }
        }
        public string Presuare2
        {
            get => _weatherDataTabe[17];
            set
            {
                _weatherDataTabe[17] = value;
                OnPropertyChanged("Presuare2");
            }
        }
        public string Presuare3
        {
            get => _weatherDataTabe[18];
            set
            {
                _weatherDataTabe[18] = value;
                OnPropertyChanged("Presuare3");
            }
        }
        public string Presuare4
        {
            get => _weatherDataTabe[19];
            set
            {
                _weatherDataTabe[19] = value;
                OnPropertyChanged("Presuare4");
            }
        }
        public string Presuare5
        {
            get => _weatherDataTabe[20];
            set
            {
                _weatherDataTabe[20] = value;
                OnPropertyChanged("Presuare5");
            }
        }
        public string Presuare6
        {
            get => _weatherDataTabe[21];
            set
            {
                _weatherDataTabe[21] = value;
                OnPropertyChanged("Presuare6");
            }
        }
        public string Presuare7
        {
            get => _weatherDataTabe[22];
            set
            {
                _weatherDataTabe[22] = value;
                OnPropertyChanged("Presuare7");
            }
        }
        public string Presuare8
        {
            get => _weatherDataTabe[23];
            set
            {
                _weatherDataTabe[23] = value;
                OnPropertyChanged("Presuare8");
            }
        }
        public string Humidity
        {
            get => _weatherDataTabe[24];
            set
            {
                _weatherDataTabe[24] = value;
                OnPropertyChanged("Humidity");
            }
        }
        public string Humidity2
        {
            get => _weatherDataTabe[25];
            set
            {
                _weatherDataTabe[25] = value;
                OnPropertyChanged("Humidity2");
            }
        }
        public string Humidity3
        {
            get => _weatherDataTabe[26];
            set
            {
                _weatherDataTabe[26] = value;
                OnPropertyChanged("Humidity3");
            }
        }
        public string Humidity4
        {
            get => _weatherDataTabe[27];
            set
            {
                _weatherDataTabe[27] = value;
                OnPropertyChanged("Humidity4");
            }
        }
        public string Humidity5
        {
            get => _weatherDataTabe[28];
            set
            {
                _weatherDataTabe[28] = value;
                OnPropertyChanged("Humidity5");
            }
        }
        public string Humidity6
        {
            get => _weatherDataTabe[29];
            set
            {
                _weatherDataTabe[29] = value;
                OnPropertyChanged("Humidity6");
            }
        }
        public string Humidity7
        {
            get => _weatherDataTabe[30];
            set
            {
                _weatherDataTabe[30] = value;
                OnPropertyChanged("Humidity7");
            }
        }
        public string Humidity8
        {
            get => _weatherDataTabe[31];
            set
            {
                _weatherDataTabe[31] = value;
                OnPropertyChanged("Humidity8");
            }
        }
        public string Wind
        {
            get => _weatherDataTabe[32];
            set
            {
                _weatherDataTabe[32] = value;
                OnPropertyChanged("Wind");
            }
        }
        public string Wind2
        {
            get => _weatherDataTabe[33];
            set
            {
                _weatherDataTabe[33] = value;
                OnPropertyChanged("Wind2");
            }
        }
        public string Wind3
        {
            get => _weatherDataTabe[34];
            set
            {
                _weatherDataTabe[34] = value;
                OnPropertyChanged("Wind3");
            }
        }
        public string Wind4
        {
            get => _weatherDataTabe[35];
            set
            {
                _weatherDataTabe[35] = value;
                OnPropertyChanged("Wind4");
            }
        }
        public string Wind5
        {
            get => _weatherDataTabe[36];
            set
            {
                _weatherDataTabe[36] = value;
                OnPropertyChanged("Wind5");
            }
        }
        public string Wind6
        {
            get => _weatherDataTabe[37];
            set
            {
                _weatherDataTabe[37] = value;
                OnPropertyChanged("Wind6");
            }
        }
        public string Wind7
        {
            get => _weatherDataTabe[38];
            set
            {
                _weatherDataTabe[38] = value;
                OnPropertyChanged("Wind7");
            }
        }
        public string Wind8
        {
            get => _weatherDataTabe[39];
            set
            {
                _weatherDataTabe[39] = value;
                OnPropertyChanged("Wind8");
            }
        }
        public string Precipitation
        {
            get => _weatherDataTabe[40];
            set
            {
                _weatherDataTabe[40] = value;
                OnPropertyChanged("Precipitation");
            }
        }
        public string Precipitation2
        {
            get => _weatherDataTabe[41];
            set
            {
                _weatherDataTabe[41] = value;
                OnPropertyChanged("Precipitation2");
            }
        }
        public string Precipitation3
        {
            get => _weatherDataTabe[42];
            set
            {
                _weatherDataTabe[42] = value;
                OnPropertyChanged("Precipitation3");
            }
        }
        public string Precipitation4
        {
            get => _weatherDataTabe[43];
            set
            {
                _weatherDataTabe[43] = value;
                OnPropertyChanged("Precipitation4");
            }
        }
        public string Precipitation5
        {
            get => _weatherDataTabe[44];
            set
            {
                _weatherDataTabe[44] = value;
                OnPropertyChanged("Precipitation5");
            }
        }
        public string Precipitation6
        {
            get => _weatherDataTabe[45];
            set
            {
                _weatherDataTabe[45] = value;
                OnPropertyChanged("Precipitation6");
            }
        }
        public string Precipitation7
        {
            get => _weatherDataTabe[46];
            set
            {
                _weatherDataTabe[46] = value;
                OnPropertyChanged("Precipitation7");
            }
        }
        public string Precipitation8
        {
            get => _weatherDataTabe[47];
            set
            {
                _weatherDataTabe[47] = value;
                OnPropertyChanged("Precipitation8");
            }
        }
        #endregion
        #endregion

        public SinoptikViewModel()
        {
            _images = new();
            _weatherDataTabe = new();
            _sinoptik = new();
            _sinoptik.GetImagesInHTML(_images);
            _sinoptik.WeaterData();
            _sinoptik.WeaterDataTable(_weatherDataTabe);
        }
    }
}
