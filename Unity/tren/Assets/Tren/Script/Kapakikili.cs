using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kapakikili : MonoBehaviour
{
    public GameObject okkapat, okaç, ImageKapat;
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


        

           




          

            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 20);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 50);
            yield return new WaitForSeconds(0.1f);

            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 70);
            yield return new WaitForSeconds(0.1f);
         
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 90);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 110);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 140);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 180);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 200);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 230);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            yield return new WaitForSeconds(3);

            okaç.SetActive(true);



        }
        else
        {
        }



    }


}