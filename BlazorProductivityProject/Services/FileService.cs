using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProductivityProject.Services
{
    public class FileService
    {
        private IWebHostEnvironment _environment { get; set; }

        public FileService(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public string[] GetFileNames(string directory, string fileName)
        {
            var folderPath = Path.Combine(_environment.WebRootPath, $"uploads\\{directory}");
            var fileNames = Directory.GetFiles(folderPath, $"{fileName}.*");
            return fileNames.Select(x => x.Split("\\").LastOrDefault()).ToArray();
        }

        public string[] GetAllAbsoluteFileNames(string directory, string fileName)
        {
            var folderPath = Path.Combine(_environment.WebRootPath, $"uploads\\{directory}");
            return Directory.GetFiles(folderPath, $"{fileName}.*");
        }

        public string GetFullPathForFolder(string directory)
        {
            return Path.Combine(_environment.WebRootPath, $"uploads\\{directory}");
        }
    }
}
