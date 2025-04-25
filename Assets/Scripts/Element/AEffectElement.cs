using Element.Definition;

namespace Element {
    /// <summary>
    /// 状態異常属性
    /// </summary>
    public abstract class AEffectElement : AElement {
        public new ElementType type = ElementType.Effect;
    }
}