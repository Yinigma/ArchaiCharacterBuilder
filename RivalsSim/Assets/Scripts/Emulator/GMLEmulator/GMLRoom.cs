using RoslynCSharp;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GMLRoom : MonoBehaviour
{
    private Dictionary<int, GMLObject> sceneObjects;

    private const string GML_ROOM_PREFAB_PATH = "";

    private static readonly GMLRoom roomPrefab;

    static GMLRoom()
    {
        roomPrefab = AssetDatabase.LoadAssetAtPath<GMLRoom>(GML_ROOM_PREFAB_PATH);
    }

    public GMLObject getObject(int refNum)
    {
        return sceneObjects[refNum];
    }

    public void Start()
    {
        sceneObjects = new Dictionary<int, GMLObject>();
    }


    public static GMLRoom createGMLRoom(Transform parent, Vector2 size, Vector2 killOffsets)
    {
        GMLRoom room = Instantiate(roomPrefab, parent.transform);
        return room;
    }

    public void addPlatform(bool solid, Vector2 location, Vector2 size)
    {
        Platform.createPlatform(transform, solid, size);
    }

    public void addObject(GMLObject gmlObject)
    {
        sceneObjects.Add((int) gmlObject.InstanceScope.getValue("id"), gmlObject);
    }
}
