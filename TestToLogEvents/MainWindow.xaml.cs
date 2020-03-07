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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestToLogEvents {
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void chkChekCustomSource_Checked(object sender, RoutedEventArgs e) {

            this.txtLog.IsEnabled = true;
            this.txtSource.IsEnabled = true;

        }


        private void chkChekCustomSource_Unchecked(object sender, RoutedEventArgs e) {

            this.txtLog.IsEnabled = false;
            this.txtSource.IsEnabled = false;

        }

        private void btnLogOnWindowsEvents_Click(object sender, RoutedEventArgs e) {

            if (chkChekCustomSource.IsChecked == true) {

                LogEventsSimplified.LogEvents.logSimpleStringCustomSource(txtMessage.Text, System.Diagnostics.EventLogEntryType.Information, 777, txtSource.Text, txtLog.Text);

            } else {

                LogEventsSimplified.LogEvents.logSimpleStringEvent(txtMessage.Text, System.Diagnostics.EventLogEntryType.Warning, 777);

            }

        }
    }
}
