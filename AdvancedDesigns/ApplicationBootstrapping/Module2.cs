using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationBootstrapping.Framework;

namespace ApplicationBootstrapping
{
    internal class Module2 : IModule<string, bool>
    {
        private readonly ApplicationState state;
        public Module2(ApplicationState state)
        {
            this.state = state;
        }

        public Task<string> LoadAsync(bool previousResult)
        {
            if (!previousResult)
            {
                state.Errors.Add("Module 2 couldn't be loaded if Module1 result is false.");
                throw new Exception();
            }
            return Task.FromResult(state.Module2Reult = "result of module2");
        }
    }
}
