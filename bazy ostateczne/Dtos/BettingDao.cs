using System;
using System.Collections.Generic;
using bazy_ostateczne.Models;
using System.Linq;
using System.Web;

namespace bazy_ostateczne.Dtos
{
    public class BettingDao
    {

        public int ID { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Nullable<int> L1 { get; set; }
        public Nullable<int> L2 { get; set; }
        public Nullable<int> L3 { get; set; }
        public Nullable<int> L4 { get; set; }
        public Nullable<int> L5 { get; set; }
        public Nullable<int> L6 { get; set; }

        public ICollection<BinaryResult> BinaryCoupon { get; set; }
    }
}