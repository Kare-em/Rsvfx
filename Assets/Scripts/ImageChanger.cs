using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageChanger : MonoBehaviour
{
    [SerializeField] GameObject[] images;
    int currentImage;
    void Start()
    {
        StartCoroutine(ChangeImage());
        currentImage = 0;
    }
    IEnumerator ChangeImage()
    {
        while (true)
        {
            images[currentImage].SetActive(false);
            currentImage = GetCorrectIndex(currentImage + 1);
            images[currentImage].SetActive(true);
            if (currentImage == 0)
                yield return new WaitForSeconds(60f);
            else
                yield return new WaitForSeconds(20f);
        }
    }
    int GetCorrectIndex(int index)
    {
        if (index > images.Length - 1)
            return 0;
        else
            return index;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
