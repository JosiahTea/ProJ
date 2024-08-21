using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextView : MonoBehaviour
{
    [SerializeField] private GameObject[] _text;
    [SerializeField] private Button _nextTextButton;
    [SerializeField] private Button _previousTextButton;

    private int _index;

    private void Start()
    {
        _index = 0;

        foreach (var item in _text)
        {
            item.SetActive(false);
        }

        _text[_index].gameObject.SetActive(true);

        _nextTextButton.onClick.AddListener(GoNext);
        _previousTextButton.onClick.AddListener(GoPrevious);
    }

    private void GoNext()
    {
        if((_index + 1) < _text.Length)
        {
            _index++;
            _text[_index].gameObject.SetActive(true);
            _text[_index - 1].gameObject.SetActive(false);
        }
        else
        {
            _text[_index].gameObject.SetActive(false);
            _index = 0;
            _text[_index].gameObject.SetActive(true);
        }
    }

    private void GoPrevious()
    {
        if((_index - 1) >= 0)
        {
            _index--;
            _text[_index].gameObject.SetActive(true);
            _text[_index + 1].gameObject.SetActive(false);
        }
        else
        {
            _text[_index].gameObject.SetActive(false);
            _index = _text.Length - 1;
            _text[_index].gameObject.SetActive(true);
        }
    }
}
