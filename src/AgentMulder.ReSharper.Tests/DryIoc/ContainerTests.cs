using AgentMulder.Containers.DryIoc;

namespace AgentMulder.ReSharper.Tests.DryIoc
{
    [TestWithNuGetPackage(Packages = new [] { "DryIoc:2.1.3.0" })]
    public class ContainerTests : AgentMulderTestBase<DryIocCotnainerInfo>
    {
         protected override string RelativeTestDataPath
        {
            get { return @"DryIoc"; }
        }
    }
}