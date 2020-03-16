using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace _4._16_HttpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            async Task<string> readWebpage(string uri)
            {
                HttpClient client = new HttpClient();
                return await client.GetStringAsync(uri);
            }

            try
            {
                string webText = await readWebpage(PageUriTextBox.Text);
                ResultTextBlock.Text = webText;
            }
            catch(Exception ex)
            {
                var dialog = new MessageDialog(ex.Message, "Request failed");
                await dialog.ShowAsync();
            }
        }
    }
}
