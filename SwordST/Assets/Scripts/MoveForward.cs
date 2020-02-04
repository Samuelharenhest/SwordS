using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject myPlayer;

    public void MoveForward()
    {
        myPlayer.transform.position += new Vector3(moveSpeed, 0, 0);
    }
   
}
