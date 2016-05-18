using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace MonoBehaviorInheritors.Main.Profile
{
    public class NameFieldMover : MonoBehaviour
    {
        [SerializeField] private RectTransform _parentRectTransform;
        [SerializeField] private RectTransform _childRectTransform;
        [SerializeField] private Text _text;
        [SerializeField] private float _speed = 1f;
        private Vector2 _textBeginingPos;
        private Vector2 _textEndingPos;

        private void Start()
        {
            if (_text.preferredWidth > _parentRectTransform.sizeDelta.x)
            {
                _textBeginingPos = new Vector2((_text.preferredWidth - _parentRectTransform.sizeDelta.x) / 2, 0);
                _textEndingPos = -_textBeginingPos;
                _childRectTransform = _text.GetComponent<RectTransform>();
                _childRectTransform.anchoredPosition = _textBeginingPos;
                StartCoroutine(MoveLeft());
            }
        }

        private IEnumerator MoveLeft()
        {
            float moveTime = 0f;
            while (Vector2.Distance(_childRectTransform.anchoredPosition, _textEndingPos) > 0.05f)
            {
                moveTime += Time.deltaTime * _speed;
                _childRectTransform.anchoredPosition = Vector2.Lerp(_childRectTransform.anchoredPosition, _textEndingPos, moveTime);
                yield return null;
            }
            StartCoroutine(MoveRight());
        }

        private IEnumerator MoveRight()
        {
            float moveTime = 0f;
            while (Vector2.Distance(_childRectTransform.anchoredPosition, _textBeginingPos) > 0.05f)
            {
                moveTime += Time.deltaTime * _speed;
                _childRectTransform.anchoredPosition = Vector2.Lerp(_childRectTransform.anchoredPosition, _textBeginingPos, moveTime);
                yield return null;
            }
            StartCoroutine(MoveLeft());
        }
    }
}