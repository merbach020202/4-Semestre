
namespace minimalAPIMongo.Controllers
{
    public class OrderViewModel
    {
        public string? Id { get; internal set; }
        public DateTime Date { get; internal set; }
        public string? Status { get; internal set; }
        public object ProductId { get; internal set; }
        public object ClientId { get; internal set; }
    }
}