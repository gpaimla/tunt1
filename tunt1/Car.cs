using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace tunt1
{
    class Car
    {
        public int kw { get; set; }
        public string manufacturer { get; set; }
        public int imageSource { get; set; }
        public string model { get; set; }
        public Car(int kw, string manufacturer, string model, int image)
        {
            this.kw = kw;
            this.manufacturer = manufacturer;
            this.imageSource = image;
            this.model = model;
        }
    }
}