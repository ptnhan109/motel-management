using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Motel.Common
{
    public class Messages
    {
        public const string LoginSuccess = "Đăng nhập thành công";
        public const string LoginFail = "Đăng nhập thất bại";

        public static async Task ShowMessage(string message)
        {
            ToastDuration duration = ToastDuration.Short;
            double fontSize = 14;

            var toast = Toast.Make(message, duration, fontSize);

            await toast.Show();
        }
    }
}
