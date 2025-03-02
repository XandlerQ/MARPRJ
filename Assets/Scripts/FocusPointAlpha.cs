using UnityEngine;

public class FocusPointAlpha : MonoBehaviour
{
    public GameObject focus;
    public float focusRadius = 0.25f;

    // Update is called once per frame
    void Update() {
        if (focus != null) {
            Vector3 focusPosition = focus.transform.position;
            Vector3 focusDirection = focus.transform.forward;
            GetComponent<Renderer>().material.SetVector("_FocusPosition", focusPosition);
            GetComponent<Renderer>().material.SetVector("_FocusDirection", focusDirection);
            GetComponent<Renderer>().material.SetFloat("_FocusRadius", focusRadius);
        }        
    }
}
