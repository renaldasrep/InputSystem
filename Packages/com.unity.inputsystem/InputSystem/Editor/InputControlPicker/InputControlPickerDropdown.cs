#if UNITY_EDITOR
using System;
using System.Linq;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine.Experimental.Input.Layouts;
using UnityEngine.Experimental.Input.Utilities;

namespace UnityEngine.Experimental.Input.Editor
{
    internal class InputControlPickerDropdown : AdvancedDropdown
    {
        SerializedProperty m_PathProperty;
        Action<SerializedProperty> m_OnPickCallback;

        public InputControlPickerDropdown(SerializedProperty pathProperty, Action<SerializedProperty> onPickCallback)
            : base(new AdvancedDropdownState())
        {
            minimumSize = new Vector2(250, 250);
            m_PathProperty = pathProperty;
            m_OnPickCallback = onPickCallback;
        }
        
        protected override AdvancedDropdownItem BuildRoot()
        {
            var root = new AdvancedDropdownItem("");

            var usages = BuildTreeForUsages();
            root.AddChild(usages);
            var devices = BuildTreeForAbstractDevices();
            root.AddChild(devices);
            var products = BuildTreeForSpecificDevices();
            root.AddChild(products);

            return root;
        }

        protected override void ItemSelected(AdvancedDropdownItem item)
        {
            m_PathProperty.stringValue = ((InputControlTreeViewItem)item).controlPathWithDevice;
            m_OnPickCallback(m_PathProperty);
        }

        private AdvancedDropdownItem BuildTreeForUsages()
        {
            var usageRoot = new AdvancedDropdownItem("Usages");
            foreach (var usage in EditorInputControlLayoutCache.allUsages)
            {
                var child = new UsageTreeViewItem(usage);
                usageRoot.AddChild(child);
            }

            return usageRoot;
        }

        private AdvancedDropdownItem BuildTreeForAbstractDevices()
        {
            var mainGroup = new AdvancedDropdownItem("Abstract Devices");
            foreach (var deviceLayout in EditorInputControlLayoutCache.allDeviceLayouts.OrderBy(a => a.name))
                AddDeviceTreeItem(deviceLayout, mainGroup);
            return mainGroup;
        }

        private AdvancedDropdownItem BuildTreeForSpecificDevices()
        {
            var mainGroup = new AdvancedDropdownItem("Specific Devices");
            foreach (var layout in EditorInputControlLayoutCache.allProductLayouts.OrderBy(a => a.name))
            {
                var rootLayoutName = InputControlLayout.s_Layouts.GetRootLayoutName(layout.name).ToString();
                if (string.IsNullOrEmpty(rootLayoutName))
                    rootLayoutName = "Other";
                else
                    rootLayoutName = rootLayoutName.GetPlural();

                var rootLayoutGroup = mainGroup.children.Any()
                    ? mainGroup.children.FirstOrDefault(x => x.name == rootLayoutName)
                    : null;
                if (rootLayoutGroup == null)
                {
                    rootLayoutGroup = new DeviceTreeViewItem(layout)
                    {
                        name = rootLayoutName,
                        id = rootLayoutName.GetHashCode(),
                    };
                    mainGroup.AddChild(rootLayoutGroup);
                }

                AddDeviceTreeItem(layout, rootLayoutGroup);
            }
            return mainGroup;
        }

        private void AddDeviceTreeItem(InputControlLayout layout, AdvancedDropdownItem parent)
        {
            // Ignore devices that have no controls. We're looking at fully merged layouts here so
            // we're also taking inherited controls into account.
            if (layout.controls.Count == 0)
                return;

            var deviceItem = new AdvancedDropdownItem(layout.name);

            AddControlTreeItemsRecursive(layout, deviceItem, "", layout.name, null);

            parent.AddChild(deviceItem);

            foreach (var commonUsage in layout.commonUsages)
            {
                var commonUsageGroup = new DeviceTreeViewItem(layout, commonUsage);
                parent.AddChild(commonUsageGroup);
                AddControlTreeItemsRecursive(layout, commonUsageGroup, "", layout.name, commonUsage);
            }
        }

        private void AddControlTreeItemsRecursive(InputControlLayout layout, AdvancedDropdownItem parent, string prefix, string deviceControlId, string commonUsage)
        {
            foreach (var control in layout.controls.OrderBy(a => a.name))
            {
                if (control.isModifyingChildControlByPath)
                    continue;

                // Skip variants except the default variant and variants dictated by the layout itself.
                if (!control.variants.IsEmpty() && control.variants != InputControlLayout.DefaultVariant
                    && (layout.variants.IsEmpty() || !InputControlLayout.VariantsMatch(layout.variants, control.variants)))
                {
                    continue;
                }

                var child = new ControlTreeViewItem(control , prefix, deviceControlId, commonUsage);
                parent.AddChild(child);

                var childLayout = EditorInputControlLayoutCache.TryGetLayout(control.layout);
                if (childLayout != null)
                {
                    AddControlTreeItemsRecursive(childLayout, parent, child.controlPath, deviceControlId, commonUsage);
                }
            }
        }
    }
}
#endif // UNITY_EDITOR
