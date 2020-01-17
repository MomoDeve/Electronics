namespace Electronics
{
    abstract class QuadrupleElement : BaseElement
    {
        public override void PushEnergy()
        {
            foreach (var connection in connections)
            {
                if (connection.Value != null && !connection.Value.isOn && isOn)
                {
                    connection.Value.RecieveEnergy(this, ~connection.Key);
                }
            }
        }
    }
}