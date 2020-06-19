using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public int hunger = 100;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = ("飢餓值:" + hunger);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
