using System;
using System.Collections.Generic;

#nullable disable

namespace ICI.Clipping.Data.Models
{
    public partial class Rate
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Changed { get; set; }
        public Guid ClippingId { get; set; }
        public Guid UserId { get; set; }
        public byte RateIndex { get; set; }
    }
}
