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
        bool holdingEnergy, energyPushed, readyToRelease;

        public override string imagePath => energyPushed ? "timerP.png" : "timerC.png";

        public override void PushEnergy()
        {
            if(!holdingEnergy && energyPushed)
            {
                readyToRelease = false;
                energyPushed = false;
            }
            else if(holdingEnergy && !readyToRelease)
            {
                readyToRelease = true;
                holdingEnergy = false;
            }
            else if (readyToRelease)
            {
                isOn = true;
                base.PushEnergy();
                isOn = false;
                energyPushed = true;
                holdingEnergy = false;
            }
        }

        public override void RecieveEnergy(IElement element, RelativePosition elementPosition)
        {
            holdingEnergy = true;
        }
    }
}
