using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
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

    public void Forward(float xMove)
    {
        myTargetPosition = myPlayer.transform.position + new Vector3(xMove, 0, 0);
    }
    
    public void Backward(float xMove)
    {
        myTargetPosition = myPlayer.transform.position + new Vector3(xMove, 0, 0);
    }
}