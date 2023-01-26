using System;
using System.Collections.Generic;
using System.Text;

namespace var08
{
    partial class Time
    {
        //public override bool Equals(object obj)
        //{
        //    if (hour == this.hour || minute != this.minute || second != this.second) return false;
        //    return true;
        //}

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;

            Time time = obj as Time;
            //if (time == null)
            //    return false;
            if (this.hour == time.hour && this.minute == time.minute && this.second == time.second)
                return true;
            else
                return false;
            //return this.hour == time.hour && this.minute == time.minute && this.second == time.second;        
        }

        public override int GetHashCode()
        {
            int hash = 269;
            hash = hour.GetHashCode();
            hash = (hash * 47) + minute.GetHashCode() + second.GetHashCode();
            return hash;
        }

        public static bool operator == (Time time1, Time time2)
        {
            if (time1.hour == time2.hour && time1.minute == time2.minute)
                return true;
            else
                return false;
        }

        public static bool operator !=(Time time1, Time time2)
        {
            if (time1.hour == time2.hour)
                return false;
            else
                return true;
        }


    }
}
