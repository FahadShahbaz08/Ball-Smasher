using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroyLevel1 : MonoBehaviour
{
    private Level1 firstLevel;
    private void Start()
    {
        firstLevel = FindAnyObjectByType<Level1>();
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
        if (firstLevel != null)
        {
            firstLevel.Level1Score();
        }
    }
    private void OnDestroy()
    {
        print(name);
    }

}
