using UnityEngine;

namespace Test.Input {
    [System.Serializable]
    [CreateAssetMenu(fileName = "ButtonData",menuName = "ButtonData")]
    /// <summary>
    /// �{�^���̊e������i�[����
    /// </summary>
    public class ButtonData : ScriptableObject {
        /// <summary>
        /// �{�^���̖��O
        /// </summary>
        public string buttonName;
        /// <summary>
        /// Press����Hold�ɏ�Ԃ��ڍs����܂łɗv�����钷��������
        /// </summary>
        public float phaseHoldTime = 0.2f;
        
    }
}