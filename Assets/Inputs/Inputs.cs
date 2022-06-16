//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Inputs/Inputs.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Inputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputs"",
    ""maps"": [
        {
            ""name"": ""Map"",
            ""id"": ""9f00d8a6-89b9-4332-8882-6ab6c623a7d0"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""e4c46af1-4ddb-406d-87f4-881ee1eb8e3b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveAxisH"",
                    ""type"": ""Value"",
                    ""id"": ""e58fcea2-1eac-43e1-8bc5-5356dccbd670"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveAxisV"",
                    ""type"": ""Value"",
                    ""id"": ""340839e3-82b0-46ae-8be0-608088119698"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""aa7db323-699c-4878-be18-7dd5d67f2e65"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""49aa0a4c-017b-4be7-9aab-1b774b9cf211"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""732781c3-a755-43bf-910f-2b8d94c14503"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""39cd908a-452a-4dbd-b521-3f2083cf56ca"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""41994f04-5cd4-4436-a55e-7da6314359c0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5f208eb6-d789-4118-a731-f2afcedf768d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow Keyboard"",
                    ""id"": ""b5c64c99-f92f-4b5b-a336-cedc2ea37600"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c769695c-2e9f-44f1-b62f-d90a57802385"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8b695ad6-b51d-4a34-8c9e-379bf2cf71bb"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f913de10-df47-4925-b053-9dba5d3ffa5b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bcc591b1-5fad-4403-9725-3666c6d47280"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""efd5cb73-95a4-49ea-acaf-ef599ffad832"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAxisH"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f08da888-e88e-4a41-83f3-71cbd52bf3ff"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAxisH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""04b9fa0a-3744-4b21-ac41-1757fd338ca6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAxisH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow"",
                    ""id"": ""bac61fb7-d7c1-4218-9f30-8bd174eef194"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAxisH"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e8d9f1bd-fcad-4d83-bdfe-99ed68f5706b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAxisH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""07dbf2b4-d54c-4962-afc9-d5fd4a2a9adc"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAxisH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""10e91b57-5ec3-4b6b-93c4-85c67b45abdb"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAxisH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Vertical"",
                    ""id"": ""863b0752-769e-4a35-8023-7fd1ce8f20f6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAxisV"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4f88a39c-f231-4d1e-95a3-0595b7ef9248"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAxisV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e5da0961-c357-4fb4-8c63-a35b4bf7bfc2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAxisV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow"",
                    ""id"": ""76597ea8-b6d0-4612-8cd5-bed8d62d9601"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAxisV"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""50917662-e033-45df-8491-b077c96c5979"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAxisV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""65b1984d-7747-4fdc-a2ae-e002af89c90e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAxisV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ed4dc2b1-e9cd-4702-bef3-4eb18a138547"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAxisV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""StateMachineTests"",
            ""id"": ""447c26e2-64d4-4dff-a601-f8d24241cd5c"",
            ""actions"": [
                {
                    ""name"": ""Space"",
                    ""type"": ""Button"",
                    ""id"": ""1d4a3977-2680-4618-9c12-dd527b190785"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5d964076-a6f6-4191-9c85-4ff69af224d6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Space"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Map
        m_Map = asset.FindActionMap("Map", throwIfNotFound: true);
        m_Map_Move = m_Map.FindAction("Move", throwIfNotFound: true);
        m_Map_MoveAxisH = m_Map.FindAction("MoveAxisH", throwIfNotFound: true);
        m_Map_MoveAxisV = m_Map.FindAction("MoveAxisV", throwIfNotFound: true);
        // StateMachineTests
        m_StateMachineTests = asset.FindActionMap("StateMachineTests", throwIfNotFound: true);
        m_StateMachineTests_Space = m_StateMachineTests.FindAction("Space", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Map
    private readonly InputActionMap m_Map;
    private IMapActions m_MapActionsCallbackInterface;
    private readonly InputAction m_Map_Move;
    private readonly InputAction m_Map_MoveAxisH;
    private readonly InputAction m_Map_MoveAxisV;
    public struct MapActions
    {
        private @Inputs m_Wrapper;
        public MapActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Map_Move;
        public InputAction @MoveAxisH => m_Wrapper.m_Map_MoveAxisH;
        public InputAction @MoveAxisV => m_Wrapper.m_Map_MoveAxisV;
        public InputActionMap Get() { return m_Wrapper.m_Map; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MapActions set) { return set.Get(); }
        public void SetCallbacks(IMapActions instance)
        {
            if (m_Wrapper.m_MapActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MapActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MapActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MapActionsCallbackInterface.OnMove;
                @MoveAxisH.started -= m_Wrapper.m_MapActionsCallbackInterface.OnMoveAxisH;
                @MoveAxisH.performed -= m_Wrapper.m_MapActionsCallbackInterface.OnMoveAxisH;
                @MoveAxisH.canceled -= m_Wrapper.m_MapActionsCallbackInterface.OnMoveAxisH;
                @MoveAxisV.started -= m_Wrapper.m_MapActionsCallbackInterface.OnMoveAxisV;
                @MoveAxisV.performed -= m_Wrapper.m_MapActionsCallbackInterface.OnMoveAxisV;
                @MoveAxisV.canceled -= m_Wrapper.m_MapActionsCallbackInterface.OnMoveAxisV;
            }
            m_Wrapper.m_MapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @MoveAxisH.started += instance.OnMoveAxisH;
                @MoveAxisH.performed += instance.OnMoveAxisH;
                @MoveAxisH.canceled += instance.OnMoveAxisH;
                @MoveAxisV.started += instance.OnMoveAxisV;
                @MoveAxisV.performed += instance.OnMoveAxisV;
                @MoveAxisV.canceled += instance.OnMoveAxisV;
            }
        }
    }
    public MapActions @Map => new MapActions(this);

    // StateMachineTests
    private readonly InputActionMap m_StateMachineTests;
    private IStateMachineTestsActions m_StateMachineTestsActionsCallbackInterface;
    private readonly InputAction m_StateMachineTests_Space;
    public struct StateMachineTestsActions
    {
        private @Inputs m_Wrapper;
        public StateMachineTestsActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Space => m_Wrapper.m_StateMachineTests_Space;
        public InputActionMap Get() { return m_Wrapper.m_StateMachineTests; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(StateMachineTestsActions set) { return set.Get(); }
        public void SetCallbacks(IStateMachineTestsActions instance)
        {
            if (m_Wrapper.m_StateMachineTestsActionsCallbackInterface != null)
            {
                @Space.started -= m_Wrapper.m_StateMachineTestsActionsCallbackInterface.OnSpace;
                @Space.performed -= m_Wrapper.m_StateMachineTestsActionsCallbackInterface.OnSpace;
                @Space.canceled -= m_Wrapper.m_StateMachineTestsActionsCallbackInterface.OnSpace;
            }
            m_Wrapper.m_StateMachineTestsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Space.started += instance.OnSpace;
                @Space.performed += instance.OnSpace;
                @Space.canceled += instance.OnSpace;
            }
        }
    }
    public StateMachineTestsActions @StateMachineTests => new StateMachineTestsActions(this);
    public interface IMapActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMoveAxisH(InputAction.CallbackContext context);
        void OnMoveAxisV(InputAction.CallbackContext context);
    }
    public interface IStateMachineTestsActions
    {
        void OnSpace(InputAction.CallbackContext context);
    }
}
