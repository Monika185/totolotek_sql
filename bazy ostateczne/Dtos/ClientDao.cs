using System;
using System.Collections.Generic;
using bazy_ostateczne.Models;
using System.Linq;
using System.Web;

namespace bazy_ostateczne.Dtos
{
    public class ClientDao
    {
        public int ID { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string FirstName { get; set; }
        public string Name { get; set; }
        public Nullable<int> NameBetting { get; set; }
        public ICollection<Betting> Betting { get; set; }
    }
}