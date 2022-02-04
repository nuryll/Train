using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kol : MonoBehaviour
{
    public GameObject okkapat, model,model2,ImageKapat,ImageKapat2,ImageKapat3,ac;
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

        StartCoroutine("yanipsönme");



    }


    public IEnumerator yanipsönme()
    {



        acik = !acik;
        if (acik)
        {
            okkapat.SetActive(false);






            yield return new WaitForSeconds(0.5f);
            model.SetActive(true);

            ac.SetActive(true);
            yield return new WaitForSeconds(3);

            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 230);
            ImageKapat2.GetComponent<Image>().color = new Color32(255, 255, 255, 230);
            ImageKapat3.GetComponent<Image>().color = new Color32(255, 255, 255, 230);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 200);
            ImageKapat2.GetComponent<Image>().color = new Color32(255, 255, 255, 200);
            ImageKapat3.GetComponent<Image>().color = new Color32(255, 255, 255, 200);
            yield return new WaitForSeconds(0.1f);

            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 180);
            ImageKapat2.GetComponent<Image>().color = new Color32(255, 255, 255, 180);
            ImageKapat3.GetComponent<Image>().color = new Color32(255, 255, 255, 180);
            yield return new WaitForSeconds(0.1f);

            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 150);
            ImageKapat2.GetComponent<Image>().color = new Color32(255, 255, 255, 150);
            ImageKapat3.GetComponent<Image>().color = new Color32(255, 255, 255, 150);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 110);
            ImageKapat2.GetComponent<Image>().color = new Color32(255, 255, 255, 110);
            ImageKapat3.GetComponent<Image>().color = new Color32(255, 255, 255, 110);
            model.SetActive(false);
            model2.SetActive(false);
            ac.SetActive(false);


            yield return new WaitForSeconds(4);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 80);
            ImageKapat2.GetComponent<Image>().color = new Color32(255, 255, 255, 80);
            ImageKapat3.GetComponent<Image>().color = new Color32(255, 255, 255, 80);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 50);
            ImageKapat2.GetComponent<Image>().color = new Color32(255, 255, 255, 50);
            ImageKapat3.GetComponent<Image>().color = new Color32(255, 255, 255, 50);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 30);
            ImageKapat2.GetComponent<Image>().color = new Color32(255, 255, 255, 30);
            ImageKapat3.GetComponent<Image>().color = new Color32(255, 255, 255, 30);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 20);
            ImageKapat2.GetComponent<Image>().color = new Color32(255, 255, 255, 20);
            ImageKapat3.GetComponent<Image>().color = new Color32(255, 255, 255, 20);
            yield return new WaitForSeconds(0.1f);
            ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            ImageKapat2.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            ImageKapat3.GetComponent<Image>().color = new Color32(255, 255, 255, 0);






        }
        else
        {
        }



    }


}