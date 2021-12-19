using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWorld : MonoBehaviour
{
    private static GameWorld _instance;
    public static GameWorld Instance
    {
        get
        {
            return _instance;
        }
    }

    public PotralManager Potral=new PotralManager();
    public CharacterManager Character = new CharacterManager();

    void Awake()
    {
        if(_instance==null)
            _instance = this;

        DontDestroyOnLoad(this);
    }


    void Start()
    {
        Potral.Init();  
        Character.Init();
    }
}
