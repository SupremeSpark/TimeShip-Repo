// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player/PlayerActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""ShipControl"",
            ""id"": ""bbef28d0-bcf2-43b8-99b4-ef104f3119ca"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""8dbe7dd6-8e5e-42ed-b8c9-9dcb5a31b2ba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AimMousePos"",
                    ""type"": ""Value"",
                    ""id"": ""f9fe995b-7983-4214-b04d-197251667360"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MovementZ"",
                    ""type"": ""Value"",
                    ""id"": ""79316857-fd9f-4905-829c-4d997a5f4aac"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MovementX"",
                    ""type"": ""Value"",
                    ""id"": ""7f3b90e0-2df0-4d54-a710-f02e0b72e4c5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""f5df05cc-516b-4be2-adaa-2bb603418ee6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Loop/Die"",
                    ""type"": ""Button"",
                    ""id"": ""dbb543bc-8d4e-430a-a2a5-5495e76f6ea4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Hard reset"",
                    ""type"": ""Button"",
                    ""id"": ""df7e2e48-fe63-4dc0-b2fd-25a133cd13c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Main menu"",
                    ""type"": ""Button"",
                    ""id"": ""30108795-14e7-4512-a723-6ff0b4a06548"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b2f28ec8-2e96-453d-9404-423db59a35c6"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc008f41-8bfa-4ecf-a20c-55aca1c2885d"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimMousePos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""befd6955-ae63-483f-8496-ad1bbab36d2c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementZ"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c2813b7c-e690-4039-b580-ab22f48e8de3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""72a23b5c-5d2a-4b93-a8af-75b858804f41"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""7b76df7b-cc24-4c90-b408-290d57986c48"",
                    ""path"": ""1DAxis(whichSideWins=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""f1b8bfd0-f475-47ca-9292-d5e53a235030"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""d943e2c2-c214-43f8-b295-ec8c5e473368"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e1067ad3-c02f-4c50-9d56-07f9630a3eaf"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6549155b-56be-4fdc-b429-112e341f2211"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""97380225-79ab-4ae9-b482-de2ec9b6ae70"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""be1f488d-514b-468a-b9cb-f897ad995b0a"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Loop/Die"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb39dd64-be14-4627-ba4f-0fc9a7f1bf5c"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hard reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d91e718-775b-4d41-8023-383cd7e72c78"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Main menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ShipControl
        m_ShipControl = asset.FindActionMap("ShipControl", throwIfNotFound: true);
        m_ShipControl_Shoot = m_ShipControl.FindAction("Shoot", throwIfNotFound: true);
        m_ShipControl_AimMousePos = m_ShipControl.FindAction("AimMousePos", throwIfNotFound: true);
        m_ShipControl_MovementZ = m_ShipControl.FindAction("MovementZ", throwIfNotFound: true);
        m_ShipControl_MovementX = m_ShipControl.FindAction("MovementX", throwIfNotFound: true);
        m_ShipControl_Movement = m_ShipControl.FindAction("Movement", throwIfNotFound: true);
        m_ShipControl_LoopDie = m_ShipControl.FindAction("Loop/Die", throwIfNotFound: true);
        m_ShipControl_Hardreset = m_ShipControl.FindAction("Hard reset", throwIfNotFound: true);
        m_ShipControl_Mainmenu = m_ShipControl.FindAction("Main menu", throwIfNotFound: true);
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

    // ShipControl
    private readonly InputActionMap m_ShipControl;
    private IShipControlActions m_ShipControlActionsCallbackInterface;
    private readonly InputAction m_ShipControl_Shoot;
    private readonly InputAction m_ShipControl_AimMousePos;
    private readonly InputAction m_ShipControl_MovementZ;
    private readonly InputAction m_ShipControl_MovementX;
    private readonly InputAction m_ShipControl_Movement;
    private readonly InputAction m_ShipControl_LoopDie;
    private readonly InputAction m_ShipControl_Hardreset;
    private readonly InputAction m_ShipControl_Mainmenu;
    public struct ShipControlActions
    {
        private @PlayerActions m_Wrapper;
        public ShipControlActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_ShipControl_Shoot;
        public InputAction @AimMousePos => m_Wrapper.m_ShipControl_AimMousePos;
        public InputAction @MovementZ => m_Wrapper.m_ShipControl_MovementZ;
        public InputAction @MovementX => m_Wrapper.m_ShipControl_MovementX;
        public InputAction @Movement => m_Wrapper.m_ShipControl_Movement;
        public InputAction @LoopDie => m_Wrapper.m_ShipControl_LoopDie;
        public InputAction @Hardreset => m_Wrapper.m_ShipControl_Hardreset;
        public InputAction @Mainmenu => m_Wrapper.m_ShipControl_Mainmenu;
        public InputActionMap Get() { return m_Wrapper.m_ShipControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShipControlActions set) { return set.Get(); }
        public void SetCallbacks(IShipControlActions instance)
        {
            if (m_Wrapper.m_ShipControlActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnShoot;
                @AimMousePos.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnAimMousePos;
                @AimMousePos.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnAimMousePos;
                @AimMousePos.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnAimMousePos;
                @MovementZ.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnMovementZ;
                @MovementZ.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnMovementZ;
                @MovementZ.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnMovementZ;
                @MovementX.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnMovementX;
                @MovementX.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnMovementX;
                @MovementX.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnMovementX;
                @Movement.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnMovement;
                @LoopDie.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnLoopDie;
                @LoopDie.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnLoopDie;
                @LoopDie.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnLoopDie;
                @Hardreset.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnHardreset;
                @Hardreset.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnHardreset;
                @Hardreset.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnHardreset;
                @Mainmenu.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnMainmenu;
                @Mainmenu.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnMainmenu;
                @Mainmenu.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnMainmenu;
            }
            m_Wrapper.m_ShipControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @AimMousePos.started += instance.OnAimMousePos;
                @AimMousePos.performed += instance.OnAimMousePos;
                @AimMousePos.canceled += instance.OnAimMousePos;
                @MovementZ.started += instance.OnMovementZ;
                @MovementZ.performed += instance.OnMovementZ;
                @MovementZ.canceled += instance.OnMovementZ;
                @MovementX.started += instance.OnMovementX;
                @MovementX.performed += instance.OnMovementX;
                @MovementX.canceled += instance.OnMovementX;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @LoopDie.started += instance.OnLoopDie;
                @LoopDie.performed += instance.OnLoopDie;
                @LoopDie.canceled += instance.OnLoopDie;
                @Hardreset.started += instance.OnHardreset;
                @Hardreset.performed += instance.OnHardreset;
                @Hardreset.canceled += instance.OnHardreset;
                @Mainmenu.started += instance.OnMainmenu;
                @Mainmenu.performed += instance.OnMainmenu;
                @Mainmenu.canceled += instance.OnMainmenu;
            }
        }
    }
    public ShipControlActions @ShipControl => new ShipControlActions(this);
    public interface IShipControlActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnAimMousePos(InputAction.CallbackContext context);
        void OnMovementZ(InputAction.CallbackContext context);
        void OnMovementX(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnLoopDie(InputAction.CallbackContext context);
        void OnHardreset(InputAction.CallbackContext context);
        void OnMainmenu(InputAction.CallbackContext context);
    }
}
