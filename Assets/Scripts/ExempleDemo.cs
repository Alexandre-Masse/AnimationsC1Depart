using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExempleDemo : MonoBehaviour
{

    string _monNom = "Alexandre";

    bool _vraiNom = true;

    int _age = 29;

    bool _verite = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(_age);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(_verite);
    }
}
