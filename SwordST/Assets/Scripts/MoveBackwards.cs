using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackwards : MonoBehaviour
{
    public float moveSpeed = -1f;
    public GameObject myPlayer;
    Vector3 myTargetPosition;

    private void Start()
    {
        myTargetPosition = myPlayer.transform.position;
    }

    private void Update()
    {
        myPlayer.transform.position = Vector3.MoveTowards(myPlayer.transform.position, myTargetPosition, 0.1f);
    }

    public void Backwards()
    {
        Debug.Log("Back");
        myTargetPosition = myPlayer.transform.position + new Vector3(moveSpeed, 0, 0);
    }

}