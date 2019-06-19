namespace UnityEngine.InputSystem.LowLevel
{
    public interface IInputStateCallbackReceiver
    {
        void OnNextUpdate();
        void OnEvent(InputEventPtr eventPtr);
    }
}
