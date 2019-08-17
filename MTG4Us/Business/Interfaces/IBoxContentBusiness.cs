using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IBoxContentBusiness
    {
        ///<summary>
        ///A box content holds the items that are phisically stored into a box.
        ///When items are deposited in the box, a new box content must be created.
        ///When the items are retrieved, the box content must be cleared.
        ///Later on, the idea is to have a single box holding items for different wishes.
        ///Once that enhancement is implemented, a new set for removing contents using boxid and itemid
        ///will be implemented.
        ///No query can be done using the BoxContent object as the content is present when you
        ///query the box itself.
        ///</summary>

        void InsertNewContent(Wish wish, int boxid);

        void EmptyBox(int boxid);
    }
}
