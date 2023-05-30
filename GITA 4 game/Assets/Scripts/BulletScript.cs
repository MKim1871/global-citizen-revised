using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
	public GameObject bulletPrefab;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
	
	private void OnCollisionEnter(Collision collision)
	{
		if (gameObject.name == "Assault Bullet(Clone)" || gameObject.name == "Pistol Bullet(Clone)")
		{
			Destroy(bulletPrefab);
		}
	}
}
