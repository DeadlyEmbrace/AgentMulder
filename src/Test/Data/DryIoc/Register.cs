// Patterns: 1
// Matches: CommonImpl1.cs
// NotMatches: Foo.cs

using DryIoc;
using TestApplication.Types;

namespace TestApplication.DryIoc
{
    public class Register
    {
        public Register()
        {
            var container = new Container();
            container.Register<ICommon, CommonImpl1>();
        } 
    }
}