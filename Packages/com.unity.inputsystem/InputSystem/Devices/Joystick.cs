using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
    internal struct JoystickState : IInputStateTypeInfo
    {
        public static FourCC kFormat => new FourCC('J', 'O', 'Y');

        [InputControl(name = "trigger", displayName = "Trigger", layout = "Button", usages = new[] { "PrimaryTrigger", "PrimaryAction", "Submit" }, bit = (int)Button.Trigger)]
        public int buttons;

        [InputControl(displayName = "Stick", layout = "Stick", usage = "Primary2DMotion", processors = "stickDeadzone")]
        public Vector2 stick;

        public enum Button
        {
            // IMPORTANT: Order has to match what is expected by DpadControl.
            HatSwitchUp,
            HatSwitchDown,
            HatSwitchLeft,
            HatSwitchRight,

            Trigger
        }

        public FourCC format => kFormat;
    }
}

namespace UnityEngine.InputSystem
{
    /// <summary>
    /// A joystick with an arbitrary number of buttons and axes.
    /// </summary>
    /// <remarks>
    /// By default comes with just a trigger, a potentially twistable
    /// stick and an optional single hatswitch.
    /// </remarks>
    [InputControlLayout(stateType = typeof(JoystickState), isGenericTypeOfDevice = true)]
    [Scripting.Preserve]
    public class Joystick : InputDevice
    {
        public ButtonControl trigger { get; private set; }
        public StickControl stick { get; private set; }

        // Optional features. These may be null.
        public AxisControl twist { get; private set; }

        public static Joystick current { get; private set; }

        protected override void FinishSetup()
        {
            // Mandatory controls.
            trigger = GetChildControl<ButtonControl>("{PrimaryTrigger}");
            stick = GetChildControl<StickControl>("{Primary2DMotion}");

            // Optional controls.
            twist = TryGetChildControl<AxisControl>("{Twist}");

            base.FinishSetup();
        }

        public override void MakeCurrent()
        {
            base.MakeCurrent();
            current = this;
        }

        protected override void OnRemoved()
        {
            base.OnRemoved();
            if (current == this)
                current = null;
        }

        private ButtonControl[] m_Buttons;
        private AxisControl[] m_Axes;
    }
}
