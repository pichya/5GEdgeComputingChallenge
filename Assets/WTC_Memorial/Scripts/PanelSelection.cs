using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PanelSelection : MonoBehaviour
{
    public int selectPanelNumber = 0;
    public Dropdown panelDropdown;
    
    // Start is called before the first frame update
    void Start()
    {
        List<string> panelListOptions = new List<string>{
            "N1", "N2", "N3", "N4", "N5", "N6", "N7", "N8", "N9", "N10",
            "N11", "N12", "N13", "N14", "N15", "N16", "N17", "N18", "N19", "N20",
            "N21", "N22", "N23", "N24", "N25", "N26", "N27", "N28", "N29", "N30",
            "N31", "N32", "N33", "N34", "N35", "N36", "N37", "N38", "N39", "N40",
            "N41", "N42", "N43", "N44", "N45", "N46", "N47", "N48", "N49", "N50",
            "N51", "N52", "N53", "N54", "N55", "N56", "N57", "N58", "N59", "N60",
            "N61", "N62", "N63", "N64", "N65", "N66", "N67", "N68", "N69", "N70",
            "N71", "N72", "N73", "N74", "N75", "N76",
            "S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "S10",
            "S11", "S12", "S13", "S14", "S15", "S16", "S17", "S18", "S19", "S20",
            "S21", "S22", "S23", "S24", "S25", "S26", "S27", "S28", "S29", "S30",
            "S31", "S32", "S33", "S34", "S35", "S36", "S37", "S38", "S39", "S40",
            "S41", "S42", "S43", "S44", "S45", "S46", "S47", "S48", "S49", "S50",
            "S51", "S52", "S53", "S54", "S55", "S56", "S57", "S58", "S59", "S60",
            "S61", "S62", "S63", "S64", "S65", "S66", "S67", "S68", "S69", "S70",
            "S71", "S72", "S73", "S74", "S75", "S76"
        };
        panelDropdown.ClearOptions();
        panelDropdown.AddOptions(panelListOptions);
    }

    void Update(){
        if (selectPanelNumber != panelDropdown.value )
        {
            selectPanelNumber = panelDropdown.value;
            Debug.Log(selectPanelNumber);
        }
    }
    
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
