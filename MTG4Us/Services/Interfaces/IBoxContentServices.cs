using Domain;

namespace Services.Interfaces
{
    public interface IBoxContentServices
    {
        void InsertNewContent(Wish wish);

        void EmptyBox(int boxid);
    }
}
