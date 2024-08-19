# 宇宙无敌超级神威霸王龙SL的实用API（简称JBAPI）
 ![JBAPI 图标](https://github.com/Carl-Frellett/ThepracticalAPIoftheUniverseInvincibleSuperGodMightyTyrannosaurusRexSL/blob/main/Icon.png#pic_center )<br>
精美实用好用能用的API，我们就是其中之一，功能强大，做工精致，欢迎使用
## 如何使用？
### RuelHint
首先，你需要先在你服务器内安装[Ruel](https://github.com/Ruemena/RueI)

然后，JBAPI提供了两种Hint，一种为RuelHint，一种为PosHint
· ***RuelHint***
下面是例子：
``` csharp
using JBAPI.Hint;

player.RuelHint(400, "这是一条用于测试的Hint", ture, 10);
```
特点：把Hint钉死在这个位置  
参数：位置，文本，是否开启日志？时间

· ***PosHint***
``` csharp
using JBAPI.Hint;

player.PosHint(400, "这是一条用于测试的Hint", ture, 10);
```
特点：适用于如bc这样的不能重叠的Hint，每条Hint有30的间隔  
参数：位置，文本，是否开启日志？时间

### 称号
本API提供了两种称号，分别为彩称，单色称号，他们的使用方法十分的简单

· ***彩称***
``` csharp
using JBAPI.Tag;

player.RTag("宇宙无敌超级神威霸王龙",true);
```
特点：不断变换称号的颜色，彰显您无与伦比的尊贵（TagController使用了NotIntense的[RainbowTags](https://github.com/NotIntense/RainbowTags)）  
参数：称号文本，是否启用（如果不启用则默认为红色）

· ***单色称号***
``` csharp
using JBAPI.Tag;

player.ORTag("宇宙无敌超级神威霸王龙","cyam");
```
特点：只有一种颜色的称号，更为便捷的称号!  
参数：称号文本，称号颜色

### 日志
JBAPI提供了***6***种日志，这里使用默认日志与自定义日志为例子
``` csharp
using JBAPI.Log;

LogAPI.日志("这是一条用于测试用的日志"); // 默认日志  他会输出一条淡蓝色的日志
LogAPI.自定义("这是一条用于测试用的日志", System.ConsoleColor.Red); // 自定义颜色日志  他会输出一条指定颜色（示例为红色）的日志
``` 

***称号可用颜色:***
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
