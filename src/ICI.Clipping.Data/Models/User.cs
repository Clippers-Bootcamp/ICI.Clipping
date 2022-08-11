using System;
using System.Collections.Generic;

#nullable disable

namespace ICI.Clipping.Data.Models
{
    public partial class User
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Changed { get; set; }
        public byte Profile { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Checked { get; set; }
        public bool Deleted { get; set; } = false;
    }
}
