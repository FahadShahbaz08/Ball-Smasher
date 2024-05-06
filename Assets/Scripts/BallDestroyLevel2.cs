using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroyLevel2 : MonoBehaviour
{
    private Level2 level2;
    private void Start()
    {
        level2 = GetComponent<Level2>(); 
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
        if(level2 != null)
        {
            level2.Level2Score();
        }
    }
    private void OnDestroy()
    {
        print("Level 2 : " + name);
    }
}
