using System;
using System.Collections.Generic;

namespace Vida.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastNameF { get; set; }
        public string? LastNameM { get; set; }
        public string? Email { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? CountryId { get; set; }
        public int? DocumentTypeId { get; set; }
        public string? DocumentNumber { get; set; }
        public bool? Status { get; set; }

        public virtual Country? Country { get; set; }
        public virtual DocumentType? DocumentType { get; set; }
    }
}
