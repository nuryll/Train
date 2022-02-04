using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class anahtar : MonoBehaviour
{
    public GameObject anahtaranim,okkapat,okaç,anahtarbuton,butonac;
    public bool acik = false;
    // Start is called before the first frame update
    void Start()
    {
        anahtaranim.SetActive(false);
        okaç.SetActive(false);

        butonac.SetActive(false);




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
            anahtaranim.SetActive(true);
            


            yield return new WaitForSeconds(3);


            okaç.SetActive(true);

            anahtarbuton.SetActive(false);
            butonac.SetActive(true);

        }
        else
        {
        }



    }


}