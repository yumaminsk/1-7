using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapPosition : MonoBehaviour
{
    public GameObject gameobject;
    public GameObject cube;
    public CharacterController controller;

    void OnTriggerEnter(Collider myTrigger)
    {
        if (myTrigger.gameObject.name == "Player")
        {
            cube.GetComponent<BoxCollider>().enabled = false;
            controller.Move(new Vector3 (gameobject.transform.position.x, gameobject.transform.position.y - 10f, gameobject.transform.position.z));
    Debug.Log("Swap position");
            cube.GetComponent<BoxCollider>().enabled = true;
        }
    }

}
