namespace OzonEdu.MerchandiseService.Models
{
    public sealed class MerchResponse
    {
        public MerchResponse(string merchName)
        {
            MerchName = merchName;
        }

        public string MerchName { get; }
    }
}