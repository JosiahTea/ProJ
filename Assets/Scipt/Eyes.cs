using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour
{
    [SerializeField] private Face _face;
    [SerializeField] private GameObject[] _eyes;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out RightEye rightEye))
        {
            Debug.Log("Вошел");

            rightEye.gameObject.transform.position = gameObject.transform.position;

            foreach (var item in _eyes)
            {
                item.SetActive(false);
            }

            rightEye.gameObject.SetActive(true);

            rightEye.gameObject.transform.SetParent(gameObject.transform);

            Draggable draggable = rightEye.GetComponent<Draggable>();
            draggable.enabled = false;

            _face.AddProgress();
        }
    }
}


