// See https://aka.ms/new-console-template for more information
using ApplicationBootstrapping;

var appLoader = new ApplicationBootstrapping.Framework.AppLoader();
var appState = new ApplicationState();

appLoader
    .Register(new LoadModule1(appState))
    .Register(new LoadModule2(appState))
    .Register(new LoadModule3(appState))
    .Register(new LoadModule4(appState));

if (await appLoader.RunAsync())
{
    Console.ReadLine();
}

Console.WriteLine($"{string.Join("\n", appState.Errors)}");
Console.ReadLine();