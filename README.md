# ?? 2D Platformer — Pet Project

Pet project демонстрирующий знание архитектуры и Unity в рамках портфолио.

## ?? Цель проекта

Показать понимание архитектурных паттернов, чистого кода и профессиональных подходов к разработке игр на Unity.

## ?? Стек

- **Engine:** Unity 6, URP (Universal Render Pipeline)
- **Language:** C#
- **Version Control:** Git / GitHub

## ?? Архитектура

### Паттерны

| Паттерн | Где используется |
|---|---|
| **State Machine** | Управление состояниями игрока (Idle / Run / Jump / Fall) |
| **ScriptableObject Events** | Развязка систем (UI ? Game Logic) без прямых зависимостей |
| **Object Pool** | Оптимизация врагов, пуль, частиц |

### Структура папок

```
Assets/
??? _Project/
?   ??? Scripts/
?   ?   ??? Core/           # GameManager, базовые системы
?   ?   ??? Player/         # PlayerController, StateMachine, States
?   ?   ??? Enemies/        # Enemy AI
?   ?   ??? UI/             # HUD, меню
?   ?   ??? Infrastructure/ # SaveSystem, AudioManager
?   ?   ??? Shared/         # Утилиты, интерфейсы, расширения
?   ??? Prefabs/
?   ??? ScriptableObjects/
?   ??? Scenes/
?   ??? Art/
?       ??? Sprites/
?       ??? Animations/
??? Settings/               # URP конфиги
??? ThirdParty/             # Внешние плагины
```

## ?? Геймплей (в разработке)

- [ ] Передвижение и прыжки игрока
- [ ] Боевая система
- [ ] Враги с AI
- [ ] Несколько уровней
- [ ] Сохранение прогресса

## ?? Запуск проекта

1. Клонировать репозиторий
```bash
git clone https://github.com/KBWGamess/PlatformerPet.git
```
2. Открыть в **Unity Hub**
3. Открыть сцену `Assets/_Project/Scenes/Main`
4. Нажать Play

## ?? Конвенция коммитов

Проект использует [Conventional Commits](https://www.conventionalcommits.org/):

- `feat:` — новая функциональность
- `fix:` — исправление бага
- `refactor:` — рефакторинг
- `docs:` — документация
- `chore:` — рутинные задачи

## ?? Автор

**KBWGamess** — Unity Developer (Junior)  
GitHub: [@KBWGamess](https://github.com/KBWGamess)# PlatformerPet# PlatformerPet