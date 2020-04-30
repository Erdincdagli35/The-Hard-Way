using UnityEngine;

public class endTrigger : MonoBehaviour {

    public GameManager gameM;
    void OnTriggerEnter()
    {
        gameM.CompleteLevel();
    }

}
