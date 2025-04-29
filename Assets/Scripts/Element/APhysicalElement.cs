using Element.Definition;

namespace Element {
    [System.Serializable]
    public abstract class APhysicalElement : AElement {
        public new ElementType type = ElementType.Physics;
    }
}