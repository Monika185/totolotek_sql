using System;
using System.Collections.Generic;

namespace bazy_ostateczne.Models
{
    public class Betting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Betting()
        {
           // this.BinaryCoupon = new HashSet<BinaryCoupon>();
        }

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

        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinaryResult> BinaryCoupon { get; set; }
        public virtual Result Result { get; set; }
    }
}
