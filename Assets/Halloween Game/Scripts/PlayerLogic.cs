using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("pumpkin"))
        {
            //collect pumpkin
            Destroy(other.gameObject);
            GameManager.Instance.CollectPumpkin();
        }else if(other.CompareTag("ghost"))
        {
            //game over
            GameManager.Instance.GameOver();
        }
    }
}
