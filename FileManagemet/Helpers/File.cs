using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileManagemet.Helpers
{
    public static class File
    {
        public static void Delete(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles().Where(p => p.Extension.EndsWith(".js") || p.Extension.EndsWith(".map")).ToArray();
            DeleteFiles(files);
            var directories = directory.GetDirectories();
            foreach (var dir in directories)
            {
                Delete(dir.FullName);
            }
        }

        private static void DeleteFiles(FileInfo[] files)
        {
            foreach (FileInfo file in files)
            {
                try
                {
                    file.Attributes = FileAttributes.Normal;
                    file.Delete();
                }

                catch { }
            }
        }
    }
}
