# 宇宙无敌超级神威霸王龙SL的实用API（简称JBAPI）

不要骂我，我是新来的😭😭😭

## 如何使用？
### AudioPlayer
需要在注册事件时使用
``` csharp
AudioPlayer.VerifyAudio();
```
来验证Audio文件夹是否存在，放入音频位置为 %AppData%/EXILED/Configs/Audio/
音频要求: Ogg 48000Hz 单声道
### Anti-Cheat
忘记了
### CustomCassie
调用CustomCassie可以自定义SCP收容,需要一个DamageHandler
例子：
``` csharp
CustomCassie.PlayCassie("scp 1 8 1","SCP-181",damagehandler);
```
### RuelHint
首先，你需要先在你服务器内安装[Ruel](https://github.com/Ruemena/RueI)

然后，JBAPI提供了两种Hint，一种为RuelHint，一种为PosHint
· RuelHint
下面是例子：
``` csharp
player.RuelHint(400, "这是一条用于测试的Hint", ture, 10);
```
特点：把Hint钉死在这个位置  
参数：位置，文本，是否开启日志？时间

· PosHint
``` csharp
player.PosHint(400, "这是一条用于测试的Hint", ture, 10);
```
特点：适用于如bc这样的不能重叠的Hint，每条Hint有30的间隔  
参数：位置，文本，是否开启日志？时间

### 称号
本API提供了两种称号，分别为彩称，单色称号，他们的使用方法十分的简单

· 彩称
``` csharp
player.RTag("宇宙无敌超级神威霸王龙",true);
```
特点：不断变换称号的颜色，彰显您无与伦比的尊贵（TagController使用了NotIntense的[RainbowTags](https://github.com/NotIntense/RainbowTags)）  
参数：称号文本，是否启用（如果不启用则默认为红色）

· 单色称号
``` csharp
player.ORTag("宇宙无敌超级神威霸王龙","cyam");
```
特点：只有一种颜色的称号，更为便捷的称号!  
参数：称号文本，称号颜色
***可用颜色:***
* pink
* red
* brown
* silver
* light_green
* crimson
* cyan
* aqua
* deep_pink
* tomato
* yellow
* magenta
* blue_green
* orange
* lime
* green
* emerald
* carmine
* nickel
* mint
* army_green
* pumpkin
##
yee，有问题加孩子QQ，孩子不会用Github：2033200993
