using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contrd : MonoBehaviour
{
    public GameObject objectToAppear;
    public Transform targetPosition;

    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonPressed);
    }

    private void OnButtonPressed()
    {
        objectToAppear.SetActive(true);
        objectToAppear.transform.position = targetPosition.position;
        objectToAppear.transform.rotation = targetPosition.rotation;
    }
}