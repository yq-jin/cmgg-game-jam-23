using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidableObject : MonoBehaviour
{
    private Collider2D z_Collider;
    [SerializeField]
    private ContactFilter2D z_filter;
    private List<Collider2D> z_CollidedObjects = new List<Collider2D>(1);

    // Start is called before the first frame update
    void Start()
    {
        z_Collider = GetComponent<Collider2D>();
    
    }
    // Update is called once per frame
    void Update()
    {
        z_Collider.OverlapCollider(z_filter, z_CollidedObjects);
        foreach(var o in z_CollidedObjects)
        {
            Debug.Log("Colided with " + o.name);
        }
    }
}
