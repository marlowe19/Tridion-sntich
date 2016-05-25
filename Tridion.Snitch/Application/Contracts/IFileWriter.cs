using Tridion.Snitch.Application.library;

namespace Tridion.Snitch.Application.Contracts
{
    public interface IFileWriter
    {
        string GetName();
        string GetAction();
        void WriteAction(User user);
    }
}