using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PantoKapat : MonoBehaviour
{
    public GameObject okkapat, okaç, modelkapat, modelac, text, sarıısık, panel,ımagekapat,kırmızıısık,acılıs,kapanıs;
    public bool acik = false;
    // Start is called before the first frame update
    void Start()
    {

        okaç.SetActive(false);
        
   
       
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

            sarıısık.SetActive(false);
            text.SetActive(false);
            panel.SetActive(true);
            ımagekapat.SetActive(false);
            kırmızıısık.SetActive(false);
            acılıs.SetActive(false);
            kapanıs.SetActive(true);
            
            yield return new WaitForSeconds(3);


            okaç.SetActive(true);

           
        }
        else
        {
        }



    }


}