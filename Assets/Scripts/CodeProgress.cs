using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeProgress : MonoBehaviour
{
    public static int codeCompletion;
    public GameObject codeCompletionDisplay;
    public int codeCompletionInternal;
    void Update(){
        codeCompletionInternal = codeCompletion;
        codeCompletionDisplay.GetComponent<Text>().text = codeCompletionInternal+"/100";
        if(codeCompletion == 100){
            codeCompletionDisplay.GetComponent<Text>().text = "Done!";
        }
        
    }
}
