using System;
using System.Collections.Generic;

#nullable disable

namespace ICI.Clipping.Data.Models
{
    public partial class Score
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Changed { get; set; }
        public Guid PublishId { get; set; }
        public Guid UserId { get; set; }
        public double Rate { get; set; }
    }
}
