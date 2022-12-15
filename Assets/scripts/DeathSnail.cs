using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathSnail : MonoBehaviour
{

        public void deathSnail(Collision collision){
//if(collision.gameObject.tag == "Player"){Destroy(collision.gameObject, 0);print("player has Died!");}

 if(collision.gameObject.name == "Player"){SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);}
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
