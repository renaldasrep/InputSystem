// GENERATED AUTOMATICALLY FROM 'Assets/TouchSamples/ControlMaps/PointerControls.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace InputSamples.Controls
{
    public class PointerControls : IInputActionCollection
    {
        private InputActionAsset asset;
        public PointerControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PointerControls"",
    ""maps"": [
        {
            ""name"": ""pointer"",
            ""id"": ""3c570214-6b14-44a9-8e61-3e4dc9ac469f"",
            ""actions"": [
                {
                    ""name"": ""point"",
                    ""type"": ""Value"",
                    ""id"": ""4d610105-c5af-439c-8a02-4f1976d8da67"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""MouseAndPen"",
                    ""id"": ""6503119b-11d7-4b61-9465-8ab83699a36c"",
                    ""path"": ""PointerInput"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""point"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""contact"",
                    ""id"": ""33cce31d-cbc6-4899-8781-9ab727534e60"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Mouse"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""contact"",
                    ""id"": ""418f64e8-359e-4b05-8869-c8a1165e44d9"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Pen"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""position"",
                    ""id"": ""60ae03ce-5f16-4763-9102-400558002a23"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Mouse"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""position"",
                    ""id"": ""4d35537c-6a23-4f4a-bad4-eaeed0a67248"",
                    ""path"": ""<Pen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Pen"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""tilt"",
                    ""id"": ""e14524a1-8951-4672-98aa-49fda32a7548"",
                    ""path"": ""<Pen>/tilt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Pen"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""pressure"",
                    ""id"": ""ce154ce8-174d-4bbf-adb7-4f8634b86a24"",
                    ""path"": ""<Pen>/pressure"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Pen"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""twist"",
                    ""id"": ""8f871c6e-49c6-4e0b-9d0f-65263a53ac84"",
                    ""path"": ""<Pen>/twist"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Pen"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Touch0"",
                    ""id"": ""f5819de4-b7e5-4745-9d93-2b45e9dad897"",
                    ""path"": ""PointerInput"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""point"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""contact"",
                    ""id"": ""a0baebac-8b22-4db8-9cf9-7ba8c4d8aab0"",
                    ""path"": ""<Touchscreen>/touch0/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""position"",
                    ""id"": ""79b4615b-9534-4aa7-af27-90a442add4bc"",
                    ""path"": ""<Touchscreen>/touch0/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""radius"",
                    ""id"": ""07bde460-f80a-45ae-823d-db51f6bda4bb"",
                    ""path"": ""<Touchscreen>/touch0/radius"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""pressure"",
                    ""id"": ""b72c4336-bd65-457f-bacd-cf9933eb2fc7"",
                    ""path"": ""<Touchscreen>/touch0/pressure"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""inputId"",
                    ""id"": ""6be63793-ef04-469d-ac12-779245b71ba9"",
                    ""path"": ""<Touchscreen>/touch0/touchId"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Touch1"",
                    ""id"": ""448ef65c-b779-4014-bdc4-1cf793b11223"",
                    ""path"": ""PointerInput"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""point"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""contact"",
                    ""id"": ""a7e9f275-8e72-4221-b947-e1d972629254"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""position"",
                    ""id"": ""64552938-2fd4-4fd9-aab5-c6873527f9fa"",
                    ""path"": ""<Touchscreen>/touch1/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""radius"",
                    ""id"": ""ccf25457-9cab-4137-bfb6-d9a3f07cdf02"",
                    ""path"": ""<Touchscreen>/touch1/radius"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""pressure"",
                    ""id"": ""1cd9d53e-4d19-4f1d-a4cf-68df808d026a"",
                    ""path"": ""<Touchscreen>/touch1/pressure"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""inputId"",
                    ""id"": ""583bf8d0-0d65-4042-9496-64d4f3b7b7e2"",
                    ""path"": ""<Touchscreen>/touch1/touchId"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Touch2"",
                    ""id"": ""19c33421-5a1b-427d-a668-3c9e57862d40"",
                    ""path"": ""PointerInput"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""point"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""contact"",
                    ""id"": ""70013879-1601-4e2d-959f-ac99c1e74af5"",
                    ""path"": ""<Touchscreen>/touch2/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""position"",
                    ""id"": ""392b2a12-03e3-42b4-9c70-89e916237cd0"",
                    ""path"": ""<Touchscreen>/touch2/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""radius"",
                    ""id"": ""301637a3-d0e1-4181-a288-53c2f7057337"",
                    ""path"": ""<Touchscreen>/touch2/radius"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""pressure"",
                    ""id"": ""28c1c15f-64bb-4129-89a3-67814ae5f3a6"",
                    ""path"": ""<Touchscreen>/touch2/pressure"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""inputId"",
                    ""id"": ""8b632dbd-6147-4928-8c90-2d2f64667fcb"",
                    ""path"": ""<Touchscreen>/touch2/touchId"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Touch3"",
                    ""id"": ""05259a7b-4240-446d-acb5-e4a580f53994"",
                    ""path"": ""PointerInput"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""point"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""contact"",
                    ""id"": ""3e7de849-5b93-4126-84a4-2d03d20ef368"",
                    ""path"": ""<Touchscreen>/touch3/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""position"",
                    ""id"": ""120da9ee-f4b2-49a7-8a29-d4e1f94f7031"",
                    ""path"": ""<Touchscreen>/touch3/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""radius"",
                    ""id"": ""29d3a1b9-e12a-470a-8ea1-9993d5b53e87"",
                    ""path"": ""<Touchscreen>/touch3/radius"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""pressure"",
                    ""id"": ""7209bbd8-72a4-440a-911a-f2f271b586a8"",
                    ""path"": ""<Touchscreen>/touch3/pressure"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""inputId"",
                    ""id"": ""7f7a6001-89d2-4947-86b9-00d9d24dadec"",
                    ""path"": ""<Touchscreen>/touch3/touchId"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Touch4"",
                    ""id"": ""1b233d85-1ef7-4af4-ac02-9615393f52c4"",
                    ""path"": ""PointerInput"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""point"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""contact"",
                    ""id"": ""53bdf954-414a-499c-bc07-8f4f09f3ad58"",
                    ""path"": ""<Touchscreen>/touch4/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""position"",
                    ""id"": ""a39e1415-77d5-4303-be04-1046a4923ced"",
                    ""path"": ""<Touchscreen>/touch4/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""radius"",
                    ""id"": ""13406675-5622-4525-8fbc-528295a19a0e"",
                    ""path"": ""<Touchscreen>/touch4/radius"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""pressure"",
                    ""id"": ""23c29f3f-f6ec-474f-b6af-ceb385bac764"",
                    ""path"": ""<Touchscreen>/touch4/pressure"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""inputId"",
                    ""id"": ""3aafb622-08a2-4a5f-ba33-2def589b35a2"",
                    ""path"": ""<Touchscreen>/touch4/touchId"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse"",
            ""basedOn"": """",
            ""bindingGroup"": ""Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Pen"",
            ""basedOn"": """",
            ""bindingGroup"": ""Pen"",
            ""devices"": [
                {
                    ""devicePath"": ""<Pen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""basedOn"": """",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // pointer
            m_pointer = asset.GetActionMap("pointer");
            m_pointer_point = m_pointer.GetAction("point");
        }

        ~PointerControls()
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

        // pointer
        private readonly InputActionMap m_pointer;
        private IPointerActions m_PointerActionsCallbackInterface;
        private readonly InputAction m_pointer_point;
        public struct PointerActions
        {
            private PointerControls m_Wrapper;
            public PointerActions(PointerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @point => m_Wrapper.m_pointer_point;
            public InputActionMap Get() { return m_Wrapper.m_pointer; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PointerActions set) { return set.Get(); }
            public void SetCallbacks(IPointerActions instance)
            {
                if (m_Wrapper.m_PointerActionsCallbackInterface != null)
                {
                    point.started -= m_Wrapper.m_PointerActionsCallbackInterface.OnPoint;
                    point.performed -= m_Wrapper.m_PointerActionsCallbackInterface.OnPoint;
                    point.canceled -= m_Wrapper.m_PointerActionsCallbackInterface.OnPoint;
                }
                m_Wrapper.m_PointerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    point.started += instance.OnPoint;
                    point.performed += instance.OnPoint;
                    point.canceled += instance.OnPoint;
                }
            }
        }
        public PointerActions @pointer => new PointerActions(this);
        private int m_MouseSchemeIndex = -1;
        public InputControlScheme MouseScheme
        {
            get
            {
                if (m_MouseSchemeIndex == -1) m_MouseSchemeIndex = asset.GetControlSchemeIndex("Mouse");
                return asset.controlSchemes[m_MouseSchemeIndex];
            }
        }
        private int m_PenSchemeIndex = -1;
        public InputControlScheme PenScheme
        {
            get
            {
                if (m_PenSchemeIndex == -1) m_PenSchemeIndex = asset.GetControlSchemeIndex("Pen");
                return asset.controlSchemes[m_PenSchemeIndex];
            }
        }
        private int m_TouchSchemeIndex = -1;
        public InputControlScheme TouchScheme
        {
            get
            {
                if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.GetControlSchemeIndex("Touch");
                return asset.controlSchemes[m_TouchSchemeIndex];
            }
        }
        public interface IPointerActions
        {
            void OnPoint(InputAction.CallbackContext context);
        }
    }
}
