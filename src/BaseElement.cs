using System;
using System.Collections.Generic;

namespace Electronics
{
    abstract class BaseElement : IElement, IClickable, INameable
    {
        public virtual string imagePath { get; set; }

        public virtual bool isOn { get; set; }

        public Dictionary<RelativePosition, IElement> connections { get; set; }
        public string Name { get; set; } = string.Empty;

        public virtual bool SupportsLabeling { get; protected set; } = false;

        public Nullable<Guid> LabelId { get; set; } = null;

        public virtual void Connect(IElement element, RelativePosition elementPosition)
        {
            connections[elementPosition] = element;
            if(element != null)
            {
                element.connections[~elementPosition] = this;
            }
        }

        public BaseElement()
        {
            connections = new Dictionary<RelativePosition, IElement>
            {
                { RelativePosition.Down, null },
                { RelativePosition.Up, null },
                { RelativePosition.Left, null },
                { RelativePosition.Right, null }
            };
        }

        public abstract void PushEnergy();

        public virtual void Click() { }

        public abstract void RecieveEnergy(IElement element, RelativePosition elementPosition);
    }
}
