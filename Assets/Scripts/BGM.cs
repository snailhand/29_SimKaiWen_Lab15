using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioClip[] bgmClip;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, bgmClip.Length);
        audioSource.PlayOneShot(bgmClip[rand]);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            audioSource.volume += 0.4f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            audioSource.volume -= 0.4f * Time.deltaTime;
        }
    }
}
