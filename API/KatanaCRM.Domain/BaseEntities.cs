using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KatanaCRM.Domain
{
    #region Interfaces

    public interface IEntity
    {
        int Id { get; set; }
        bool IsNew { get; set; }
    }

    public interface IDeletable
    {
        bool IsDeleted { get; set; }
    }

    public interface ITableEntity
    {
        bool IsDeleted { get; set; }
        int CreateBy { get; set; }
        DateTime CreateDateTime { get; set; }
        int? UpdateBy { get; set; }
        DateTime? UpdateDateTime { get; set; }
    }


    #endregion

    #region Classes

    public class Entity : IEntity
    {
        [Key]
        public int Id { get; set; }
        [NotMapped]
        public bool IsNew { get; set; }
    }

    public class TableEntity : Entity, ITableEntity, IEntity, IDeletable
    {
        public bool IsDeleted { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDateTime { get; set; }
    }

    #endregion
}
