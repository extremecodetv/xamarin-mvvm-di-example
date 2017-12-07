using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using CrossPlatformApp.Models;

namespace CrossPlatformApp.iOS.Models
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