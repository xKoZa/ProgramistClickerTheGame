using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClicked : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton(){
        if(CodeProgress.codeCompletion == 100){
            
        }
        else{
            ProgressBar.targetProgress += 0.01f;
            CodeProgress.codeCompletion += 1;
        }
    }
}
