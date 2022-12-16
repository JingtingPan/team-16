using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipette : MonoBehaviour
{
    GameObject objPlasma;
    GameObject objRed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.transform.Find("plasma").gameObject.activeSelf == true && collider.transform.Find("red").gameObject.activeSelf == true)
        {

            objPlasma = collider.transform.Find("plasma").gameObject;
            objPlasma.SetActive(false);
        }
        else if (collider.transform.Find("plasma").gameObject.activeSelf == false && collider.transform.Find("red").gameObject.activeSelf == true)
        {
            objRed = collider.transform.Find("red").gameObject;
            objRed.SetActive(false);
        }
        else if (collider.transform.Find("plasma").gameObject.activeSelf == false && collider.transform.Find("red").gameObject.activeSelf == false)
        {
            objPlasma = collider.transform.Find("plasma").gameObject;
            objPlasma.SetActive(true);
        }
            

    }
}
