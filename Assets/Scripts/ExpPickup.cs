using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpPickup : MonoBehaviour
{
    // Start is called before the first frame update
    public int expValue;
    private bool movingToPlayer;
    public float moveSpeed;
    public float timeBetweenChecks = .2f;
    private float checkCounter;
    private PlayerController player;
    void Start()
    {
        player=PlayerHealthController.instance.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (movingToPlayer == true) {
        transform.position = Vector3.MoveTowards(transform.position,PlayerHealthController.instance.transform.position,moveSpeed*Time.deltaTime);

        }
        else
        {
            checkCounter-=Time.deltaTime;
            if (checkCounter <= 0)
            {
                checkCounter=timeBetweenChecks;
                if (Vector3.Distance(transform.position, player.transform.position) < player.pickupRange)
                {
                    movingToPlayer = true;
                    moveSpeed += player.moveSpeed;
                }
            }
        }
        
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
