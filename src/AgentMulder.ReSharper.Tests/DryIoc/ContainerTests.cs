using AgentMulder.Containers.DryIoc;

namespace AgentMulder.ReSharper.Tests.DryIoc
{
    [TestWithNuGetPackage(Packages = new [] { "DryIoc" })]
    public class ContainerTests : AgentMulderTestBase<DryIocCotnainerInfo>
    {
         protected override string RelativeTestDataPath
        {
            get { return @"DryIoc"; }
        }
    }
}