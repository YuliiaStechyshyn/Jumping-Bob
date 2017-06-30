using UnityEngine;

public class GestureHandler : MonoBehaviour
{
    private Frog _frog;
    private float _holdStart;


    public void OnHoldStart()
    {
        _holdStart = Time.timeSinceLevelLoad;
    }

    public void OnHoldEnd()
    {
        _frog = FindObjectOfType<Frog>();
        _frog.Jump(Time.timeSinceLevelLoad - _holdStart);
    }
}