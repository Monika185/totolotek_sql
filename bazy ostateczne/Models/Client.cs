using System;
using System.Collections.Generic;


namespace bazy_ostateczne.Models
{
    public class Client
    {

        public Client()
        {
            this.Betting = new HashSet<Betting>();
        }

        public int ID { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string FirstName { get; set; }
        public string Name { get; set; }
        public Nullable<int> NameBetting { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Betting> Betting { get; set; }

    }
}