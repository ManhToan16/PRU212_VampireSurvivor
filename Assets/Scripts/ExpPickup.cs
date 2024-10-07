using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpPickup : MonoBehaviour
{
    // Start is called before the first frame update
    public int expValue;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            ExperienceLevelController.instance.GetExp(expValue);
            Destroy(gameObject);
        }
    }
}
