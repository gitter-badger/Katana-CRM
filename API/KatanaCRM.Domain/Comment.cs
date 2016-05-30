using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KatanaCRM.Domain
{
    public class Comment : TableEntity
    {
        public string Content { get; set; }
        public int RefId { get; set; }
        public bool IsSolution { get; set; }

        //Foreign keys...
        public virtual ICollection<CommentPoint> CommentPoints { get; set; }

        public Comment()
        {
            CommentPoints = new HashSet<CommentPoint>();
        }
    }
}
