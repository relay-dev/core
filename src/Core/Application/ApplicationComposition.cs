using System.Collections.Generic;

namespace Core.Application
{
    public class ApplicationComposition
    {
        public string IoCContainer { get; set; }

        public List<string> IoCContainerPlugins { get; set; }
    }
}
