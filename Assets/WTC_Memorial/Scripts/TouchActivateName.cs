using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchActivateName : MonoBehaviour
{
    public GameObject PhotoObj;
    
    // Start is called before the first frame update
    void Start()
    {
        PhotoObj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseUp(){
        PhotoObj.SetActive(false);
    }
    
    void OnMouseDown(){
        PhotoObj.SetActive(true);
    }
}
