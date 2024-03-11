using Epoxy.RabbitMQ.Models;

namespace Epoxy.RabbitMQ
{
    public class QueueHelper : IQueueHelper
    {
        public Task<QueueItem> Dequeue()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Enqueue(QueueItem item)
        {
            throw new NotImplementedException();
        }
    }
}
