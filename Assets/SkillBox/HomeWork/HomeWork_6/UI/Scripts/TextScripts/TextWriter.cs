using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System;

public class TextWriter : MonoBehaviour
{
    [SerializeField] private float _timePerCharacter;

    private TextMeshProUGUI _uiText;
    private string _textToWrite;
    private int _characterIndex;
    private float _timer;

    public void AddWriter(TextMeshProUGUI uiText, string textToWrite)
    {
        _uiText = uiText;
        _textToWrite = textToWrite;
        _characterIndex = 0;
    }


    private void Update()
    {
        if (_uiText != null)
        {
            _timer -= Time.deltaTime;
            while (_timer <= 0f)
            {

                //Display next character
                _timer += _timePerCharacter;
                _characterIndex++;
                _uiText.text = _textToWrite.Substring(0, _characterIndex);

                if (_characterIndex >= _textToWrite.Length)
                {
                    _uiText = null;
                    return;
                }
            }
        }
    }
}
