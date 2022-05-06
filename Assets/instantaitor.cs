using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantaitor : MonoBehaviour
{
    public GameObject objectToClone; 



    // Start is called before the first frame update
    void Start()
    {
        Instantiate(objectToClone);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
