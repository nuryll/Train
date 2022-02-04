using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trennn : MonoBehaviour
{
    public GameObject panelbilgi;
    public bool acik = false;
    // Start is called before the first frame update
    void Start()
    {
      




    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void openPanel()
    {

        acik = !acik;
        if (acik)
        {
           
            panelbilgi.SetActive(false);







        }
        else
        {
            panelbilgi.SetActive(true);
        }




    }


   
}