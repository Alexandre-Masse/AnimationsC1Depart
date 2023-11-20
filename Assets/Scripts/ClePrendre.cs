using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClePrendre : MonoBehaviour
{

    [SerializeField] GameObject _Cle;
    [SerializeField] GameObject _Player;
    [SerializeField] GameObject _Porte;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
           
            _Cle.SetActive(false);
            _Porte.GetComponent<Animator>().SetBool("Porte", true);
        }
    }
}
