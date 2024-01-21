using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiksscript : MonoBehaviour
{
    public Rigidbody2D PlayerRigidbody;


    [SerializeField] public GameObject objectToDestroy;
    [SerializeField] public LogicScript logic;
    [SerializeField] public PlayerScript player;
    [SerializeField] public bool playerisalive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        player.playerisalive = false;
        logic.gameOver();
        Debug.Log("dnz");
    } 
    
}
