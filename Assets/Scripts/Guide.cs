using System;
using UnityEngine;

public class Guide : MonoBehaviour {
    public Objective f_objective;

    [SerializeField]
    GameObject f_pointer;

    [SerializeField]
    float f_critDistance;

    [SerializeField]
    float f_minDistance;

    Vector3 f_initScale;

    [SerializeField]
    float f_pulsationSpeed;

    float f_time;

    void UpdateRotation() {
        transform.LookAt(f_objective.transform, Vector3.up);
    }

    void Start() {
        f_initScale = transform.localScale;
    }

    void Update() {
        f_time += Time.deltaTime;
        float distance = (f_objective.transform.position - transform.position).magnitude - f_minDistance;
        if (distance <= 0) {
            f_pointer.SetActive(false);
        }
        else if (distance < f_critDistance) {
            f_pointer.SetActive(true);
            float t = distance / f_critDistance;
            transform.localScale = new Vector3(f_initScale.x, f_initScale.y, (0.8f + 0.2f * (float)Math.Cos(f_pulsationSpeed * f_time)) * t * f_initScale.z);
        }
        else {
            f_pointer.SetActive(true);
            transform.localScale = new Vector3(f_initScale.x, f_initScale.y, (0.8f + 0.2f * (float)Math.Cos(f_pulsationSpeed * f_time)) * f_initScale.z);
        }
        UpdateRotation();
    }
}
