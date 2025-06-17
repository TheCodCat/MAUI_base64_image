using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUI_base64_image.Models;
using Newtonsoft.Json;

namespace MAUI_base64_image.viewModels
{
    public partial class ImagesViewModels : ObservableObject
    {
        HttpClient client = new HttpClient();

        [ObservableProperty]
        private List<ImageDTO> images;

        [RelayCommand]
        private async void GetImages()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("http://localhost:5059/ImageStorage/GetAllImages"),
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Images = JsonConvert.DeserializeObject<List<ImageDTO>>(body);
            }
        }
    }
}
