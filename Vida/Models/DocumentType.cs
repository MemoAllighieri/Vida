using System;
using System.Collections.Generic;

namespace Vida.Models
{
    public partial class DocumentType
    {
        public DocumentType()
        {
            Users = new HashSet<User>();
        }

        public int DocumentTypeId { get; set; }
        public string? DocumentCode { get; set; }
        public string? Description { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
