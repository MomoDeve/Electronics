namespace Electronic
{
    class NotElement : PowerElement
    {
        public override string imagePath => "not.png";

        public override void RecieveEnergy(IElement element, RelativePosition elementPosition)
        {
            if(elementPosition == RelativePosition.Left)
            {
                isOn = true;
            }
        }

        public override void PushEnergy()
        {
            var connection = connections[RelativePosition.Right];
            if (connection != null && !connection.isOn && !isOn)
            {
                connection.RecieveEnergy(this, RelativePosition.Left);
            }
            isOn = false;
        }
    }

    class AndElement : BinaryElement
    {
        public override string imagePath => "and.png";

        public override bool isOn => upRecieved && downRecieved;         
    }

    class OrElement : BinaryElement
    {
        public override string imagePath => "or.png";

        public override bool isOn => upRecieved || downRecieved;
    }

    class XorElement : PowerElement
    {
        bool upRecieved, downRecieved;

        public override string imagePath => "xor.png";

        public override bool isOn => false;

        public override void RecieveEnergy(IElement element, RelativePosition elementPosition)
        {
            if (elementPosition == RelativePosition.Up)
            {
                upRecieved = true;
            }
            else if (elementPosition == RelativePosition.Down)
            {
                downRecieved = true;
            }
        }

        public override void PushEnergy()
        {
            var connection = connections[RelativePosition.Right];
            if (connection != null && !connection.isOn && (upRecieved != downRecieved))
            {
                connection.RecieveEnergy(this, RelativePosition.Left);
            }
            upRecieved = downRecieved = false;
        }
    }

    class EqElement : PowerElement
    {
        bool upRecieved, downRecieved;

        public override string imagePath => "eq.png";

        public override bool isOn => false;

        public override void RecieveEnergy(IElement element, RelativePosition elementPosition)
        {
            if (elementPosition == RelativePosition.Up)
            {
                upRecieved = true;
            }
            else if(elementPosition == RelativePosition.Down)
            {
                downRecieved = true;
            }
        }

        public override void PushEnergy()
        {
            var connection = connections[RelativePosition.Right];
            if (connection != null && !connection.isOn && (upRecieved == downRecieved))
            {
                connection.RecieveEnergy(this, RelativePosition.Left);
            }
            upRecieved = downRecieved = false;
        }
    }

    class NorElement : PowerElement
    {
        bool upRecieved, downRecieved;

        public override string imagePath => "nor.png";

        public override bool isOn
        {
            get => downRecieved || upRecieved;
            set
            {
                upRecieved = downRecieved = value;
            }
        }

        public override void RecieveEnergy(IElement element, RelativePosition elementPosition)
        {
            if (elementPosition == RelativePosition.Down || elementPosition == RelativePosition.Up)
            {
                isOn = true;
            }
        }

        public override void PushEnergy()
        {
            var connection = connections[RelativePosition.Right];
            if (connection != null && !connection.isOn && !isOn)
            {
                connection.RecieveEnergy(this, RelativePosition.Left);
            }
            isOn = false;
        }
    }

    class NandElement : PowerElement
    {
        bool upRecieved, downRecieved;

        public override string imagePath => "nand.png";

        public override bool isOn
        {
            set
            {
                base.isOn = downRecieved = upRecieved = value;
            }
        }

        public override void RecieveEnergy(IElement element, RelativePosition elementPosition)
        {
            if (elementPosition == RelativePosition.Up)
            {
                upRecieved = true;
            }
            else if (elementPosition == RelativePosition.Down)
            {
                downRecieved = true;
            }
            if (downRecieved && upRecieved)
            {
                isOn = true;
            }
        }

        public override void PushEnergy()
        {
            var connection = connections[RelativePosition.Right];
            if (connection != null && !connection.isOn && !isOn)
            {
                connection.RecieveEnergy(this, RelativePosition.Left);
            }
            isOn = false;
        }
    }
}
