using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> Invoke()
        {
            List<ResultInstagramFollowersDto> resultInstagramFollowersDtos = new List<ResultInstagramFollowersDto>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/leomessi"),
                Headers =
    {
        { "x-rapidapi-key", "6efde1ea05msh480182dc91f0992p1131fejsn7853079fac06" },
        { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                resultInstagramFollowersDtos = JsonConvert.DeserializeObject<List<ResultInstagramFollowersDto>>(body);
                return View(resultInstagramFollowersDtos);
            }

        }
    }
}
