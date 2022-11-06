using System.Diagnostics;

namespace ApplicationBootstrapping.Framework
{
    internal class AppLoader
    {
        private readonly List<dynamic> Loaders = new List<dynamic>();

        public AppLoader Register(object loader)
        {
            if (loader is not ILoaderCore)
                throw new ArgumentException();

            Loaders.Add(loader);
            return this;
        }

        public async Task<bool> RunAsync()
        {
            try
            {
                dynamic? result = null;

                for (int i = 0; i < Loaders.Count; i++)
                {
                    var loader = Loaders[i];

                    // you can compute the load time of each module and optimize.
                    result = await loader.LoadAsync(result);
                }

                return true;
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ex}");
                return false;
            }
            finally
            {
                Loaders.Clear();
            }
        }
    }
}
