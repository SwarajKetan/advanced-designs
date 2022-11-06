using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationBootstrapping.Framework;

namespace ApplicationBootstrapping
{
    internal class Module4 : IModule<string, Complex>
    {
        private readonly ApplicationState state;
        public Module4(ApplicationState state)
        {
            this.state = state;
        }

        public Task<string> LoadAsync(Complex previousResult)
        {
            return Task.FromResult(state.Module4Result = $"age:{previousResult.Age}, name:{previousResult.Name}");
        }
    }
}
