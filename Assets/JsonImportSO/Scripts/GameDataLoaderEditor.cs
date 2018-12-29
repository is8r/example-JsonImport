using UnityEditor;
using UnityEngine;

namespace JsonImport
{
#if UNITY_EDITOR
    [CustomEditor(typeof(GameDataLoader))]
    public class GameDataLoaderEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (GUILayout.Button("Load"))
            {
                GameDataLoader t = target as GameDataLoader;
                t.Load();
            }
        }
    }
#endif
}
