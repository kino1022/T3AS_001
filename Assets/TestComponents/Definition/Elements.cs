using System;
using UnityEngine;

namespace Test.Definition {
    /// <summary>
    /// •¨—”ñ•¨—‘S‚Ä‚Ì‘®«•ª—Ş
    /// </summary>
    public enum Elements {
        /// <summary>
        /// aŒ‚‘®«
        /// </summary>
        Slash,
        /// <summary>
        /// ‘ÅŒ‚‘®«
        /// </summary>
        Blow,
        /// <summary>
        /// h“Ë‘®«
        /// </summary>
        Pierting,
        /// <summary>
        /// ËŒ‚‘®«
        /// </summary>
        Shot,
        Fire,
    }
    /// <summary>
    /// •¨—ƒ_ƒ[ƒW‚Ì‘®«•ª—Ş
    /// </summary>
    public enum PhysicalElement {
        /// <summary>
        /// aŒ‚‘®«
        /// </summary>
        Slash = Elements.Slash,
        /// <summary>
        /// ‘ÅŒ‚‘®«
        /// </summary>
        Blow = Elements.Blow,
        /// <summary>
        /// h“Ë‘®«
        /// </summary>
        Pierting = Elements.Pierting,
        /// <summary>
        /// ËŒ‚‘®«
        /// </summary>
        Shot = Elements.Shot,
    }
}