using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kuang : MonoBehaviour
{
    public GameObject target;

    public Color yes, no,wu;
    public void OnEnable()
    {
        GetComponent<MeshRenderer>().material.color = wu; 
    }
    
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject== target)
        {
            GetComponent<MeshRenderer>().material.color = yes;
            Game1_M.initialize.fen++;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = no;
            Game1_M.initialize.fen--;
        }
    }

    public void OnCollisionExit(Collision other)
    {
        GetComponent<MeshRenderer>().material.color = wu;
 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
