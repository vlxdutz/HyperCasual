using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   private Rigidbody _rb;

   Vector3 _pos = new Vector3(0, 0, 0);

   private void Awake() {
    _rb = GetComponent<Rigidbody>();
   }

    public float ForceStrenght = 10f;

    //forta de deplasare inainte
    public float Speed = 1000f;

    // Referinta pentru obiectul pe care il rotim
    public Transform VisualTarget;

    private float _targetRotation;

    // Update is called once per frame
    void Update()
    {
        // Citim input pe orizontala
        float horizontal = Input.GetAxis("Horizontal");

        _pos.x = horizontal * ForceStrenght;  

        _targetRotation = -horizontal * 0.5f;

        _rb.AddForce(_pos, ForceMode.Impulse);
        _rb.AddForce(new Vector3(0, 0, 1f) * Speed);

        // Adaugam rotatia la obiect
        VisualTarget.localRotation = Quaternion.Lerp(VisualTarget.localRotation, new Quaternion(0f, 0f, _targetRotation, 1f), 0.04f);
    }
}
