# Udemy RPG — Unity 2D

> Udemy 강의 "The Ultimate Guide to Creating an RPG Game in Unity" (Alex Dev) 수강 프로젝트

`[📷 이미지 배치 예정 - 게임 플레이 화면]`

| 항목 | 내용 |
|------|------|
| 강의 | The Ultimate Guide to Creating an RPG Game in Unity (Alex Dev) |
| 엔진 | Unity 6 (6000.0.71f1) |
| 언어 | C# |
| 렌더 파이프라인 | URP 2D Renderer |
| 입력 시스템 | New Input System |
| 설계 패턴 | FSM (Finite State Machine) |
| 진행 섹션 | Section 3 완료 |

**문서**: [Section 3 FSM 학습 노트](StudyNotes/Section_03_FSM.md)

---

## 화면 구성

| 인게임 |
|--------|
| `[📷 이미지 배치 예정 - 인게임 플레이어 씬]` |

```
[시작 씬] → [게임 씬] → ...
```

| 화면 | 설명 |
|------|------|
| 게임 씬 | 플레이어 캐릭터 및 FSM 동작 테스트 |

---

## 핵심 기능

| 기능 | 설명 |
|------|------|
| FSM 기반 상태 관리 | `StateMachine`이 현재 활성 상태를 관리하고 전환을 제어 |
| 상태 기반 캐릭터 동작 | `EntityState`의 Enter/Exit 라이프사이클로 각 상태 동작 분리 |
| 플레이어 제어 | `Player`가 `StateMachine`을 통해 상태 전환 |

---

## 아키텍처

FSM(유한 상태 기계) 패턴으로 캐릭터 행동을 상태 단위로 분리 관리한다.

| 레이어 | 역할 | 주요 클래스 |
|--------|------|-------------|
| 상태 머신 | 현재 상태 보유, 상태 전환 처리 | `StateMachine` |
| 상태 | 각 상태의 진입/종료 동작 정의 | `EntityState` |
| 엔티티 | 상태 머신을 소유하고 입력을 처리 | `Player` |

---

## 디렉토리 구조

```
Assets/
├── Scripts/
│   ├── StateMachine.cs     # FSM 코어 — 현재 상태 관리 및 전환
│   ├── EntityState.cs      # 상태 기반 클래스 (Enter/Exit 인터페이스)
│   └── Player.cs           # 플레이어 엔티티
├── Scenes/                 # Unity 씬 파일
└── Settings/               # URP, 렌더러 설정

StudyNotes/
└── Section_03_FSM.md       # FSM 학습 노트
```

---

## 데이터 흐름

```
Player (입력 수신)
  └─ StateMachine.ChangeState(nextState)
       ├─ currentState.Exit()
       └─ nextState.Enter()
            └─ 상태별 동작 실행 (Update 루프)
```

---

## 변경 이력

| 날짜 | 내용 |
|------|------|
| 2026-03-31 | Section 3 완료 — FSM 기반 StateMachine, EntityState, Player 구현 |
| 2026-03-31 | Unity 6 프로젝트 초기 세팅 (URP 2D, New Input System) |
