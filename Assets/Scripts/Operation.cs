using System.Data.Common;
using UnityEngine;

public class Operation : MonoBehaviour {
    [SerializeField]
    Objective[] f_objectives;

    [SerializeField]
    Guide f_guide;

    int f_objectiveCount;

    public void objectiveReached(int id) {
        if (f_guide.f_objective.f_Id == id) {
            bool newObjFlag = setNewObjective();
            if (!newObjFlag) {
                reset();
            }
        }
    }

    void reset() {
        for (int i = 0; i < f_objectiveCount; i++) {
            f_objectives[i].randomPos();
            f_objectives[i].reset();
        }
        f_guide.gameObject.SetActive(true);
    }

    bool setNewObjective() {
        for (int i = 0; i < f_objectiveCount; i++) {
            if (!f_objectives[i].f_reached) {
                f_guide.f_objective = f_objectives[i];
                return true;
            } 
        }
        f_guide.gameObject.SetActive(false);
        return false;
    }

    void Start() {
        f_objectiveCount = f_objectives.Length;
        f_guide.gameObject.SetActive(false);
    }

    public void onPatientITFound() {
        f_guide.gameObject.SetActive(true);
        setNewObjective();
    }

    public void onPatientITLost() {
        f_guide.gameObject.SetActive(false);
    }

    void Update() {
        
    }
}
