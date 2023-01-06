using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
    public ScriptedJourney scriptedJourney;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "-----Player-----")
        {
            //Debug.Log("sss");
            scriptedJourney.StatusTuto = 2;
        }
    }
}
