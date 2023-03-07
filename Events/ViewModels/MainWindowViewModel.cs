using System.IO;
using Events.Models;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;

namespace Events.ViewModels
{

    public class MainWindowViewModel : ViewModelBase
    {
         

        /*public CityEvent Eventzxc = new CityEvent();
        public string FirstName
        {
            get { return Eventzxc.Header; }
            set {
                string qwe = Eventzxc.Header;
                this.RaiseAndSetIfChanged(ref qwe, value); }
        }

        public void Change()
        {
            Eventzxc.Header = "qwe";
            FirstName = "zxc";
        }*/



        static CityEvent JsonRead()
        {
            var Eventzxc = File.Exists("City.json") ? 
                JsonConvert.DeserializeObject<CityEvent>(File.ReadAllText("City.json")) : 
                new CityEvent
            {
                
            };
            File.WriteAllText("City.json", JsonConvert.SerializeObject(Eventzxc));
            return Eventzxc;
        }
        public CityEvent eventFromJSON = JsonRead();

        public List<string> myvalues = new List<string>() { "May 2020", "May", "Monday", "25/May/2020" };

        public string Header0 { get { return eventFromJSON.Header[0]; } }
        public string Header1 { get { return eventFromJSON.Header[1]; } }
        public string Header2 { get { return eventFromJSON.Header[2]; } }
        public string Header3 { get { return eventFromJSON.Header[3]; } }
        public string Header4 { get { return eventFromJSON.Header[4]; } }
        public string Header5 { get { return eventFromJSON.Header[5]; } }
        public string Header6 { get { return eventFromJSON.Header[6]; } }
        public string Header7 { get { return eventFromJSON.Header[7]; } }
        public string Header8 { get { return eventFromJSON.Header[8]; } }


        public string Description0 { get { return eventFromJSON.Description[0]; } }
        public string Description1 { get { return eventFromJSON.Description[1]; } }
        public string Description2 { get { return eventFromJSON.Description[2]; } }
        public string Description3 { get { return eventFromJSON.Description[3]; } }
        public string Description4 { get { return eventFromJSON.Description[4]; } }
        public string Description5 { get { return eventFromJSON.Description[5]; } }
        public string Description6 { get { return eventFromJSON.Description[6]; } }
        public string Description7 { get { return eventFromJSON.Description[7]; } }
        public string Description8 { get { return eventFromJSON.Description[8]; } }
        

        public string Image0 { get { return eventFromJSON.Image[0]; } }
        public string Image1 { get { return eventFromJSON.Image[1]; } }
        public string Image2 { get { return eventFromJSON.Image[2]; } }
        public string Image3 { get { return eventFromJSON.Image[3]; } }
        public string Image4 { get { return eventFromJSON.Image[4]; } }
        public string Image5 { get { return eventFromJSON.Image[5]; } }
        public string Image6 { get { return eventFromJSON.Image[6]; } }
        public string Image7 { get { return eventFromJSON.Image[7]; } }
        public string Image8 { get { return eventFromJSON.Image[8]; } }


        public string Date0 { get { return eventFromJSON.Date[0]; } }
        public string Date1 { get { return eventFromJSON.Date[1]; } }
        public string Date2 { get { return eventFromJSON.Date[2]; } }
        public string Date3 { get { return eventFromJSON.Date[3]; } }
        public string Date4 { get { return eventFromJSON.Date[4]; } }
        public string Date5 { get { return eventFromJSON.Date[5]; } }
        public string Date6 { get { return eventFromJSON.Date[6]; } }
        public string Date7 { get { return eventFromJSON.Date[7]; } }
        public string Date8 { get { return eventFromJSON.Date[8]; } }

        public string Category0 { get { return eventFromJSON.Category[0]; } }
        public string Category1 { get { return eventFromJSON.Category[1]; } }
        public string Category2 { get { return eventFromJSON.Category[2]; } }
        public string Category3 { get { return eventFromJSON.Category[3]; } }
        public string Category4 { get { return eventFromJSON.Category[4]; } }
        public string Category5 { get { return eventFromJSON.Category[5]; } }
        public string Category6 { get { return eventFromJSON.Category[6]; } }
        public string Category7 { get { return eventFromJSON.Category[7]; } }
        public string Category8 { get { return eventFromJSON.Category[8]; } }

        public string Price0 { get { return eventFromJSON.Price[0]; } }
        public string Price1 { get { return eventFromJSON.Price[1]; } }
        public string Price2 { get { return eventFromJSON.Price[2]; } }
        public string Price3 { get { return eventFromJSON.Price[3]; } }
        public string Price4 { get { return eventFromJSON.Price[4]; } }
        public string Price5 { get { return eventFromJSON.Price[5]; } }
        public string Price6 { get { return eventFromJSON.Price[6]; } }
        public string Price7 { get { return eventFromJSON.Price[7]; } }
        public string Price8 { get { return eventFromJSON.Price[8]; } }

    }
}
