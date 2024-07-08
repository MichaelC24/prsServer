namespace prsServer.Model
{
    public class RequestLines
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; } = 1;

        public virtual Requests? Requests { get; set; }
        public virtual Products? Products { get; set; }
    }
}
