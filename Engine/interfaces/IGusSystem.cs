using System.Collections.Generic;

namespace GUS
{
    public interface IGusSystem
    {
        IList<IGusApplication> LoadApps();
    }
}
