using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair : MonoBehaviour
{
    [SerializeField] private Face _face;
    [SerializeField] private GameObject[] _hairs;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out RightHair rightHair))
        {
            Debug.Log("Вошел");

            rightHair.gameObject.transform.position = gameObject.transform.position;

            foreach (var item in _hairs)
            {
                item.SetActive(false);
            }

            rightHair.gameObject.SetActive(true);

            rightHair.gameObject.transform.SetParent(gameObject.transform);

            Draggable draggable = rightHair.GetComponent<Draggable>();
            draggable.enabled = false;

            _face.AddProgress();
        }
    }
}

