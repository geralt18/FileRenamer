using Microsoft.VisualBasic;
using System;
using System.IO;

namespace FileRenamer
{
   class Program
   {
      static void Main(string[] args) {

         foreach (var file in Directory.GetFiles(_path)) {
            string name = Path.GetFileNameWithoutExtension(file);
            string ext = Path.GetExtension(file);

            string[] vs = name.Split("_");
            int chapter = int.Parse(vs[0]);
            int page = int.Parse(vs[1]);
            string newName = $"{chapter:d3}_{page:d2}{ext}";
            Console.WriteLine($"Zmieniam nazwę pliku {file} -> {newName}");
            FileSystem.Rename(Path.Combine(_path, file), Path.Combine(_path, newName));
         }
      }

      static string _path = @"D:\Temp\Download\Naruto Manga";
   }
}
