namespace LoadingData.Entities
{
    public class BlogUser
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
        public bool IsAdmin { get; set; }
    }
}
