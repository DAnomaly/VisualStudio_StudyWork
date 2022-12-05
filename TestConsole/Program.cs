// See https://aka.ms/new-console-template for more information
using UtilLibrary.File;

var ini = new IniFile();

ini.Load("test.ini");

Console.WriteLine(ini["test1"]["doubleB2"].ToString());

