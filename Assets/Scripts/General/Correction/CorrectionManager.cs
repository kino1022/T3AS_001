using System;
using System.Collections.Generic;
using System.Linq;
using General.Correction.Definition;
using Unity.VisualScripting;
using UnityEngine;

namespace General.Correction {
    [System.Serializable]
    public class CorrectionManager {
        /// <summary>
        /// 補正値を分類ごとに管理するリスト
        /// </summary>
        [SerializeField] private List<CorrectionList> correctionLists;
        
        /// <summary>
        /// 補正値の変化が起きて再計算の必要が生じた際に呼び出されるイベント
        /// </summary>
        public Action CorrectionValueChangeEvent;
        
        
        /// <summary>
        /// 与えられた元々の値を補正値計算して返すメソッド
        /// </summary>
        /// <param name="baseValue"></param>
        /// <returns></returns>
        public float CalculateCorrectionedValue(float baseValue) {
            var correctionedValue = baseValue;
            foreach (var list in correctionLists) {
                correctionedValue = list.ExecuteCorrection(correctionedValue);
            }
            
            return correctionedValue;
        }
        
        /// <summary>
        /// 補正値の新規作成とリストへの加算を行うメソッド
        /// </summary>
        /// <param name="args"></param>
        /// <typeparam name="T"></typeparam>
        public void CreateNewCorrection<T>(params object[] args) where T : Correction {
            var correction = (T)Activator.CreateInstance(typeof(T), args);
            var list = GetCorrectionListFromType(correction.type);
            if (list == null) {
                list = CreateNewCorrectionList<CorrectionList>(correction.type);
            }
            list.AddCorrection(correction);
        }
        
        /// <summary>
        /// 指定したタイプの補正値を管理するリストが存在しているかを返すメソッド
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private bool GetExsistListFromType(CorrectionType type) {
            return correctionLists.Exists(x => x.type == type);
        }

        private CorrectionList GetCorrectionListFromType(CorrectionType type) {
            return correctionLists.Find(x => x.type == type);
        }

        
        private T CreateNewCorrectionList<T>(params object[] args) where T : CorrectionList {
            T newList = (T)Activator.CreateInstance(typeof(T), args);
            correctionLists.Add(newList);
            OnNewListCreated(newList);
            return newList;
        }
        
        protected virtual void OnNewListCreated(CorrectionList correctionList) {
            CorrectionValueChangeEvent?.Invoke();
        }
    }
}