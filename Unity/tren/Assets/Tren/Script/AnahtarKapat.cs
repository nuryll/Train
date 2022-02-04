using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnahtarKapat : MonoBehaviour
{
    public GameObject anahtaranim,modelkapat, okkapat,sarıısık,text,panel,kırmızıısık,al;
    public bool acik = false;
    // Start is called before the first frame update
    void Start()
    {
        anahtaranim.SetActive(false);
        






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
            modelkapat.SetActive(false);
            anahtaranim.SetActive(true);

            

            yield return new WaitForSeconds(1);        
            sarıısık.SetActive(false);
            kırmızıısık.SetActive(false);
            text.SetActive(false);
            panel.SetActive(false);
            yield return new WaitForSeconds(1);
            anahtaranim.SetActive(false);
            al.SetActive(true);




        }
        else
        {
        }



    }


}