namespace WorkManage.Data.Models
{
    public class WorkStage
    {
        public int? Id { get; set; }
        public int? WorkId { get; set; }
        public Work? Work { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
    }
}
