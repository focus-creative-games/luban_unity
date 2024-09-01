using UnityEditor;
using UnityEngine;

namespace Luban.Editor
{
    public static class Menu
    {

        [MenuItem("Luban/About", priority = 0)]
        public static void OpenAbout() => Application.OpenURL("https://luban.doc.code-philosophy.com/docs/intro");


        [MenuItem("Luban/Quick Start")]
        public static void OpenQuickStart() => Application.OpenURL("https://luban.doc.code-philosophy.com/docs/beginner/quickstart");
    }

}