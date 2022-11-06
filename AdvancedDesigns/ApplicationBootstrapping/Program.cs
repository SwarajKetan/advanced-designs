// See https://aka.ms/new-console-template for more information
using ApplicationBootstrapping;

var appLoader = new ApplicationBootstrapping.Framework.AppLoader();
var appState = new ApplicationState();

appLoader
    .Register(new Module1(appState))
    .Register(new Module2(appState))
    .Register(new Module3(appState))
    .Register(new Module4(appState));

if (await appLoader.RunAsync())
{
    Console.ReadLine();
}

Console.WriteLine($"{string.Join("\n", appState.Errors)}");
Console.ReadLine();