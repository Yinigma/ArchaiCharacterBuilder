using RoslynCSharp;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GMLContext : MonoBehaviour
{

    private Dictionary<int, GMLRoom> rooms;

    public int RoomIndex { get; private set; }

    private GMLSymbolTable globalScope;

    private ScriptDomain domain;

    private const string SCRIPTS_PATH = "/scripts";

    private const string SOUNDS_PATH = "/sounds";

    private const string SPRITES_PATH = "/sprites";

    public void Awake()
    {
        domain = ScriptDomain.CreateDomain("GML Domain", true, true, AppDomain.CurrentDomain);
    }

    public void Start()
    {
        globalScope = new GMLSymbolTable();
        RoomIndex = 0;
        rooms.Add(RoomIndex, GMLRoom.createGMLRoom(transform));
        rooms[RoomIndex].addPlatform(true, new Vector2(), new Vector2(640, 120));
    }

    public void addCharacterToRoom()
    {

    }

    public void loadCharacter(string directory)
    {
        //
        string fighterUpdateSource = File.ReadAllText(directory+SCRIPTS_PATH+"/update.gml");
        ScriptType updateScript = compileScript(fighterUpdateSource);
        //
        string fighterInitSource = File.ReadAllText(directory + SCRIPTS_PATH + "/init.gml");
        ScriptType initScript = compileScript(fighterInitSource);

        GMLFighter.createGMLFighter( rooms[RoomIndex], (scope) => runScript(initScript, scope), (scope) => runScript(updateScript, scope) );
    }

    public ScriptType compileScript(string source)
    {
        return domain.CompileAndLoadMainSource(source, ScriptSecurityMode.UseSettings);
    }

    public void runScript(ScriptType script, GMLSymbolTable instanceScope)
    {
        lock(this)
        {
            //This is so fuckin' stupid
            GMLSymbolTable localScope = new GMLSymbolTable();
            script.CallStatic("run", globalScope, instanceScope, localScope);
        }
    }

    public void addRoom()
    {
        GMLRoom.createGMLRoom(this, domain);
    }

    public void create_instance(string type, int roomId, Vector2 pos)
    {
        if( rooms.ContainsKey(roomId) )
        {
            switch (type)
            {
                case "oPlayer":
                    break;
                case "oTestPlayer":
                    break;
                case "pHitBox":
                    break;
                case "pHurtBox":
                    break;
                case "hit_fx_obj":
                    break;
                case "obj_article1":
                    break;
                case "obj_article2":
                    break;
                case "obj_article3":
                    break;
                case "obj_article_solid":
                    break;
                case "obj_article_platform":
                    break;
            }
        }
    }
}
