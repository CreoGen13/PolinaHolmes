using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageText : MonoBehaviour
{
    [SerializeField] GameObject coll = null;
    public void Exit()
    {
        coll.SetActive(false);
        gameObject.SetActive(false);
    }
}
