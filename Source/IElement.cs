using System.Collections.Generic;

namespace Electronic
{
    enum RelativePosition
    {
       Left = 0x0001,
       Right = ~0x0001,
       Up = 0x0000,
       Down = ~0x0000
    }

    interface IElement
    {
        string imagePath { get; set; }

        bool isOn { get; set; }

        void RecieveEnergy(IElement element, RelativePosition elementPosition);

        void PushEnergy();

        void Connect(IElement element, RelativePosition elementPosition);

        Dictionary<RelativePosition, IElement> connections { get; set; }
    }
}
