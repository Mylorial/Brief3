using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
private SceneController sceneController;
public float HP = 100;
public float MaxHP = 125;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(HP <= 0)
        {
            sceneController.ReloadScene();
        }
    }

    public void TakenDamage(float TotalDamageTaken)
    {
        Hp -= TotalDamageTaken;
        hpbar.SetValue(HP);
        HpText.text = HP.ToString();
    }

}
