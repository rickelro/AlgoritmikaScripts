using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // При старте удаляет объект, к которому прикреплен скрипт
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
