using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExcessObject : MonoBehaviour
{
    [SerializeField] private GameObject _questions;

    [SerializeField] private Button _continueButton;
    [SerializeField] private Camera _camera;

    private void Start()
    {
        _continueButton.gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        _camera.backgroundColor = Color.green;
       _continueButton.gameObject.SetActive(true);
        _questions.SetActive(false);
    }
}