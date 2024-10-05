using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinWeapon : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotateSpeed;
    public Transform holder;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        holder.rotation = Quaternion.Euler(0f,0f, holder.rotation.eulerAngles.z+(rotateSpeed*Time.deltaTime));
    }
}
