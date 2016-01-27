using System.ComponentModel.Composition;
using AgentMulder.ReSharper.Domain.Patterns;
using JetBrains.ReSharper.Feature.Services.CSharp.StructuralSearch;
using JetBrains.ReSharper.Feature.Services.CSharp.StructuralSearch.Placeholders;
using JetBrains.ReSharper.Feature.Services.StructuralSearch;

namespace AgentMulder.Containers.DryIoc.Patterns
{
    [Export("ComponentRegistration", typeof(IRegistrationPattern))]
    public class Register : RegisterWithService
    {
        private static readonly IStructuralSearchPattern pattern = new CSharpStructuralSearchPattern("$container$.Register<$type$,$concrete$>()",
            new ExpressionPlaceholder("container"), //, "global::DryIoc.Container", true
            new TypePlaceholder("type"), 
            new TypePlaceholder("concrete"));

        public Register()
            : base(pattern)
        {
        }
    }
}