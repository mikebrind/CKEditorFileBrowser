using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class FileExtensions
{
    public static IEnumerable<FileInfo> GetFilesByExtensions(this DirectoryInfo directoryInfo, params string[] extensions) {
        var allowedExtensions = new HashSet<string>(extensions, StringComparer.OrdinalIgnoreCase);
        return directoryInfo.EnumerateFiles().Where(f => allowedExtensions.Contains(f.Extension));
    } 
}