using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEditor.Build;

namespace RosConnector.Editor
{
    [InitializeOnLoad]
    public class SetDefines
    {
        static readonly string[] defines = new string[]
        {
            "MTFS_ROS_CONNECTOR", "MTFS_ROS_CONNECTOR_1_0",
            "MTFS_ROS_CONNECTOR_1_0_OR_NEWER",
        };
    
        static SetDefines()
        {
            setGlobalDefineSymbol(defines);
        }

        static void setGlobalDefineSymbol(string[] defines)
        {
            List<NamedBuildTarget> buildTargets = getAllNamedBuildTargets();
            foreach (NamedBuildTarget target in buildTargets)
            {
                PlayerSettings.SetScriptingDefineSymbols(target, defines);
            }
        }
    
        static List<NamedBuildTarget> getAllNamedBuildTargets()
        {
            FieldInfo[] staticFields = typeof(NamedBuildTarget).GetFields(BindingFlags.Public | BindingFlags.Static);
            List<NamedBuildTarget> buildTargets = new List<NamedBuildTarget>();

            foreach (var staticField in staticFields)
            {
                if (staticField.Name == "Unknown")
                    continue;

                if (staticField.FieldType == typeof(NamedBuildTarget))
                    buildTargets.Add((NamedBuildTarget)staticField.GetValue(null));
            }

            return buildTargets;
        }
    }
}
