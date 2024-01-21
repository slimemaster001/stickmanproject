using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarterTexstScript : MonoBehaviour
{
    private float noloop;
    [SerializeField] private Text Tutorial;
    [SerializeField] public Doorscript doorscript;
    // Start is called before the first frame update
    void Start()
    {
        Tutorial.text = "Welkom to StickMan Dungeons. Press any key to continue (if you press Space you wil skip a part of the tutorial.) enjoy!";
        noloop = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.anyKeyDown && noloop < 2)
        {

            Tutorial.text = "Press space to jump.";
            noloop = 2;
        }
        if (Input.GetKeyDown(KeyCode.Space) && noloop < 3)
        {
            Tutorial.text = "If you hit dangerous objects you wil die and wil need to restart the level.";
        }
        if  (doorscript.level == 1) 
        {
            Destroy(gameObject);
        }
    } 
}
