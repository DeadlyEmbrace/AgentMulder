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
        private static readonly IStructuralSearchPattern pattern = new CSharpStructuralSearchPattern("$builder$.Register<$type$,$concrete$>()",
            new ExpressionPlaceholder("builder", "global::DryIoc.Container", true),
            new ArgumentPlaceholder("type", -1, -1), 
            new ArgumentPlaceholder("concrete", -1, -1));

        public Register(IStructuralSearchPattern pattern)
            : base(pattern)
        {
        }
    }
}