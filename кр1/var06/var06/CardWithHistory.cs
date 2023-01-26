using System;
using System.Collections.Generic;
using System.Text;

namespace var06
{
    class CardWithHistory:Card
    {
        
         public CardWithHistory(int _Number, int _Month, int _Year, int _Balance)
            :base(_Number, _Month, _Year,_Balance)
        {  }

        public static int operator +(CardWithHistory card1, int val)
        {
            return card1.Balance + val;
        }

        //public void Add(int val)
        //{
        //    string str = "Зачислено на счёт " + val;
        //}
        public string Add(int val)
        {
             return "Зачислено на счёт " + val;
        }

        
    }
}
