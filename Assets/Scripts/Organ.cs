using UnityEngine;

public class Organ : MonoBehaviour {
    [SerializeField]
    float f_critDistance;

    [SerializeField]
    float f_minDistance;

    [SerializeField]
    GameObject f_object;

    void Update() {
        float distance = (f_object.transform.position - transform.position).magnitude - f_minDistance;
        if (distance <= 0) {
            Renderer renderer = GetComponent<Renderer>();
            Color color = renderer.material.color;
            if (renderer != null) {
                renderer.material.color = new Color(color.r, color.g, color.b, 0.1f);
            }
        }
        else if (distance < f_critDistance) {
            float t = distance / f_critDistance;
            float alpha = 0.1f + t * 0.65f;
            Renderer renderer = GetComponent<Renderer>();
            Color color = renderer.material.color;
            if (renderer != null) {
                renderer.material.color = new Color(color.r, color.g, color.b, alpha);
            }

        }
        else {
            Renderer renderer = GetComponent<Renderer>();
            Color color = renderer.material.color;
            if (renderer != null) {
                renderer.material.color = new Color(color.r, color.g, color.b, 0.75f);
            }
        }
    }
}
