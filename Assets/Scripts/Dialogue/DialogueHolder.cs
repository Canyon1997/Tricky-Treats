using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DialogueSystem
{
    public class DialogueHolder : MonoBehaviour
    {
        
        private void Awake()
        {
            StartCoroutine(dialogueSequence());
        }
        
        private IEnumerator dialogueSequence()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                Deactivate(); // function to disable past text objects.
                transform.GetChild(i).gameObject.SetActive(true); // new object displays.
                yield return new WaitUntil(() => transform.GetChild(i).GetComponent<DialogueLine>().finishedLine); // wait to move on to next dialogue line until time/click.
            }

            gameObject.SetActive(false); //disble otherwise.
        }

        private void Deactivate()
        {
            for(int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(false); // disables text objects after playing them.
            }
        }
    }
}
