namespace Lumia.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
