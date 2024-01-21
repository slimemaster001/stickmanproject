using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doorscript : MonoBehaviour
{
    public Rigidbody2D PlayerRigidbody;
    [SerializeField] public int timer;
    [SerializeField] public int level = 0;
    [SerializeField] public StarterTexstScript starterTexstScript;
    [SerializeField] public PlayerScript player;
    [SerializeField] public bool playerisalive = true;
    [SerializeField] public int sceneBuildIndex;
    [SerializeField] public Transform respauwnlocation;
    [SerializeField] public Transform level2to3;
    [SerializeField] public Transform level1to2;
    [SerializeField] public Transform level0to1;
    //[SerializeField] public Transform level0;
    [SerializeField] public Transform playercords;
    
    // Start is called before the first frame update
    void Start()
    {
        level = 0;
        timer = 10;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
           timer = timer -1; 
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {   

        if (playerisalive == true && level == 0 && timer == 0)
        {
        level = 1;
        timer = timer + 10;
        Debug.Log("Level 0 -> 1");
        respauwnlocation.position = level0to1.position;
        }

        if (playerisalive == true && level == 1 && timer == 0)
        {
        level = 2;
        timer = timer + 10;
        Debug.Log("Level 1 -> 2");
        respauwnlocation.position = level1to2.position;
        }

        if (playerisalive == true && level == 2 && timer == 0)
        {
        level = 3;
        timer = timer + 10;
        Debug.Log("Level 2 -> 3");
        respauwnlocation.position = level2to3.position;
        }

        playercords.position = respauwnlocation.position;
    }  
    
}
