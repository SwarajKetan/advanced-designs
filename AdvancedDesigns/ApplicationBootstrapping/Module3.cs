using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationBootstrapping.Framework;

namespace ApplicationBootstrapping
{
    internal class Module3 : IModule<Complex, string>
    {
        private readonly ApplicationState state;
        public Module3(ApplicationState state)
        {
            this.state = state;
        }

        public Task<Complex> LoadAsync(string previousResult)
        {
            return Task.FromResult( state.Module3Result = new Complex()
            {
                Age = 100,
                Name = "Simpu"
            });
        }
    }
}
