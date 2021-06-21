using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WtcAppFeaturesMenu : MonoBehaviour
{

    public void OCRfeatureTest(){
		SceneManager.LoadScene("OCRcapture", LoadSceneMode.Single);
    }
    
    public void ImageTargetfeatureTest(){
        SceneManager.LoadScene("ImageTargets", LoadSceneMode.Single);
    }
    
    public void LocationAnchorsfeatureTest(){
        SceneManager.LoadScene("LocationAnchors", LoadSceneMode.Single);
    }
    
    
}
