using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Algorand.Unity
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
    [Conditional("UNITY_EDITOR")]
    public class ProvideSourceInfoAttribute : Attribute
    {
        private readonly string absoluteFilePath;
        private string assetPath;

        public string Member { get; }
        public int LineNumber { get; }
        public string AssetPath
        {
            get
            {
                if (assetPath == null)
                    assetPath = absoluteFilePath.Replace('\\', '/').Substring(LengthOfPathToProject);
                return assetPath;
            }
        }
        public string AbsoluteFilePath => absoluteFilePath;

        private static int LengthOfPathToProject =>
            UnityEngine.Application.dataPath.Length - "Assets".Length;

        public ProvideSourceInfoAttribute(
            [CallerMemberName] string member = "",
            [CallerFilePath] string filePath = "",
            [CallerLineNumber] int lineNumber = 0)
        {
            Member = member;
            absoluteFilePath = filePath;
            LineNumber = lineNumber;
        }
    }
}
