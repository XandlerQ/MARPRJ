using UnityEngine;

public class Objective : MonoBehaviour {
    [SerializeField]
    public int f_Id;

    [SerializeField]
    Reciever f_reciever;

    [SerializeField]
    GameObject f_organ;

    public bool f_reached = false;

    public bool f_exited = false;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Tool") {
            f_reached = true;
            Renderer renderer = GetComponent<Renderer>();
            if (renderer != null) {
                renderer.material.color = new Color(0.2f, 1.0f, 0.1f, 0.5f);
            }
            if (!f_exited) {
                f_reciever.recieve(f_Id);
            }
        }
    }

    public void randomPos() {
        transform.position = f_organ.transform.position + new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(0.0175f - 0.1122f, 0.175f - 0.1122f), Random.Range(-0.1885f, 0.1885f));
    }

    public void reset() {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null) {
            renderer.material.color = new Color(1.0f, 0.35f, 0.05f, 0.5f);
        }
        f_reached = false;
        f_exited = false;
    }

    void OnTriggerStay(Collider other) {
    }

    void OnTriggerExit(Collider other) {
        if (f_reached) {
            if (other.gameObject.tag == "Tool") {
                f_exited = true;
                Renderer renderer = GetComponent<Renderer>();
                if (renderer != null) {
                    renderer.material.color = new Color(0.7f, 0.7f, 0.7f, 0.5f);
                }
            }
        }
    }
}
