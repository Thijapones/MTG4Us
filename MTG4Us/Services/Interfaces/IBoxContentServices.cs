using Domain;

namespace Services.Interfaces
{
    public interface IBoxContentServices
    {
        void InsertNewContent(Wish wish, int boxid);

        void EmptyBox(int boxid);
    }
}
