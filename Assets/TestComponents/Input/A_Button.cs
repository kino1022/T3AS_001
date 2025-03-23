using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using GenerallySys.Definition;
using Test.Definition;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static GenerallySys.Definition.ButtonCondition;
using static GenerallySys.Utility.GenerallyUtility;

namespace Test.Input {
    /// <summary>
    /// 全ての仮想ボタン（内部的に存在する押下状態を管理するクラス）の基底クラス
    /// </summary>
    public abstract class A_Button : MonoBehaviour {
        /// <summary>
        /// 適用するボタンのデータ
        /// </summary>
        private ButtonData _data;
        /// <summary>
        /// 長押しに移行するまでに要求する押下時間
        /// </summary>
        private float _phaseHold;
        /// <summary>
        /// ボタン状態がHoldになってから押下され続けた時間
        /// </summary>
        private float _HoldTime = 0.0f;

        private ButtonCondition _condition = None;
        /// <summary>
        /// 現在のボタンの状態(プロパティ)
        /// </summary>
        /// <value></value>
        public ButtonCondition condition {
            get{return _condition;}
            set {
                //状態がHoldからPressに遷移した際の発火処理
                if (_condition == Hold || value == None){
                    wasRelease?.Invoke(_HoldTime);
                }
                //状態がNoneからPressに遷移した際の発火処理
                else if (_condition == None || value == Press) {
                    wasPress?.Invoke();
                }
                _condition = value;
            }
        }

        /// <summary>
        /// ボタンがNoneからPressに変化した際に発火されるUnityEvent。
        /// </summary>
        public UnityEvent wasPress;

        /// <summary>
        /// ボタンがHoldからNoneに変化した際に発火されるUnityEvent、引数は_HoldTime
        /// </summary>
        public UnityEvent<float> wasRelease;

        private void Start () {
            if (_data != null) {
                _phaseHold = _data.phaseHoldTime;
            }
            else {
                Debug.Log($"{this.name}にButtonDataがアタッチされていません!!");
            }
        }

        /// <summary>
        /// InputSystemから呼び出されるメソッド
        /// </summary>
        /// <param name="context"></param>
        public void WasPress (InputAction.CallbackContext context) {
            if (context.performed) {
                Debug.Log($"{this.name}に割り当てられたボタンが押下されました");
                if (_condition == None) {
                    _condition = Press;
                    PhaseHoldTimer(this.GetCancellationTokenOnDestroy(),_phaseHold).Forget();
                }
            }
            if (context.canceled) {
                Debug.Log($"{this.name}に割り当てられたボタンが離されました");
                if (condition != None) {
                    condition = None;
                }
                else{
                    Debug.Log($"{this.name}で二重のリリース処理が発生しました。");
                }
            }
        }

        /// <summary>
        /// ボタンが指定時間押され続けた場合にPressからHoldに状態移行を行うタスク(未完成)
        /// </summary>
        /// <param name="token"></param>
        /// <param name="waitTime"></param>
        /// <returns></returns>
        async private UniTaskVoid PhaseHoldTimer (CancellationToken token, float waitTime) {
            try {
                if (this.condition == Press) {
                    condition = Hold;
                }
            }
            catch(OperationCanceledException) {

            }
            finally {

            }
        }
    }
}