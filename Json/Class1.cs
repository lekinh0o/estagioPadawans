namespace Json
{/* para facilitar criei somente uma class com o nome post*/
    public class Post
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Completed { get; set; }
    }
}
