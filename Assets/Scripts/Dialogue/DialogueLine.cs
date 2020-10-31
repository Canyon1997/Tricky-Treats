using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DialogueSystem
{
    public class DialogueLine : DialogueBaseClass
        {
            private Text textHolder;
            [Header ("Text Options")]
            [SerializeField] private string input; // allows text input to be edited from inspector.
            [SerializeField] private Color textColor; // allows text color to be edited via inspector.
            [SerializeField] private Font textFont;

            [Header ("Time Parameters")]
            [SerializeField] private float delay;
            [SerializeField] private float delayBetweenLines; // Probably don't need this anymore due to text advancing from mouseclick.

            private void Awake() 
            {
                textHolder = GetComponent<Text>(); // gets text from dialogue line > dialogue line script > input within the inspector.
                textHolder.text = ""; // Makes sure that on start anything left gets wiped and only pulls text from appropriate place.
            }

            private void Start()
            {
                StartCoroutine(WriteText(input, textHolder, textColor, textFont, delay, delayBetweenLines));
            }

    }
}

