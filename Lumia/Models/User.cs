using System.Collections.Generic;

namespace Lumia.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Fullname { get; set; }
        public string Position { get; set; }
        public List<Testimonial> Testimonials { get; set; }
    }
}
