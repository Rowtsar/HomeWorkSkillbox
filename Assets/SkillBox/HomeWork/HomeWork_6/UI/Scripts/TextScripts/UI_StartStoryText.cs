using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_StartStoryText : MonoBehaviour
{
    [SerializeField] private StartingText _startingText;
    [SerializeField] private TextWriter _textWriter;

    [SerializeField] private StateMachineToStartGame _screenChahge;

    

    private string[] _startStringText = 
    {
        "Hello World, my name is Anton, i'm from rushaka",
        "Bam bam",
        "Wow haw"
    };

    private TextMeshProUGUI _text;


    private void Awake()
    {
        _text = _startingText.GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        _textWriter.AddWriter(_text, _startStringText[_screenChahge.screen - 1]);
    }
}
