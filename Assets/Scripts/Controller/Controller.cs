// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controller/Controller.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controller : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controller"",
    ""maps"": [
        {
            ""name"": ""Controls"",
            ""id"": ""b27e42dd-1ef6-4e9b-ac37-2f32bd699275"",
            ""actions"": [
                {
                    ""name"": ""PlayerMovements"",
                    ""type"": ""PassThrough"",
                    ""id"": ""04ac00af-7e50-4866-b008-c5226b5dd8a2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BoatMovements"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9e3ae14b-ab42-4eca-81a7-8f11f34b106c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayerInteraction"",
                    ""type"": ""Button"",
                    ""id"": ""699e44a5-b181-499c-b086-1bb39970eaa4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ZQSD"",
                    ""id"": ""9415348a-4bfd-4c97-9c66-0a6293d8af36"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovements"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9d9101eb-9f38-4aae-8c66-ce6745ecbdeb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""PlayerMovements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a7674b91-de4b-4da8-a46f-52fc4c84a967"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""PlayerMovements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6e918926-0869-4dbc-882c-8a79f04e4e6c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""PlayerMovements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cedb0feb-dc0a-4121-b10f-bc2c200c0c12"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""PlayerMovements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""076a8b10-4f10-49f4-a4e5-b85a476d6d81"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""PlayerMovements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""86801f63-810f-4511-94fa-854826542fe1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BoatMovements"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c7e8062c-4da1-4648-8f70-5ec6983f23c9"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""BoatMovements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3bbbea0d-29d2-4032-b737-c0c65e7934cc"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""BoatMovements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2a36bc7b-5c6a-47cf-822f-c365b7ecf361"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""BoatMovements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6231ded2-8810-4c76-a8d7-aecd6a262561"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""BoatMovements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b33c6f87-e38f-47d4-a1f8-5220bf572cbb"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""PlayerInteraction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6dcd6c43-942d-4188-b594-0f1ed881bdfc"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""PlayerInteraction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Controls
        m_Controls = asset.FindActionMap("Controls", throwIfNotFound: true);
        m_Controls_PlayerMovements = m_Controls.FindAction("PlayerMovements", throwIfNotFound: true);
        m_Controls_BoatMovements = m_Controls.FindAction("BoatMovements", throwIfNotFound: true);
        m_Controls_PlayerInteraction = m_Controls.FindAction("PlayerInteraction", throwIfNotFound: true);
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

    // Controls
    private readonly InputActionMap m_Controls;
    private IControlsActions m_ControlsActionsCallbackInterface;
    private readonly InputAction m_Controls_PlayerMovements;
    private readonly InputAction m_Controls_BoatMovements;
    private readonly InputAction m_Controls_PlayerInteraction;
    public struct ControlsActions
    {
        private @Controller m_Wrapper;
        public ControlsActions(@Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlayerMovements => m_Wrapper.m_Controls_PlayerMovements;
        public InputAction @BoatMovements => m_Wrapper.m_Controls_BoatMovements;
        public InputAction @PlayerInteraction => m_Wrapper.m_Controls_PlayerInteraction;
        public InputActionMap Get() { return m_Wrapper.m_Controls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControlsActions set) { return set.Get(); }
        public void SetCallbacks(IControlsActions instance)
        {
            if (m_Wrapper.m_ControlsActionsCallbackInterface != null)
            {
                @PlayerMovements.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnPlayerMovements;
                @PlayerMovements.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnPlayerMovements;
                @PlayerMovements.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnPlayerMovements;
                @BoatMovements.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnBoatMovements;
                @BoatMovements.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnBoatMovements;
                @BoatMovements.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnBoatMovements;
                @PlayerInteraction.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnPlayerInteraction;
                @PlayerInteraction.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnPlayerInteraction;
                @PlayerInteraction.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnPlayerInteraction;
            }
            m_Wrapper.m_ControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PlayerMovements.started += instance.OnPlayerMovements;
                @PlayerMovements.performed += instance.OnPlayerMovements;
                @PlayerMovements.canceled += instance.OnPlayerMovements;
                @BoatMovements.started += instance.OnBoatMovements;
                @BoatMovements.performed += instance.OnBoatMovements;
                @BoatMovements.canceled += instance.OnBoatMovements;
                @PlayerInteraction.started += instance.OnPlayerInteraction;
                @PlayerInteraction.performed += instance.OnPlayerInteraction;
                @PlayerInteraction.canceled += instance.OnPlayerInteraction;
            }
        }
    }
    public ControlsActions @Controls => new ControlsActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    public interface IControlsActions
    {
        void OnPlayerMovements(InputAction.CallbackContext context);
        void OnBoatMovements(InputAction.CallbackContext context);
        void OnPlayerInteraction(InputAction.CallbackContext context);
    }
}
