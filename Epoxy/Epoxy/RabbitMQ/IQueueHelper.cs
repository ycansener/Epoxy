using Epoxy.RabbitMQ.Models;

namespace Epoxy.RabbitMQ
{
    public interface IQueueHelper
    {
        Task<bool> Enqueue(QueueItem item);
        Task<QueueItem> Dequeue();
    }
}
