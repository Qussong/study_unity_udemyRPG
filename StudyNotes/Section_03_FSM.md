# Section 3 - FSM (Finite State Machine)

> 학습 날짜: 2026-03-31

## 개요
플레이어/적 캐릭터의 동작(Idle, Move, Attack 등)을 관리하기 위한 FSM 패턴을 학습했다.

## 핵심 개념

### 1. FSM (Finite State Machine)
- **유한 상태 기계** — 객체의 동작을 상태 단위로 구성하는 디자인 패턴
- **핵심 규칙 3가지**:
  1. 한 번에 **하나의 상태만** 활성화된다
  2. 각 상태는 **고유한 동작**(Enter/Update/Exit)을 가진다
  3. 상태 전환은 **명확한 조건**(Transition)에 의해서만 발생한다

### 2. Unity에서의 활용
- RPG 캐릭터의 행동 관리에 적합 (Idle → Move → Attack → Idle ...)
- Animator Controller도 내부적으로 FSM 구조
- 코드로 직접 구현하면 Animator에 의존하지 않는 유연한 상태 관리 가능

## 정리
- FSM은 복잡한 캐릭터 행동을 상태별로 분리해 관리하는 패턴
- "한 번에 하나의 상태", "명확한 전환 조건"이 핵심 원칙
- 이후 코드로 State 클래스를 구현하면서 실제 적용 예정

---

> 학습 날짜: 2026-04-01

## 구현 — EntityState / StateMachine / Player 연결

### FSM 클래스 설계

FSM을 구성하는 3개의 클래스를 구현했다.

| 클래스 | 역할 |
|---|---|
| `EntityState` | 모든 상태의 **베이스 클래스**. Enter/Update/Exit 라이프사이클 정의 |
| `StateMachine` | 현재 상태를 보관하고 상태 전환을 담당 |
| `Player` | StateMachine을 소유하고 매 프레임 Update를 위임 |

---

### 파일: `Assets/EntityState.cs`

- 직접 인스턴스화하는 클래스가 아니라, **구체적인 상태(IdleState, MoveState 등)가 상속할 베이스 클래스**다.
- `Enter` / `Update` / `Exit`를 `virtual`로 선언해 서브클래스가 오버라이드하도록 설계되었다.
- 현재는 `Debug.Log`만 찍는 더미 구현이지만, 이 라이프사이클 자체가 FSM의 핵심 뼈대다.

```csharp
public virtual void Enter()   { Debug.Log($"I enter {_stateName}"); }
public virtual void Update()  { Debug.Log($"I run update of {_stateName}"); }
public virtual void Exit()    { Debug.Log($"I exit {_stateName}"); }
```

---

### 파일: `Assets/StateMachine.cs`

- `MonoBehaviour`를 **제거**하고 순수 C# 클래스로 변경했다.
  - StateMachine은 씬 오브젝트가 아니라 Player가 인스턴스를 직접 생성(`new StateMachine()`)해서 사용하는 데이터 클래스다.
- `Initialize` — 시작 상태를 지정하고 `Enter()`를 호출
- `ChangeState` — 현재 상태의 `Exit()` → 새 상태의 `Enter()` 순으로 전환

```csharp
public void ChangeState(EntityState newState)
{
    currentState.Exit();
    currentState = newState;
    currentState.Enter();
}
```

---

### 파일: `Assets/Player.cs`

- `Awake`에서 `StateMachine`과 첫 번째 상태(`_idleState`)를 생성한다.
- `Start`에서 `stateMachine.Initialize(_idleState)`로 초기 상태 진입.
- `Update`에서 `stateMachine.currentState.Update()`를 호출해 현재 상태의 로직을 매 프레임 실행.

---

## 정리

- `EntityState`는 단일 동작을 직접 수행하는 클래스가 아니다. **상태가 진입(Enter)될 때 어떤 동작을 할지** 서브클래스가 정의하도록 구조를 제공하는 역할이다.
- `StateMachine`은 MonoBehaviour일 필요가 없다 — Player에 종속된 데이터이므로 순수 C# 클래스가 적합하다.
- `Enter → Update → Exit` 라이프사이클이 모든 상태 구현의 기본 틀이 된다.
