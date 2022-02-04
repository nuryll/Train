using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panto : MonoBehaviour
{
    public GameObject okkapat, okaç,modelkapat,modelac,text,sarıısık,butonac,panel,acılıs;
    public bool acik = false;
    // Start is called before the first frame update
    void Start()
    {

        okaç.SetActive(false);
        modelac.SetActive(false);
        sarıısık.SetActive(false);
        text.SetActive(false);
        butonac.SetActive(false);
        panel.SetActive(false);







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


            yield return new WaitForSeconds(1);

            modelkapat.SetActive(false);
            modelac.SetActive(true);

            sarıısık.SetActive(true);
            text.SetActive(true);
            panel.SetActive(true);
            acılıs.SetActive(true);

            yield return new WaitForSeconds(3);


            okaç.SetActive(true);

            butonac.SetActive(true);
        }
        else
        {
        }



    }


}