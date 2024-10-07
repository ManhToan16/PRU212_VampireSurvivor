using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageNumberController : MonoBehaviour
{
    // Start is called before the first frame update
    public static DamageNumberController instance;
    private void Awake()
    {
        instance = this;
    }
    public DamageNumber numberToSpawn;
    public Transform numberCanvas;
    private List<DamageNumber> numperPool = new List<DamageNumber>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U)) {
            SpawnDamage(57f, new Vector3(4, 3, 0));
        }
    }
    public void SpawnDamage(float damageAmount,Vector3 location)
    {
        int rounded=Mathf.RoundToInt(damageAmount);
        //DamageNumber newDamage = Instantiate(numberToSpawn, location, Quaternion.identity, numberCanvas);
        DamageNumber newDamage = GetFormPool();
        newDamage.Setup(rounded);
        newDamage.gameObject.SetActive(true);
        newDamage.transform.position = location;
    }
    public DamageNumber GetFormPool()
    {
        DamageNumber numberToOutput = null;
        if (numperPool.Count == 0)
        {
            numberToOutput = Instantiate(numberToSpawn, numberCanvas);
        }
        else
        {
            numberToOutput = numperPool[0];
            numperPool.RemoveAt(0);
        }
        return numberToOutput;
    }
    public void PlaceInPool(DamageNumber numberToPlace)
    {
        numberToPlace.gameObject.SetActive(true);
        numperPool.Add(numberToPlace);
    }
}
