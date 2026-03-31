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
