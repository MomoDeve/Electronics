namespace Electronics
{
    abstract class SingularElement : BaseElement
    {
        public override void PushEnergy()
        {
            var connection = connections[RelativePosition.Right];
            if (connection != null && !connection.isOn && isOn)
            {
                connection.RecieveEnergy(this, RelativePosition.Left);
            }
        }
    }
}
