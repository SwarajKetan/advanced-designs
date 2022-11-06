// See https://aka.ms/new-console-template for more information
using ApplicationBootstrapping;

Console.WriteLine("Hello, World!");

var appLoader = new ApplicationBootstrapping.Framework.AppLoader();

appLoader
    .Register(new LoadModule1())
    .Register(new LoadModule2())
    .Register(new LoadModule3())
    .Register(new LoadModule4());

/*
 * 
 * 
 * 
 * appLoader
    .Register(new LoadModule1(state))
    .Register(new LoadModule2(state))
    .Register(new LoadModule3(state))
    .Register(new LoadModule4(state));
 * 
 * 
 * 
 * 
 */

await appLoader.RunAsync();

Console.ReadLine();