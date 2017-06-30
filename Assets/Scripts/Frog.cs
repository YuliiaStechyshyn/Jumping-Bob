using UnityEngine;

public class Frog : MonoBehaviour
{
    public float MaxJumpPower = 0.85f;
    public float MinJumpPower = 0.1f;

    private const float JumpFactor = 7;
    private Rigidbody _rigidbody;
    private bool _canJump;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Jump(float power)
    {
        if (!_canJump) return;
        var clampedPower = Mathf.Sqrt(Mathf.Clamp(power, MinJumpPower, MaxJumpPower));
        var jumpVelocity = new Vector3(clampedPower, clampedPower) * JumpFactor;
        _rigidbody.velocity = jumpVelocity;
        _canJump = false;
    }

    private void OnCollisionEnter(Collision other)
    {
        var otherParent = other.gameObject.transform.parent;
        _canJump = otherParent && otherParent.GetComponent<Lilia>();
        Debug.Log(_canJump);
    }
}