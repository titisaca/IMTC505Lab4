using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{

    public GameObject newButton;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeColor()
        {
        newButton.GetComponent<Image>().color = Color.green;
        }
    public void BaseColor()
    {
        newButton.GetComponent<Image>().color = Color.white;
    }


}
