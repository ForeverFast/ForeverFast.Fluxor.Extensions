using Fluxor.DependencyInjection;
using Fluxor.Extensions;
using System.Reflection;

namespace ForeverFast.Fluxor.Extensions
{
    public static class Configure
    {
        public static FluxorOptions UseEntityAdapters(this FluxorOptions options, params Assembly[] assemblies)
        {
            Adapters.Scan(assemblies);

            return options;
        }
    }
}
