using Flunt.Notifications;

namespace Alterdata.Immobile.MapaDeErros.Shared.Entities
{
    public abstract class Entity : Notifiable
    {
        public int ID { get; private set; }

        public Entity(int id)
        {
            ID = id;
        }
    }
}