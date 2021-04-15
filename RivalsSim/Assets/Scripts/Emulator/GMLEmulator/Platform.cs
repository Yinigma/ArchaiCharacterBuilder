using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private const string PLAT_PREFAB_PATH = ""; 

    private static readonly Platform platformPrefab;

    static Platform()
    {
        platformPrefab = AssetDatabase.LoadAssetAtPath<Platform>(PLAT_PREFAB_PATH);
    }

    /// <summary>
    /// Whether the platform is solid or fall-through
    /// </summary>
    public bool Solid { get; private set; }

    /// <summary>
    /// The size of the platform
    /// </summary>
    public Vector2 Size { get; private set; }

    /// <summary>
    /// Create a platform to stuff into another game object
    /// </summary>
    public static Platform createPlatform(Transform parent, bool solid, Vector2 size)
    {
        Platform platform = Instantiate(platformPrefab, parent);
        platform.Solid = solid;
        platform.Size = size;
        return platform;
    }
}
