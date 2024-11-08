﻿using TextFilteringApp.Services;
using TextFilteringApp.Services.File;
using TextFilteringApp.Services.Filtering;

var fileReader = new TextFileReader();
var filter1 = new ExcludeWithVowelInTheMiddleFilter();
var filter2 = new ExcludeShorterThan3CharsFilter();
var filter3 = new ExcludeWithLetterTFilter();

var content = await fileReader.ReadAsStringAsync("input.txt");

Console.WriteLine("Original text:");
Console.WriteLine(content);
Console.WriteLine();

var applier = new TextFilterApplier([filter1, filter2, filter3]);

Console.WriteLine("Filtered text:");
Console.WriteLine(applier.Apply(content));
Console.ReadKey();