using Android.Util;
using Enrollment.XPlatform.Flow;
using LogicBuilder.App.Maui.Utils.Interfaces;

namespace Enrollment.XPlatform
{
    public class AppLogger : IAppLogger
    {
        public void LogMessage(string group, string message)
        {
            Log.Debug($"X:{group}", message);
        }
    }
}
