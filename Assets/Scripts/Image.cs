using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image : MonoBehaviour
{
    [SerializeField] AudioClip Yes = null;
    [SerializeField] AudioClip No = null;
    [SerializeField] private int step;
    [SerializeField] GameObject go = null;
    [SerializeField] ButtonImageText BIT = null;
    public void Check()
    {
        if (step == DataHolder.step)
        {
            DataHolder.step++;
            if(DataHolder.step < 23)
                StartCoroutine(Do(Yes));
        }
        else
        {
            Camera.main.GetComponent<AudioSource>().PlayOneShot(No);
        }
    }
    IEnumerator Do(AudioClip x)
    {
        go.SetActive(true);
        Camera.main.GetComponent<AudioSource>().PlayOneShot(x);
        yield return new WaitForSeconds(2.2f);
        BIT.Open();
    }
}
