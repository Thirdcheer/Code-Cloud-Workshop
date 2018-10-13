using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Warsztaty.Core
{
    [Table("Contact")]
    public class ContactModel
    {
        [Key]
        public virtual int ID { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }
        public int Number { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

    }
}
