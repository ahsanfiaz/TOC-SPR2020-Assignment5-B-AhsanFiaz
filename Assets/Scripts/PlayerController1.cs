using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController1 : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 10;
    private Rigidbody rb;
    public int count = 0;

    public AudioSource audio;
    public Text countText;
    public TextMesh result;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        countText.text = "Eat 0 Parenthesis";
        audio = GetComponent<AudioSource>();
    }
    private void Update()
    {

        Vector3 namePos = Camera.main.WorldToScreenPoint(this.transform.position);
        countText.transform.position = namePos;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 mov = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(mov * speed);
    }
    void OnTriggerEnter(Collider other)
    {

     
        string n = other.GetComponent<Help>().x;
        Spawner1 s = new Spawner1();
        if (s.isbalnce(n))
        {
            count = count + 1;
            setCount(s.getparen());
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);

        }
        else
        {

            audio.Play();
        }
    }


  

    void setCount(int s)
    {
        if (s == count)
        {
            result.text = "Eat All : " + s.ToString() + "Parenthesis";
            countText.text = "Eat All : " + s.ToString() + "Parenthesis";
        }
        else
        {
            countText.text = "Eat " + count + "Parenthesis from " + s.ToString();
        }
    }


}
