using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceLevelController : MonoBehaviour
{
    // Start is called before the first frame update
    public static ExperienceLevelController instance;
    private void Awake()
    {
        instance = this;
    }
    public int currentExperience;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetExp(int amountToGet)
    {
        currentExperience += amountToGet;
    }
}
