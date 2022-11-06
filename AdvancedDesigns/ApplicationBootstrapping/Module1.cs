using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationBootstrapping.Framework;

namespace ApplicationBootstrapping
{
    internal class Module1 : IModule<bool, string>
    {
        private readonly ApplicationState state;
        public Module1(ApplicationState state)
        {
            this.state = state;
        }
        /// <inheritdoc/>
        public Task<bool> LoadAsync(string previousResult)
        {
            return Task.FromResult(state.Module1Result = false);
        }
    }
}
