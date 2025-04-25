using Element.Definition;

namespace Element {
    [System.Serializable]
    public abstract class APhysicalElement : AElement {
        public ElementType type = ElementType.Physics;
    }
}