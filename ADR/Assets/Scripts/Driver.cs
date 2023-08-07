using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // transform.Rotate(0, 0, -45);
        // oyun başlar başlamaz z aksisinde -45 derece dönücek
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 0.1F); // Dönmeyi sağlıyor
        transform.Translate(0, 0.01F, 0); // İleri gitmeyi sağlıyor
    }
}
