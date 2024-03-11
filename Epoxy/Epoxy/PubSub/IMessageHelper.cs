using Epoxy.PubSub.Models;

namespace Epoxy.PubSub
{
    public interface IMessageHelper
    {
        Task<bool> Send(EpoxyMessage message);
        void Listen();
    }
}
