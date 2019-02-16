using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTriger : MonoBehaviour
{
    public GameObject Player;
    public GameObject SpawnPoint;
    public GameObject Enter_Text;

    void OnTriggerEnter(Collider col)
    {
       // if (col.name == "EnterTrigger")
       //     Player.transform.position = SpawnPoint.transform.position; 
    }
    void OnTriggerStay(Collider col)
    {
        if(col.name == "EnterTrigger")
        {
            Enter_Text.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Player.transform.position = SpawnPoint.transform.position;
            }
        }
    }
    void OnTriggerExit(Collider col)
    {
        if(col.name == "EnterTrigger")
        {
            Enter_Text.SetActive(false);
        }
    }
}
