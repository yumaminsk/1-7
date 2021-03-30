using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject Light;
    public GameObject Lantern;
    public GameObject Lantern2;
    [SerializeField] GameObject bloodWall;
    bool isRotateLight = false;
    private void OnTriggerExit(Collider other)
    {
        int a = UnityEngine.Random.Range(0, 3);
        print(a);
        if (a == 0) { LightMetod(); }
        if (a == 1) { LanternMetod(); }
        if (a == 2) { RotateLight(); }

    }

    void Update()
    {
        if (isRotateLight == true)
        {
                Lantern2.transform.Rotate(Lantern2.transform.rotation.x, Lantern2.transform.rotation.y + 3f, Lantern2.transform.rotation.z);
        }
        
    }
    void LanternMetod()
    {
        StartCoroutine(LanternCoroutine());
        IEnumerator LanternCoroutine()
        {
            
            yield return new WaitForSeconds(0.5f);
            Lantern.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            Lantern.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            Lantern.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            Lantern.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            Lantern.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            Lantern.SetActive(false);   
        }
    }

    void LightMetod()
    {
        StartCoroutine(Crqw());
        IEnumerator Crqw()
        {
            bloodWall.SetActive(true);
            yield return new WaitForSeconds(1f);
            Light.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            Light.SetActive(false);
            yield return new WaitForSeconds(0.2f);
            Light.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            Light.SetActive(false);
            yield return new WaitForSeconds(0.2f);
            Light.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            Light.SetActive(false);
            bloodWall.SetActive(false);
        }
    }
    void RotateLight()
    {
        isRotateLight = true;
        StartCoroutine(RotationLanter2());
        IEnumerator RotationLanter2()
        {
            Lantern2.SetActive(true);
            yield return new WaitForSeconds(1f);
            Lantern2.SetActive(false);
            isRotateLight = false;
        }
    }
}
