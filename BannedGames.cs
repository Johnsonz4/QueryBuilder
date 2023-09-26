namespace QueryBuilder.Models
{
    public class BannedGame : IClassModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Reason { get; set; }

    }
}
