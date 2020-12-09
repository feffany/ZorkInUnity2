using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zork;

public class Game_Manager : MonoBehaviour
{
    public string ZorkFilename = @"Assets\Resources\Zork.json";
    public UnityOutputService OutputService;
    public UnityInputService InputService;

    void Awake()
    {
        //TextAsset gameJsonAsset = Resources.Load<TextAsset>(ZorkGameFileAssetName);
        //Game.Start(gameJsonAsset.text, InputService, OutputService);
        //Game.Instance.CommandManager.PerformCommand(Game.Instance, "LOOK");
    }

    // Start is called before the first frame update
    void Start()
    {
        TextAsset gameJsonAsset = Resources.Load<TextAsset>(ZorkGameFileAssetName);
        Game.Start(gameJsonAsset.text, InputService, OutputService);
        Game.Instance.CommandManager.PerformCommand(Game.Instance, "LOOK");
    }

    // Update is called once per frame
    /*void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            InputService.ProcessInput();
        }
    }*/

    [SerializeField]
    private string ZorkGameFileAssetName = "Zork";
}
