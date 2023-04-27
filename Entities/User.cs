using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingData.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual List<BlogUser> BlogUsers { get; set; }

    }
}
