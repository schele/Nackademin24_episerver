using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Initialization;
using EPiServer.ServiceLocation;
using EPiServer.Shell.ObjectEditing;
using nackademin24_episerver.Business.Extenders;

namespace nackademin24_episerver.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(CmsCoreInitialization))]
    public class MetaDataInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            if (context.HostType == HostType.WebApplication)
            {
                var registry = context.Locate.Advanced.GetInstance<MetadataHandlerRegistry>();
                registry.RegisterMetadataHandler(typeof(ContentData), new MetaDataExtender());
            }
        }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}