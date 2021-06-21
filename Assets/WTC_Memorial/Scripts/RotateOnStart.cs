using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnStart : MonoBehaviour
{
    public Transform lookObj;
    public Transform towersObj;
    
    private float startX;
    private float startY;
    private float panelXIncrement;
    private float panelYIncrement;
    private float panelNumber;
    private float cameraRotation;
    
    private float[,] anchorPositions;
    
    private int currentPanelNumber = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        if (Camera.current){
            
            // Get Selected panel number
            currentPanelNumber = GameObject.FindWithTag("GameController").GetComponent<PanelSelection>().selectPanelNumber;
            
            
            Transform cameraForward = Camera.current.transform;
            //cameraForward.position = new Vector3(Camera.current.transform.position.x, 0f, Camera.current.transform.position.z);
            lookObj.LookAt(cameraForward);
            
            // Memorial Anchor Positions (N1-N76, S1-N76)
            // N Tower Variables
            // x = 63, z = -86 (7 inc start buffer from edge)
            // x = 16, z = -39
            // panelIncrement = 2.47(19 inc corners), 1.94(17 inc edges)
            // S Tower Variables
            // x = 19, z = -18
            // x = -28, z = 29
            anchorPositions = new float[,]
            {
                    // North Tower
                    // N1-N18
                    {56f, -86f, -1.94f, 0f, 17f, 0f},
                    {56f, -86f, -1.94f, 0f, 16f, 0f},
                    {56f, -86f, -1.94f, 0f, 15f, 0f},
                    {56f, -86f, -1.94f, 0f, 14f, 0f},
                    {56f, -86f, -1.94f, 0f, 13f, 0f},
                    {56f, -86f, -1.94f, 0f, 12f, 0f},
                    {56f, -86f, -1.94f, 0f, 11f, 0f},
                    {56f, -86f, -1.94f, 0f, 10f, 0f},
                    {56f, -86f, -1.94f, 0f, 9f, 0f},
                    {56f, -86f, -1.94f, 0f, 8f, 0f},
                    {56f, -86f, -1.94f, 0f, 7f, 0f},
                    {56f, -86f, -1.94f, 0f, 6f, 0f},
                    {56f, -86f, -1.94f, 0f, 5f, 0f},
                    {56f, -86f, -1.94f, 0f, 4f, 0f},
                    {56f, -86f, -1.94f, 0f, 3f, 0f},
                    {56f, -86f, -1.94f, 0f, 2f, 0f},
                    {56f, -86f, -1.94f, 0f, 1f, 0f},
                    {56f, -86f, -1.94f, 0f, 0f, 0f},
                    // N19
                    {63f, -86f, 0f, 0f, 0f, 45f},
                    // N20-N37
                    {63f, -79f, 0f, 1.94f, 0f, 90f},
                    {63f, -79f, 0f, 1.94f, 1f, 90f},
                    {63f, -79f, 0f, 1.94f, 2f, 90f},
                    {63f, -79f, 0f, 1.94f, 3f, 90f},
                    {63f, -79f, 0f, 1.94f, 4f, 90f},
                    {63f, -79f, 0f, 1.94f, 5f, 90f},
                    {63f, -79f, 0f, 1.94f, 6f, 90f},
                    {63f, -79f, 0f, 1.94f, 7f, 90f},
                    {63f, -79f, 0f, 1.94f, 8f, 90f},
                    {63f, -79f, 0f, 1.94f, 9f, 90f},
                    {63f, -79f, 0f, 1.94f, 10f, 90f},
                    {63f, -79f, 0f, 1.94f, 11f, 90f},
                    {63f, -79f, 0f, 1.94f, 12f, 90f},
                    {63f, -79f, 0f, 1.94f, 13f, 90f},
                    {63f, -79f, 0f, 1.94f, 14f, 90f},
                    {63f, -79f, 0f, 1.94f, 15f, 90f},
                    {63f, -79f, 0f, 1.94f, 16f, 90f},
                    {63f, -79f, 0f, 1.94f, 17f, 90f},
                    // N38
                    {63f, -86f, 0f, 2.47f, 19f, 135f},
                    // N39-N56
                    {23f, -39f, 1.94f, 0f, 17f, 180f},
                    {23f, -39f, 1.94f, 0f, 16f, 180f},
                    {23f, -39f, 1.94f, 0f, 15f, 180f},
                    {23f, -39f, 1.94f, 0f, 14f, 180f},
                    {23f, -39f, 1.94f, 0f, 13f, 180f},
                    {23f, -39f, 1.94f, 0f, 12f, 180f},
                    {23f, -39f, 1.94f, 0f, 11f, 180f},
                    {23f, -39f, 1.94f, 0f, 10f, 180f},
                    {23f, -39f, 1.94f, 0f, 9f, 180f},
                    {23f, -39f, 1.94f, 0f, 8f, 180f},
                    {23f, -39f, 1.94f, 0f, 7f, 180f},
                    {23f, -39f, 1.94f, 0f, 6f, 180f},
                    {23f, -39f, 1.94f, 0f, 5f, 180f},
                    {23f, -39f, 1.94f, 0f, 4f, 180f},
                    {23f, -39f, 1.94f, 0f, 3f, 180f},
                    {23f, -39f, 1.94f, 0f, 2f, 180f},
                    {23f, -39f, 1.94f, 0f, 1f, 180f},
                    {23f, -39f, 1.94f, 0f, 0f, 180f},
                    // N57
                    {16f, -39f, 0f, 0f, 0f, -135f},
                    // N58-N75
                    {16f, -46f, 0f, -1.94f, 0f, -90f},
                    {16f, -46f, 0f, -1.94f, 1f, -90f},
                    {16f, -46f, 0f, -1.94f, 2f, -90f},
                    {16f, -46f, 0f, -1.94f, 3f, -90f},
                    {16f, -46f, 0f, -1.94f, 4f, -90f},
                    {16f, -46f, 0f, -1.94f, 5f, -90f},
                    {16f, -46f, 0f, -1.94f, 6f, -90f},
                    {16f, -46f, 0f, -1.94f, 7f, -90f},
                    {16f, -46f, 0f, -1.94f, 8f, -90f},
                    {16f, -46f, 0f, -1.94f, 9f, -90f},
                    {16f, -46f, 0f, -1.94f, 10f, -90f},
                    {16f, -46f, 0f, -1.94f, 11f, -90f},
                    {16f, -46f, 0f, -1.94f, 12f, -90f},
                    {16f, -46f, 0f, -1.94f, 13f, -90f},
                    {16f, -46f, 0f, -1.94f, 14f, -90f},
                    {16f, -46f, 0f, -1.94f, 15f, -90f},
                    {16f, -46f, 0f, -1.94f, 16f, -90f},
                    {16f, -46f, 0f, -1.94f, 17f, -90f},
                    // N76
                    {16f, -39f, 0f, -2.47f, 19f, -45f},
                    // South Tower
                    // S1-S18
                    {12f, -18f, -1.94f, 0f, 17f, 0f},
                    {12f, -18f, -1.94f, 0f, 16f, 0f},
                    {12f, -18f, -1.94f, 0f, 15f, 0f},
                    {12f, -18f, -1.94f, 0f, 14f, 0f},
                    {12f, -18f, -1.94f, 0f, 13f, 0f},
                    {12f, -18f, -1.94f, 0f, 12f, 0f},
                    {12f, -18f, -1.94f, 0f, 11f, 0f},
                    {12f, -18f, -1.94f, 0f, 10f, 0f},
                    {12f, -18f, -1.94f, 0f, 9f, 0f},
                    {12f, -18f, -1.94f, 0f, 8f, 0f},
                    {12f, -18f, -1.94f, 0f, 7f, 0f},
                    {12f, -18f, -1.94f, 0f, 6f, 0f},
                    {12f, -18f, -1.94f, 0f, 5f, 0f},
                    {12f, -18f, -1.94f, 0f, 4f, 0f},
                    {12f, -18f, -1.94f, 0f, 3f, 0f},
                    {12f, -18f, -1.94f, 0f, 2f, 0f},
                    {12f, -18f, -1.94f, 0f, 1f, 0f},
                    {12f, -18f, -1.94f, 0f, 0f, 0f},
                    // S19
                    {19f, -18f, 0f, 0f, 0f, 45f},
                    // S20-S37
                    {19f, -11f, 0f, 1.94f, 0f, 90f},
                    {19f, -11f, 0f, 1.94f, 1f, 90f},
                    {19f, -11f, 0f, 1.94f, 2f, 90f},
                    {19f, -11f, 0f, 1.94f, 3f, 90f},
                    {19f, -11f, 0f, 1.94f, 4f, 90f},
                    {19f, -11f, 0f, 1.94f, 5f, 90f},
                    {19f, -11f, 0f, 1.94f, 6f, 90f},
                    {19f, -11f, 0f, 1.94f, 7f, 90f},
                    {19f, -11f, 0f, 1.94f, 8f, 90f},
                    {19f, -11f, 0f, 1.94f, 9f, 90f},
                    {19f, -11f, 0f, 1.94f, 10f, 90f},
                    {19f, -11f, 0f, 1.94f, 11f, 90f},
                    {19f, -11f, 0f, 1.94f, 12f, 90f},
                    {19f, -11f, 0f, 1.94f, 13f, 90f},
                    {19f, -11f, 0f, 1.94f, 14f, 90f},
                    {19f, -11f, 0f, 1.94f, 15f, 90f},
                    {19f, -11f, 0f, 1.94f, 16f, 90f},
                    {19f, -11f, 0f, 1.94f, 17f, 90f},
                    // S38
                    {19f, -18f, 0f, 2.47f, 19f, 135f},
                    // S39-S56
                    {-21f, 29f, 1.94f, 0f, 17f, 180f},
                    {-21f, 29f, 1.94f, 0f, 16f, 180f},
                    {-21f, 29f, 1.94f, 0f, 15f, 180f},
                    {-21f, 29f, 1.94f, 0f, 14f, 180f},
                    {-21f, 29f, 1.94f, 0f, 13f, 180f},
                    {-21f, 29f, 1.94f, 0f, 12f, 180f},
                    {-21f, 29f, 1.94f, 0f, 11f, 180f},
                    {-21f, 29f, 1.94f, 0f, 10f, 180f},
                    {-21f, 29f, 1.94f, 0f, 9f, 180f},
                    {-21f, 29f, 1.94f, 0f, 8f, 180f},
                    {-21f, 29f, 1.94f, 0f, 7f, 180f},
                    {-21f, 29f, 1.94f, 0f, 6f, 180f},
                    {-21f, 29f, 1.94f, 0f, 5f, 180f},
                    {-21f, 29f, 1.94f, 0f, 4f, 180f},
                    {-21f, 29f, 1.94f, 0f, 3f, 180f},
                    {-21f, 29f, 1.94f, 0f, 2f, 180f},
                    {-21f, 29f, 1.94f, 0f, 1f, 180f},
                    {-21f, 29f, 1.94f, 0f, 0f, 180f},
                    // S57
                    {-28f, 29f, 0f, 0f, 0f, -135f},
                    // S58-S75
                    {-28f, 22f, 0f, -1.94f, 0f, -90f},
                    {-28f, 22f, 0f, -1.94f, 1f, -90f},
                    {-28f, 22f, 0f, -1.94f, 2f, -90f},
                    {-28f, 22f, 0f, -1.94f, 3f, -90f},
                    {-28f, 22f, 0f, -1.94f, 4f, -90f},
                    {-28f, 22f, 0f, -1.94f, 5f, -90f},
                    {-28f, 22f, 0f, -1.94f, 6f, -90f},
                    {-28f, 22f, 0f, -1.94f, 7f, -90f},
                    {-28f, 22f, 0f, -1.94f, 8f, -90f},
                    {-28f, 22f, 0f, -1.94f, 9f, -90f},
                    {-28f, 22f, 0f, -1.94f, 10f, -90f},
                    {-28f, 22f, 0f, -1.94f, 11f, -90f},
                    {-28f, 22f, 0f, -1.94f, 12f, -90f},
                    {-28f, 22f, 0f, -1.94f, 13f, -90f},
                    {-28f, 22f, 0f, -1.94f, 14f, -90f},
                    {-28f, 22f, 0f, -1.94f, 15f, -90f},
                    {-28f, 22f, 0f, -1.94f, 16f, -90f},
                    {-28f, 22f, 0f, -1.94f, 17f, -90f},
                    // S76
                    {-28f, 29f, 0f, -2.47f, 19f, -45f},
            };
            
            // Set Rotation (-45, 0 : 45, 90: 135, 180 : -135, -90)
            transform.localEulerAngles = new Vector3(0f, lookObj.localEulerAngles.y + anchorPositions[currentPanelNumber,5] ,0f);
           
            // Set Position
            towersObj.localPosition = new Vector3(anchorPositions[currentPanelNumber,0] + anchorPositions[currentPanelNumber,2]*anchorPositions[currentPanelNumber,4] , 0.5f ,anchorPositions[currentPanelNumber,1] + anchorPositions[currentPanelNumber,3]*anchorPositions[currentPanelNumber,4] );
        }
    }

}
