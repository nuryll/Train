using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButonKutu : MonoBehaviour
{
    public GameObject panel,okkapat,okaç,anahtar,yer,ImageKapat,kapak;
    public bool acik = false;
    // Start is called before the first frame update
    void Start()
    {
       
        okaç.SetActive(false);
        panel.SetActive(false);
        anahtar.SetActive(false);
        yer.SetActive(false);






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
            kapak.SetActive(false);

            yield return new WaitForSeconds(1);
            panel.SetActive(true);
           

            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 210);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 180);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 150);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 130);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 80);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 60);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 40);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 20);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
           
            
            okaç.SetActive(true);

            yield return new WaitForSeconds(3);
            anahtar.SetActive(true);
            yer.SetActive(true);



        }
        else
        {
        }



    }


}