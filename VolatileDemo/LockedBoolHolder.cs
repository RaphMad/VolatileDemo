#region header

/*******************************************************
 *                                                     *
 * COPYRIGHT: FREQUENTIS AG. All rights reserved.      *
 *            Registered with Commercial Court Vienna, *
 *            reg.no. FN 72.115b.                      *
 *                                                     *
 *******************************************************/

#endregion

namespace VolatileDemo
{
   public class LockedBoolHolder
   {
      private bool flag;

      public bool _isOn
      {
         get
         {
            lock (this)
            {
               return flag;
            }
         }
         set
         {
            lock (this)
            {
               flag = value;
            }
         }
      }
   }
}