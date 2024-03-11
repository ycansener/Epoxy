using Epoxy.PubSub;
using Epoxy.RabbitMQ;
using Epoxy.Redis;
using Microsoft.Extensions.DependencyInjection;

namespace Epoxy.Extensions
{
    public static class EpoxyExtensions
    {
        public static IServiceCollection AddEpoxy(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddSingleton<IMessageHelper, MessageHelper>();
            services.AddSingleton<IQueueHelper, QueueHelper>();
            services.AddSingleton<ICacheHelper, CacheHelper>();

            return services;
        }


    }
}
