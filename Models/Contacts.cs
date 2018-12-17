using System;
using System.Collections.Generic;

namespace myPhonebook.Models
{
    public partial class Contacts
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public int? Number { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
