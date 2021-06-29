// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Mouse"",
            ""id"": ""7a29242e-74db-49bf-967f-ccf81ffc90a5"",
            ""actions"": [
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""4a2a198d-5622-41f6-9e97-47c23bcba732"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""Button"",
                    ""id"": ""73f1cf55-6044-41b5-bc1e-eb50a9477fc4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CursorPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5f5cd69d-4a1a-4e1d-a514-cecfe1ad56f6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""Value"",
                    ""id"": ""e2a087bf-c2d7-4ccb-91c1-1597ce5ce8e9"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Yaw"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a435e4a9-0360-41b4-9b63-20079546dce2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""Button"",
                    ""id"": ""d8ddd220-3801-4b2b-9a8a-9cd6266150d6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""361ca933-2ef3-4613-8f05-633ff8f7b58d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07b4abf8-cffb-49c4-a9ff-49315057255f"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CursorPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d305759b-90ea-40b9-954b-0bd873d77ca7"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa7f1083-f6c1-4eb3-b2bb-b615f2f56509"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23f7595c-6268-400f-8d41-161b7cf81780"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80ac8b12-96f3-4c66-b250-1068ce560f23"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""id"": ""5e1de1ce-9dcd-4a78-8c14-e5aae4c069f3"",
            ""actions"": [
                {
                    ""name"": ""InventoryToggle"",
                    ""type"": ""Button"",
                    ""id"": ""4d9e24f3-e098-4454-9f24-0ebde313672c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f5caf911-822a-46fd-824c-12c76f7bf5c4"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InventoryToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_LeftClick = m_Mouse.FindAction("LeftClick", throwIfNotFound: true);
        m_Mouse_RightClick = m_Mouse.FindAction("RightClick", throwIfNotFound: true);
        m_Mouse_CursorPosition = m_Mouse.FindAction("CursorPosition", throwIfNotFound: true);
        m_Mouse_ScrollWheel = m_Mouse.FindAction("ScrollWheel", throwIfNotFound: true);
        m_Mouse_Yaw = m_Mouse.FindAction("Yaw", throwIfNotFound: true);
        m_Mouse_MiddleClick = m_Mouse.FindAction("MiddleClick", throwIfNotFound: true);
        // Keyboard
        m_Keyboard = asset.FindActionMap("Keyboard", throwIfNotFound: true);
        m_Keyboard_InventoryToggle = m_Keyboard.FindAction("InventoryToggle", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Mouse
    private readonly InputActionMap m_Mouse;
    private IMouseActions m_MouseActionsCallbackInterface;
    private readonly InputAction m_Mouse_LeftClick;
    private readonly InputAction m_Mouse_RightClick;
    private readonly InputAction m_Mouse_CursorPosition;
    private readonly InputAction m_Mouse_ScrollWheel;
    private readonly InputAction m_Mouse_Yaw;
    private readonly InputAction m_Mouse_MiddleClick;
    public struct MouseActions
    {
        private @Controls m_Wrapper;
        public MouseActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftClick => m_Wrapper.m_Mouse_LeftClick;
        public InputAction @RightClick => m_Wrapper.m_Mouse_RightClick;
        public InputAction @CursorPosition => m_Wrapper.m_Mouse_CursorPosition;
        public InputAction @ScrollWheel => m_Wrapper.m_Mouse_ScrollWheel;
        public InputAction @Yaw => m_Wrapper.m_Mouse_Yaw;
        public InputAction @MiddleClick => m_Wrapper.m_Mouse_MiddleClick;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterface != null)
            {
                @LeftClick.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnLeftClick;
                @RightClick.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnRightClick;
                @CursorPosition.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnCursorPosition;
                @CursorPosition.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnCursorPosition;
                @CursorPosition.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnCursorPosition;
                @ScrollWheel.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnScrollWheel;
                @Yaw.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnYaw;
                @Yaw.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnYaw;
                @Yaw.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnYaw;
                @MiddleClick.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMiddleClick;
            }
            m_Wrapper.m_MouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @CursorPosition.started += instance.OnCursorPosition;
                @CursorPosition.performed += instance.OnCursorPosition;
                @CursorPosition.canceled += instance.OnCursorPosition;
                @ScrollWheel.started += instance.OnScrollWheel;
                @ScrollWheel.performed += instance.OnScrollWheel;
                @ScrollWheel.canceled += instance.OnScrollWheel;
                @Yaw.started += instance.OnYaw;
                @Yaw.performed += instance.OnYaw;
                @Yaw.canceled += instance.OnYaw;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
            }
        }
    }
    public MouseActions @Mouse => new MouseActions(this);

    // Keyboard
    private readonly InputActionMap m_Keyboard;
    private IKeyboardActions m_KeyboardActionsCallbackInterface;
    private readonly InputAction m_Keyboard_InventoryToggle;
    public struct KeyboardActions
    {
        private @Controls m_Wrapper;
        public KeyboardActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @InventoryToggle => m_Wrapper.m_Keyboard_InventoryToggle;
        public InputActionMap Get() { return m_Wrapper.m_Keyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardActions instance)
        {
            if (m_Wrapper.m_KeyboardActionsCallbackInterface != null)
            {
                @InventoryToggle.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnInventoryToggle;
                @InventoryToggle.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnInventoryToggle;
                @InventoryToggle.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnInventoryToggle;
            }
            m_Wrapper.m_KeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @InventoryToggle.started += instance.OnInventoryToggle;
                @InventoryToggle.performed += instance.OnInventoryToggle;
                @InventoryToggle.canceled += instance.OnInventoryToggle;
            }
        }
    }
    public KeyboardActions @Keyboard => new KeyboardActions(this);
    public interface IMouseActions
    {
        void OnLeftClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnCursorPosition(InputAction.CallbackContext context);
        void OnScrollWheel(InputAction.CallbackContext context);
        void OnYaw(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
    }
    public interface IKeyboardActions
    {
        void OnInventoryToggle(InputAction.CallbackContext context);
    }
}
