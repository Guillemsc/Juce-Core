﻿using System.IO;
using UnityEngine;

namespace Juce.CoreUnity.Files
{
    public static class PathsUtils
    {
        public static string CombinePaths(params string[] paths)
        {
            return Path.Combine(paths);
        }

        public static string PersistentDataPath => Application.persistentDataPath;
    }
}