using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonImageText : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Text textQuestion = null;
    [SerializeField] GameObject imageText = null;
    [SerializeField] GameObject go = null;

    [SerializeField] GameObject end = null;
    [SerializeField] AudioClip endMusic = null;
    private bool flag = true;
    public void Open()
    {
        go.SetActive(true);
        imageText.SetActive(true);
        textQuestion.text = DataHolder.text[DataHolder.step];
    }
    private void Update()
    {
        if(DataHolder.step == 23 && flag)
        {
            flag = false;
            end.SetActive(true);
            Camera.main.GetComponent<AudioSource>().PlayOneShot(endMusic);
        }

    }
}
