using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionTrue : MonoBehaviour
{
    [SerializeField] private Button _trueButton;
    [SerializeField] private Button _falseButton;

    private void Start()
    {
        _trueButton.onClick.AddListener(True);
        _falseButton.onClick.AddListener(False);
    }

    private void True()
    {
        gameObject.GetComponent<Image>().color = Color.green;
        _trueButton.gameObject.SetActive(false);
        _falseButton.gameObject.SetActive(false);
    }

    private void False()
    {

        gameObject.GetComponent<Image>().color = Color.red;
        _trueButton.gameObject.SetActive(false);
        _falseButton.gameObject.SetActive(false);
    }
}
