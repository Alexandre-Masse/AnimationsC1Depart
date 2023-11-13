using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvrirPorte : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject _porteDroite;
    [SerializeField] GameObject _porteGauche;

    [SerializeField] GameObject _Joueur;
    void Start()
    {
        Debug.Log(_porteDroite);
        Debug.Log(_porteGauche);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _porteGauche.GetComponent<Animator>().SetBool("Ouvre", true);
            _porteDroite.GetComponent<Animator>().SetBool("Ouvre", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _porteGauche.GetComponent<Animator>().SetBool("Ouvre", false);
            _porteDroite.GetComponent<Animator>().SetBool("Ouvre", false);
        }
    }
}
