using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace tunt1
{
    [Activity(Label = "tunt1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private ListView carListView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            AppCenter.Start("5b6bc696-6c5b-4ede-9d85-c79f345e88af",
                   typeof(Analytics), typeof(Crashes));
            AppCenter.Start("5b6bc696-6c5b-4ede-9d85-c79f345e88af", typeof(Analytics), typeof(Crashes));

            carListView = FindViewById<ListView>(Resource.Id.carListView);

            List<Car> carList = new List<Car>();

            carList.Add(new Car(5000, "GenericCarModule1","model1", Resource.Drawable.ZtUpfQ9));
            carList.Add(new Car(7000, "GenericCarModule2", "model2", Resource.Drawable.b8YQGr3f));
            carList.Add(new Car(6000, "GenericCarModule3", "model3", Resource.Drawable.biBGTpH));
            carList.Add(new Car(4000, "GenericCarModule4", "model4", Resource.Drawable.DtUXgZd));
            carList.Add(new Car(3000, "GenericCarModule5", "model5", Resource.Drawable.OkdoG6a));
            carList.Add(new Car(2000, "GenericCarModule6", "model6", Resource.Drawable.s36wK9am));
            carList.Add(new Car(2000, "GenericCarModule7", "model7", Resource.Drawable.XD9lHWdEr));
            carList.Add(new Car(1000, "GenericCarModule8", "model8", Resource.Drawable.gwIdolZ));
            carList.Add(new Car(3000, "GenericCarModule9", "model9", Resource.Drawable.eheDC1Y));
            carList.Add(new Car(2000, "GenericCarModule10", "model10", Resource.Drawable.DHWM9FX));
            ListViewAdapter adapter = new ListViewAdapter(this, carList);

            carListView.Adapter = adapter;
        }
    }
}

