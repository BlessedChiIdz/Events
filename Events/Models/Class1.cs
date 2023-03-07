using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using System.IO;
using Newtonsoft.Json;

namespace Events.Models
{
    public class CityEvent
    {
        public string[] Header { get; set; }
        public string[] Description { get; set; }
        public string[] Image { get; set; }
        public string[] Date { get; set; }
        public string[] Category { get; set; }
        public string[] Price { get; set; }

        /* public string Header
        {
            get { return _Header; }
            set
            {
                this.RaiseAndSetIfChanged(ref _Header, value);
            }
        }
        public string Description
        {
            get { return _Description; }
            set
            {
                this.RaiseAndSetIfChanged(ref _Description, value);
            }
        }
        public string Image
        {
            get { return _Image; }
            set
            {
                this.RaiseAndSetIfChanged(ref _Image, value);
            }
        }
        public string Date
        {
            get { return _Date; }
            set
            {
                this.RaiseAndSetIfChanged(ref _Date, value);
            }
        }
        public string Category
        {
            get { return _Category; }
            set
            {
                this.RaiseAndSetIfChanged(ref _Category, value);
            }
        }
        public string Price
        {
            get { return _Price; }
            set
            {
                this.RaiseAndSetIfChanged(ref _Price, value);
            }
        }*/
    }
}
