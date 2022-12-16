using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopUpText : MonoBehaviour
{
    [SerializeField] GameObject TextPopUp;
    [SerializeField] GameObject Player;
    
    private bool FinishedPopUpText;
  
    public TextMeshProUGUI Description;
    
    public string DescriptionSave;
    private bool PopUpTextAmount;




    

    private void OnTriggerEnter(Collider collider)
    {
        StartTextPopUp();
    }

    private void StartTextPopUp()
    {
        if(PopUpTextAmount)
        {
            
           
            Description.text = DescriptionSave;
            TextPopUp.gameObject.SetActive(true);
            Player.GetComponent<PlayerMovement>().enabled = false;
            FinishedPopUpText = true;
           
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q") && FinishedPopUpText)
        {
            TextPopUp.gameObject.SetActive(false);
            Player.GetComponent<PlayerMovement>().enabled = true;
            FinishedPopUpText = false;
        }
    }
}
