using UnityEngine;

public class Reciever : MonoBehaviour {
    [SerializeField] 
    Operation f_operation;
    public void recieve(int id) {
        f_operation.objectiveReached(id);
    }
}
