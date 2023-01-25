using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chractor_Move : MonoBehaviour
{
    public Rigidbody PlayerRigidbody = null;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
