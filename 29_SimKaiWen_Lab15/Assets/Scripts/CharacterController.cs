using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    public GameObject jumpText;
    public AudioSource audioSource;
    public AudioClip[] audioArray;

    private int jumpCount = 0;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpCount++;

            jumpText.GetComponent<Text>().text = "Jump: " + jumpCount;
            rb.AddForce(new Vector3(0, 250, 0));

            //audioSource.Play();
            int rand = Random.Range(0, audioArray.Length);
            audioSource.PlayOneShot(audioArray[rand]);

        }
    }
}
