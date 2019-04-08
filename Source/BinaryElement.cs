namespace Electronic
{
    abstract class BinaryElement : BaseElement
    {
        protected bool upRecieved, downRecieved;

        public override bool isOn { set => downRecieved = upRecieved = base.isOn = value; }

        public override void PushEnergy()
        {
            var connection = connections[RelativePosition.Right];
            if (connection != null && !connection.isOn && isOn)
            {
                connection.RecieveEnergy(this, RelativePosition.Left);
            }   
        }

        public override void RecieveEnergy(IElement element, RelativePosition elementPosition)
        {
            if (elementPosition == RelativePosition.Down)
            {
                downRecieved = element.isOn;
            }
            else if (elementPosition == RelativePosition.Up)
            {
                upRecieved = element.isOn;
            }
            PushEnergy();
        }
    }
}
