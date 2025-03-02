using System;
using UnityEngine;

public class PulsationZ : MonoBehaviour
{
    [SerializeField]
    float f_pulsationSpeed;

    float f_initialScaleZ;

    float f_time;

    void Start() {
        f_initialScaleZ = transform.localScale.z;
    }

    void Update() {
        f_time += Time.deltaTime;

        transform.localScale = new Vector3(
            transform.localScale.x, 
            transform.localScale.y, 
            f_initialScaleZ * (0.75f + 0.25f * (float)(Math.Cos(f_pulsationSpeed * f_time)))
        );
    }
}
