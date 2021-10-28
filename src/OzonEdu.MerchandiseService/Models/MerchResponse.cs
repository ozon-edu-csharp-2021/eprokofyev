namespace OzonEdu.MerchandiseService.Models
{
    public class MerchResponse
    {
        public MerchResponse(string merchName)
        {
            MerchName = merchName;
        }
        
        public string MerchName { get; }
    }
}