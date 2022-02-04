using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Saat : MonoBehaviour
{
    public GameObject  okkapat, okaç;
    public bool acik = false;
    // Start is called before the first frame update
    void Start()
    {
       
        okaç.SetActive(false);
       







    }

    // Update is called once per frame
    void Update()
    {

    }

    public void openPanel()
    {

        StartCoroutine("yanipsönme");



    }


    public IEnumerator yanipsönme()
    {



        acik = !acik;
        if (acik)
        {
            okkapat.SetActive(false);
          

           
          

            yield return new WaitForSeconds(3);


            okaç.SetActive(true);


        }
        else
        {
        }



    }


}