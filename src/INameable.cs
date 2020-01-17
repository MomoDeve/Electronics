using System;

namespace Electronics
{ 
    interface INameable
    {
        Nullable<Guid> LabelId { get; set; }
        bool SupportsLabeling { get; }
        string Name { get; }
    }
}
