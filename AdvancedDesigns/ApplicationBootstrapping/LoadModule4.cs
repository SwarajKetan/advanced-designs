using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationBootstrapping.Framework;

namespace ApplicationBootstrapping
{
    internal class LoadModule4 : IModule<string, Complex>
    {
        public Task<string> LoadAsync(Complex previousResult)
        {
            return Task.FromResult($"age:{previousResult.Age}, name:{previousResult.Name}");
        }
    }
}
