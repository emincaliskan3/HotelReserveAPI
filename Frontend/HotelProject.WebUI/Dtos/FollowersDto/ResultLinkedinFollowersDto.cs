namespace HotelProject.WebUI.Dtos.FollowersDto
{
    public class ResultLinkedinFollowersDto
    {
        public Data data { get; set; }

        public class Data
        {
            public int connection_count { get; set; }

            public string location { get; set; }

        }
    }
}
