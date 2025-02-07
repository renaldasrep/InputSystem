namespace UnityEngine.InputSystem.Processors
{
    [Scripting.Preserve]
    internal class NormalizeVector2Processor : InputProcessor<Vector2>
    {
        public override Vector2 Process(Vector2 value, InputControl<Vector2> control)
        {
            return value.normalized;
        }
    }
}
