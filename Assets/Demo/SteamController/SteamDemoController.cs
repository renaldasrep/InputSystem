// THIS FILE HAS BEEN AUTO-GENERATED
#if (UNITY_EDITOR || UNITY_STANDALONE) && UNITY_ENABLE_STEAM_CONTROLLER_SUPPORT
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.InputSystem.Steam;
#if UNITY_EDITOR
using UnityEditor;
#endif

#if UNITY_EDITOR
[InitializeOnLoad]
#endif
[InputControlLayout(stateType = typeof(SteamDemoControllerState))]
public class SteamDemoController : SteamController
{
    private static InputDeviceMatcher deviceMatcher
    {
        get { return new InputDeviceMatcher().WithInterface("Steam").WithProduct("SteamDemoController"); }
    }

#if UNITY_EDITOR
    static SteamDemoController()
    {
        InputSystem.RegisterLayout<SteamDemoController>(matches: deviceMatcher);
    }

#endif

    [RuntimeInitializeOnLoadMethod(loadType: RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void RuntimeInitializeOnLoad()
    {
        InputSystem.RegisterLayout<SteamDemoController>(matches: deviceMatcher);
    }

    [InputControl]
    public StickControl move { get; protected set; }
    [InputControl]
    public Vector2Control look { get; protected set; }
    [InputControl]
    public ButtonControl fire { get; protected set; }
    [InputControl]
    public ButtonControl jump { get; protected set; }
    [InputControl]
    public ButtonControl menu { get; protected set; }
    [InputControl]
    public ButtonControl steamEnterMenu { get; protected set; }
    [InputControl]
    public Vector2Control navigate { get; protected set; }
    [InputControl]
    public ButtonControl click { get; protected set; }
    [InputControl]
    public ButtonControl steamExitMenu { get; protected set; }

    protected override void FinishSetup()
    {
        base.FinishSetup();
        move = GetChildControl<StickControl>("move");
        look = GetChildControl<Vector2Control>("look");
        fire = GetChildControl<ButtonControl>("fire");
        jump = GetChildControl<ButtonControl>("jump");
        menu = GetChildControl<ButtonControl>("menu");
        steamEnterMenu = GetChildControl<ButtonControl>("steamEnterMenu");
        navigate = GetChildControl<Vector2Control>("navigate");
        click = GetChildControl<ButtonControl>("click");
        steamExitMenu = GetChildControl<ButtonControl>("steamExitMenu");
    }

    protected override void ResolveSteamActions(ISteamControllerAPI api)
    {
        gameplaySetHandle = api.GetActionSetHandle("gameplay");
        moveHandle = api.GetAnalogActionHandle("move");
        lookHandle = api.GetAnalogActionHandle("look");
        fireHandle = api.GetDigitalActionHandle("fire");
        jumpHandle = api.GetDigitalActionHandle("jump");
        menuHandle = api.GetDigitalActionHandle("menu");
        steamEnterMenuHandle = api.GetDigitalActionHandle("steamEnterMenu");
        menuSetHandle = api.GetActionSetHandle("menu");
        navigateHandle = api.GetAnalogActionHandle("navigate");
        clickHandle = api.GetDigitalActionHandle("click");
        steamExitMenuHandle = api.GetDigitalActionHandle("steamExitMenu");
    }

    public SteamHandle<InputActionMap> gameplaySetHandle { get; private set; }
    public SteamHandle<InputAction> moveHandle { get; private set; }
    public SteamHandle<InputAction> lookHandle { get; private set; }
    public SteamHandle<InputAction> fireHandle { get; private set; }
    public SteamHandle<InputAction> jumpHandle { get; private set; }
    public SteamHandle<InputAction> menuHandle { get; private set; }
    public SteamHandle<InputAction> steamEnterMenuHandle { get; private set; }
    public SteamHandle<InputActionMap> menuSetHandle { get; private set; }
    public SteamHandle<InputAction> navigateHandle { get; private set; }
    public SteamHandle<InputAction> clickHandle { get; private set; }
    public SteamHandle<InputAction> steamExitMenuHandle { get; private set; }

    private SteamActionSetInfo[] m_ActionSets;
    public override ReadOnlyArray<SteamActionSetInfo> steamActionSets
    {
        get
        {
            if (m_ActionSets == null)
                m_ActionSets = new[]
                {
                    new SteamActionSetInfo { name = "gameplay", handle = gameplaySetHandle },
                    new SteamActionSetInfo { name = "menu", handle = menuSetHandle },
                };
            return new ReadOnlyArray<SteamActionSetInfo>(m_ActionSets);
        }
    }

    protected override unsafe void Update(ISteamControllerAPI api)
    {
        SteamDemoControllerState state;
        state.move = api.GetAnalogActionData(steamControllerHandle, moveHandle).position;
        state.look = api.GetAnalogActionData(steamControllerHandle, lookHandle).position;
        if (api.GetDigitalActionData(steamControllerHandle, fireHandle).pressed)
            state.buttons[0] |= 0;
        if (api.GetDigitalActionData(steamControllerHandle, jumpHandle).pressed)
            state.buttons[0] |= 1;
        if (api.GetDigitalActionData(steamControllerHandle, menuHandle).pressed)
            state.buttons[0] |= 2;
        if (api.GetDigitalActionData(steamControllerHandle, steamEnterMenuHandle).pressed)
            state.buttons[0] |= 3;
        state.navigate = api.GetAnalogActionData(steamControllerHandle, navigateHandle).position;
        if (api.GetDigitalActionData(steamControllerHandle, clickHandle).pressed)
            state.buttons[0] |= 4;
        if (api.GetDigitalActionData(steamControllerHandle, steamExitMenuHandle).pressed)
            state.buttons[0] |= 5;
        InputSystem.QueueStateEvent(this, state);
    }
}
public unsafe struct SteamDemoControllerState : IInputStateTypeInfo
{
    public FourCC format
    {
        get
        {
            return new FourCC('S', 't', 'e', 'a');
        }
    }

    [InputControl(name = "fire", layout = "Button", bit = 0)]
    [InputControl(name = "jump", layout = "Button", bit = 1)]
    [InputControl(name = "menu", layout = "Button", bit = 2)]
    [InputControl(name = "steamEnterMenu", layout = "Button", bit = 3)]
    [InputControl(name = "click", layout = "Button", bit = 4)]
    [InputControl(name = "steamExitMenu", layout = "Button", bit = 5)]
    public fixed byte buttons[1];
    [InputControl(name = "move", layout = "Stick")]
    public Vector2 move;
    [InputControl(name = "look", layout = "Vector2")]
    public Vector2 look;
    [InputControl(name = "navigate", layout = "Vector2")]
    public Vector2 navigate;
}
#endif
