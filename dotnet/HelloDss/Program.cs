using Hec.Dss;
using System.Collections.Concurrent;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var fileName = Path.GetTempFileName();
Console.WriteLine( "attempting to create '"+fileName+"'");
DssReader dss = new DssReader(fileName);
var version = DssReader.GetVersion(fileName);
Console.WriteLine(   "version:  "+version);
version = DssReader.GetVersion("does not exist2");
Console.WriteLine("version:  " + version);