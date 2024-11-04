//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using TextFilteringApp.Services.File;

//HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
//builder.Services.AddSingleton<IFileReader, TextFileReader>();
//using IHost host = builder.Build();

using TextFilteringApp.Services;
using TextFilteringApp.Services.File;
using TextFilteringApp.Services.Filtering;

Console.WriteLine("hello world");

var fileReader = new TextFileReader();
var filter1 = new ExcludeWithVowelInTheMiddleFilter();
var filter2 = new ExcludeShorterThan3Chars();
var filter3 = new ExcludeWithLetterT();

var content = await fileReader.ReadAsStringAsync("input.txt");

var applier = new TextFilterApplier(filter1);
Console.WriteLine(applier.Apply(content));