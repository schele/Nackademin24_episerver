using EPiServer.Cms.Shell;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using EPiServer.Shell;
using nackademin24_episerver.Business.Attributes;
using System.Reflection;

namespace nackademin24_episerver.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(InitializableModule))]
    public class ContentIconInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            var registry = context.Locate.Advanced.GetInstance<UIDescriptorRegistry>();
            var classes = GetDescriptorClasses();

            foreach (var descriptor in registry.UIDescriptors)
            {
                if (classes.ContainsKey(descriptor.ForType))
                {
                    descriptor.IconClass += " " + classes[descriptor.ForType];
                }
            }
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        private Dictionary<Type, string> GetDescriptorClasses()
        {
            var typesWithAttribute = GetTypesWithAttribute();

            var descriptors = new Dictionary<Type, string>();

            foreach (var type in typesWithAttribute)
            {
                var iconAttribute = (ContentIconAttribute)Attribute.GetCustomAttribute(type, typeof(ContentIconAttribute));

                descriptors.Add(type, $"epi-icon{iconAttribute.Icon.ToString()}");
            }

            return descriptors;
        }

        private List<Type> GetTypesWithAttribute()
        {
            var validAssemblies = AppDomain.CurrentDomain.GetAssemblies().Where(x => !x.IsDynamic);
            var typesWithAttribute = new List<Type>();

            foreach (var assembly in validAssemblies)
            {
                Type[] types;

                try
                {
                    types = assembly.GetTypes();
                }
                catch (ReflectionTypeLoadException ex)
                {
                    // Some types couldn't be loaded — take only those that could
                    types = ex.Types.Where(t => t != null).ToArray();
                }
                catch
                {
                    // In case of other exceptions (e.g., BadImageFormatException), skip the assembly
                    continue;
                }

                foreach (var type in types)
                {
                    if (type.IsDefined(typeof(ContentIconAttribute), inherit: false))
                    {
                        typesWithAttribute.Add(type);
                    }
                }
            }

            return typesWithAttribute;
        }
    }
}
