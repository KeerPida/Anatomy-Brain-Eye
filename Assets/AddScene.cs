using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Add(int data)
    {
        SceneManager.LoadSceneAsync(data);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
