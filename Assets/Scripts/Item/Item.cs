using System;
using System.Collections.Generic;
using Item.Feature;
using Item.Feature.Interface;
using UnityEngine;

namespace Item {
    [System.Serializable]
    public class Item {
        
        public ItemData data;

        public Item(ItemData data) {
            this.data = data;
            Initialize();
        }

        protected void Initialize() {
            var OnInstanceInterface = data.GetFeaturesHasAnyInterface<IOnInstance>();
            foreach (var feature in OnInstanceInterface) {
                feature.OnInstance();
            }
            OnInitialize();
        }
        
        /// <summary>
        /// 
        /// </summary>
        protected virtual void OnInitialize() {
            
        }
    }
}