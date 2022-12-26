using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace solution_wpfapp
{
    /// <summary>
    /// Interaction logic for ExamWindow.xaml
    /// </summary>
    public partial class ExamWindow : Window
    {
        public ExamWindow()
        {
            InitializeComponent();
            Loaded += ExamWindowLoaded;
            ParticipantWebView.WebMessageReceived += ParticipantWebViewWebMessageReceived;

        }

        /// <summary>
        /// Messages received from Dyte Web Backend will be received here!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParticipantWebViewWebMessageReceived(object? sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            MessageBox.Show(e.WebMessageAsJson);
        }

        private void ExamWindowLoaded(object sender, RoutedEventArgs e)
        {
            var host = string.Empty;        //Example: http://127.0.0.1:5500";
            var url = string.Empty;         //Example: index.html;
            var roomName = string.Empty;    //Example: kvxbov-ksabzy;
            var authToken = string.Empty;   //Example: eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjViMDZkNmY4LWM2M2YtNDA5Ny05ZmYwLTU4NzdmZmJmOTFiZiIsImxvZ2dlZEluIjp0cnVlLCJpYXQiOjE2NzIwMjc4NzksImV4cCI6MTY4MDY2Nzg3OX0.rvme95rRweh8ntafl042wMITiYQ4DLNuApHlarDg8A-4qU5r2q1Lg-B7Ev3rOWerXnhrlr0bIHCCsNoQVAc7wSq9gGBmfLhJvNJn3mtS1ief004YfpKpxAfnOhkVk8oRAcgBrmJxhVEZuxPQvD3--aEbdkRctqHo9z0JfZCnE2PaCPDa2uYOQhf4sFfORGfbTjPtdjs3FsR2gmSIu-nY0hHW3uStfuccA7s04gXy7-u9yVr18ibOColszxe4EONRyfV2uiouXZutCD_T6u9YMukk3RxkmK5LI7eFzWsc_gUmrpUahKoThmvh8PeiHwOSzWJd-BsJFHHPpKe0ivQIhg;

            var source = new Uri(string.Concat(host, "/", url, "?", "roomName=", roomName, "&authToken=", authToken));
            ParticipantWebView.Source = new Uri(source.ToString());
        }
    }
}
