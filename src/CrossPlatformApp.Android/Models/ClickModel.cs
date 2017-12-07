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
using CrossPlatformApp.Models;

namespace CrossPlatformApp.Droid.Models
{
    class ClickModel : IClickModel
    {
        public int Clicks { get; private set; }

        public void OnClick()
        {
            Clicks++;
        }

        public void Reset()
        {
            Clicks = 0;
        }
    }
}