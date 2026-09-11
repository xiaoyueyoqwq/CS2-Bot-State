# CS2-Bot-State

Maintained fork of [CS2-Smarter-Bot](https://github.com/ed0ard/CS2-Smarter-Bot).
The loaded plugin name is still `Smarter-Bot` (1.9.5).

This is a standalone plugin repo. CS2-Bot-Improver is the combined
distribution; do not develop BotState on Improver feature branches.

Relative to upstream 1.9.4 this fork adds:

1. Optional idle-repath interval (`EnableCustomIdleRepath`, default off = native 5s)
2. Stop clearing `IsWaitingBehindFriend` / `PoliteTimer` every tick
3. Resolve BotController usercmd suppression by reflection (live ABI 17)
4. Per-round unique first-shot reaction delay (`EnableReactionDelay`, default 180-300ms ±5%)

# Requirement

[Ray-Trace](https://github.com/FUNPLAY-pro-CS2/Ray-Trace)

[CS2-Bot-Controller](https://github.com/XBribo/CS2-Bot-Controller)

# Features
1. Keeps bots always active

2. Fixes most bot stuck issues

3. Improves bots' movement

4. Allow bots to spam smoke and tweak bots' vision in smoke to make it more reasonable

5. Each bot has a chance to anti-flash, according to the visible duration of the flash

6. Allows bots to spray at any range

7. Refines bot behavior logic

8. Fixes an issue where bots would only aim without shooting
<img width="464" height="433" alt="smarter" src="https://github.com/user-attachments/assets/43ed231f-a79e-456d-8a25-862d476ccad4" />

# Installation
1. Download the latest **RayTrace-MM.tar.gz** and **RayTrace-CSS-API.tar.gz** from [Ray-Trace](https://github.com/FUNPLAY-pro-CS2/Ray-Trace/releases)

   Also download the latest **BotController-MM.zip** and **BotController-CSS-API.zip** from [CS2-Bot-Controller](https://github.com/XBribo/CS2-Bot-Controller/releases)

2. Extract the folders and upload them to `game/csgo/addons` on your server

3. Build this repo (`dotnet build -c Release` with `BotControllerApi.dll` in `libs/`) and upload `BotState.dll` from `bin/Release/net10.0/`

4. Extract the folder and upload it to `game/csgo/addons/counterstrikesharp/plugins` on your server

5. Restart your server
