using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    private Rigidbody rbody;
    private ParticleSystem particleSystem;
    private GameObject bamsongi;
    void Start()
    {
        this.rbody = this.GetComponent<Rigidbody>();
        this.particleSystem = this.GetComponent<ParticleSystem>();
        this.Shoot();
    }

    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Instantiate(this.rbody);
        }          
    }




    void OnCollisionEnter(Collision collision)
    {

            Debug.LogFormat("OnCollisionEnter: {0}", collision.gameObject.name);
            //this.rbody.isKinematic = true;

            //��ƼŬ�ý��� ������Ʈ �����ؼ� Play�޼��� ȣ�� 
            
        
        this.particleSystem.Play();
    }

    public void Shoot()
    {
        this.rbody.AddForce(new Vector3(0, 200, 2000));
    }
}
