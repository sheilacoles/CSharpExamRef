using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._25_NASA_JSON
{
    public class ImageOfDay
    {
        public string date { get; set; }
        public string explanation { get; set; }
        public string hdurl { get; set; }
        public string media_type { get; set; }
        public string service_version { get; set; }
        public string title { get; set; }
        public string url { get; set; }
    }
    async Task<ImageOfDay> GetImageOfDay(string imageURL)
    {
        string NASAJson = await readWebpage(imageURL);
        ImageOfDay result = JsonConvert.DeserializeObject<ImageOfDay>(NASAJson);
        return result;
    }
    private async void LoadButtonClicked(object sender, RoutedEventArgs e)
    {
        try
        {
            ImageOfDay imageOfDay = await getImageOfDay(
                "https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY&date=2018-05-29");

            if(imageOfDay.media_type != "image")
            {
                MessageBox.Show("It is not an image today");
                return;
            }
            DescriptionTextBlock.T ext = imageOfDay.explanation;
            await displayUrl(imageOfDay.url);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Fetch failed: {0}", ex.Message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
