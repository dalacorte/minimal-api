using Api.Models;
using Flunt.Notifications;
using Flunt.Validations;

namespace Api.ViewModels
{
    public class CreateTodoViewModel : Notifiable<Notification>
    {
        public string Title { get; set; }

        public Todo MapTo()
        {
            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotNull(Title, "New Task")
                .IsGreaterThan(Title, 5, "Grater than five"));

            return new Todo(Guid.NewGuid(), Title, false);
        }
    }
}
