﻿using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //   *****  RapidApi request hakkı dolduğu için ***** 


            //        var client = new HttpClient();
            //        var request = new HttpRequestMessage
            //        {
            //            Method = HttpMethod.Get,
            //            RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/ardaguler"),
            //            Headers =
            //{
            //    { "x-rapidapi-key", "6efde1ea05msh480182dc91f0992p1131fejsn7853079fac06" },
            //    { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
            //},
            //        };
            //        using (var response = await client.SendAsync(request))
            //        {
            //            response.EnsureSuccessStatusCode();
            //            var body = await response.Content.ReadAsStringAsync();
            //            ResultInstagramFollowersDto resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
            //            ViewBag.v1 = resultInstagramFollowersDtos.followers;
            //            ViewBag.v2 = resultInstagramFollowersDtos.following;

            //        }
            //        var client2 = new HttpClient();
            //        var request2 = new HttpRequestMessage
            //        {
            //            Method = HttpMethod.Get,
            //            RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=elonmusk"),
            //            Headers =
            //{
            //    { "x-rapidapi-key", "6efde1ea05msh480182dc91f0992p1131fejsn7853079fac06" },
            //    { "x-rapidapi-host", "twitter32.p.rapidapi.com" },
            //},
            //        };
            //        using (var response2 = await client2.SendAsync(request2))
            //        {
            //            response2.EnsureSuccessStatusCode();
            //            var body2 = await response2.Content.ReadAsStringAsync();
            //            ResultTwittterFollowersDto resultTwittterFollowersDto = JsonConvert.DeserializeObject<ResultTwittterFollowersDto>(body2);
            //            ViewBag.v3 = resultTwittterFollowersDto.data.user_info.followers_count;
            //            ViewBag.v4 = resultTwittterFollowersDto.data.user_info.friends_count;
            //        }
            //        var client3 = new HttpClient();
            //        var request3 = new HttpRequestMessage
            //        {
            //            Method = HttpMethod.Get,
            //            RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fmuhammetemincaliskan%2F&include_skills=false&include_certifications=false&include_publications=false&include_honors=false&include_volunteers=false&include_projects=false&include_patents=false&include_courses=false&include_organizations=false&include_profile_status=false&include_company_public_url=false"),
            //            Headers =
            //{
            //    { "x-rapidapi-key", "6efde1ea05msh480182dc91f0992p1131fejsn7853079fac06" },
            //    { "x-rapidapi-host", "fresh-linkedin-profile-data.p.rapidapi.com" },
            //},
            //        };
            //        using (var response3 = await client3.SendAsync(request3))
            //        {
            //            response3.EnsureSuccessStatusCode();
            //            var body3 = await response3.Content.ReadAsStringAsync();
            //            ResultLinkedinFollowersDto resultLinkedinFollowersDto = JsonConvert.DeserializeObject<ResultLinkedinFollowersDto>(body3);
            //            ViewBag.v5 = resultLinkedinFollowersDto.data.connection_count;
            //            ViewBag.v6 = resultLinkedinFollowersDto.data.location;
            //        }
            return View();
        }
    }
}