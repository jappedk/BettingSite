using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BettingClient.Models
{
    public class Wrapper
    {
        public Bruger bruger { get; set; }
        public wager onewager { get; set; }
        public List<wager> wager { get; set; }
        public bet emptybet { get; set; }

    }
}