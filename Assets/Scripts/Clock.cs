using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Transform;

public class Clock : MonoBehaviour
{

    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    [SerializeField]
    Transform hourPivot, minutePivot, secondPivot;

    // Awake is called when the component awakens.
    void Awake() {
        DateTime time = DateTime.Now;
        hourPivot.localRotation = Quaternion.Euler(0f, 0f, time.Hour * hoursToDegrees);
        minutePivot.localRotation = Quaternion.Euler(0f, 0f, time.Minute * minutesToDegrees);
        secondPivot.localRotation = Quaternion.Euler(0f, 0f, time.Second * secondsToDegrees);
    }

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hourPivot.localRotation = Quaternion.Euler(0f, 0f, (float) time.TotalHours * hoursToDegrees);
        minutePivot.localRotation = Quaternion.Euler(0f, 0f, (float) time.TotalMinutes * minutesToDegrees);
        secondPivot.localRotation = Quaternion.Euler(0f, 0f, (float) time.TotalSeconds * secondsToDegrees);        
    }
}
