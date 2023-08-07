using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    public float steerSpeed = 0.1F;
    public float moveSpeed = 0.01F;

    // Start is called before the first frame update
    void Start()
    {
        // transform.Rotate(0, 0, -45);
        // oyun başlar başlamaz z aksisinde -45 derece dönücek
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, steerSpeed); // Dönmeyi sağlıyor
        transform.Translate(0, moveSpeed, 0); // İleri gitmeyi sağlıyor
    }
}
