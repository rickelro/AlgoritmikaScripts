using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrimitives : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // оздает новый игровой объект (GameObject) в сцене с примитивом типа "Куб"
        // .transform - получает доступ к компоненту Transform созданного куба
        // .position = new Vector3(x, y, z) - устанавливает позицию созданного куба
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position =new Vector3(0, 0, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-0.5f, 1, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0.5f, 1, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0.5f, 2, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-0.5f, 2, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
