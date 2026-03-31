# CLAUDE.md

## 프로젝트 개요

- **프로젝트명**: Udemy Course - RPG (Alex Dev)
- **엔진**: Unity 6 (6000.0.71f1)
- **장르**: 2D RPG
- **렌더 파이프라인**: URP 2D Renderer
- **입력 시스템**: New Input System

## 프로젝트 구조

```
Assets/
├── Scenes/          # Unity 씬 파일
├── Scripts/         # C# 스크립트 (예정)
├── Settings/        # URP, 렌더러 설정
└── ...
```

## 코딩 컨벤션

- **언어**: C# (Unity 스크립트)
- **네이밍**:
  - 클래스/메서드: PascalCase
  - private 필드: camelCase (SerializeField 시 `[SerializeField]` 어트리뷰트 사용)
  - 상수: UPPER_SNAKE_CASE
- **접근 제한자**: 명시적으로 작성 (`private`, `public` 등 생략하지 않음)
- **주석 언어**: 한국어

## Git 규칙

- **메인 브랜치**: `main`
- **커밋 메시지**: Conventional Commits 형식, 한국어
- **커밋 제외 대상**: `Library/`, `Temp/`, `Logs/`, `UserSettings/`, `.vscode/` (`.gitignore` 참고)

## 작업 시 주의사항

- Unity 에셋 파일(`.asset`, `.unity`, `.prefab` 등)은 직접 수정하지 않는다. Unity Editor를 통해 변경한다.
- `.meta` 파일은 삭제하거나 무시하지 않는다. Unity가 에셋을 추적하는 데 필수적이다.
- C# 스크립트 작성 시 `MonoBehaviour` 상속 여부를 항상 확인한다.
