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