using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Reflection;
using AgentMulder.ReSharper.Domain.Containers;

namespace AgentMulder.Containers.DryIoc
{
    [Export(typeof(IContainerInfo))]
    public class DryIocCotnainerInfo : ContainerInfoBase
    {
        public override string ContainerDisplayName {
            get { return "DryIoc"; }
        }

        public override IEnumerable<string> ContainerQualifiedNames
        {
            get { yield return "DryIoc"; }
        }

        protected override ComposablePartCatalog GetComponentCatalog()
        {
            return new AssemblyCatalog(Assembly.GetExecutingAssembly());
        }
    }
}
