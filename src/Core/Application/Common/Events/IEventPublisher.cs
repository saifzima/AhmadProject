using AhmadProject.Shared.Events;

namespace AhmadProject.Application.Common.Events;

public interface IEventPublisher : ITransientService
{
    Task PublishAsync(IEvent @event);
}