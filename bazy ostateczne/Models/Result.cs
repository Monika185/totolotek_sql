using System;
using System.Collections.Generic;

namespace bazy_ostateczne.Models
{
    public class Result
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Result()
        {
            this.BinaryWin = new HashSet<BinaryResult>();
            this.Zaklady = new HashSet<Betting>();
        }

        public int ID { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Nullable<int> NumbersCoupon { get; set; }
        public Nullable<int> NumberWin3 { get; set; }
        public Nullable<int> NumberWin4 { get; set; }
        public Nullable<int> NumberWin5 { get; set; }
        public Nullable<int> NumberWin6 { get; set; }
        public Nullable<int> L1 { get; set; }
        public Nullable<int> L2 { get; set; }
        public Nullable<int> L3 { get; set; }
        public Nullable<int> L4 { get; set; }
        public Nullable<int> L5 { get; set; }
        public Nullable<int> L6 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinaryResult> BinaryWin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Betting> Zaklady { get; set; }
    }
}