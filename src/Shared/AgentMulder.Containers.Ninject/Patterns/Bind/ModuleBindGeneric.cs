﻿using System.ComponentModel.Composition;
using AgentMulder.ReSharper.Domain.Patterns;
#if SDK90
using JetBrains.ReSharper.Feature.Services.CSharp.StructuralSearch;
using JetBrains.ReSharper.Feature.Services.CSharp.StructuralSearch.Placeholders;
using JetBrains.ReSharper.Feature.Services.StructuralSearch;
#else
using JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch;
using JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders;
using JetBrains.ReSharper.Psi.Services.StructuralSearch;
#endif

namespace AgentMulder.Containers.Ninject.Patterns.Bind
{
    internal sealed class ModuleBindGeneric : BindBasePattern
    {
        private static readonly IStructuralSearchPattern pattern =
            new CSharpStructuralSearchPattern("Bind<$service$>()", 
                new TypePlaceholder("service"));

        [ImportingConstructor]
        public ModuleBindGeneric([ImportMany] params ComponentImplementationPatternBase[] toPatterns)
            : base(pattern, "service", toPatterns)
        {
        }
    }
}