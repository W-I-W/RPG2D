

using DG.Tweening;

using System.Reflection;

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;

using ETouch = UnityEngine.InputSystem.EnhancedTouch;

public class Joystick : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    [SerializeField] private RectTransform m_Background;
    [SerializeField] private RectTransform m_Handle;
    [SerializeField] private RectTransform m_Panel;

    private Camera m_Camera;
    private const float MaxPosition = 80;
    public Vector2 direction { get; private set; }
    public bool isActive { get; private set; }

    private void Start()
    {
        isActive = false;
        m_Background.gameObject.SetActive(isActive);
        m_Camera = Camera.main;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isActive = true;
        m_Background.transform.localScale = Vector2.one / 2f;
        m_Background.anchoredPosition = GetLocalPoint(m_Panel, eventData);
        m_Background.gameObject.SetActive(isActive);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 distance = GetLocalPoint(m_Background, eventData);
        Vector2 position = distance.magnitude < MaxPosition ? distance : distance.normalized * MaxPosition;
        m_Handle.anchoredPosition = position;
        direction = position / 64f;
        SetScaleJoystick();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        direction = Vector2.zero;
        m_Handle.anchoredPosition = Vector2.zero;
        isActive = false;
        m_Background.gameObject.SetActive(isActive);
    }

    private Vector2 GetLocalPoint(RectTransform rect, PointerEventData eventData)
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(rect, eventData.position, m_Camera, out Vector2 localPoint);
        return localPoint;
    }

    private void SetScaleJoystick()
    {
        float xScale = Mathf.Clamp(direction.magnitude, 0.5f, 1);
        float yScale = Mathf.Clamp(direction.magnitude, 0.5f, 1);
        Vector2 scale = new Vector2(xScale, yScale);
        m_Background.transform.DOScale(scale, 0.1f);
    }


}
