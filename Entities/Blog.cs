using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingData.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual List<BlogUser> BlogUsers { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}
