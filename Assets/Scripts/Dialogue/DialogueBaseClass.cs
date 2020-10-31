using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DialogueSystem
{
    
    public class DialogueBaseClass : MonoBehaviour
    {
        public bool finishedLine { get; private set; }
        
        protected IEnumerator WriteText(string input, Text textHolder, Color textColor, Font textFont, float delay, float delayBetweenLines) { // everytime the loop goes through it prints a letter in the dialogue.
            
            textHolder.color = textColor; // sets text color.
            textHolder.font = textFont; // sets font. We can add them in.
            for (int i = 0; i < input.Length; i++){
                textHolder.text += input[i];
                // play letter sound if you want
                yield return new WaitForSeconds(delay); // with .1 second time delay.
                Debug.Log("Print dialogye."); // bug testing
            }

            //yield return new WaitForSeconds(delayBetweenLines);
            yield return new WaitUntil(() => Input.GetMouseButton(0));
            finishedLine = true;
        }
    }
}