using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButonKırmızı : MonoBehaviour
{
    public GameObject lightkırmızı, okkapat, okaç,panel1,ımagekapat;
    public bool acik = false;
    // Start is called before the first frame update
    void Start()
    {
        lightkırmızı.SetActive(false);
        okaç.SetActive(false);
        panel1.SetActive(false);
      






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
            lightkırmızı.SetActive(true);

            yield return new WaitForSeconds(1);
            panel1.SetActive(true);
            ımagekapat.SetActive(false);

            yield return new WaitForSeconds(3);


            okaç.SetActive(true);


        }
        else
        {
        }



    }


}