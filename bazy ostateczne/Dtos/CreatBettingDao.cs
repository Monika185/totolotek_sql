using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bazy_ostateczne.Dtos
{
    public class CreatBettingDao
    {
        public Nullable<int> L1 { get; set; }
        public Nullable<int> L2 { get; set; }
        public Nullable<int> L3 { get; set; }
        public Nullable<int> L4 { get; set; }
        public Nullable<int> L5 { get; set; }
        public Nullable<int> L6 { get; set; }

        public int Result_Id { get; set; }
        public int Clientt_Id { get; set; }

        public CreatBettingDao()
        {

        }
        public CreatBettingDao(int clientID, int resultID)
        {
            Result_Id = resultID;
            Clientt_Id = clientID;
        }
    }
}