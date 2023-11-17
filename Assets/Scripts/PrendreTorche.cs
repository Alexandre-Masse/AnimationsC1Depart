using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prendre : MonoBehaviour
{
    //Start is called before the first frame update
    [SerializeField] GameObject _Torch_Wall_Player;
    [SerializeField] GameObject _Torch_Player;

    [SerializeField] GameObject _Joueur;

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            _Torch_Player.SetActive(true);
            _Torch_Wall_Player.SetActive(false); 
        }
    }

}
