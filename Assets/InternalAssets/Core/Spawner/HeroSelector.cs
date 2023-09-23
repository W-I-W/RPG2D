
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

using ETouch = UnityEngine.InputSystem.EnhancedTouch;

public class HeroSelector : Inject
{
    [SerializeField] private SpriteRenderer m_SpriteSelect;
    [SerializeField] private LoadingCharacters m_LoadingCharacters;
    [SerializeField] private GameDatabase m_Database;

    private Camera m_Camera;

    public override void Init()
    {
        if (m_LoadingCharacters.characters.Count > 0)
        {
            Select(m_LoadingCharacters.characters[0]);
        }
        else
        {
            m_SpriteSelect.gameObject.SetActive(false);
        }

        m_Camera = Camera.main;
    }

    private void OnEnable()
    {
        EnhancedTouchSupport.Enable();
        ETouch.Touch.onFingerDown += FingerDown;
    }

    private void OnDisable()
    {
        ETouch.Touch.onFingerDown -= FingerDown;
        EnhancedTouchSupport.Disable();
    }

    private void FingerDown(Finger finger)
    {
        Vector2 point = m_Camera.ScreenToWorldPoint(finger.screenPosition);
        RaycastHit2D hit = Physics2D.Raycast(point, Vector2.one, 1f);
        if (hit)
        {
            bool isCharacter = hit.transform.TryGetComponent(out DemoCharacter character);
            if (isCharacter)
            {
                Select(character);
            }
        }
    }

    private void Select(DemoCharacter character)
    {
        m_SpriteSelect.gameObject.SetActive(true);
        m_SpriteSelect.transform.SetParent(character.transform);
        m_SpriteSelect.transform.localPosition = Vector2.zero;
        m_Database.selectedPlayer = character.player;
    }
}
