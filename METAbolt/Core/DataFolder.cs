﻿using System;
using System.IO;
using System.Reflection;

namespace METAbolt
{
    class DataFolder
    {
        static bool firstRun = true;

        //This is necessary because System.IO.Directory.CreateDirectory fails with paths longer than 256 characters
        private static void CreateDirectoryRecursively(string path)
        {
            string[] pathParts = path.Split('\\');

            for (int i = 0; i < pathParts.Length; i++)
            {
                if (i > 0)
                    pathParts[i] = Path.Combine(pathParts[i - 1]+"/", pathParts[i]);

                if (!Directory.Exists(pathParts[i]))
                {
                    Directory.CreateDirectory(pathParts[i]);
                }
            }
        }

        private static string GetDataFolderInternal()
        {
            if (Type.GetType("Mono.Runtime") != null)
            {
                return Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "/data";
            }
            else
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MEGAbolt";
            }
        }
        public static string GetDataFolder()
        {
            string folder = GetDataFolderInternal();
            if (firstRun)
            {
                firstRun = false;
                if (!Directory.Exists(folder))
                {
                    CreateDirectoryRecursively(folder);
                }
            }
            return folder;
        }
    }
}
