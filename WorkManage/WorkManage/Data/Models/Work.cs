namespace WorkManage.Data.Models
{
    public class Work
    {
        public int Id { get; set; }
        public int MasterId { get; set; }
        public Master Master { get; set; }
        public decimal Price { get; set; }
        public int DaysCount { get; set; }
        public string Name { get; set; }
        public IEnumerable<WorkStage> WorkStages { get; set; }
    }
}
