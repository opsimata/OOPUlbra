using System;
using System.Linq;
using Data;

//local do banco
var db = new DataContext();
Console.WriteLine($"Database path: {db.DbPath}.");