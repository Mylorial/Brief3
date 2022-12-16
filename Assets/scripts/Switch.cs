using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Switch : MonoBehaviour
{
public GameObject gameObject;
public bool MoveWall = false;
public TextMeshProUGUI UIText;
public string TextPopUp;

    // Start is called before the first frame update
    // get an AudioSource to play later 
    void Start()
    {
        EventBus.Current.Switch += SwitchActivate;
    }

    void SwitchActivate()
    {
        // plays audio and turn off and on MeshRenderer and BoxCollider
        
        gameObject.GetComponent<MeshRenderer>().enabled = !gameObject.GetComponent<BoxCollider>().enabled;
        gameObject.GetComponent<BoxCollider>().enabled = !gameObject.GetComponent<BoxCollider>().enabled;


    }

void Update()
{
    if(MoveWall && Input.GetKeyDown("e"))
    {
        EventBus.Current.Switchtrigger();
    }
}

   void OnDestroy() 
    {
        EventBus.Current.Switch -= SwitchActivate;
    }

    void OnTriggerEnter()
        {
        MoveWall = true;
    
    UIText.text = TextPopUp;
        
        }
   void OnTriggerExit()
        {
        MoveWall = false;
        UIText.text = "";
        }


}