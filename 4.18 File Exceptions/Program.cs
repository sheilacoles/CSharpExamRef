using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _4._18_File_Exceptions
{
    class Program
    {
        private async void StartTaskButton_Click(object sender, RoutedEventArgs e)
        {
            byte[] date = new byte[100];

            try
            {
                //note that the filename contains an invalid character await
                WriteBytesAsyncTask("demo:.dat", data);
            }
            catch (Exception writeException)
            {
                MessageBox.Show(writeException.Message, "File write failed");
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
