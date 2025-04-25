using CustomAbility;

namespace Equipment {
    [System.Serializable]
    public class AbilitySlot {
        /// <summary>
        /// 固有枠のスロットかどうか
        /// </summary>
        public bool isUniqueSlot;
        
        /// <summary>
        /// そのスロットにセットされているアビリティ
        /// </summary>
        public WeaponAbility ability;
        
    }
}