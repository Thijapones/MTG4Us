using Domain;
using Repository.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IBoxContentRepository : IRepository<BoxContent>
    {
        void InsertNewContent(Wish wish, int boxid);

        void EmptyBox(int boxid);
    }
}
