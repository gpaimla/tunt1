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
    class ListViewAdapter : BaseAdapter<Car>
    {
        private List<Car> CarList;
        private Context Context;

        public ListViewAdapter(Context context, List<Car> list)
        {
            this.Context = context;
            this.CarList = list;

        }

        public override int Count
        {
            get { return CarList.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Car this[int position]
        {
            get { return CarList[position]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(Context).Inflate(Resource.Layout.ListViewRow, null, false);
            }

            TextView manufacturer = row.FindViewById<TextView>(Resource.Id.manufacturer);
            TextView KW = row.FindViewById<TextView>(Resource.Id.KW);
            TextView model = row.FindViewById<TextView>(Resource.Id.model);
            ImageView carImage = row.FindViewById<ImageView>(Resource.Id.listViewCarImage);

            KW.Text = CarList[position].kw.ToString();
            manufacturer.Text = CarList[position].manufacturer;
            model.Text = CarList[position].model;
            carImage.SetImageResource(CarList[position].imageSource);

            return row;
        }


    }
}