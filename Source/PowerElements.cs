using System.Collections.Generic;

namespace Electronic
{
    abstract class PowerElement : QuadrupleElement
    {
        public override void RecieveEnergy(IElement element, RelativePosition elementPosition) { }
    }

    class Switcher : PowerElement
    {
        public override string imagePath => isOn ? "switcherP.png" : "switcherC.png";

        public override void Click()
        {
            isOn = !isOn;
        }
    }

    class Generator : PowerElement
    {
        public override string imagePath => "generator.png";

        public override bool isOn
        {
            get => true;
        }
    }

    class TickGenerator : PowerElement
    {
        public override string imagePath => "tickgenerator.png";

        public override void PushEnergy()
        {
            isOn = !isOn;
            base.PushEnergy();
        }
    }

    class Timer : PowerElement
    {
        bool memory, pushed, energyNotRecieved;

        public override string imagePath => isOn ? "timerP.png" : "timerC.png";

        public override bool isOn => pushed;

        public override void PushEnergy()
        {
            if (memory)
            {
                base.PushEnergy();
            }
            pushed = memory;
            if (energyNotRecieved)
            {
                memory = false;
            }
            energyNotRecieved = true;
        }

        public override void RecieveEnergy(IElement element, RelativePosition elementPosition)
        {
            memory = true;
            energyNotRecieved = false;
        }
    }
}
