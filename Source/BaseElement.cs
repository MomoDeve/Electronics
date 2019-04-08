using System.Collections.Generic;

namespace Electronic
{
    abstract class BaseElement : IElement, IClickable
    {
        public virtual string imagePath { get; set; }

        public virtual bool isOn { get; set; }

        public Dictionary<RelativePosition, IElement> connections { get; set; }

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
