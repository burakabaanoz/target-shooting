using UnityEngine;
using System;
public class Target : MonoBehaviour
{
    public static event Action TargetClicked;

    void OnMouseDown()
    {
        TargetClicked?.Invoke();
        Destroy(gameObject); // bu obje yok olduðunda ben yok oldum demeli veya baþka bir script yok olduðunu zaten bilmeli
        
        
    }
}
