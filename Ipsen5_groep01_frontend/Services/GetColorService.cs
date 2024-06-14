namespace Ipsen5_groep01_frontend.Services
{
    public class GetColorService
    {
        public string GetBackgroundColor(string status)
        {
            return status switch
            {
                "New" => "lightgreen",
                "Completed" => "#AA77FF",
                "Wachten op beoordeling" => "#FFFDD0",
                "Goedgekeurd" => "#3CB371",
                "Afgekeurd" => "#FF3131",
                _ => "lightblue"
            };
        }
    }
}
