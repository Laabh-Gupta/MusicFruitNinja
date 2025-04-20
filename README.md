# MusicFruitNinja

**MusicFruitNinja** is a Unity-based rhythm-action game inspired by the classic Fruit Ninja, infused with musical interactivity. Slice flying fruits with your mouse to generate unique musical notes. Each fruit triggers a different sound, with dynamic pitch and volume changes depending on how you slice them.

## 🎮 Game Features

### 🎵 Musical Interactions
- **Default Sound Mode**: Each fruit plays a distinct sound when sliced.
- **Pitched Sound Mode**: The vertical slice position changes the pitch of the note played.
- **Scales**: Choose between:
  - **Diatonic Scale**: Seven-note major scale (Do-Re-Mi...)
  - **Chromatic Scale**: Full 12-semitone scale for richer tonality.

### ⚔️ Slicing Mechanics
- **Volume Control**: Faster or more forceful slices result in louder sounds.
- **Combo Scoring**: Slice multiple fruits rapidly to boost your score.

### 🍓 Fruit Types
- **Regular Fruits**: Slice them for points and sounds.
- **Freeze Fruit**: Slows down fruit spawn for a short time.
- **Frenzy Fruit**: Triggers a fruit explosion event for 10 seconds.

### 🚀 Launch Modes
- **Auto Mode**: Fruits appear automatically at intervals.
- **Manual Mode**: Launch fruits yourself using number keys (`1` to `0`).

### 📊 Scoring System
- Real-time score display based on successful slices.
- Multipliers and bonuses based on combo and timing.

## 🕹️ Controls

| Key        | Action                          |
|------------|---------------------------------|
| `A`        | Auto Mode                        |
| `Q`        | Manual Mode                      |
| `S`        | Default Sound Mode               |
| `W`        | Pitched Sound Mode               |
| `D`        | Diatonic Scale                   |
| `E`        | Chromatic Scale                  |
| `1-0`      | Launch selected fruits (Manual)  |
| `L`        | Toggle slicing line guide        |

## 📁 Project Structure

```
MusicFruitNinja/
├── Assets/
│   ├── Scripts/               # C# game logic scripts
│   ├── Sounds/                # Audio clips for fruits
│   ├── Prefabs/               # Fruit object templates
│   └── Scenes/                # Unity game scenes
├── ProjectSettings/
└── README.md                  # Project documentation
```

## 🚧 Future Improvements

- Add blade color feedback based on slicing rhythm.
- Design preset musical patterns or songs as slicing challenges.
- Implement smoother physics for more fluid fruit motion.

## 💡 Purpose
The game is designed to:
- Improve player reflexes and reaction speed.
- Encourage musical creativity through interactive slicing.
- Blend rhythm, action, and melody into a single gaming experience.

## 📜 License
This project is open-source and available under the [MIT License](LICENSE).

---

Made with 🎵 and 🍉 in Unity.

