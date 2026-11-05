using LogicBuilder.Domain;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Enrollment.Domain.Entities
{
    public abstract class EntityModelBase : BaseModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            var eventHandler = this.PropertyChanged;
            if (eventHandler != null)
                this.PropertyChanged!(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
