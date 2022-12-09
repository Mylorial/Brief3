using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTrap : MonoBehaviour
{

    public void Trap() {

    }

    public void Water(Collision collision){
        if(collision.gameObject.tag == "Player"){
                    Destroy(collision.gameObject, 0);
        print("player has died");
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
