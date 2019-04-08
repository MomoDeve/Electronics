namespace Electronic
{
    class Bulb : QuadrupleElement
    {
        public override string imagePath => isOn ? "bulbP.png" : "bulbC.png";

        public override void RecieveEnergy(IElement element, RelativePosition elementPosition)
        {
            isOn = true;
        }
    }

    class Wire : QuadrupleElement
    {

        public override string imagePath
        {
            get
            {
                string fileName = "wire";
                fileName += (isOn ? 'P' : 'C');
                if (connections[RelativePosition.Down] != null) fileName += 'D';
                if (connections[RelativePosition.Up] != null) fileName += 'U';
                if (connections[RelativePosition.Left] != null) fileName += 'L';
                if (connections[RelativePosition.Right] != null) fileName += 'R';

                return fileName + ".png";
            }
        }

        public override void RecieveEnergy(IElement element, RelativePosition elementPosition)
        {
            isOn = true;
            PushEnergy();
        }
    }

    class Bridge : QuadrupleElement
    {
        bool downUpEnergy, leftRightEnergy;

        int countHandler;

        public override string imagePath => (downUpEnergy || leftRightEnergy) ? "bridgeP.png" : "bridgeC.png";

        public override bool isOn
        {
            set
            {
                if (!value)
                {
                    downUpEnergy = leftRightEnergy = value;
                    countHandler = 0;
                }
                base.isOn = value;
            }
        }

        public override void RecieveEnergy(IElement element, RelativePosition elementPosition)
        {
            downUpEnergy = downUpEnergy || (elementPosition == RelativePosition.Down) || (elementPosition == RelativePosition.Up);
            leftRightEnergy = leftRightEnergy || (elementPosition == RelativePosition.Left) || (elementPosition == RelativePosition.Right);

            base.isOn = downUpEnergy && leftRightEnergy;

            PushEnergy();
        }

        public override void PushEnergy()
        {
            if (countHandler > 50)
            {
                return;
            }
            countHandler++;

            foreach (var connection in connections)
            {
                var element = connection.Value;
                if (element != null && !element.isOn)
                {
                    if (downUpEnergy && (connection.Key == RelativePosition.Down || connection.Key == RelativePosition.Up))
                    {
                        element.RecieveEnergy(this, ~connection.Key);
                    }
                    else if (leftRightEnergy && (connection.Key == RelativePosition.Left || connection.Key == RelativePosition.Right))
                    {
                        element.RecieveEnergy(this, ~connection.Key);
                    }
                }
            }
        }
    }

    class RightFilter : SingularElement
    {
        public override string imagePath => "filterR.png";

        public override void RecieveEnergy(IElement element, RelativePosition elementPosition)
        {
            isOn = isOn || (elementPosition == RelativePosition.Left);
            PushEnergy();
        }
    }

    class LeftFilter : BaseElement
    {
        public override string imagePath => "filterL.png";

        public override void RecieveEnergy(IElement element, RelativePosition elementPosition)
        {
            isOn = isOn || (elementPosition == RelativePosition.Right);
            PushEnergy();
        }

        public override void PushEnergy()
        {
            var connection = connections[RelativePosition.Left];
            if (connection != null && !connection.isOn && isOn)
            {
                connection.RecieveEnergy(this, RelativePosition.Right);
            }
        }
    }

    class UpFilter : BaseElement
    {
        public override string imagePath => "filterU.png";

        public override void RecieveEnergy(IElement element, RelativePosition elementPosition)
        {
            isOn = isOn || (elementPosition == RelativePosition.Down);
            PushEnergy();
        }

        public override void PushEnergy()
        {
            var connection = connections[RelativePosition.Up];
            if (connection != null && !connection.isOn && isOn)
            {
                connection.RecieveEnergy(this, RelativePosition.Down);
            }
        }
    }

    class DownFilter : BaseElement
    {
        public override string imagePath => "filterD.png";

        public override void RecieveEnergy(IElement element, RelativePosition elementPosition)
        {
            isOn = isOn || (elementPosition == RelativePosition.Up);
            PushEnergy();
        }

        public override void PushEnergy()
        {
            var connection = connections[RelativePosition.Down];
            if (connection != null && !connection.isOn && isOn)
            {
                connection.RecieveEnergy(this, RelativePosition.Up);
            }
        }
    }
}
