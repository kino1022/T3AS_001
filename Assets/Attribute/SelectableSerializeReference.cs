using System;
using UnityEngine;

namespace Attribute {
    [AttributeUsage(AttributeTargets.Field)]
    public class SelectableSerializeReferenceAttribute : PropertyAttribute
    {
    }
}