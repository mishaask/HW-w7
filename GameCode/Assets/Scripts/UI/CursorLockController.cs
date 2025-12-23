using UnityEngine;

public class CursorLockController : MonoBehaviour
{
    [SerializeField] private bool lockOnStart = true;

    private void Start()
    {
        if (lockOnStart)
            LockCursor();
    }

    public void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
