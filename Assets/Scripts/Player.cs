using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text hpText;
    public Slider hpslider;

    void Start()
    {
        hpText.text = "50";
        hpslider.value = 50;
    }

    // Update is called once per frame

    private void Update()
    {
        transform.position += new Vector3(0.1f, 0, 0);
    }
}