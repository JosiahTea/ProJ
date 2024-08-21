using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextQuestionButton : MonoBehaviour
{
    [SerializeField] private GameObject[] _questions;
    [SerializeField] private Button _nextButton;

    private int _numberQuestion = 1;

    private void Start()
    {
        _nextButton.onClick.AddListener(NextQuestion);
    }

    private void NextQuestion()
    {
        for (int i = 0; i < _questions.Length; i++)
        {
            _questions[i].SetActive(false);
        }

        if(_numberQuestion < _questions.Length)
        {
            _questions[_numberQuestion].SetActive(true);
            _numberQuestion++;
        }
    }
}
