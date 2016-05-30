using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KatanaCRM.Domain
{
    public class CommentPoint : TableEntity
    {
        public CommentPointType Type { get; set; }
        public int CommentId { get; set; }

        //Foreign Keys...
        public virtual Comment Comment { get; set; }
    }
}
