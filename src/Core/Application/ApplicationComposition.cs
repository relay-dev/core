using System.Collections.Generic;

namespace Core.Application
{
    public partial class ApplicationComposition
    {
        public ApplicationComposition()
        {
            IoCContainerPlugins = new List<string>();
        }

        public string IoCContainer { get; set; }

        public List<string> IoCContainerPlugins { get; set; }
    }
}
