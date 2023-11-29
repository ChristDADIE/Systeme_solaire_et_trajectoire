using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptToogle : MonoBehaviour
{


    public Toggle toggle;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        toggle.onValueChanged.AddListener(OnToogleValueChanged);
        
    }

    private void OnToogleValueChanged(bool newValue) {

        if (newValue) {

            

        }
        else { 
        }
    
    
    
    }
}
