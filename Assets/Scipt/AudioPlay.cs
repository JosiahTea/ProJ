using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioPlay : MonoBehaviour
{
    [SerializeField] AudioSource[] _audioSources;
    [SerializeField] private Button _nextTextButton;
    [SerializeField] private Button _previousTextButton;

    private int _index;

    private void Start()
    {
        _index = 0;

        foreach (var item in _audioSources)
        {
            item.gameObject.SetActive(false);
        }

        _audioSources[_index].gameObject.SetActive(true);
        _audioSources[_index].Play();

        _nextTextButton.onClick.AddListener(GoNext);
        _previousTextButton.onClick.AddListener(GoPrevious);
    }

    private void GoNext()
    {
        if ((_index + 1) < _audioSources.Length)
        {
            _index++;
            _audioSources[_index].gameObject.SetActive(true);
            _audioSources[_index - 1].gameObject.SetActive(false);

            _audioSources[_index].Play();
            _audioSources[_index - 1].Pause();
        }
        else
        {
            _audioSources[_index].Pause();
            _audioSources[_index].gameObject.SetActive(false);
            _index = 0;
            _audioSources[_index].gameObject.SetActive(true);

            _audioSources[_index].Play();
        }
    }

    private void GoPrevious()
    {
        if ((_index - 1) >= 0)
        {
            _index--;
            _audioSources[_index].gameObject.SetActive(true);
            _audioSources[_index + 1].gameObject.SetActive(false);

            _audioSources[_index].Play();
            _audioSources[_index + 1].Pause();
        }
        else
        {
            _audioSources[_index].Play();

            _audioSources[_index].gameObject.SetActive(false);
            _index = _audioSources.Length - 1;
            _audioSources[_index].gameObject.SetActive(true);

            _audioSources[_index].Play();
        }
    }
}
