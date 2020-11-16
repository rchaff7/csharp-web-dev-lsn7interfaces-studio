using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        double StorageSize { get; }
        string WriteStyle { get; }
        string ReadStyle { get; }
        double CurrentCapacity { get; }
        string DiscType { get; }
        List<string> Contents { get; set; }
        string Name { get; set; }
    }
}
