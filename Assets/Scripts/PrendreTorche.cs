using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrendreTorche : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject _Torch_Wall_Player;
    [SerializeField] GameObject _Torch_Player;

    [SerializeField] GameObject _Joueur;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           
    }
    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            _Torch_Player.SetActive(true);
            _Torch_Wall_Player.SetActive(false); 
        }
    }
}
