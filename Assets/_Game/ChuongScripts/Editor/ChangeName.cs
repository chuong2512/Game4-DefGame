using System.IO;
using UnityEditor;
using UnityEngine;

namespace _Game.ChuongScripts.Editor
{
    public class ChangeName : MonoBehaviour
    {
        [MenuItem("Tools/ChangeUnitName")]
        public static void ChangeUnitName()
        {
            // Get the selected sprite file
            Object selectedObject = Selection.activeObject;
            string assetPath = AssetDatabase.GetAssetPath(selectedObject);
            
            if (!string.IsNullOrEmpty(assetPath))
            {
                // Get all PNG files in the folder
                string[] pngFiles = Directory.GetFiles(assetPath, "*.png");
                int i = 0;
                // Output the paths of the PNG files
                foreach (string filePath in pngFiles)
                {
                    // Rename the file
                    string newPath = $"{assetPath}/{i.ToString()}.png";
                    i++;
                    AssetDatabase.MoveAsset(filePath, newPath);

                    // Refresh the Asset Database to see the changes
                    AssetDatabase.Refresh();
                }
            }
        }
    }
}