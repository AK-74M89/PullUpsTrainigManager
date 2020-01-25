using System;

namespace PuullUpsTrainigManager
{
    public struct UsersListItem
    {        
        public int ID;
        public string UserName;
        public int InitMax;
        public int CurrentMax;
    }

    public struct ResultsListItem
    {
        public int ID;
        public int Result;
        public DateTime Date;
    }
}
