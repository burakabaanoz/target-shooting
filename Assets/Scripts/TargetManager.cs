using UnityEngine;

public class TargetManager : MonoBehaviour
{

    
    private void OnEnable()
    {
        Target.TargetClicked += OnTargetClicked;
    }

    private void OnDisable()
    {
        Target.TargetClicked -= OnTargetClicked;
    }
    void OnTargetClicked()
    {
        Debug.Log("Hedefe Vuruldu");
    }
}
