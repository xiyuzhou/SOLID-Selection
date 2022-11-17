using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Selectable : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI lookPersentageLabel;
    [SerializeField] private float yPos = 0.5f;
    [HideInInspector] public float LookPercentage;

    private void Start()
    {
        var Position = gameObject.transform.position;
        Position.y += yPos;
        lookPersentageLabel.transform.position = Position;
    }

    private void Update()
    {
        lookPersentageLabel.text = LookPercentage.ToString("F3");
        lookPersentageLabel.transform.LookAt(Camera.main.transform);
    }
}
