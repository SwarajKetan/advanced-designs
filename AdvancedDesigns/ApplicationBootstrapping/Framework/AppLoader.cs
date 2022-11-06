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

        public async Task RunAsync()
        {
            dynamic? result = null;

            for (int i = 0; i < Loaders.Count; i++)
            {
                var loader = Loaders[i];
                result = await loader.LoadAsync(result);
            }
        }
    }
}
