namespace WorkManage.Data.Models
{
    public class Master
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string Rank { get; set; }
        public DateTime HireDate { get; set; }
        public IEnumerable<Work> Works { get; set; }
    }
}
