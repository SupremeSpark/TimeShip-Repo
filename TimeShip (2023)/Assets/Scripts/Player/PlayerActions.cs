// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerActions.inputactions'

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
                    ""type"": ""PassThrough"",
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
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""79316857-fd9f-4905-829c-4d997a5f4aac"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Steer"",
                    ""type"": ""Value"",
                    ""id"": ""025cc7b5-dcab-48d6-b4a8-afc7f00adff6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveForward"",
                    ""type"": ""Value"",
                    ""id"": ""f8433c7c-9c73-427d-a465-b16a1cfdda3d"",
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
                    ""name"": ""WASD"",
                    ""id"": ""12a9e151-5eda-4d27-b6d3-7de3b17fd553"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""78597b39-4a15-44ff-a4fd-402ae051ce8b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""af81b875-833f-4757-8f6e-c84b9b18d75e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ac33db9e-4f1e-4739-8d67-16ee047d638f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6013f8ae-1d3c-4b85-aacd-bbdf18b80391"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""82302b03-d107-4bb0-b448-70fbe5a9e515"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8cccf0b1-6854-4671-82b5-25ff0394d37e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f1d349eb-34cb-4520-9315-525040f5b881"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""ab727f84-bf59-4d10-9835-cda26b649f10"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveForward"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7c186d63-f11e-4883-9fff-0576598642c3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""902b113e-9e49-4e6e-890e-ffc1132c3662"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
        m_ShipControl_Movement = m_ShipControl.FindAction("Movement", throwIfNotFound: true);
        m_ShipControl_Steer = m_ShipControl.FindAction("Steer", throwIfNotFound: true);
        m_ShipControl_MoveForward = m_ShipControl.FindAction("MoveForward", throwIfNotFound: true);
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
    private readonly InputAction m_ShipControl_Movement;
    private readonly InputAction m_ShipControl_Steer;
    private readonly InputAction m_ShipControl_MoveForward;
    public struct ShipControlActions
    {
        private @PlayerActions m_Wrapper;
        public ShipControlActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_ShipControl_Shoot;
        public InputAction @AimMousePos => m_Wrapper.m_ShipControl_AimMousePos;
        public InputAction @Movement => m_Wrapper.m_ShipControl_Movement;
        public InputAction @Steer => m_Wrapper.m_ShipControl_Steer;
        public InputAction @MoveForward => m_Wrapper.m_ShipControl_MoveForward;
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
                @Movement.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnMovement;
                @Steer.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnSteer;
                @Steer.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnSteer;
                @Steer.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnSteer;
                @MoveForward.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnMoveForward;
                @MoveForward.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnMoveForward;
                @MoveForward.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnMoveForward;
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
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Steer.started += instance.OnSteer;
                @Steer.performed += instance.OnSteer;
                @Steer.canceled += instance.OnSteer;
                @MoveForward.started += instance.OnMoveForward;
                @MoveForward.performed += instance.OnMoveForward;
                @MoveForward.canceled += instance.OnMoveForward;
            }
        }
    }
    public ShipControlActions @ShipControl => new ShipControlActions(this);
    public interface IShipControlActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnAimMousePos(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnSteer(InputAction.CallbackContext context);
        void OnMoveForward(InputAction.CallbackContext context);
    }
}
