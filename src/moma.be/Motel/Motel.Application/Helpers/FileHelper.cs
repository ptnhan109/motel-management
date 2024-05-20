using Microsoft.AspNetCore.Http;
using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Helpers
{
    public static class FileHelper
    {
        public static async Task<string> SaveFile(this IFormFile file, EnumFileType type)
        {
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "Assets", Enum.GetName(typeof(EnumFileType),type));
            if (!File.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            var fileName = $"{Guid.NewGuid()}_{file.FileName}";
            using (var stream = new FileStream(Path.Combine(folderPath,fileName), FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return GetPath(fileName,type);
        }

        public static string GetPath(string fileName, EnumFileType type) => $"/{Enum.GetName(typeof(EnumFileType), type)}/{fileName}";
        

    }
}
