using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{


    [SerializeField] public PlayerScript player;
    [SerializeField] public Doorscript doorscript;
    [SerializeField] public Transform respauwnlocation;
    [SerializeField] public Transform playercords;
    [SerializeField] public bool playerisalive = true;
    [SerializeField] public int level = 0;
    // Start is called before the first frame update
    void Start()
    {

    }
    //Update is called once per frame
    void Update()
    {
       
    }
    public void gameOver()
    {
        Debug.Log("dood");
        playercords.position = respauwnlocation.position;
        player.playerisalive = true;

    }

    
    
}   

    
