using System;
using System.Collections.Generic;

#nullable disable

namespace ICI.Clipping.Data.Models
{
    public partial class Clipping
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Changed { get; set; }
        public string Image { get; set; }
        public string Synopsis { get; set; }
        public string Contents { get; set; }
        public string Link { get; set; }
        public string NewsChannel { get; set; }
        public string Local { get; set; }
        public DateTime Publish { get; set; }
    }
}
