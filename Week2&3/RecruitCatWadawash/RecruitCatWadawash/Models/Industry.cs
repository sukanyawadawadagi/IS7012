using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatWadawash.Models
{
    public class Industry
    {
        public string Name { get; set; }

        public int ID { get; set; }

        public int MarketShare { get; set; }

        public List<Candidate> Candidates { get; set; }

        public List<Company> Companies { get; set; }

    }
}
