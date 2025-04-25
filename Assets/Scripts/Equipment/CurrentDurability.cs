using Equipment.Interface;
using General.Status;

namespace Equipment {
    /// <summary>
    /// 現在の耐久値
    /// </summary>
    public class CurrentDurability : CurrentStatus, IRepairAble {
        
        
        public void Repair(float amount) {
            AddStatusValue(amount);
            OnRepair(amount);
        }

        protected virtual void OnRepair(float amount) {
            
        }
    }
}